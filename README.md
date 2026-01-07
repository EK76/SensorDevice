# Sensor Device

The goal with this project was to build a simple weather device that messaure temperature and humitidy and store the results to a MySQL table with a pyhton program.
Then result can be read with the Sensor Device application (Visual Studio C#) and trough a webserver, that is installed on device.
Pyhton program is included with this project under Pyhton folder.
The device itself is Raspberry Pi 5 with Debian GNU/Linux 13 (trixie) as a operating system.

The device can be connected to any network long as DCHP is enabled.
If you wan't to use Wifi instead of wire, you use the scp command to transfer addwifi script, to the device. 
The addwifi script file is included with this project under Files folder.

Sensor Device application work only with computers that run Windows operating system. 
But the web version can be run on all most common operating system (Windows, Linux, MacOS). 
In order to use the webvserver version, you haft to installa PHP. PHP reads the results from MySQL table
PHP files are included with this project under HomePage folder.

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

create table systemstatus( 
id int not null auto_increment, 
dateupdated datetime, 
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
![image](https://github.com/user-attachments/assets/95aaf302-ddfd-45f1-aec9-0f0012a2b11a)
![image](https://github.com/user-attachments/assets/92811a9f-766a-4b51-a065-d6da2243e2f4)

**How to clone this repository with git.**
https://github.com/EK76/SensorDevice.git<br/>
If you discover any fault or inaccurate information, feel free to contact me trough epost address: ken.ekholm@live.com
