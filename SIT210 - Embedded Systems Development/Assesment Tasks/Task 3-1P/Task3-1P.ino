// =======================================================================
// Application:      Sending Data to the Web 
// Purpose:          Task 3-1P - Particle - Sending data to the web
// Author:           Justin Bland
// Date:             03/04/2021
// Status            In Development 
// Revisions         03/04/2021 - Create File 
// =======================================================================
#include <JsonParserGeneratorRK.h>
#include <Grove_Temperature_And_Humidity_Sensor.h>

double temp;
double humid;

void setup()
{
    dht.begin();
    pinMode(D3, INPUT);
}

void loop() 
{
    temp = dht.getTempCelcius();
    humid = dht.getHumidity();
    sendThinkSpeak(temp,humid);
    delay(5000);
}

void sendThinkSpeak(double temp, double humid)
{
    JsonWriterStatic<256> jw;
    {
        JsonWriterAutoObject obj(&jw);
        jw.insertKeyValue("temp", temp);
        jw.insertKeyValue("humid", humid);
    }
    Particle.publish("Task3-1P", jw.getBuffer(), PRIVATE);
}
