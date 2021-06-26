#include <Arduino.h>
#include <Adafruit_MLX90614.h>
#include <DHT.h>
#include "displayFunctions.h"

// Relay Pin Definitions
#define HeatLamp 13
#define HeatMat 12
#define UVLamp 14

// Sensor Pin Definitions
#define DHTPIN 27
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);

Adafruit_MLX90614 mlx = Adafruit_MLX90614();

bool HeatL = false;
bool HeatM = false;
bool UV = false;

void setupRelayPins()
{
    pinMode(HeatLamp, OUTPUT);
    pinMode(HeatMat, OUTPUT);
    pinMode(UVLamp, OUTPUT);

  mlx.begin();
  dht.begin();
}

void toggleHeatLamp(bool onOff)
{
    if (onOff)
    {
        digitalWrite(HeatLamp,HIGH);
        updateMainScreen(105,48,"ON");
    }
    else
    {
        digitalWrite(HeatLamp, LOW);
        updateMainScreen(105,48, "OFF");
    }
}

void toggleHeatMat(bool onOff)
{
        if (onOff)
    {
        digitalWrite(HeatMat,HIGH);
        updateMainScreen(105,56,"ON");
    }
    else
    {
        digitalWrite(HeatMat, LOW);
        updateMainScreen(105,56,"OFF");
    }
}

void toggleUV(bool onOff)
{
        if (onOff)
    {
        digitalWrite(UVLamp,HIGH);
        updateMainScreen(105,64,"ON");
    }
    else
    {
        digitalWrite(UVLamp, LOW);
        updateMainScreen(105,64,"OFF");
    }
}




// Temp Functions
int getIRTemp()
{
  return mlx.readObjectTempC();
}

int getTemp()
{
  return dht.readTemperature();
}

int getHumid()
{
  return dht.readHumidity();
}