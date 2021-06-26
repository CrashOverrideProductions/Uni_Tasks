#include <Adafruit_GFX.h>    // Core graphics library
#include <XTronical_ST7735.h> // Hardware-specific library
#include <SPI.h>


#define TFT_DC     2       // register select (stands for Data Control perhaps!)
#define TFT_RST   4         // Display reset pin, you can also connect this to the ESP32 reset
                            // in which case, set this #define pin to -1!
#define TFT_CS   5       // Display enable (Chip select), if not enabled will not talk on SPI bus
#define bgColour ST7735_BLACK
// initialise the routine to talk to this display with these pin connections (as we've missed off
// TFT_SCLK and TFT_MOSI the routine presumes we are using hardware SPI and internally uses 13 and 11
Adafruit_ST7735 tft = Adafruit_ST7735(TFT_CS,  TFT_DC, TFT_RST);  

float p = 3.1415926;



void startTFT()
{
    tft.init();   // initialize a ST7735S chip,
    tft.setRotation(2);

    tft.setTextWrap(true);
    tft.fillScreen(bgColour);
    tft.setCursor(0, 0);
    tft.setTextColor(ST7735_WHITE);
    tft.setTextSize(1);
}


void tftPrint(String msg)
// This is only for Showing Inital Startup Routine
{
    tft.println(msg);
}

void setupMainScreen()
{
    tft.fillScreen(bgColour);
    tft.setTextWrap(false);

    tft.setCursor(0,5);
    tft.println("Time:");
    
    tft.setCursor(0,40);
    tft.println("Heat & Light Status");
    tft.println("Heat Light:");
    tft.println("Heat Mat:");
    tft.println("UV Light:");

    tft.setCursor(0,80);
    tft.println("Temp & Humidity");
    tft.println("Warm Side:");
    tft.println("Cool Side:");
    tft.println("Bask Spot:");
}

void updateMainScreen(int x, int y, String msg)
{
    tft.setCursor(x,y);
    tft.fillRect(x, y, tft.width()-x, 8, bgColour);

    tft.print(msg);
}
