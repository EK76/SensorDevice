#!/usr/bin/python
import Adafruit_GPIO as GPIO
import Adafruit_GPIO.SPI as SPI
from distro import info
from gpiozero import LED
import mysql.connector, sys, Adafruit_DHT, datetime, time
from mysql.connector import Error
from mysql.connector import errorcode
from time import *
import RPi.GPIO as GPIO
import board
import adafruit_dht
import atexit
import subprocess
import signal
import os
from luma.core.interface.serial import i2c
from luma.core.render import canvas
from luma.oled.device import sh1106

import time
import datetime

serial = i2c(port=1, address=0x3C)
device = sh1106(serial, width=128, height=64, rotate=2)

def disabledevice():
   greenled.off()
   redled.off()


def addmysqlrecord(temp, hum):
   mysql_insert_query = "INSERT INTO sensorlog(temp, hum) VALUES ('%s','%s')"
   cursor = connection.cursor()
   record = (temp, hum)
   cursor.execute(mysql_insert_query, record)
   connection.commit()
   print("Record inserted successfully into table weatherdata", temp, " ", hum)
   cursor.close()  

def addmysqlrecord2(info):
      cursor = connection.cursor()
      query = "insert into loginfo(logtext) values (%s)"
      cursor.execute(query, [info])
      connection.commit()   
      cursor.close()
      print("Record inserted successfully into table weatherdata with info: )", (info))

def oledinfo(row1, row2, row3, row4):
  with canvas(device) as draw:
    draw.rectangle(device.bounding_box, outline="white", fill="black")
    draw.text((5, 10), row1, fill="white")
    draw.text((5, 22), row2, fill="white")
    draw.text((5, 34), row3, fill="white")
    draw.text((5, 46), row4, fill="white")

sensor = adafruit_dht.DHT22(board.D18)
redled = LED(17) 
greenled = LED(27)

config = {
  'host':'localhost',
  'user':'loguser',
  'password':os.getenv("sqlpass"),
  'database':'sensorinfo'
}

try:
   greenled.on()
   redled.off()
   counter=0
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

      addmysqlrecord2("Sensor device started.")
      row1 = "Sensor device."
      row2 = "version 3.24."
      row3 = "(C) Ken Ekholm"
      row4 = "Device started."
      oledinfo(row1, row2, row3, row4)
      sleep(5)

      query = "select delay from settings where id=1"
      cursor = connection.cursor()
      cursor.execute(query)
      row = cursor.fetchone()
      delay = row[0]
      connection.commit()
      allow = True
      counter = 0 
      print("Delay: ", delay)
      while True:
         print(f"Counter: {counter}")
         now = datetime.datetime.now()
         showdate = now.strftime("%d.%m.%Y")
         showtime = now.strftime("%H:%M")
         if counter == delay or allow == True:
            try:   
               greenled.on()
               redled.off()
               temperature = sensor.temperature
               humidity = sensor.humidity
               temperature=(round(temperature,2))
               humidity=(round(humidity,4))
               row1 = showdate + "  " + showtime
               row2 = "Temp: "+str(temperature)+"C"  
               row3 = "Humidity: "+str(humidity)+"%"
               row4 = ""
               print("Loop")
               oledinfo(row1, row2, row3, row4)
               addmysqlrecord(temperature, humidity)

            except RuntimeError as error:
               greenled.off()
               redled.on()
               addmysqlrecord2("Sensor malfunction.")
               row1 = showdate + "  " + showtime
               row2 = "Sensor device"  
               row3 = "mailfunction"
               row4 = ""
               oledinfo(row1, row2, row3, row4)
               print("Sensor malfunction.")
            counter = 0 
            allow = False
         counter+=1  
         sleep(1)
         atexit.register(disabledevice)
except mysql.connector.Error as error:
   print("Failed to insert record into table {}".format(error))

except KeyboardInterrupt:
   print("Exit!")
   GPIO.cleanup()

finally:
    if connection.is_connected():
      connection.close()
      print("MySQL connection is closed.")
