#!/usr/bin/python
import Adafruit_GPIO as GPIO
import Adafruit_GPIO.SPI as SPI
from gpiozero import LED, Button
import mysql.connector, sys, Adafruit_DHT, datetime, time
from mysql.connector import Error
from mysql.connector import errorcode
from time import *
import RPi.GPIO as GPIO
import board
import adafruit_dht
import I2C_LCD_driver
import time


sensor =  adafruit_dht.DHT22(board.D18)
led = LED(13) 
button = Button(6,pull_up = True,bounce_time= None) 

config = {
  'host':'localhost',
  'user':'loguser',
  'password':'Test0880!',
  'database':'sensorinfo'
}


try:
    led.on()
    checked = True
    counter=0
    lcdcounter=0
    connection = mysql.connector.connect(**config)
    if connection.is_connected():
       db_Info = connection.get_server_info()
       print("Connected to MySQL Server version ", db_Info)
       cursor = connection.cursor()
       cursor.execute("select database();")
       record = cursor.fetchone()
       cursor.close()
       print("You're connected to database: ", record)
       temperature = sensor.temperature
       humidity = sensor.humidity
       sensorlcd = I2C_LCD_driver.lcd()
       if humidity is not None and temperature is not None and counter == 1800:
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
                  
       sensorlcd.lcd_display_string("Date: %s" %time.strftime("%d.%m.%Y"), 1)
       sensorlcd.lcd_display_string("Time: %s" %time.strftime("%H:%M:%S"), 2)

       while True:
            if lcdcounter == 10:
               temperature = sensor.temperature
               humidity = sensor.humidity
               temperature=(round(temperature,2))
               humidity=(round(humidity,4))
               sensorlcd.lcd_clear()
               sensorlcd.lcd_display_string("Temp: %.1f%s"% (temperature, chr(32)) +  chr(176) +"C", 1)
               sensorlcd.lcd_display_string("Humitidy: %.1f%s"% (humidity, chr(32)) + "%", 2)

            if lcdcounter == 30:
               sensorlcd.lcd_clear()
               sensorlcd.lcd_display_string("Date: %s" %time.strftime("%d.%m.%Y"), 1)
               sensorlcd.lcd_display_string("Time: %s" %time.strftime("%H:%M:%S"), 2)
               lcdcounter = 0
            lcdcounter+=1
       
            if button.is_pressed:
               print ("Checked: ", checked)
               if checked == True:
                  checked = False
               else:
                  checked = True
                  sleep(0.5)
            if checked == True:  
               led.on()
               counter+=1
               print("Counter:", counter)
               if humidity is not None and temperature is not None and counter == 1800:
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
                  counter = 0
            else:
               led.off()  
               print("LED OFF!")
            sleep(1)

except mysql.connector.Error as error:
    print("Failed to insert record into table {}".format(error))

except KeyboardInterrupt:
    print("Exit!")
    GPIO.cleanup()

finally:
    if (connection.is_connected()):
        connection.close()
        print("MySQL connection is closed")
