<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
<link rel="stylesheet" href="style.css">
</head>

<?php
require_once 'config.php';
if ($dbconnect->connect_error) {
    die("Database connection failed: " . $dbconnect->connect_error);
}

?>
<p class="maintext">
Ken's Sensor Device
</p>
<center>
<form action="" method="post" enctype="multipart/form-data">
<table class="buttonvalue">
<tr>
<td>  
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
</td>
<td>

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
</select>
</td>
<td>
<br /><br />
<input type="submit" value = " Search " name="showTable">
</td>
</tr>
</table>
</form>

</center>
<form action="files/files.php" method="post" class="files">
<input type="submit" value = " CVS files "/>
</form>
<br /><br />
<hr class="index">
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
    ?>
    <center>
      <table border="1" class="datarows2">
      <tr>
      <td>Temperature</td>
      <td>Humitidy</td>
      <td>Datecreated</td>
      </tr> 
      <?php
      $number = 0;
      $tempitem[] = array('','Temperature (C)');
      $humitem[] = array('','Humitidy (%)');
      while ($row = mysqli_fetch_array($query)) 
      {
        $datecreated2 = date('d.m.Y H:i:s', strtotime($row['datecreated']));
        echo" 
        <tr>
        <td>{$row['temp']} C</td>
        <td>{$row['hum']} %</td>
        <td>{$datecreated2}</td>
        </tr>";
        $convertdate = date('d.m.Y', strtotime($row['datecreated']));
        $converttime = date('H:i', strtotime($row['datecreated']));
        if ($number == 0)
        {
          $startdate=$convertdate;
          $starttime=$converttime;
          $number=1;
        }
        $temp=(float)$row['temp'];
        $hum=(float)$row['hum'];
        $tempitem[]=array('',$temp);
        $humitem[]=array('',$hum);
      }
      echo "</td>";
      echo "</t>";
      echo "</table>";
      echo "<br />";
    $enddate=$convertdate;
    $endtime=$converttime;
   
    $chartdata = json_encode($tempitem);
    $chartdata2 = json_encode($humitem);

    ?>  

    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">
    google.charts.load('current', {'packages':['corechart']});
    google.charts.setOnLoadCallback(drawChart);

    function drawChart() {
      var data = google.visualization.arrayToDataTable(<?php echo $chartdata; ?>);
      var data2 = google.visualization.arrayToDataTable(<?php echo $chartdata2; ?>);

      var options = {
        curveType: 'function',
        legend: { position: 'bottom' },
        vAxis: {minValue: -40, maxValue: 40}
      };

      var options2 = {
        curveType: 'function',
        legend: { position: 'bottom' },
        vAxis: {minValue: 0, maxValue: 100}
      };
      var chart = new google.visualization.LineChart(document.getElementById('tempchart'));
      chart.draw(data, options);

      var chart2 = new google.visualization.LineChart(document.getElementById('humchart'));
      chart2.draw(data2, options2);
   }
   </script>

   <table class="chartdata" border="0">
   <tr>
   <td>  
   <div id="tempchart" style="width: 900px; height: 600px;"></div>
   <p class="subtext1">
   <?php 
   echo "<br /><br />Start Date: ",$startdate; 
   echo " &nbsp;&nbsp;&nbsp;&nbsp;";
   echo " Start Time: ",$starttime; 
   ?>
   </p>
   </td>
   <td>
   <div id="humchart" style="width: 900px; height: 600px;"></div>
   <p class="subtext1">
   <?php 
   echo "<br /><br />End Date: ",$enddate; 
   echo " &nbsp;&nbsp;&nbsp;&nbsp;";
   echo " End Time: ",$endtime; 
   ?>
   </p>
   </td>
   </tr>
   </table>
   <br /><br />
   <form action="" method="post" align="center" enctype="multipart/form-data">
   <input type="hidden" value = "<?php echo $startdate?>" name="exportstartdate"/>
   <input type="hidden" value = "<?php echo $enddate?>" name="exportenddate"/>
   <input type="submit" value = "  Export to csv  " name="exportTable"/>
   </form>
   <br /><br /><br /><br /><br /> 
   </center>
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
</body>
</html>