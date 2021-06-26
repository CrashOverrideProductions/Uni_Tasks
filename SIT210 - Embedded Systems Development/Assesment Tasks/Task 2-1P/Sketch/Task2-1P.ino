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

// Setup Function
void setup() {
pinMode(LED, OUTPUT);
}


// Loop Function
void loop() {

  // Print J
  flashLight(dot);
  flashLight(dash);
  flashLight(dash);
  flashLight(dash);

  // Print U
  flashLight(dot);
  flashLight(dot);
  flashLight(dash);

  // Print S
  flashLight(dot);
  flashLight(dot);
  flashLight(dot);

  // Print T
  flashLight(dash);

  // Print I
  flashLight(dot);
  flashLight(dash);

  // Print N
  flashLight(dash);
  flashLight(dot);

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
