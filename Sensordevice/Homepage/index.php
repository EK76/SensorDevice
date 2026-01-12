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
    ?>
    <center>
      <table border="1" class="datarows">
      <tr class="datarows2">
      <td class="datarows2">Temperature</td>
      <td class="datarows2">Humitidy</td>
      <td class="datarows2">Datecreated</td>
      </tr> 
      <?php
      $number = 0;
      $tempitem[] = array('','Temperature');
      $humitem[] = array('','Humitidy');
      while ($row = mysqli_fetch_array($query)) 
      {
        $datecreated2 = date('d.m.Y H:i:s', strtotime($row['datecreated']));
        echo" 
        <tr class='datarows2'>
        <td class='datarows2'>{$row['temp']}</td>
        <td class='datarows2'>{$row['hum']}</td>
        <td class='datarows2'>{$datecreated2}</td>
        </tr>";
        $convertdate = date('d.m.Y', strtotime($row['datecreated']));
        $converttime = date('h:i', strtotime($row['datecreated']));
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
      echo "</table>";
      echo "<br />";
    $enddate=$convertdate;
    $endtime=$converttime;
   
    $chartdata = json_encode($tempitem);
    $chartdata2 = json_encode($humitem);

    ?>  
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">
    google.charts.load('current', {'packages':['line']});
    google.charts.setOnLoadCallback(drawChart);

    function drawChart() {
      var data = google.visualization.arrayToDataTable(<?php echo $chartdata; ?>);
            var data2 = google.visualization.arrayToDataTable(<?php echo $chartdata2; ?>);
        var options = {
         chart: {
              title: 'Temperature Data',
              legend: 'none',
         },
         vAxes: {
         0: {baseline: 0}, 
         }  

  
      };

        var options2 = {
         chart: {
              title: 'Humitidy Data',
              legend: 'none',
         },
         vAxes: {
         0: {baseline: 0}, 
         }  
        };
        var chart = new google.charts.Line(document.getElementById('tempchart'));
        //chart.draw(data, google.charts.Line.convertOptions(options));
         chart.draw(data, options);
        var chart2 = new google.charts.Line(document.getElementById('humchart'));
        //chart.draw(data, google.charts.Line.convertOptions(options));
         chart2.draw(data2, options2);
      }
    </script>
    <form action="" method="post" align="center" enctype="multipart/form-data">
    <input type="hidden" value = "<?php echo $startdate?>" name="exportstartdate"/>
    <input type="hidden" value = "<?php echo $enddate?>" name="exportenddate"/>
    <input type="submit" value = "  Export to csv  " name="exportTable"/>
    </form>
    <form action="files/files.php" method="post" align="center">
    <input type="submit" value = " CVS files "/>
    </form>
    <center>
<table class="chartdata" border="0">
<tr>
<td>  
<div id="tempchart" style="width: 800px; height: 500px; align: center border width: 0px"></div>
</td>
<td>
<div id="humchart" style="width: 800px; height: 500px; align: center border width: 0px"></div>
</td>
</tr>
</table>
</center>
<?php 
echo "<br /><br />Start Date: ",$startdate; 
echo " Start Time: ",$starttime; 
echo "<br />End Date: ",$enddate; 
echo " End Time: ",$endtime 
?>
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