#include "beer_arduino_clion.h"

// ds18b20
// adres czujnika na plytce stykowej (goly, bez sondy):
//byte address[8] = {0x28, 0x36, 0x66, 0x2C, 0x6, 0x0, 0x0, 0x7F};
// adres czujnika z sonda 1 m:
byte address[8] = {0x28, 0xFF, 0x67, 0xF4, 0x61, 0x15, 0x3, 0x88};
OneWire onewire(D__DS18B20_DATA_PIN);
DS18B20 sensors(&onewire);

byte first_bytes[4];
struct s_boiler_state s_boiler;

double regulator_p_gain = D__HEATER_REGULATOR_P_CONSTANT;
double regulator_i_gain = D__HEATER_REGULATOR_I_CONSTANT;
double regulator_d_gain = D__HEATER_REGULATOR_D_CONSTANT;

//The setup function is called once at startup of the sketch
void setup()
{
    while(!Serial);
    Serial.begin(D__BAUDRATE);
    sensors.begin();
    sensors.request(address);
    pinMode(D__HEATER_RELAY_PIN,OUTPUT);
    pinMode(D__MIXER_RELAY_PIN,OUTPUT);

    // zerowanie parametrow struktury
    s_boiler.boiler_state = 0;
    s_boiler.temperature_demanded = 30;
    s_boiler.temperature_actual = 0;
    s_boiler.temperature_regulator_actual = 0;
    //s_boiler.temperature_regulator_last_one = 0;
    s_boiler.temperature_regulator_sum = 0;
    s_boiler.temperature_regulator_difference_last = 0;
    s_boiler.temperature_regulator_difference_actual = 0;
    s_boiler.regulator_test_gains = 0;
    s_boiler.mixer_state_actual = 0;
    s_boiler.mixer_state_demanded = 0;
    s_boiler.heater_manual_mode = 0;
    s_boiler.heater_time_manual_mode = 0;
    s_boiler.heater_time = 0;
}

