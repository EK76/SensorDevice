# Sensor Device

The goal with this project was to build a simple weather application created by Visual Studio 2022 C# which reads the content from MySQL table containing temperature and humitidy values, which are
obtained from Raspberry PI 5 device with a help of DHT22 sensor. Another goal was that you could move this device to any network of your choosing. Python was used for storing values 
from DHT22 sensor to MySQL table. The Pyhton program is included to under the Pyhton folder within this project. It was also made possible to read the contents from the MySQL table trough a web browser. 
For this I use the Apache version 2.4.66 as a webserver which was installed on the device. The operating system of the device is Debian GNU/Linux 13 (trixie). I used python version 3.13.5 for this project.

#### Requirements for the Visual Studio C# project.
- .NET 9.0
-  C# language version 13.0

The device can be connected to any network long as DCHP is enabled and with a wire connection.
If you want to use Wifi instead of wire, you can use the scp command to transfer addwifi bash script to the device. 
The addwifi script file is included with this project under System folder.

Sensor Device application work only with computers that run under Windows 11 operating system. 
But the web version can be run on all most common operating system (Windows, Linux, MacOS). In order to 
use the webvserver version, you haft to also install also PHP besides Apache and MySQL on the device. PHP reads the results from MySQL table
and display the contents to web browser trough the Apache webserver. PHP files are included with this project under HomePage folder.
For my php script I used the PHP version. 8.4.16.

**Homepage folder's content.**
- index.php -> Where the result of sensor data is shown from MySQL table.
- files.php -> Where files are stored as cvs format with selected data exported from the MySQL table.
- config.php -> Where the database configuration is stored.
- style.css -> Where the design of the homepages is configured.

