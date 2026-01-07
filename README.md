#Sensor Device
This project is done with help of Visual Studio C#. Purpose for this project is to monitor both the computer's CPU 
and harddisk temperature when using a Linux operatingsystem. In my case I used the Ubuntu 25.04 LTS. 
You should also be able to use any kind of the most common Linux operating system for this purpose, but I have only tested on Ubuntu.
It is also possible to check when the Linux computer have been last rebooted.

In order to use this application, you must create following database and tables according to the directive below.
MySQL have been chosen as database language for this project.

```
create database serverpcstatus;
use serverpcstatus;

create table infostatus3(
id int not null auto_increment,
cpustatus0 decimal(10,2),
cpustatus1 decimal(10,2),
cpustatus2 decimal(10,2),
cpustatus3 decimal(10,2),
cpustatus4 decimal(10,2),
cpustatus5 decimal(10,2),
hdstatus decimal(10,2),
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
mysql> desc infostatus;
+-------------+---------------+------+-----+---------+-------------------+
| Field       | Type          | Null | Key | Default | Extra             |
+-------------+---------------+------+-----+---------+-------------------+
| id          | int           | NO   | PRI | NULL    | auto_increment    |
| cpustatus1  | decimal(10,2) | YES  |     | NULL    |                   |
| datecreated | datetime      | YES  |     | now()   | DEFAULT_GENERATED |
| hdstatus    | decimal(10,2) | YES  |     | NULL    |                   |
| cpustatus2  | decimal(10,2) | YES  |     | NULL    |                   |
| cpustatus3  | decimal(10,2) | YES  |     | NULL    |                   |
| cpustatus4  | decimal(10,2) | YES  |     | NULL    |                   |
| cpustatus5  | decimal(10,2) | YES  |     | NULL    |                   |
| cpustatus0  | decimal(10,2) | YES  |     | NULL    |                   |
+-------------+---------------+------+-----+---------+-------------------+
9 rows in set (0.00 sec)

mysql> desc systemstatus;
+-------------+----------+------+-----+---------+----------------+
| Field       | Type     | Null | Key | Default | Extra          |
+-------------+----------+------+-----+---------+----------------+
| id          | int      | NO   | PRI | NULL    | auto_increment |
| dateupdated | datetime | YES  |     | NULL    |                |
+-------------+----------+------+-----+---------+----------------+
2 rows in set (0.00 sec)
```

After creation of database and tables are done.
Edit configdb.txt file with the correct info about your MySQL credentials with text editor of your choosing.
Compaile or publish the project with Visual Studio 2022 to test it.

I have also installed MySql.Data plugin from Oracle Corporation trough Visual Studio NuGet Package Manager
when I developed this project. MySql.Data makes it easier to read from and make changes to MySQL database when
using Visual Studio.

**Two pictures of the application.**
![image](https://github.com/user-attachments/assets/95aaf302-ddfd-45f1-aec9-0f0012a2b11a)
![image](https://github.com/user-attachments/assets/92811a9f-766a-4b51-a065-d6da2243e2f4)

**How to clone this repository with git.**
https://github.com/EK76/ServerStatus.git<br/>
If you discover any fault or inaccurate information, feel free to contact me trough epost address: ken.ekholm@live.com
