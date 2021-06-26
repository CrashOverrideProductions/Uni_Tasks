# =======================================================================
# Application:      Morse Blinky
# Purpose:          Task 5.3D RPi - Morse Code Using GUI
# Author:           Justin Bland
# Date:             30/04/2021
# Status            In Development 
# Revisions         30/04/2021 - Create File 
# =======================================================================

# USEFUL INFORMATION ====================================================
# - CODE FORMATTING:
#      Line Length:    75 Characters +~5% if needed 
# =======================================================================

# Imports
#import RPi.GPIO as GPIO

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

# GPIO Setup
#GPIO.setmode(GPIO.BCM) 
#GPIO.setup(redGPIO, GPIO.OUT)

class MorseBlinky(QMainWindow): 
    def __init__(self): 
        super(MorseBlinky, self).__init__()

        self.setGeometry(xMin, yMin, width, height)
        self.setWindowTitle("Morse Blinky")     
        self.initUI()           
    
    def initUI(self):

        # Button Send
        self.buttonRed = QtWidgets.QPushButton(self)
        self.buttonRed.setText("Red")
        self.buttonRed.move(10,10)
        self.buttonRed.clicked.connect(self.Send)

        self.textbox = QLineEdit(self)
        self.textbox.move(20, 20)
        self.textbox.resize(280,40)

    def Send(self):
            print("Test")

def window():
    app = QApplication(sys.argv)     
    win = MorseBlinky()
    win.show()
    sys.exit(app.exec())

window()
#GPIO.cleanup()