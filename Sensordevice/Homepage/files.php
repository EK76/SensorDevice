<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    <link rel="stylesheet" href="../style.css">
  <script>
</script>
</head>
<body>
<p class="subtext4">
Contents of the cvs files.
</br>
</p>
<?php

if(isset($_POST['showFile']))
{ 
    echo nl2br(file_get_contents($_POST['show']));
    echo "<br /><button onclick='history.back()'>Back</button>";
} 
else
{   
  if(isset($_POST['deleteFile']))
  {  
    $delete = "/files/".$_POST['delete']; 
    unlink($_SERVER['DOCUMENT_ROOT'] .$delete);
  }    
  $folder = "/var/www/sensordevice/files/";
  $file= glob($folder . "*.csv");

  foreach($file as $file2)
  {
    echo "<p class='subtext3'>";
    echo basename($file2, "&nbsp;&nbsp;&nbsp;&nbsp;");
  ?>
  <table class="buttonvalue">
  <tr>
  <td>  
  <form action="" method="post" enctype="multipart/form-data">
  <input type="hidden" name="delete" value="<?php echo basename($file2)?>">
  <input type="submit" value = "  Delete file  " name="deleteFile"/>
  </form>
  </td>
  <td>
  <form action="" method="post" enctype="multipart/form-data">
  <input type="hidden" name="show" value="<?php echo basename($file2)?>">
  <input type="submit" value = "  Show contents  " name="showFile"/>
  </form>
  </td>
  <td>
  <button class="btn"><a href="<?php echo basename($file2)?>" download="<?php echo basename($file2)?>">Download</a></button>  
  </td>
  </tr>
  </table>
  </p>
  <?php  
}
?>
<form action="/../index.php" method="post">
<input type="submit" value = " Back "/>
</form>
<?php  
}
?>
</body>
</html>