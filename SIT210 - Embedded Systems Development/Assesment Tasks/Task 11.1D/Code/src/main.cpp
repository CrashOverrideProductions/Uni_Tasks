#include <Arduino.h>
#include <Wire.h>

char Hour[80];
char Minu[80];
char Seco[80];

double DayStart = 07.00;
double NightStart = 17.30;

#include "debug.h"


#include "relayFunctions.h"
#include "WiFiFunctions.h"


// Functions * Setup and Loop at EOF
bool timeCycle()
{
  String msg = "";
  msg.concat(Hour);
  msg.concat(".");
  msg.concat(Minu);

  
  if ((DayStart < msg.toDouble()) && (NightStart > msg.toDouble()))
  {
    return true;
  }
  else
  {
    return false;
  }
}

void getWarmSide()
{
  String msg = "";
  msg.concat(getTemp());
  msg.concat("C | ");
  msg.concat(getHumid());
  msg.concat("%");

  updateMainScreen(70,88,msg);
}

void getCoolSide()
{
  String msg = "";
  msg.concat(getTemp());
  msg.concat("C | ");
  msg.concat(getHumid());
  msg.concat("%");

  updateMainScreen(70,96,msg);
}

void getBask()
{
    String msg = "";
  msg.concat(getIRTemp());
  msg.concat("C");

  updateMainScreen(70,104,msg);
}

void initalStatus()
{
  // Set Relay Status
    if (HeatL)
    {
      updateMainScreen(105,48,"ON");
    }
    else
    {
      updateMainScreen(105,48,"OFF");
    }

    if (HeatM)
    {
      updateMainScreen(105,56,"ON");
    }
    else
    {
      updateMainScreen(105,56,"OFF");
    }

    if (UV)
    {
      updateMainScreen(105,64,"ON");
    }
    else
    {
      updateMainScreen(105,64,"OFF");
    }

  getWarmSide();
  getCoolSide();
  getBask();

  // Set Inital Sensor
}



void updateTime()
{
   //String h = Hour;
        String msg = "";
        msg.concat(Hour);
        msg.concat(":");
        msg.concat(Minu);
        msg.concat(" | ");

        if (timeCycle())
        {
          msg.concat("Day Cycle");
        }
        else
        {
          msg.concat("Night Cycle");
        }

        updateMainScreen(5,15,msg);
}


 


void setup()
{
  Serial.begin(115200);
  setupRelayPins();
  startTFT();
  connectToWifi();
  delay(500);
  setupMainScreen();
  initalStatus();
}
 
void loop()
{
  if(getTime())
  {
    updateTime();


  }
 

  if (timeCycle())
  {
      toggleUV(true);
  
    if (getIRTemp() > 42)
    {
      toggleHeatLamp(false);
    }
    else if (getTemp() < 38)
    {
      toggleHeatLamp(true);
    }
  }
  else
  {
    toggleUV(false);
    toggleHeatLamp(false);
  }

    if (getTemp() > 30)
    {
      toggleHeatMat(false);
    }
    else if (getTemp() < 25)
    {
      toggleHeatMat(true);
    }

  
  
  getWarmSide();
  getCoolSide();
  getBask();
    // Toggle Heat Mat
    // Update Display
delay(1000);
}