To the show result as diagram I used [Google Chart Gallery](https://developers.google.com/chart/interactive/docs/gallery).
In my case I named my Raspberry PI 5 to sensordevice. It means in this case I can use the webbrowser version with this url, *http://sensordevice*.

**List over the hardware for this project.**
- Raspberry Pi 5
- DHT22 sensor
- 16x2 display with I2C interface
- 2 RGB (red/greeb) led
- Pushbutton


### Sensor DHT22.
<img width="348" height="295" alt="image" src="https://github.com/user-attachments/assets/eeeafe8d-5864-4a19-a55e-c85f11f0b5e5" />

Sensor DHT22's signal is connected to Rasepberry PI 5's pin 12 (GPIO 18) where it reads the temperature and humitidy from sensor.
Operating voltage is 3.3V - 5.5V for the DHT 22 sensor.

### Installation of library for the Sensor DHT22.

```
sudo pip3 install adafruit-circuitpython-dht
```

### 16x2 Display with I2C interface pinout.

<img align = "center" width="320" height="180" alt="Screenshot 2026-01-22 165314" src="https://github.com/user-attachments/assets/a9b74c83-123a-4e8d-a711-09a4090bf946" />
<img align = "center" width="320" height="180" alt="Screenshot 2026-01-22 165301" src="https://github.com/user-attachments/assets/facb06a2-db7d-4862-a273-17ec6a50d3d8" /><br />

The LCD display used in this project uses 16x2 with I2C protocol connection. 16x2 means it contains of two rows, which both can contain of 16 characters. I2C stands for Inter-Integrated Circuit. It is a simple two-wire communication system in this case between the LCD display and Raspberry Pi5.

Information about I2C protocol's function.
- Uses two shared signal lines: SDA (Serial Data Line) to send data, and SCL (Serial Clock Line) to keep the timing synced.
- Operates with a controller (master) device that directs traffic and a peripheral (slave) device that responds.
- Each slave device has a unique address. The master calls this address so only the correct part listens.
- Built-in acknowledgment bits tell the master if data arrived safely.

The connection between Raspberry PI5 and the LCD display.

- The LCD display's SDA pin is connected to SDA pin (GPIO2) on the Raspberry Pi5.
- The LCD display's SCL pin is connected to SCL pin (GPIO3) on the Raspberry Pi5.
- The LCD display's VCC pin is connected to 5V pin on the Raspberry Pi5.
- The LCD display's GND pin is connected to ground on the Raspberry Pi5.

Before you can use this LCD display, you must activate I2C.

- Type sudo raspi-config and press Enter in a terminal window.
- Use the arrow keys to select 3 Interface Options or 5 Interfacing Options (depending on your OS version) and press Enter.
- Choose I2C and select Yes to enable the ARM I2C interface.
- Select Ok and then Finish to exit the configuration menu.
- Reboot your Raspberry Pi 5 using sudo reboot for changes to take effect.

Installation of library for the LCD display.

```
sudo pip3 install RPLCD smbus2
```
### RGB Leds
These RGB leds consists of red and green color

One of the RGB led woks as a indicator to show if sensor data is also been stored to a mysql table.
The other RGB led woks as a indicator to show if something is failure.

- Green color = enabled / working.
- Red color = disabled / failure.

The connection between Raspberry PI5 and the RGB Leds.

- The RGB Leds (red version) are connected to GPIO13 and GPIO17 on the Raspberry Pi5.
- The RGB Leds (green version) are connected to GPIO26 and GPIO27 on the Raspberry Pi5.

### The installation of library for the RGB leds.

#### Raspberry Pi OS (Recommended).
```
sudo apt update
sudo apt install python3-gpiozero
```
#### Using pip (For other OS or virtual environments).
```
sudo pip3 install gpiozero

```
### Pushbutton

Pushbutton's function is to turn on / off depending on whether or not you want to save sensor data to the table.
The pushbutton is connected to GPIO6 on the Raspberry Pi5.

### The installation of library for the Pushbuttons
It is the same library as for the RGB leds.

The code for display, switch button and indicator led functions are found in the same pyhton script, where sensor device stores it's data to MySQL table.

### Database

In order to use both Sensor Device application and web version, you must create following database and tables according to the directive below.
MySQL have been chosen as database language for this project. The MySQL version used in this project is 11.8.6-MariaDB-0+deb13u1.

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

create table settings(
id int not null auto_increment,
delay int,
numberofrows int,
datecreated datetime default (current_timestamp),
primary key(id)
);

create table loginfo(
id int not null auto_increment,,
logtext varchar(250),
datecreated datetime default (current_timestamp),
primary key(id)
);

```
You can also modify some settings with this project, which are stored in the settings table.
You can modify these setting with the Visual Studio C# project. The Visual Studio C# project works only with computers that run under Windows 11 operating system.
I have created a service which I have named sensordevice.service that when one or more of these changes are changed, it restarts the python program.
```
[Unit]
Description=Enable/disable sensor data storing.
After=multi-user.target

[Service]
Type=simple
EnvironmentFile=/etc/sensordevice/sensordevice.conf
WorkingDirectory=/home/sensoruser/Sensordevice/
user=sensoruser
ExecStart=/usr/bin/python3 /home/sensoruser/Sensordevice/sensor.py
Restart=on-abort

[Install]
WantedBy=multi-user.target
```

My mysql password  /etc/controldevice/controldevice.conf file. You should always consider to hide sensative information, for example password. On way to achieve this is to use environment variables, as I have done.

To use this sensoradevice service without sudo password from Visual Studio C# project, I created a simple bash script, camerarestart.sh
```
sudo systemctl restart cameradevice
```
As the next step I put this line at bottom of /etc/sudoers file with the help of sudo visudo.
```
sensoruser ALL=(ALL) NOPASSWD: /home/sensoruser/Sensordevice/sensorrestart.sh
```
The same procedure is also done if you wan't to shutdown the device from Visual Studio C# project, then you can create a bashscript camerashutdown.sh
```
sudo shutdown now
```
Put this line at bottom of /etc/sudoers file with the help of sudo visudo.
```
sensoruser ALL=(ALL) NOPASSWD: /home/sensorauser/Sensordevice/sensorshutdown.sh
```
This project also cointain of php file (updatesql) that works like a cli application, which purpose is to delete all rows for the table cameralogs, except the newest rows according to the value $row[6] 
In order for updatesql can run as cli application you must put **#!/usr/bin/env php** as the first row in updatesql and make the file runnable with **chmod 777 updatesql**.

Content of the updatesql file.
```
#!/usr/bin/env php
<?php
$hostname = "localhost";
$username = "loguser";
$password = getenv('sqlpass');
$db = "camerasystem";
$dbconnect=mysqli_connect($hostname,$username,$password,$db);

$query = mysqli_query($dbconnect, "select * from settings where id = 1")
or die (mysqli_error($dbconnect));
$row = mysqli_fetch_row($query);

mysqli_query($dbconnect, "delete from cameralogs where id not in (select id from(select id from cameralogs order by id desc limit ".$row[2]." )info)")
or die (mysqli_error($dbconnect));
?>
```
You can use crontab to run this updatesql for example every night at 2 o'clock, by adding this line to rhe crontab config file.
```
0 2 * * * /home/sensoruser/Sensordevice/updatetable
```
To use this updatesql without sudo password, put this line at bottom of /etc/sudoers file with the help of sudo visudo.
```
sensoruser ALL=(ALL) NOPASSWD: /home/sensoruser/Sensordevice/updatesql
```

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
