<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Add Recipes</title>
    <!--Import Google Icon Font-->
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <!--Import materialize.css-->
    <link type="text/css" rel="stylesheet" href="css/materialize.min.css"  media="screen,projection"/>
	<link rel= "stylesheet" href="css/add.css">
	<!--<link rel="stylesheet" href="css/demo.css">-->
	<link rel="stylesheet" href="css/footer-basic-centered.css">
	
	
	
    <!--Let browser know website is optimized for mobile-->
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
	
	<form method="POST" action="connectivity-addrecipe.php">
</head>



<body>


<!--Import jQuery before materialize.js-->

<script type="text/javascript" src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
<script type="text/javascript" src="js/materialize.min.js"></script>

<form method="POST" action="connectivity-addrecipe.php">



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


<br>
</br>

<br>
</br>

<br>
</br>

<div class= "recipieform">





   <div class="row">
   
  <form method="POST" action="connectivity-addrecipe.php">
       <form class="col s12 #1976d2 blue darken-2">
	   <form method="POST" action="connectivity-addrecipe.php">
           <div class="input-field col s12">
		   <form method="POST" action="connectivity-addrecipe.php">
		   
               <input placeholder="Enter Recipe Name Here" name="recipename" type="text" class="recipename">
               <label for="recipe_name"><h5></h5></label>
			   
               </div>
			   
           <div class="input-field col s6">
               <input name="ing1" type="text" class="ingredient_name" >
               <label for="ing1">Ingredient</label>
               </div>
           <div class="input-field col s6">
               <input name="ing2" type="text" class="ingredient_name">
               <label for="ing2" >Ingredient</label>
               </div>
           <div class="input-field col s6">
               <input name="ing3" type="text" class="ingredient_name">
               <label for="ing3" >Ingredient</label>
           </div>
           <div class="input-field col s6">
               <input name="ing4" type="text" class="ingredient_name" >
               <label for="ing4">Ingredient</label>
           </div>
           <div class="input-field col s6">
               <input name="ing5" type="text" class="ingredient_name" >
               <label for="ing5">Ingredient</label>
           </div>
           <div class="input-field col s6">
               <input name="ing6" type="text" class="ingredient_name" >
               <label for="ingr6">Ingredient</label>
           </div>
           <div class="input-field col s6">
               <input name="ing7" type="text" class="ingredient_name" >
               <label for="ing7">Ingredient</label>
           </div>
           <div class="input-field col s6">
               <input name="ing8" type="text" class="ingredient_name" >
               <label for="ing8">Ingredient</label>
           </div>
           <div class="input-field col s6">
               <input name="step1" type="text" class="recipe_steps" >
               <label for="step1">Recipe Steps</label>
           </div>
           <div class="input-field col s6">
               <input name="step2" type="text" class="recipe_steps" >
               <label for="step2">Recipe Steps</label>
           </div>
           <div class="input-field col s6">
               <input name="step3" type="text" class="recipe_steps" >
               <label for="step3">Recipe Steps</label>
           </div>
           <div class="input-field col s6">
               <input name="step4" type="text" class="recipe_steps" >
               <label for="step4">Recipe Steps</label>
           </div>
           <div class="input-field col s6">
               <input name="step5" type="text" class="recipe_steps" >
               <label for="step5">Recipe Steps</label>
           </div>
           <div class="input-field col s6">
               <input name="step6" type="text" class="recipe_steps" >
               <label for="step6">Recipe Steps</label>
           </div>
		   <br></br>
		
	<!--Buttons-->
		   
		<!--   <div class="input-field col s2">
               <input name="categoryID" type="text" class="categoryID" >
               <label for="categoryID">Please Enter 1 For Breakfast 2 for Lunch 3 For Dinner</label>
           </div>-->
		   
		   
		   
    <p>
      <input name="categoryID" type="radio" id="1" value="1" />
      <label for="1">Breakfast</label>
    </p>
    <p>
      <input name="categoryID" type="radio" id="2" value="2" />
      <label for="2">Lunch</label>
    </p>
    <p>
      <input  name="categoryID" type="radio" id="3" value="3"  />
      <label for="3">Dinner</label>
    </p>
    

	
		

  </ul>
  

           <div class="row">
               <form class="col s12">
                   <div class="row">
                 <div class="input-field col s12">
                     <textarea name="instruction" class="text_instruction"></textarea>
                     <label for="instruction">Instructions For Recipe</label>
                 </div>
                       </div>
               </form>
           </div>

           <input type="submit" value="Enter Recipe"> 

       </form>


   </div>

</div>







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

			<p class="footer-company-name">Easy Healthy Eats &copy; 2017</p>

		</footer>
<!-- Footer-->



</body>



</html>
