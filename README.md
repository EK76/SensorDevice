# Sensor Device

The main two goal with this project was to build a simple weather application (Ken's Sensor Device) created by Visual Studio 2022 C# which reads the content from MySQL table containing temperature and humitidy values, which are
obtained from Raspberry PI 5 device with a help of DHT22 sensor. Another goal was that you could use this device to any network of your choosing. Python was used for storing values 
from DHT22 sensor to MySQL table. The Pyhton program is included to this project under the Pyhton folder. It was also made possible to read the contents trough a web browser. 
For this I use the Apache as a webserver which was installed on the device. The operating system of the device is Debian GNU/Linux 13 (trixie).

The device can be connected to any network long as DCHP is enabled and with wire connection.
If you want to use Wifi instead of wire, you can use the scp command to transfer addwifi script to the device. 
The addwifi script file is included with this project under System folder. At the same folder
is also modifytime.service file that can be used to start/stop/restart the pyhton program working as a service on the device.

Sensor Device application work only with computers that run under Windows operating system. 
But the web version can be run on all most common operating system (Windows, Linux, MacOS). In order to 
use the webvserver version, you haft to also install also PHP besides Apache and MySQL on the device. PHP reads the results from MySQL table
and display the contents to web browser trough the Apache webserver. PHP files are included with this project under HomePage folder.

I have also added 16x2 display with I2C interface and switch button with indicator led to the deivce. 
The display show date,time and data from sensor alternately after same delay. The switch button's purpose is to turn off the sensor if you only wan't look at sensor data stored to a MySQL table
and not store any data. 

Both the display and switch button are just additional functions, you can manage without them.
The code for display, switch button and indicator led functions are found in the same pyhton program, where sensor device stores it's data to MySQL table.

**Homepage folder's conent.**

- index.php -> Where the result of sensor is shown from MySQL table.
- files.php -> Where files are stored as cvs format with selected data exported from the MySQL table.
- config.php -> Where the database configuration is stored.
- style.css -> Where the design of the homepages is configured.

To the show result as diagram I used [Google Chart Gallery][https://developers.google.com/chart/interactive/docs/gallery].

As mention before I chose the DHT22 sensor for this project, which is both temperature and humitidy sensor.
<img width="424" height="377" alt="image" src="https://github.com/user-attachments/assets/ced7df2b-60e7-413b-abd9-3d4165a7ad78" />

Sensor DHT22's signal is connected to Rasepberry PI 5's pin 12 (GPIO 18) where it reads the temperature and humitidy from sensor.
Operating voltage is 3.3V - 5.5V for the DHT 22 sensor. The switch button that turn sensor on/off is conected to pin 31 (GPIO6) and the indicator led
is connected to pin 33 (GPIO 13). Display I2C interface is connected trough SDA and SCL on both I2C interface and Raspberry PI 5 device. The display'
operating voltage is 5V. SDA ans SCL are found at pin 3 (GPIO2) and pin 5 (GPIO3) on Raspberry PI 5 device.

<img width="348" height="295" alt="image" src="https://github.com/user-attachments/assets/eeeafe8d-5864-4a19-a55e-c85f11f0b5e5" /><br />
Sensor DHT22 pinout.<br /><br />

<img align = "center" width="440" height="440" alt="Screenshot 2026-01-22 165314" src="https://github.com/user-attachments/assets/a9b74c83-123a-4e8d-a711-09a4090bf946" />
<img align = "center" width="440" height="440" alt="Screenshot 2026-01-22 165301" src="https://github.com/user-attachments/assets/facb06a2-db7d-4862-a273-17ec6a50d3d8" /><br />
16x2 Display with I2C interface pinout.<br /><br />

In order to use both Sensor Device application and web version, you must create following database and table according to the directive below.
MySQL have been chosen as database language for this project.

```
create database sensorinfo;
use sensorinfo;

create table sensorlog(
id int not null auto_increment,
temp decimal(3,1),
hum decimal(4,1),
datecreated datetime default (current_timestamp),
primary key(id)
);

```

**Description of the tables.**

```
mysql> desc sensorlog;
+-------------+--------------+------+-----+---------------------+----------------+
| Field       | Type         | Null | Key | Default             | Extra          |
+-------------+--------------+------+-----+---------------------+----------------+
| id          | int(11)      | NO   | PRI | NULL                | auto_increment |
| temp        | decimal(3,1) | YES  |     | NULL                |                |
| hum         | decimal(4,1) | YES  |     | NULL                |                |
| datecreated | datetime     | YES  |     | current_timestamp() |                |
+-------------+--------------+------+-----+---------------------+----------------+
4 rows in set (0.001 sec)

```

After creation of database and table are done.
Edit configdb.txt file with the correct info about your MySQL credentials with text editor of your choosing.
Compaile or publish the project with Visual Studio 2022 to test it.

I have also installed two external plugins trough Visual Studio NuGet Package Manager when I developed this project. 
- MySql.Data from Oracle Corporation. <br /> 
  MySql.Data makes it easier to read from and make changes to MySQL database when using Visual Studio.
- MySqlBackup.NET <br /> 
  Backup and restore databases and tables from MySQL.

**Two pictures of the application.**

<img width="500" height="628" alt="pic1" src="https://github.com/user-attachments/assets/8b492c36-0cc9-4893-9660-aa03f6a0c0c9" /><br /> 
<img width="1400" height="563" alt="pic2" src="https://github.com/user-attachments/assets/4393a6bc-0412-4f3e-9697-11fc0eb0d1ee" />

**Picture for web solution.**

<img width="1688" height="1173" alt="Screenshot 2026-01-22 170427" src="https://github.com/user-attachments/assets/78193762-318c-47c7-bcf5-9862c565e045" />

**How to clone this repository with git.**
https://github.com/EK76/SensorDevice.git<br/>
If you discover any fault or inaccurate information, feel free to contact me trough epost address: ken.ekholm@live.com
