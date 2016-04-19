//
// Created by Robert on 02.03.2016.
//

#ifndef BEER_ARDUINO_CLION_BEER_ARDUINO_CLION_H
#define BEER_ARDUINO_CLION_BEER_ARDUINO_CLION_H

#include "Arduino.h"

//#define __AVR__ (1)
#include <OneWire.h>
#include <DS18B20.h>

#ifdef __cplusplus
extern "C" {
#endif

#define D__BAUDRATE									((int)9600)

#define D__BLUETOOTH_RX_PIN							((int)0)
#define D__BLUETOOTH_TX_PIN							((int)1)
#define D__DS18B20_DATA_PIN							((int)7)
#define D__HEATER_RELAY_PIN							((int)8)
#define D__MIXER_RELAY_PIN							((int)9)

#define D__HEATER_REGULATOR_MIN_TIME_MS				((int)0)
#define D__HEATER_REGULATOR_MAX_TIME_MS				((int)3000)
#define D__HEATER_REGULATOR_P_CONSTANT				((double)0.0000000)
#define D__HEATER_REGULATOR_I_CONSTANT				((double)0.0000000)
#define D__HEATER_REGULATOR_D_CONSTANT				((double)0.0000000)

#define D__TEMPERATURE_DEAD_ZONE					((double)0.0000000)
#define D__TEMPERATURE_MULTIPLIER					((double)10)
#define D__REGULATOR_VARIABLES_MULTIPLIER			((double)100)

#define D__TEMPERATURE_MAX							((double)100.000000)
#define D__TEMPERATURE_MIN							((double)0.000000)
#define D__HEATER_REGULATOR_PID_MAX_VALUE			((double)20000.000000)
#define D__HEATER_REGULATOR_PID_MIN_VALUE			((double)0.000000)

#define D__REGULATOR_MAX_INTERGRATE_VALUE			((double)(20.000000)) // anti wind-up
#define D__REGULATOR_INTEGRATE_TEMPERATURE_RANGE	((double)(3.000000))

#define D__REGULATOR_P_VALUE_30_C					((double)2000.0)
#define D__REGULATOR_P_VALUE_40_C					((double)3500.0)
#define D__REGULATOR_P_VALUE_50_C					((double)4000.0)
#define D__REGULATOR_P_VALUE_60_C					((double)5000.0)
#define D__REGULATOR_P_VALUE_70_C					((double)6000.0)
#define D__REGULATOR_P_VALUE_80_C					((double)8500.0)
#define D__REGULATOR_P_VALUE_90_C					((double)12000.0)

#define D__REGULATOR_I_VALUE_30_C					((double)12.0)
#define D__REGULATOR_I_VALUE_40_C					((double)21.0)
#define D__REGULATOR_I_VALUE_50_C					((double)24.0)
#define D__REGULATOR_I_VALUE_60_C					((double)30.0)
#define D__REGULATOR_I_VALUE_70_C					((double)48.0)
#define D__REGULATOR_I_VALUE_80_C					((double)51.0)
#define D__REGULATOR_I_VALUE_90_C					((double)96.0)

#define D__REGULATOR_D_VALUE_30_C					((double)4000.0)
#define D__REGULATOR_D_VALUE_40_C					((double)7000.0)
#define D__REGULATOR_D_VALUE_50_C					((double)8000.0)
#define D__REGULATOR_D_VALUE_60_C					((double)10000.0)
#define D__REGULATOR_D_VALUE_70_C					((double)12000.0)
#define D__REGULATOR_D_VALUE_80_C					((double)17000.0)
#define D__REGULATOR_D_VALUE_90_C					((double)20000.0)

struct s_boiler_state {
    byte boiler_state; // 0 - 1
    double temperature_demanded; // D__TEMPERATURE_MIN - D__TEMPERATURE_MAX
    double temperature_actual; // D__TEMPERATURE_MIN - D__TEMPERATURE_MAX
    double temperature_regulator_actual; // D__TEMPERATURE_MIN - D__TEMPERATURE_MAX
    //double temperature_regulator_last_one; // D__TEMPERATURE_MIN - D__TEMPERATURE_MAX
    double temperature_regulator_sum; // -D__REGULATOR_MAX_INTERGRATE_VALUE - D__REGULATOR_MAX_INTERGRATE_VALUE
    double temperature_regulator_difference_last;
    double temperature_regulator_difference_actual;
    byte regulator_test_gains; // 0 - 1
    byte mixer_state_demanded; // 0 - 1
    byte mixer_state_actual; // 0 - 1
    byte heater_manual_mode; // 0 - 1
    uint16_t heater_time_manual_mode; // 0 - 3000
    int16_t heater_time; // 0 - 3000
};

void loop();
void setup();

#ifdef __cplusplus
} // extern "C"
#endif

//add your function definitions for the project beer_arduino here
void print_structure_test(void);
void pid_gains_update(double temp_demanded);

#endif //BEER_ARDUINO_CLION_BEER_ARDUINO_CLION_H
