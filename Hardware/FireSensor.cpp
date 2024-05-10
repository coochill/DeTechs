#include "FireSensor.h"
#include "Arduino.h"


FireSensor::FireSensor(int pin,int output){
  pinMode(pin,INPUT);
  pinMode(output,OUTPUT);
  _input = pin;
  _output = output;

}
int FireSensor::range(){
  return digitalRead(_input);
}

void FireSensor::Buzzer(){
  int rate = range();
   switch (rate) {
    case 0:    
    Serial.println("Fire Detected!");
     digitalWrite(_output,HIGH);
    delay(10);
    digitalWrite(_output,LOW);
    delay(10);
    digitalWrite(_output,HIGH);
    delay(10);
    digitalWrite(_output,LOW);
    delay(10);
    digitalWrite(_output,HIGH);
    delay(10);
    digitalWrite(_output,LOW);
    delay(10);
    break;

  case 1:    // No fire detected.
   // Serial.println("No Fire Detected");
    digitalWrite(_output,LOW);
    delay(10);
    break;
  }
  return;

}