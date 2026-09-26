#!/usr/bin/python
import Adafruit_GPIO as GPIO
import Adafruit_GPIO.SPI as SPI
#from distro import info
from gpiozero import LED
import mysql.connector, sys, Adafruit_DHT, datetime, time
from mysql.connector import Error
from mysql.connector import errorcode
from time import *
import RPi.GPIO as GPIO
import board
import adafruit_dht
import atexit
#import subprocess
#import signal
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
   print("Record inserted successfully into table weatherdata with info: ", (info))
   cursor.close()

def deletemysqlrecords(limit):
   cursor = connection.cursor()
   query = "delete from loginfo where id not in (select id from(select id from loginfo order by id desc limit " + str(limit) + ")info);"
   cursor.execute(query)
   connection.commit()   
   cursor.close()
    
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
      cursor = connection.cursor()
      query = "select delay, numberofrows from settings where id=1"
      cursor = connection.cursor()
      cursor.execute(query)
      row = cursor.fetchone()
      delay = row[0]
      limit = row[1]
      connection.commit()
      cursor.close()
      deletemysqlrecords(limit)

      checkSensor = True
      allow = True
      counter = 0 
      counter2 = 0
      counter3 = 0
      print("Delay: ", limit)
      while True:
         if checkSensor == True:
           print(f"Counter: {counter}")
           now = datetime.datetime.now()
           showdate = now.strftime("%d.%m.%Y")
           showtime = now.strftime("%H:%M")
         
           if counter2 == 60 or allow == True:
               greenled.on()
               redled.off()
               try:
                  temperature = sensor.temperature
                  humidity = sensor.humidity
                  temperature=(round(temperature,2))
                  humidity=(round(humidity,4))
                  row1 = showdate + "  " + showtime
                  row2 = "Temp: "+str(temperature)+"C"  
                  row3 = "Humidity: "+str(humidity)+"%"
                  row4 = ""
                  print(f"Loop (60) {counter2}")
                  print(f"Delay {counter}") 
                  oledinfo(row1, row2, row3, row4)
                  if counter == delay:
                     addmysqlrecord(temperature, humidity)
                     counter = 0
                  counter2 = 0 
               except RuntimeError as error:    
                  checkSensor = False          
         else:
             if counter3 == 0:
               greenled.off()
               redled.on()
               addmysqlrecord2("Sensor malfunction.")
               row1 = showdate + "  " + showtime
               row2 = "Sensor device"
               row3 = "mailfunction"
               row4 = ""
               oledinfo(row1, row2, row3, row4)
               print("Sensor malfunction.")
               counter3 =  1
               deletemysqlrecords(limit)
             print("Test!")

         allow = False
         counter+=1  
         counter2+=1
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
