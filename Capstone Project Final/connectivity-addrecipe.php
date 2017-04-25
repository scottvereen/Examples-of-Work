<?php

define('DB_HOST', 'localhost'); 
define('DB_NAME', 'practice'); 
define('DB_USER','root'); 
define('DB_PASSWORD',''); 

$con=@mysql_connect(DB_HOST,DB_USER,DB_PASSWORD) or die("Failed to connect to MySQL: " . mysql_error()); 
$db=mysql_select_db(DB_NAME,$con) or die("Failed to connect to MySQL: " . mysql_error()); 


	$RecipeName = $_POST['recipename'];
	$ing1 = $_POST['ing1'];
	$ing2 = $_POST['ing2'];
	$ing3 = $_POST['ing3'];
	$ing4 = $_POST['ing4'];
	$ing5 = $_POST['ing5'];
	$ing6 = $_POST['ing6'];
	$ing7 = $_POST['ing7'];
	$ing8 = $_POST['ing8'];
	$step1 = $_POST['step1'];
	$step2 = $_POST['step2'];
	$step3 = $_POST['step3'];
	$step4 = $_POST['step4'];
	$step5 = $_POST['step5'];
	$step6 = $_POST['step6'];
	$categoryID = $_POST['categoryID'];
	$instruction = $_POST['instruction'];
	
	
	
	
	$query = "INSERT INTO recipe(RecipeName,ing1,ing2,ing3,ing4,ing5,ing6,ing7,ing8,step1,step2,step3,step4,step5,step6,categoryID,instruction) VALUES ('$RecipeName','$ing1','$ing2','$ing3','$ing4','$ing5','$ing6','$ing7','$ing8','$step1','$step2','$step3','$step4','$step5','$step6','$categoryID','$instruction')";
	
$result = mysql_query($query); 





if($result) 
{ 
header( 'Location: http://localhost/Capstone%20Project%20Final/addrecipe.php' ) ;
} 
else 
{ 

die('Error: '.mysql_error($con)); 
} 

mysql_close($con);


?>