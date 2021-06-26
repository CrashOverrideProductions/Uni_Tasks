# =======================================================================
# Application:      LED GUI
# Purpose:          Task 5.2C RPi - Making GUI 
# Author:           Justin Bland
# Date:             29/04/2021
# Status            In Development 
# Revisions         29/04/2021 - Create File 
# =======================================================================

# USEFUL INFORMATION ====================================================
# - CODE FORMATTING:
#      Line Length:    75 Characters +~5% if needed 
# =======================================================================

# Imports
import RPi.GPIO as GPIO

import time
import sys

from PyQt5 import QtWidgets
from PyQt5.QtWidgets import QApplication, QMainWindow

# Define Variables
xMin = 200
yMin = 200
width = 475
height = 54

redGPIO = 13    #Board Pin 33
greenGPIO = 19  #Board Pin 35
blueGPIO = 26   #Board Pin 37

# GPIO Setup
GPIO.setmode(GPIO.BCM) 
GPIO.setup(redGPIO, GPIO.OUT)
GPIO.setup(greenGPIO, GPIO.OUT)
GPIO.setup(blueGPIO, GPIO.OUT)

class LEDControl(QMainWindow): 
    def __init__(self): 
        super(LEDControl, self).__init__()

        self.setGeometry(xMin, yMin, width, height)
        self.setWindowTitle("Control the Lights")     
        self.initUI()           
    
    def initUI(self):
       
        # Button Red
        self.buttonRed = QtWidgets.QPushButton(self)
        self.buttonRed.setText("Red")
        self.buttonRed.move(10,10)
        self.buttonRed.clicked.connect(self.ToggleRed)

        # Button Green
        self.buttonGreen = QtWidgets.QPushButton(self)
        self.buttonGreen.setText("Green")
        self.buttonGreen.move(125,10)
        self.buttonGreen.clicked.connect(self.ToggleGreen)

        # Button Blue
        self.buttonBlue = QtWidgets.QPushButton(self)
        self.buttonBlue.setText("Blue")
        self.buttonBlue.move(240,10)
        self.buttonBlue.clicked.connect(self.ToggleBlue)
        
        # Button Off
        self.buttonOff = QtWidgets.QPushButton(self)
        self.buttonOff.setText("OFF")
        self.buttonOff.move(355,10)
        self.buttonOff.clicked.connect(self.AllOff)
        
    def AllOff(self):
        GPIO.output(redGPIO, GPIO.LOW)
        GPIO.output(greenGPIO, GPIO.LOW)
        GPIO.output(blueGPIO, GPIO.LOW)
        print("All Off")
    
    def ToggleRed(self):
        self.AllOff()
        print("Red On")
        GPIO.output(redGPIO, GPIO.HIGH)


    def ToggleGreen(self):
        self.AllOff()
        GPIO.output(greenGPIO, GPIO.HIGH)
        print("Green On")

    def ToggleBlue(self):
        self.AllOff()
        GPIO.output(blueGPIO, GPIO.HIGH)
        print("Blue On")
     
def window():
    app = QApplication(sys.argv)     
    win = LEDControl()
    win.show()
    sys.exit(app.exec())

window()
GPIO.cleanup()
