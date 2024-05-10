#ifndef FireSensor_h
#define FireSensor_h

#include "Arduino.h"

class FireSensor{
public:
FireSensor(int pin,int output);
int range();
void Buzzer();

private:
int _input;
int _output;
};


#endif 