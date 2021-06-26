// =======================================================================
// Application:      Buddy System
// Purpose:          Task 3-3D - Particle - Buddy System 
// Author:           Justin Bland
// Date:             10/04/2021
// Status            In Development 
// Revisions         10/04/2021 - Create File 
// =======================================================================

// USEFUL INFORMATION ====================================================
// - CODE FORMATTING:
//      Line Length:    75 Characters +~5% if needed 
// 
// =======================================================================


// Variables
int LED = D7;                     // LED GPIO Pin
SYSTEM_THREAD(ENABLED);

// Setup Function
void setup()
{
    Particle.function("Wave", wave_Function);
    Particle.function("Pat", pat_Function);

    pinMode(LED, OUTPUT);
    Serial.begin(9600);

}


// Loop Function
void loop() 
{
    delay(1000);
}

int wave_Function(String args)
{
    // Flash 1
    digitalWrite(LED, HIGH);
    delay(500);
    digitalWrite(LED, LOW);
    delay(500);
    
    // Flash 2
    digitalWrite(LED, HIGH);
    delay(500);
    digitalWrite(LED, LOW);
    delay(500);
        
    // Flash 3
    digitalWrite(LED, HIGH);
    delay(500);
    digitalWrite(LED, LOW);
    delay(500);
    return 0;
}

int pat_Function(String args)
{
    // Flash 1
    digitalWrite(LED, HIGH);
    delay(250);
    digitalWrite(LED, LOW);
    delay(250);
    
    // Flash 2
    digitalWrite(LED, HIGH);
    delay(250);
    digitalWrite(LED, LOW);
    delay(250);
        
    return 0;
}


