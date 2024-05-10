#include "FireSensor.h"
#include "EarthquakeSensor.h"

FireSensor FS(11,12);
EarthquakeSensor ES(A0,12);




void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
FS.Buzzer();
ES.Buzzer();

delay(100);

}
