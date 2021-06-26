#include <Arduino.h>
#include <WiFi.h>
#include <Time.h>


const char* ssid     = "UniFiNetwork";
const char* password = "14231315";

const char* ntpServer = "pool.ntp.org";
const long  gmtOffset_sec = 36000; // +10hrs GMT = Brisbane Time Zone
const int   daylightOffset_sec = 0;



bool getTime()
{
    struct tm timeinfo;
    if(!getLocalTime(&timeinfo))
    {
        serialDebugPrint("Failed to obtain time");
        tftPrint("Failed to obtain time");
    return false;
    }
    
    Serial.println(&timeinfo, "%H:%M:%S");

    strftime (Hour, 80, "%H", &timeinfo);
    strftime (Minu, 80, "%M", &timeinfo);
    strftime (Seco, 80, "%S", &timeinfo);

    return true;
}

void connectToWifi()
{
    serialDebugPrint("Connecting to ");
    tftPrint("Connecting to ");
    serialDebugPrint(ssid);
    tftPrint(ssid);
    
    WiFi.begin(ssid, password);
    while (WiFi.status() != WL_CONNECTED) {
        delay(500);
        serialDebugPrint(".");
        tftPrint(".");
    }

    serialDebugPrint("WiFi connected.");
    tftPrint("WiFi Connected");

    configTime(gmtOffset_sec, daylightOffset_sec, ntpServer);

    if (getTime())
    {
        //String h = Hour;
        String msg = "Current Time is: ";
        msg.concat(Hour);
        msg.concat(":");
        msg.concat(Minu);
        msg.concat(":");
        msg.concat(Seco);

        serialDebugPrint(msg);
        tftPrint(msg);
    }
    else
    {
        serialDebugPrint("Unable to Get Time from NTP Server");
        tftPrint("Unable to Get Time from NTP Server");

    }

}

