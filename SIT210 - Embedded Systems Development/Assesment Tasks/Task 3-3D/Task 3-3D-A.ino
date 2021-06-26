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

// Setup Function
void setup()
{
    pinMode(LED, OUTPUT);
    Particle.subscribe("Deakin_RIOT_SIT210_Photon_Buddy", myHandler);
}


// Loop Function
void loop() {}

void myHandler(const char *event, const char *data)
{
    if (strcmp(data, "wave")==0)
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
    }
}
