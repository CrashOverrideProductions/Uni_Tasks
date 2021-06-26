#include "Adafruit_GFX.h"
#include "Adafruit_TFTLCD.h"
#include "RTClib.h"
#include "DHT.h"
#include "SD.h"
#include "Wire.h"
RTC_DS1307 RTC;
#define SD_CS_DIO 10 

DHT dht(9, DHT11);
int SoilPin = A5;
int SoilVal = 0;

int mintemp = 25;
int maxtemp = 32;

int minhumid = 60;
int maxhumid = 70;

// Made up variable
int minsoil = 10;
int maxsoil = 30;

int z = 0;
File sDFile;

Adafruit_TFTLCD tft(A3, A2, A1, A0, 18);

const int chipSelect = 10;

void setup() {
  Serial.begin(9600);
tft.reset();
  uint16_t identifier = tft.readID();
  identifier = 0x9341;
  tft.begin(identifier);
    Wire.begin();
    RTC.begin();
  if (! RTC.isrunning()) {
    RTC.adjust(DateTime(__DATE__, __TIME__));
  }
Serial.print(F("\nInitalising SD Card\n"));
  pinMode(SD_CS_DIO, OUTPUT);
  /* Initialise the SD card */
  if (!SD.begin(SD_CS_DIO)) 
  {
    /* If there was an error output this to the serial port and go no further */
    Serial.println("ERROR: SD card failed to initialise");
    while(1);
  }else
  {
    Serial.println("SD Card OK");
  }
}


void loop() {
  tft.setRotation(1);
  SmartPlant();
  delay(1000);
}

unsigned long SmartPlant() {
 tft.fillScreen(0x0000);
  unsigned long start = micros();
  tft.setCursor(0, 0);

  tft.setTextColor(0x07E0);
  tft.setTextSize(4);
  tft.println(F("    Smart Plant"));

  tft.setTextSize(3);
  tft.println(F(" Keeping Your Plants Happy"));
  tft.println(F(" "));

 // Read Sensors Here
  SoilVal = analogRead(SoilPin);//Read the SIG value form sensor
  float h = dht.readHumidity();
  float t = dht.readTemperature();

  tft.setTextSize(2);
  tft.println(F("Plant Name:      Red Climbing Rose"));
  tft.println(F("Scientific Name: Rosa 'Santana'"));
  tft.println(F(" "));

  tft.setTextSize(2);
  tft.print(F("Current Soil Moisture:      "));
  tft.println(SoilVal);

  tft.print(F("Current Temperature:        " ));
  tft.print(t );
  tft.println(F(" *C" ));

  tft.print("Current Humidity:           ");
  tft.print( h );
  tft.println(" % ");

  tft.println(F(" "));
  tft.println(F(" "));

 String SoilMoistureStatus = "";

  if (SoilVal > maxsoil) {
    tft.setTextColor(0xF800);
    SoilMoistureStatus = "     Soil Moisture High";
  }

  else if (SoilVal < minsoil) {
    tft.setTextColor(0xF800);
    SoilMoistureStatus = "     Soil Moisture Low";
  }

  else {
    tft.setTextColor(0x07E0);
    SoilMoistureStatus = "     Soil Moisture Good";
  }

  tft.setTextSize(3);
  tft.println(SoilMoistureStatus);

  String TempStatus = "";

  if (t > maxtemp) {
    tft.setTextColor(0xF800);
    TempStatus = "     Temperature High";
  }

  else if (t < mintemp) {
    tft.setTextColor(0xF800);
    TempStatus = "     Temperature Low";
  }

  else {
    tft.setTextColor(0x07E0);
    TempStatus = "     Temperature Good";
  }
  tft.println(TempStatus);

  String HumidStatus = "";

  if (h > maxhumid) {
    tft.setTextColor(0xF800);
    HumidStatus = "     Humidity High";
  }

  else if (h < minhumid) {
    tft.setTextColor(0xF800);
    HumidStatus = "       Humidity Low";
  }

  else {
    tft.setTextColor(0x07E0);
    HumidStatus = "      Humidity Good";
  }

  tft.println(HumidStatus);
// SAVE TO LOG (TO DO)
  sDFile = SD.open("data.csv", FILE_WRITE);

  if (sDFile) 
  {
      DateTime now = RTC.now();        
  sDFile.print(now.year(), DEC);    
  sDFile.print('/');   
  sDFile.print(now.month(), DEC);   
  sDFile.print('/');  
  sDFile.print(now.day(), DEC); 
    sDFile.print(", ");
    sDFile.print(SoilVal);
    sDFile.print(", ");
    sDFile.print(t);
    sDFile.print(", ");
    sDFile.println(h);  
    sDFile.close();
  }


}
