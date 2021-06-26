# Imports and Definitions
import RPi.GPIO as GPIO
import time

GPIO.setwarnings(False)
GPIO.setmode(GPIO.BCM)

Trig = 17
Echo = 27
LED = 18

GPIO.setup(Trig, GPIO.OUT)
GPIO.setup(Echo, GPIO.IN)
GPIO.setup(LED, GPIO.OUT)

GPIO.output(Trig, False)

pi_pwm = GPIO.PWM(LED,1000)
pi_pwm.start(100)

try:
    while 1:
        GPIO.output(Trig, True)
        time.sleep(0.00001)
        GPIO.output (Trig, False)

        while GPIO.input(Echo)==0:
            pulse_start = time.time()

        while GPIO.input(Echo)==1:
            pulse_end = time.time()

        pulse_duration = pulse_end - pulse_start

        distance = pulse_duration * 17150

        distance = round(distance, 2)
        
        if distance > 400:
            pi_pwm.ChangeDutyCycle(0)

        else:
            cycle = round(100 - ((distance / 400 ) * 100))
            pi_pwm.ChangeDutyCycle(cycle)

        print distance, "cm"
        time.sleep(0.25)

except KeyboardInterrupt:
    GPIO.cleanup()

