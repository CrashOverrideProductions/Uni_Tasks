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
import RPi.GPIO as GPIO

import time
import sys

from PyQt5 import QtWidgets
from PyQt5.QtWidgets import QApplication, QMainWindow, QLineEdit

# Define Variables
xMin = 200
yMin = 200
width = 425
height = 65

# Time Units
baseTime = 0.1

dotTime = baseTime
dashTime = baseTime * 3

letterChange = baseTime * 3
wordChange = baseTime * 7

redGPIO = 13    #Board Pin 33

# GPIO Setup
GPIO.setmode(GPIO.BCM) 
GPIO.setup(redGPIO, GPIO.OUT)


CODE = {' ': ' ',
        "'": '.----.',
        '(': '-.--.-',
        ')': '-.--.-',
        ',': '--..--',
        '-': '-....-',
        '.': '.-.-.-',
        '/': '-..-.',
        '0': '-----',
        '1': '.----',
        '2': '..---',
        '3': '...--',
        '4': '....-',
        '5': '.....',
        '6': '-....',
        '7': '--...',
        '8': '---..',
        '9': '----.',
        ':': '---...',
        ';': '-.-.-.',
        '?': '..--..',
        'A': '.-',
        'B': '-...',
        'C': '-.-.',
        'D': '-..',
        'E': '.',
        'F': '..-.',
        'G': '--.',
        'H': '....',
        'I': '..',
        'J': '.---',
        'K': '-.-',
        'L': '.-..',
        'M': '--',
        'N': '-.',
        'O': '---',
        'P': '.--.',
        'Q': '--.-',
        'R': '.-.',
        'S': '...',
        'T': '-',
        'U': '..-',
        'V': '...-',
        'W': '.--',
        'X': '-..-',
        'Y': '-.--',
        'Z': '--..',
        '_': '..--.-'}

class MorseBlinky(QMainWindow): 
    def __init__(self): 
        super(MorseBlinky, self).__init__()

        self.setGeometry(xMin, yMin, width, height)
        self.setWindowTitle("Morse Blinky")     
        self.initUI()           
    
    def initUI(self):

        # Button Send
        self.buttonRed = QtWidgets.QPushButton(self)
        self.buttonRed.setText("Send")
        self.buttonRed.move(310,15)
        self.buttonRed.clicked.connect(self.Send)

        self.textbox = QLineEdit(self)
        self.textbox.move(15, 10)
        self.textbox.resize(280,40)

    def split(self, word):
        return list(word)

    def dot(self):
        GPIO.output(redGPIO,1)
        time.sleep(dotTime)
        GPIO.output(redGPIO,0)
        time.sleep(baseTime)

    def dash(self):
        GPIO.output(redGPIO,1)
        time.sleep(dashTime)
        GPIO.output(redGPIO,0)
        time.sleep(baseTime)

    def Send(self):
        text = self.textbox.text()
        
        if len(self.split(text)) < 12 :
            for char in text:
                for symbol in CODE[char.upper()]:
                    if symbol == '-':
                        self.dash()

                    elif symbol == '.':
                        self.dot()
                    
                    else:
                        time.sleep(letterChange)
                time.sleep(letterChange)
        else:
            print("Message Must Be Shorter than 12 Chars")

def window():
    app = QApplication(sys.argv)     
    win = MorseBlinky()
    win.show()
    sys.exit(app.exec())

window()
GPIO.cleanup()
