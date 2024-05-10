#ifndef EarthquakeSensor_h
#define EarthquakeSensor_h

#include "Arduino.h"

class EarthquakeSensor{
public:
EarthquakeSensor(const int pin,const int output);
long Intensity();
void Buzzer();

private:
int _input;
int _output;
};


#endif 