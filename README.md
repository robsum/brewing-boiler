## brewing-boiler
Arduino and PC (.NET application) codes used in my microprocessor controlled brewing boiler for domestic beer production.

## arduino-code
Arduino Uno (Atmega382) code for my brewing boiler. Code was written in CLion (with Platform.io), but you can just put it in default ArduinoIDE and it should work as well.

Program generates PWM digital signal for heating elements and on/off signal for a motor which moves an agitator. Besides, it read DS18B20 temperature sensor using One Wire interface. It also receives and sends bytes via serial (USB) from/to comuter.

## pc-code
PC application was written in MS Visual Studio 2015. It's a WinForms application and it communicates with Arduino's code.

User sets desired boiler and agitator state (on/off) and wanted temperature. Application also automatically draws a real-time chart with temperature data. Besides it offers few more advanced features (like PID controller parameters change).

Some screenshots:

![Application screenshot nr 01](/images/pc-app-screenshot-01.png)

![Application screenshot nr 02](/images/pc-app-screenshot-02.png)
