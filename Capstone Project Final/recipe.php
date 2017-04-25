<!DOCTYPE html>
<html lang="en" >
<head>
    <meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta name="keywords" content="footer, links, icons" />
	
	
    <title>Recipies</title>
<link rel= "stylesheet" href="css/style.css">
	<link rel="stylesheet" href="css/demo.css">
	<link rel="stylesheet" href="css/footer-basic-centered.css">
	<link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css">

	
</head>


<body>

<!--Navigation Bar-->



<nav>
<ul>
<h2 style="font-size:200%;text-align:center;color:white;">Easy Healthy Eats</h2>
  <li><a href="index.php">Home</a></li>
  <li><a href="recipe.php">Recipes</a></li>
  <li><a href="addrecipe.php">Add Recpe</a></li>
 
  
  <li><a href="Sign-In.php">Sign In</a></li>
  <li><a href="sign-up.php">Register</a></li>
  
</ul>
</nav>

<!--Navigation Bar End-->

<?php


//connecting to database
require_once("db.php");


$categoryID = (isset($_GET['category']) ? $_GET['category'] : '');
//$categoryID = $_GET['category'];


if ( empty($categoryID) ){
    $categoryID = 1;
}
$sql = "SELECT * FROM categories";
$results = $db->query($sql);


?>






<form action="recipe.php" method="get">

    <select name="category">
	
	
	<table>
        
        <?php
            foreach($results as $row){
                echo "<option value='" . $row['categoryID'] . "'>";
                echo $row['categoryName'];
                echo "</option>\n";
            }
        ?>
    </select>
    <input style=" background-color: #3e8c93;
    border: none;
    color: white;
    padding: 12px 20px;
    text-align: center;
    text-decoration: none;
    display: inline-block;
    font-size: 16px;
    margin: 4px 2px;
    cursor: pointer;" type="submit" />
	
</form>


<?php
$sql = "SELECT categoryName FROM categories WHERE categoryID=$categoryID";
$results = $db->query($sql);
$row = $results->fetch();
?>



<h1>List Of Recipes For  <?php echo $row['categoryName']; ?></h1>


<table>


    <thead>
        <tr>
		<th>RecipeID		</th>
		<th>RecipeName		</th>
		<th>Ingredient			</th>
		<th>Ingredient			</th>
		<th>Ingredient			</th>
		<th>Ingredient			</th>
		<th>Ingredient			</th>
		<th>Ingredient			</th>
		<th>Ingredient			</th>
		<th>Ingredient			</th>
		<th>Step 1		</th>
		<th>Step 2		</th>
		<th>Step 3		</th>
		<th>Step 4		</th>
		<th>Step 5		</th>
		<th>Step 6		</th>
		<th>Instructions</th>
		</tr>
    </thead>
    <tbody>
	
	
	
        <?php
		
        $sql = "SELECT * FROM recipe WHERE categoryID = $categoryID";
        $results = $db->query($sql);
        foreach($results as $row) 
		{
            echo "\t<tr>";
            echo "<td>" . $row['RecipeID'] . "</td>";
            echo "<td>" . $row['RecipeName'] . "</td>";
            echo "<td>" . $row['ing1'] . "</td>";
			echo "<td>" . $row['ing2'] . "</td>";
			echo "<td>" . $row['ing3'] . "</td>";
			echo "<td>" . $row['ing4'] . "</td>";
			echo "<td>" . $row['ing5'] . "</td>";
			echo "<td>" . $row['ing6'] . "</td>";
			echo "<td>" . $row['ing7'] . "</td>";
			echo "<td>" . $row['ing8'] . "</td>";
			echo "<td>" . $row['step1'] . "</td>";
			echo "<td>" . $row['step2'] . "</td>";
			echo "<td>" . $row['step3'] . "</td>";
			echo "<td>" . $row['step4'] . "</td>";
			echo "<td>" . $row['step5'] . "</td>";
			echo "<td>" . $row['step6'] . "</td>";
			echo "<td>" . $row['instruction'] . "</td>";
            
            echo "</tr>\n";
        }
        ?>
		
		
    </tbody>
	
	</table>
	

	
	
	
	
	
	




<!-- Footer-->


	<footer class="footer-basic-centered">

			<p class="footer-company-motto">Easy Healthy Eats</p>

			<p class="footer-links">
				<a href="http://www.bodybuilding.com/">BodyBuilding.com</a>
				·
				<a href="http://www.gnc.com/home/index.jsp">GNC</a>
				·
				<a href="https://www.vitaminshoppe.com/">Vitamin Shop</a>
				
			
			</p>

			<p class="footer-company-name">Easy Helthy Eats &copy; 2017</p>

		</footer>
<!-- Footer-->



</body>
</html>
