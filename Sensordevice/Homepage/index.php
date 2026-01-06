<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <link rel="stylesheet" href="style.css">
  <script>
</script>
</head>
<body>

<?php
$hostname = "localhost";
$username = "loguser";
$password = "Test0880!";
$db = "sensorinfo";
$dbconnect=mysqli_connect($hostname,$username,$password,$db);
if ($dbconnect->connect_error) {
    die("Database connection failed: " . $dbconnect->connect_error);
}

?>
<p class="maintext">
Ken's Sensor Device
</p>
<form action="" method="post" align="center" enctype="multipart/form-data">
<h4>Put start date</h4>
<select name="startdate">
<?php

$query = mysqli_query($dbconnect, "select distinct cast(datecreated as date) as 'date' from sensorlog");
while ($row = mysqli_fetch_array($query)) 
{
  $convertdate = date('d.m.Y', strtotime($row['date']));
  echo "<option value={$row['date']}</option>";   
  echo $convertdate;
}
?>
</select>

<h4>Put end date</h4>
<select name="enddate">
<?php

$query = mysqli_query($dbconnect, "select distinct cast(datecreated as date) as 'date' from sensorlog");
while ($row = mysqli_fetch_array($query)) 
{
   $convertdate2 = date('d.m.Y ', strtotime($row['date']));
  echo "<option value={$row['date']}</option>";   
  echo $convertdate2;
}
?>
</select><br /><br />
<input type="submit" value = "  OK  " name="showTable"/>
</form>

<?php

if(isset($_POST['exportTable']))
{ 
 
  echo "<p class='subtext2'>";
  echo "Table exported! <br /><br />";
  echo "</p>";
  
  date_default_timezone_set("Europe/Helsinki");
  $currentdate = date("d-m-Y_H:i:s");

  $exportstartdate = $_POST['exportstartdate']; 
  $exportenddate = $_POST['exportenddate']; 
 
  $output = fopen("files/data_".$currentdate.".csv", "w");  
  fputcsv($output, array('Temperature', 'Humitidy', 'Date'));  
  $query = "select temp, hum, datecreated from sensorlog where datecreated between '".$exportstartdate."' and '".$exportenddate."' + INTERVAL 1 DAY";  
  $result = mysqli_query($dbconnect, $query);  
  while($row = mysqli_fetch_assoc($result))  
  {  
      fputcsv($output, $row);  
  }  
  fclose($output);  
} 


if(isset($_POST['showTable']))
{ 
  $startdate = $_POST['startdate']; 
  $enddate = $_POST['enddate']; 
 
  if ($startdate > $enddate)
  {
    echo "<center>";
    echo "<p class='errorcode1'>";
    echo "The End date must larger than Start date!";
    echo "</p>";
    echo "</center>";
  }   
  else
  { 
    $query = mysqli_query($dbconnect, "select * from sensorlog where datecreated between '".$startdate."' and '".$enddate."' + INTERVAL 1 DAY")
    or die (mysqli_error($dbconnect));
    echo '<p class="subtext1">';
  
    $row = mysqli_fetch_row($query);

    $query2 = mysqli_query($dbconnect, "select * from sensorlog where datecreated between '".$startdate."' and '".$enddate."' + INTERVAL 1 DAY order by datecreated desc limit 1")
    or die (mysqli_error($dbconnect));
    $row2 = mysqli_fetch_row($query2);

    echo "<br />Information between ",  date('d.m.Y', strtotime($row[3])), " and ",date('d.m.Y', strtotime($row2[3])),".";   
 
    $rowcount = mysqli_num_rows($query);
    echo "</br></br>Number of rows: ", $rowcount;

    if ($rowcount!=0)
    {
      echo "
      <table border='1' align='center'>
      <tr>
      <td>Temperatur</td>
      <td>Humitidy</td>
      <td>Date created</td>
      </tr> ";
 
      while ($row = mysqli_fetch_array($query)) 
      {
        $datecreated2 = date('d.m.Y H:i:s', strtotime($row['datecreated']));
        echo" 
        <tr>
        <td>{$row['temp']}</td>
        <td>{$row['hum']}</td>
        <td>{$datecreated2}</td>
        </tr>";
      }
      echo "</table>";
      echo "<br />";

      ?>  
      <form action="" method="post" align="center" enctype="multipart/form-data">
      <input type="hidden" value = "<?php echo $startdate?>" name="exportstartdate"/>
      <input type="hidden" value = "<?php echo $enddate?>" name="exportenddate"/>
      <input type="submit" value = "  Export to csv  " name="exportTable"/>
      </form>
      <?php  
    }
    else
    {
       echo "<p class='errorcode1'>";
       echo "None results!";
       echo "</p>";
    }  
  }
  
} 
?>
<hr>
<form action="files/files.php" method="post" align="center">
<input type="submit" value = " CVS files "/>
</form>
</body>
</html>