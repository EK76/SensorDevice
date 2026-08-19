#!/usr/bin/python
import Adafruit_GPIO as GPIO
import Adafruit_GPIO.SPI as SPI
from gpiozero import LED, Button
import mysql.connector, sys, Adafruit_DHT, datetime, time
from mysql.connector import Error
from mysql.connector import errorcode
from RPLCD.i2c import CharLCD
from time import *
import RPi.GPIO as GPIO
import board
import adafruit_dht
import time
import atexit
import subprocess
import signal
import os

def disabledevice():
   greenled.off()
   redled.off()
   sensorlcd.backlight_enabled = False
   sensorlcd.close(clear=True)

def stopall():
   greenled.off()
   redled.off()
   sensorlcd.backlight_enabled = False
   sensorlcd.close(clear=True)

checked = True

def sensorStatus():
    global checked
    if checked == True:
      checked = False
      sensorlcd.clear()
      sensorlcd.write_string("    SENSOR")
      sensorlcd.crlf()
      sensorlcd.write_string("    DISABLED")
      mysql_insert_query = """INSERT INTO loginfo(logtext) VALUES ('Sensor disabled.')"""
      cursor = connection.cursor()
      cursor.execute(mysql_insert_query)
      connection.commit()
    else:
      checked = True
      sensorlcd.clear()
      sensorlcd.write_string("    SENSOR")
      sensorlcd.crlf()
      sensorlcd.write_string("    ENABLED")
      mysql_insert_query = """INSERT INTO loginfo(logtext) VALUES ('Sensor enabled.')"""
      cursor = connection.cursor()
      cursor.execute(mysql_insert_query)
      connection.commit()

sensor = adafruit_dht.DHT22(board.D18)
redled = LED(13) 
greenled = LED(26)

redled2 = LED(17)
greenled2 = LED(27)
button = Button(6,pull_up = True,bounce_time= 0.2) 

config = {
  'host':'localhost',
  'user':'loguser',
  'password':os.getenv("sqlpass"),
  'database':'sensorinfo'
}

try:
    greenled.on()
    redled.off()
    greenled2.on()
    redled2.off()
    counter=0
    lcdcounter=0
    sensorlcd = CharLCD('PCF8574', 0x27, cols=16, rows=2)
    connection = mysql.connector.connect(**config)
    if connection.is_connected():
       db_Info = connection.get_server_info()
       print("Connected to MySQL Server version ", db_Info)
       cursor = connection.cursor()
       cursor.execute("select database();")
       record = cursor.fetchone()
       cursor.close()
       print("You're connected to database: ", record)
       sleep(2)

       mysql_insert_query = """INSERT INTO loginfo(logtext) VALUES ('Sensor device started.')"""
       cursor = connection.cursor()
       cursor.execute(mysql_insert_query)
       connection.commit()
       sensorlcd.write_string("Date: "+ "%s" %time.strftime("%d.%m.%Y") + "Time:" + " %s" %time.strftime("%H:%M"))


       try:
            errorlog1 = True
            temperature = sensor.temperature
            humidity = sensor.humidity
            temperature=(round(temperature,2))
            humidity=(round(humidity,4))
            mysql_insert_query = """INSERT INTO sensorlog(temp, hum) VALUES ('%s','%s')"""
            cursor = connection.cursor()
            record = (temperature, humidity)
            cursor.execute(mysql_insert_query, record)
            connection.commit()
            print("Record inserted successfully into table weatherdata", temperature, " ", humidity)
            cursor.close()   
       except RuntimeError as error:
            if errorlog1 == True:
              mysql_insert_query = """INSERT INTO loginfo(logtext) VALUES ('Sensor malfunction.')"""
              cursor = connection.cursor()
              cursor.execute(mysql_insert_query)
              connection.commit()
              print("Record not inserted successfully into table weatherdata")
              cursor.close()
              errorlog1 = False
     


       query = "select delay from settings where id=1"
       cursor = connection.cursor()
       cursor.execute(query)
       row = cursor.fetchone()
       delay = row[0]
       delay = delay * 60
       connection.commit()
 
       while True:
            if lcdcounter == 10:
               try:   
                 errorlog2 = True
                 temperature = sensor.temperature
                 humidity = sensor.humidity
                 temperature=(round(temperature,2))
                 humidity=(round(humidity,4))
                 sensorlcd.clear()
                 sensorlcd.write_string("TEMP: "+str(temperature)+"C")
                 sensorlcd.crlf()
                 sensorlcd.write_string("HUMIDITY: "+str(humidity)+"%")
                 greenled2.on()
                 redled2.off()
               except RuntimeError as error:
                 if errorlog2 == True:
                    sensorlcd.clear()
                    sensorlcd.write_string("SENSOR   ")
                    sensorlcd.crlf()
                    sensorlcd.write_string("MAILFUNCTION    ") 
                    print("Error: ", error.args[0])
                    print("Error2: ", temperature, " ",humidity)
                    greenled2.off()
                    redled2.on()
                    errorlog2 = False
            if lcdcounter == 30:
               sensorlcd.clear()
               sensorlcd.write_string("Date: "+ "%s" %time.strftime("%d.%m.%Y") + "Time:" + " %s" %time.strftime("%H:%M"))
               lcdcounter = 0
            lcdcounter+=1
       
            button.when_released = sensorStatus
            sleep(1)
            if checked == True:  
               greenled.on()
               redled.off()  
               counter+=1
               print("Counter:", counter)
               if counter == delay:
                  try:
                    errorlog3 = True
                    temperature = sensor.temperature
                    humidity = sensor.humidity
                    temperature=(round(temperature,2))
                    humidity=(round(humidity,4))
                    mysql_insert_query = """INSERT INTO sensorlog(temp, hum) VALUES ('%s','%s')"""
                    cursor = connection.cursor()
                    record = (temperature, humidity)
                    cursor.execute(mysql_insert_query, record)
                    connection.commit()
                    print("Record inserted successfully into table weatherdata", temperature, " ", humidity)
                    cursor.close()

                    greenled2.on()
                    redled2.off()
                #    sensorlcd.clear()
                #    sensorlcd.write_string("TEMP: "+str(temperature)+"C")
                #    sensorlcd.crlf()
                 #   sensorlcd.write_string("HUMIDITY: "+str(humidity)+"%")
                  except RuntimeError as error:
                     if errorlog3 == True:
                       mysql_insert_query = """INSERT INTO loginfo(logtext) VALUES ('Sensor malfunction.')"""
                       cursor = connection.cursor()
                       cursor.execute(mysql_insert_query)
                       connection.commit()
                       cursor.close()
                       print("Error2: ", temperature, " ",humidity)
                       errorlog3 = False
                     greenled2.off()
                     redled2.on()
                     sensorlcd.clear()
                     sensorlcd.write_string("SENSOR   ")
                     sensorlcd.crlf()
                     sensorlcd.write_string("MAILFUNCTION    ") 
                     cursor.close()
                  counter = 0
               print("LED ON!")   
            else:
               greenled.off()  
               redled.on()  
               print("LED OFF!")
            sleep(1)
            atexit.register(disabledevice)
            signal.signal(signal.SIGTERM,stopall)
except mysql.connector.Error as error:
    print("Failed to insert record into table {}".format(error))

except KeyboardInterrupt:
    print("Exit!")
    GPIO.cleanup()

finally:
    if connection.is_connected():
        connection.close()
        print("MySQL connection is closed.")