// The loop function is called in an endless loop
void loop()
{
    static unsigned long heater_timer;
    static int64_t temp_heater_time;
    static volatile int heat_regulation_in_progress = 0;
    static uint32_t temp_uint32;
    static double temp_double;

    if (sensors.available())
    {
        s_boiler.temperature_actual = sensors.readTemperature(address);
        sensors.request(address);
    }

    if (Serial.available()) // komunikacja
    {
        // kolejnosc danych:
        // stan kotla (1 bajt)
        // temp_zadana (2 bajty)
        // stan mieszadla (1 bajt)
        // stala p (4 bajty)
        // stala i (4 bajty)
        // stala d (4 bajty)
        first_bytes[0] = Serial.read();
        first_bytes[1] = Serial.read();
        first_bytes[2] = Serial.read();
        first_bytes[3] = Serial.read();

        while (!(first_bytes[0] == 0xFF && first_bytes[1] == 0xFF && first_bytes[2] == 0xFF && first_bytes[3] == 0xFF))
        {
            first_bytes[0] = first_bytes[1];
            first_bytes[1] = first_bytes[2];
            first_bytes[2] = first_bytes[3];
            first_bytes[3] = Serial.read();
        }

        // odbieranie ramki
        temp_uint32 = (uint32_t)Serial.read();
        if (temp_uint32 == 1 || temp_uint32 == 0)
        {
            s_boiler.boiler_state = (byte)temp_uint32;
        }

        temp_uint32 =  (uint32_t)Serial.read();
        temp_uint32 += (((uint32_t)Serial.read()) << 8);
        temp_double = ((double)temp_uint32)/D__TEMPERATURE_MULTIPLIER;
        if ((temp_double <= D__TEMPERATURE_MAX) && (temp_double >= D__TEMPERATURE_MIN))
        {
            if ((int)temp_double != (int)s_boiler.temperature_demanded)
            {
                // nowa temp zadana, trzeba wyzerowac parametry
                s_boiler.temperature_regulator_sum = 0;
                s_boiler.temperature_regulator_difference_last = 0;
                s_boiler.temperature_regulator_difference_actual = 0;
            }
            pid_gains_update(s_boiler.temperature_demanded);

            s_boiler.temperature_demanded = temp_double;
        }

        temp_uint32 = (uint32_t)Serial.read();
        if (temp_uint32 == 1 || temp_uint32 == 0)
        {
            s_boiler.mixer_state_demanded = (byte)temp_uint32;
        }

        temp_uint32 = (uint32_t)Serial.read();
        if (temp_uint32 == 1 || temp_uint32 == 0)
        {
            s_boiler.regulator_test_gains = (byte)temp_uint32;
        }

        temp_uint32 =  (uint32_t)Serial.read();
        temp_uint32 += (((uint32_t)Serial.read()) << 8);
        temp_uint32 += (((uint32_t)Serial.read()) << 16);
        temp_uint32 += (((uint32_t)Serial.read()) << 24);
        temp_double = ((double)temp_uint32)/D__REGULATOR_VARIABLES_MULTIPLIER;
        if ((temp_double <= D__HEATER_REGULATOR_PID_MAX_VALUE) && (temp_double >= D__HEATER_REGULATOR_PID_MIN_VALUE))
        {
            if (s_boiler.regulator_test_gains)
            {
                regulator_p_gain = temp_double;
            }
        }

        temp_uint32 =  (uint32_t)Serial.read();
        temp_uint32 += (((uint32_t)Serial.read()) << 8);
        temp_uint32 += (((uint32_t)Serial.read()) << 16);
        temp_uint32 += (((uint32_t)Serial.read()) << 24);
        temp_double = ((double)temp_uint32)/D__REGULATOR_VARIABLES_MULTIPLIER;
        if ((temp_double <= D__HEATER_REGULATOR_PID_MAX_VALUE) && (temp_double >= D__HEATER_REGULATOR_PID_MIN_VALUE))
        {
            if (s_boiler.regulator_test_gains)
            {
                regulator_i_gain = temp_double;
            }
        }

        temp_uint32 =  (uint32_t)Serial.read();
        temp_uint32 += (((uint32_t)Serial.read()) << 8);
        temp_uint32 += (((uint32_t)Serial.read()) << 16);
        temp_uint32 += (((uint32_t)Serial.read()) << 24);
        temp_double = ((double)temp_uint32)/D__REGULATOR_VARIABLES_MULTIPLIER;
        if ((temp_double <= D__HEATER_REGULATOR_PID_MAX_VALUE) && (temp_double >= D__HEATER_REGULATOR_PID_MIN_VALUE))
        {
            if (s_boiler.regulator_test_gains)
            {
                regulator_d_gain = temp_double;
            }
        }

        temp_uint32 = (uint32_t)Serial.read();
        if (temp_uint32 == 1 || temp_uint32 == 0)
        {
            s_boiler.heater_manual_mode = (byte)temp_uint32;
        }

        temp_uint32 =  (uint32_t)Serial.read();
        temp_uint32 += (((uint32_t)Serial.read()) << 8);
        if ((temp_uint32 <= D__HEATER_REGULATOR_MAX_TIME_MS) && (temp_uint32 >= D__HEATER_REGULATOR_MIN_TIME_MS))
        {
            s_boiler.heater_time_manual_mode = (uint16_t)temp_uint32;
        }

        while (Serial.available())
        {
            Serial.read(); // czytanie ewentualnych innych danych
        }

        // wysylanie ramki
        temp_uint32 = (uint32_t)(s_boiler.temperature_actual * D__TEMPERATURE_MULTIPLIER);
        Serial.write((byte)(0x00FF & temp_uint32));
        Serial.write((byte)((0xFF00 & temp_uint32) >> 8));

        temp_uint32 = (uint32_t)(s_boiler.heater_time);
        Serial.write((byte)(0x00FF & temp_uint32));
        Serial.write((byte)(((0xFF00 & temp_uint32)) >> 8));

        Serial.print("regulator_p_gain: ");
        Serial.print(regulator_p_gain);
        Serial.print(", regulator_i_gain: ");
        Serial.print(regulator_i_gain);
        Serial.print(", regulator_d_gain: ");
        Serial.print(regulator_d_gain);
        Serial.print(", ");
        print_structure_test();
        Serial.flush();
    }

    if (!s_boiler.boiler_state)
    {
        digitalWrite(D__HEATER_RELAY_PIN,LOW);
        digitalWrite(D__MIXER_RELAY_PIN,LOW);
        s_boiler.mixer_state_actual = 0;
        s_boiler.heater_time_manual_mode = 0;
        s_boiler.heater_time = 0;
        s_boiler.temperature_regulator_actual = 0;
        //s_boiler.temperature_regulator_last_one = 0;
        s_boiler.temperature_regulator_sum = 0;
        s_boiler.temperature_regulator_difference_last = 0;
        s_boiler.temperature_regulator_difference_actual = 0;
        heat_regulation_in_progress = 0;
    } else
    {
        // grzalka
        if (!heat_regulation_in_progress)
        {
            // uaktualnienie zmiennych regulatora
            //s_boiler.temperature_regulator_last_one = s_boiler.temperature_regulator_actual;
            s_boiler.temperature_regulator_actual = s_boiler.temperature_actual;
            s_boiler.temperature_regulator_difference_last = s_boiler.temperature_regulator_difference_actual;
            s_boiler.temperature_regulator_difference_actual = s_boiler.temperature_demanded - s_boiler.temperature_regulator_actual;
            if (abs(s_boiler.temperature_regulator_difference_actual) <= D__REGULATOR_INTEGRATE_TEMPERATURE_RANGE)
            {
                s_boiler.temperature_regulator_sum += s_boiler.temperature_regulator_difference_actual;
            } else s_boiler.temperature_regulator_sum = 0.000000;

            // anti wind-up
            if (s_boiler.temperature_regulator_sum > D__REGULATOR_MAX_INTERGRATE_VALUE)
            {
                s_boiler.temperature_regulator_sum = D__REGULATOR_MAX_INTERGRATE_VALUE;
            }
            if (s_boiler.temperature_regulator_sum < (-D__REGULATOR_MAX_INTERGRATE_VALUE))
            {
                s_boiler.temperature_regulator_sum = (-D__REGULATOR_MAX_INTERGRATE_VALUE);
            }

            // wyliczenie czasu zalaczenia grzalek
            temp_heater_time = 0;
            // czlon P
            temp_heater_time += (int64_t)(regulator_p_gain * s_boiler.temperature_regulator_difference_actual);
            // czlon I
            temp_heater_time += (int64_t)(regulator_i_gain * s_boiler.temperature_regulator_sum);
            // czlon D
            temp_heater_time += (int64_t)(regulator_d_gain * (s_boiler.temperature_regulator_difference_actual - s_boiler.temperature_regulator_difference_last));

            if (s_boiler.heater_manual_mode)
            {
                temp_heater_time = s_boiler.heater_time_manual_mode;
            }

            // ograniczenia
            if (temp_heater_time > D__HEATER_REGULATOR_MAX_TIME_MS)
            {
                temp_heater_time = D__HEATER_REGULATOR_MAX_TIME_MS;
            }
            if (temp_heater_time < D__HEATER_REGULATOR_MIN_TIME_MS)
            {
                temp_heater_time = D__HEATER_REGULATOR_MIN_TIME_MS;
            }
            // przypisanie wyliczonej wartosci do struktury
            s_boiler.heater_time = temp_heater_time;

            // start cyklu regulacji pwm
            heater_timer = millis();
            if (s_boiler.heater_time > 0)
            {
                digitalWrite(D__HEATER_RELAY_PIN,HIGH);
            }
            heat_regulation_in_progress = 1;
        }

        if (heat_regulation_in_progress)
        {
            if (((heater_timer + (unsigned long)s_boiler.heater_time) < millis()) && (s_boiler.heater_time < D__HEATER_REGULATOR_MAX_TIME_MS))
            {
                // czas wylaczyc grzanie w danym okresie
                digitalWrite(D__HEATER_RELAY_PIN,LOW);
            }

            if (((heater_timer + (unsigned long)D__HEATER_REGULATOR_MAX_TIME_MS) < millis()))
            {
                // koniec cyklu regulacji pwm
                heat_regulation_in_progress = 0;
            }
        }

        // mieszadlo aktualizacja
        if (s_boiler.mixer_state_demanded == 1 && s_boiler.mixer_state_actual == 0)
        {
            digitalWrite(D__MIXER_RELAY_PIN,HIGH);
            s_boiler.mixer_state_actual = 1;
        }
        if (s_boiler.mixer_state_demanded == 0 && s_boiler.mixer_state_actual == 1)
        {
            digitalWrite(D__MIXER_RELAY_PIN,LOW);
            s_boiler.mixer_state_actual = 0;
        }
    }
}

