// =======================================================================
// Application:      IFTTT Trigger
// Purpose:          Task 3-2C - Create IFTTT Trigger 
// Author:           Justin Bland
// Date:             08/04/2021
// Status            In Development 
// Revisions         08/04/2021 - Create File 
// =======================================================================

// USEFUL INFORMATION ====================================================
// - CODE FORMATTING:
//      Line Length:    75 Characters +~5% if needed 
// =======================================================================

int LDR = A2;

int oldValue;
int newValue;

int luxLen = 10;

int luxThreshold = 1100;
int currentState = 0; // 0 = Low | 1 = High

void setup() {
    pinMode(LDR, INPUT);
    Serial.begin(9600);
}

void loop() {
    
    if (getLumValue())
    {
    
    if (newValue < luxThreshold)
    {
        // Dark
        if (currentState != 0)
        {
            Particle.publish("Light", "No Light Detected", PRIVATE);
            currentState = 0;
        }
    }
    else
    {
        // Light
                if (currentState != 1)
        {
            Particle.publish("Light", "Light Detected", PRIVATE);
            currentState = 1;
        } 
    }
   
    Serial.println(oldValue);
    Serial.println(newValue);
    delay(5000);
    }
    else
    {
        Particle.publish("Light", "Error", PRIVATE);
    }
}


bool getLumValue()
{
    int luxReading[luxLen];
    
    for (int i = 0; i < luxLen -1; i++)
    {
        luxReading[i] = analogRead(LDR);
        delay(100);
    }
    
    int tempValue = 0;
    
    for (int i = 0; i < luxLen -1; i++)
    {
    tempValue = (tempValue + luxReading[i]);    
    }
    
    newValue = (tempValue / luxLen);
    
    return true;
}
