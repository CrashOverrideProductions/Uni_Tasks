# =======================================================================
# Application:      I2C IR Temp 
# Purpose:          Task 8.1D - RPi I2C 
# Author:           Justin Bland
# Date:             12/04/2021
# Status            In Development 
# Revisions         12/04/2021 - Create File 
# =======================================================================

# USEFUL INFORMATION ====================================================
# - CODE FORMATTING:
#      Line Length:    75 Characters +~5% if needed 
# =======================================================================

from smbus2 import SMBus
from mlx90614 import MLX90614
from time import sleep

bus = SMBus(1)
sensor = MLX90614(bus, address=0x5A)

loop = True

while loop:
    irTemp = sensor.get_object_1()

    if irTemp > 40:
        print("Too Hot", irTemp)

    elif 35 <= irTemp <= 40:
        print("Just Right", irTemp)

    elif 24 <= irTemp <= 28:
        print("A Bit Chilly", irTemp)

    else:
        print("Too Cold", irTemp)

    sleep(1)
bus.close()
