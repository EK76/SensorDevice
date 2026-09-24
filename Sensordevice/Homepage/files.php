<?php
header("Cache-Control: no-store, must-revalidate, max-age=0");
?>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
    <link rel="stylesheet" href="../style.css">
  <script>
</script>
</head>
<body>
<p class="maintext">
Ken's Sensor Device
</p>
<p class="maintext2">
Contents of the cvs files.
</br>
</p>
<?php

if(isset($_POST['showFile']))
{ 
    echo nl2br(file_get_contents($_POST['show']));
    echo "<form action='files.php' method='post'>
    <input type='submit' value = ' Back '>
    </form>";
} 



else
{   
  if(isset($_POST['deleteFile']))
  {  
    $delete = "/files/".$_POST['delete']; 
    unlink($_SERVER['DOCUMENT_ROOT'] .$delete);
      echo "<p class='subtext4'>";
    echo "File ",basename($delete)," is deleted!<br />";
    echo "</p>";
  }    


  $folder = "/var/www/sensordevice/files/";
  $files= glob($folder . "*.csv");
  $files = array_combine(array_map("filemtime", $files), $files);
  krsort($files);
  
  foreach($files as $files2)
  {
    echo "<p class='subtext3'>";
    echo basename($files2, "&nbsp;&nbsp;&nbsp;&nbsp;");

    
  ?>
  <table class="buttonvalue">
  <tr>
  <td>  
  <form action="" method="post" enctype="multipart/form-data" onsubmit="return confirm('Are you sure you want to delete this file?')">
  <input type="hidden" name="delete" value="<?php echo basename($files2)?>">
  <input type="submit" value = "  Delete file  " name="deleteFile"/>
  </form>
  </td>
  <td>
  <form action="" method="post" enctype="multipart/form-data">
  <input type="hidden" name="show" value="<?php echo basename($files2)?>">
  <input type="submit" value = "  Show contents  " name="showFile"/>
  </form>
  </td>
  <td>
  <form method="get" action="<?php echo basename($files2)?>">
  <button type="submit">Download</button>
  </form>
  </td>
  </tr>
  </table>
  </p>
  <?php  
}
?>


<form action="/../index.php" method="post">
<input type="submit" value = " Back ">
</form>
<?php  
}
?>
</body>
</html>