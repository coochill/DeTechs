#include "Arduino.h"
#include "EarthquakeSensor.h"

EarthquakeSensor::EarthquakeSensor(const int pin,const int output){
  pinMode(pin,INPUT);
  pinMode(output,OUTPUT);
  _input = pin;
  _output = output;
}

long EarthquakeSensor::Intensity(){
  long measurement = pulseIn(_input,HIGH);
  return measurement;
}

void EarthquakeSensor::Buzzer(){
  int late,rate = Intensity();
 //Serial.println(rate);
  if(rate>10000){
    late = 1000;Serial.print("Dangerous:");
    Serial.println(rate); }
  else if(rate>7500){
    late = 500;Serial.print("High:");Serial.println(rate);}
  else if(rate>5000){
  late = 100;Serial.print("Mild:");Serial.println(rate);}
  else if(rate>0&&rate<2500){
  late = 50;Serial.print("Low:");Serial.println(rate);}
  else{
    return;}
  

  digitalWrite(_output,HIGH);
  delay(100);
  return;
}