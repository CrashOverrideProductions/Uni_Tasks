#include <Arduino.h>

#define debug;

void serialDebugSetup()
{
    #ifdef debug
        Serial.begin(115200);
    #endif
}

void serialDebugPrint(String msg)
{
    #ifdef debug
        Serial.println(msg);
    #endif
}