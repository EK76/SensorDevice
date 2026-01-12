# Sensor Device

The main two goal with this project was to build a simple weather application which reads the content from MySQL table containing temperature and humitidy values, which are
obtained from Raspberry PI 5 device with a help of DHT22 sensor. Another goal was that you could take this device to any network of your choosing  Python was used for storing values 
from DHT22 sensor to MySQL table. The Pyhton program is included with this project  under the Pyhton folder. Later it was also possible to read the contents from web browser. For this I use
the Apache as a webserver which was installed on the device. The operating system of the device is Debian GNU/Linux 13 (trixie)

The device can be connected to any network long as DCHP is enabled and with wire connection.
If you want to use Wifi instead of wire, you use the scp command to transfer addwifi script, to the device. 
The addwifi script file is included with this project under System folder. At the same folder
is also modifytime.service file that can be used to start/stop/restart the pyhton program.

Sensor Device application work only with computers that run Windows operating system. 
But the web version can be run on all most common operating system (Windows, Linux, MacOS). In order to 
use the webvserver version, you haft to also install PHP on the device. PHP reads the results from MySQL table
and display the contents to web browser trough the Apache webserver. PHP files are included with this project under HomePage folder.

I chose the DHT22 sensor for this project, which is temperature and humitidy sensor.
<img width="424" height="377" alt="image" src="https://github.com/user-attachments/assets/ced7df2b-60e7-413b-abd9-3d4165a7ad78" />

Sensor DHT22 is connected to Rasepberry PI 5's pin 12 (GPIO 18). Trough GPIO26 Raspberry PI 5 reads the temperature and humitidy from sensor.

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

Description of the tables.

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

I have also installed MySql.Data plugin from Oracle Corporation trough Visual Studio NuGet Package Manager
when I developed this project. MySql.Data makes it easier to read from and make changes to MySQL database when
using Visual Studio.

**Two pictures of the application.**

<img width="500" height="628" alt="pic1" src="https://github.com/user-attachments/assets/8b492c36-0cc9-4893-9660-aa03f6a0c0c9" />
<img width="1400" height="563" alt="pic2" src="https://github.com/user-attachments/assets/4393a6bc-0412-4f3e-9697-11fc0eb0d1ee" />

**How to clone this repository with git.**
https://github.com/EK76/SensorDevice.git<br/>
If you discover any fault or inaccurate information, feel free to contact me trough epost address: ken.ekholm@live.com