void print_structure_test(void)
{
    Serial.print("boiler_state: ");
    Serial.print(s_boiler.boiler_state);
    Serial.print(", temperature_demanded: ");
    Serial.print(s_boiler.temperature_demanded);
    Serial.print(", temperature_actual: ");
    Serial.print(s_boiler.temperature_actual);
    Serial.print(", temperature_regulator_actual: ");
    Serial.print(s_boiler.temperature_regulator_actual);
    //Serial.print(", temperature_regulator_last_one: ");
    //Serial.print(s_boiler.temperature_regulator_last_one);
    Serial.print(", temperature_regulator_sum: ");
    Serial.print(s_boiler.temperature_regulator_sum);
    Serial.print(", mixer_state_actual: ");
    Serial.print(s_boiler.mixer_state_actual);
    Serial.print(", mixer_state_demanded: ");
    Serial.print(s_boiler.mixer_state_demanded);
    Serial.print(", heater_time: ");
    Serial.println(s_boiler.heater_time);
}

void pid_gains_update(double temp_demanded)
{
    if (!s_boiler.regulator_test_gains)
    {
        if (temp_demanded < 35.0)
        {
            regulator_p_gain = D__REGULATOR_P_VALUE_30_C;
            regulator_i_gain = D__REGULATOR_I_VALUE_30_C;
            regulator_d_gain = D__REGULATOR_D_VALUE_30_C;
        } else if (temp_demanded < 45.0)
        {
            regulator_p_gain = D__REGULATOR_P_VALUE_40_C;
            regulator_i_gain = D__REGULATOR_I_VALUE_40_C;
            regulator_d_gain = D__REGULATOR_D_VALUE_40_C;
        } else if (temp_demanded < 55.0)
        {
            regulator_p_gain = D__REGULATOR_P_VALUE_50_C;
            regulator_i_gain = D__REGULATOR_I_VALUE_50_C;
            regulator_d_gain = D__REGULATOR_D_VALUE_50_C;
        } else if (temp_demanded < 65.0)
        {
            regulator_p_gain = D__REGULATOR_P_VALUE_60_C;
            regulator_i_gain = D__REGULATOR_I_VALUE_60_C;
            regulator_d_gain = D__REGULATOR_D_VALUE_60_C;
        } else if (temp_demanded < 75.0)
        {
            regulator_p_gain = D__REGULATOR_P_VALUE_70_C;
            regulator_i_gain = D__REGULATOR_I_VALUE_70_C;
            regulator_d_gain = D__REGULATOR_D_VALUE_70_C;
        } else if (temp_demanded < 85.0)
        {
            regulator_p_gain = D__REGULATOR_P_VALUE_80_C;
            regulator_i_gain = D__REGULATOR_I_VALUE_80_C;
            regulator_d_gain = D__REGULATOR_D_VALUE_80_C;
        } else
        {
            regulator_p_gain = D__REGULATOR_P_VALUE_90_C;
            regulator_i_gain = D__REGULATOR_I_VALUE_90_C;
            regulator_d_gain = D__REGULATOR_D_VALUE_90_C;
        }
    }
}
