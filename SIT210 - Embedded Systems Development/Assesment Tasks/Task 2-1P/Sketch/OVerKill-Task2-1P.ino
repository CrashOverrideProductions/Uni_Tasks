// =======================================================================
// Application:      Blinky Name 
// Purpose:          Task 2-1P - Particle Programming - First Name Blinky 
// Author:           Justin Bland
// Date:             29/03/2021
// Status            In Development 
// Revisions         29/03/2021 - Create File 
// =======================================================================

// USEFUL INFORMATION ====================================================
// - CODE FORMATTING:
//      Line Length:    75 Characters +~5% if needed 
// 
//  - Morse Code Timing Standards
//      The space between dots and dashes of the same letter is 1 time unit
//      The length of a dot is 1 time unit.
//      A dash is 3 time units
//      The space between letters is 3 time units.
//      The space between words is 7 time units.
//
// =======================================================================


// Variables
int LED = D7;                     // LED GPIO Pin
int baseTime = 100;               // 100ms Base Time Unit

int dot = (baseTime);             // Dot Time Length
int dash = (baseTime*3);          // Dash Time Length

char name[] = "Justin"; // First Name Char Array
char alph[] = "abcdefghijklmnopqrstuvwxyz";

// Setup Function
void setup() {
pinMode(LED, OUTPUT);
}


// Loop Function
void loop() {

int i = 0;

for(int i =0; i < strlen(name); i++ ) {
  //char c = name[i];

    sendLetter(i-1);
  delay(baseTime*3);

  }

delay(baseTime*7);
}

// Functions

void flashLight(int time)
{
  digitalWrite(LED, HIGH);
  delay(time);
  digitalWrite(LED, LOW);
  delay(baseTime);
}

void sendLetter(int i)
{

  if (strcmp(name[i], alph[0]) == 0)
  {
    flashLight(dot);
    flashLight(dash);
  }
  
  else if (strcmp(name[i], alph[0]) == 0)
  {
      flashLight(dash);
      flashLight(dot);
      flashLight(dot);
      flashLight(dot);
  }

  else if (strcmp(name[i], alph[0]) == 0)
  {
      flashLight(dot);
      flashLight(dot);
      flashLight(baseTime);
      flashLight(dot);
  }


}

