<!doctype html>
  <html lang="en">
    <head>
      <!-- Required meta tags -->
      <meta charset="utf-8">
     
      <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

      <!-- Bootstrap CSS -->
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">

      <title>Exercice 2 prêt bancaire Webserveur en mode OBJET PHP </title>
      <style>
      input[type='text'] { margin:15px 20px; background-color:#E6E6E6;  }
  	label { margin-left:10px;margin-right:10px}
  	fieldset {margin-top:50px; width:50%; margin-left:auto; margin-right:auto;}
  	#btnsub { width:100%; text-align:right}
  	#echeance {width:100%; text-align:left}
  	#echeance input[type='text'] { width:40%;}
      </style>
    </head>
    
    <body>
  <?php
   
      
     require_once("metier/service_financier.php");
     
    $res=0;

      
    if(isset($_GET["kal"]) && isset($_GET["ta"]) && isset($_GET["an"]))
    {
      
    $monfinancier=new financier($_GET['kal'],$_GET['ta'],$_GET['an'] );
    
    //utilisation de la methode d'instance: la fonction calcul "mensualité" avec un retour de variable double   
    $res=$monfinancier->calculMensualite();
    //echo $res;
    //utilisation d'une methode dite "de classe" ou static
    financier::affichemessage();
    //accès à un attribut static de classe
    financier::$typeclient="entreprise";
    //rappel de la methode dite  "de classe"
    financier::affichemessage();

  
    }
    


   

   

  ?>
   
    
    <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="get" enctype="text/plain">
    <!--variable environnement serveur adresse page en cours $_SERVER['PHP_SELF']-->
    <fieldset><legend>Calcul prêt bancaire</legend>
    <div class="form-group">
      <label for="kal">Capital empruté (en €):</label>
      <input type="text" class="form-control" placeholder="montant emprunt" id="kal" name="kal" value="<?php echo(!empty($_GET["kal"]))? $_GET["kal"]: ""  ?>" >
    </div>
    <div class="form-group">
      <label for="ta">Taux d'intérêt emprunteur en % :</label>
      <input type="text" class="form-control" placeholder="taux en %" id="ta" name="ta"  value="<?php echo(!empty($_GET["ta"]))? $_GET["ta"]: ""  ?>" >
    </div>
    
      <div class="form-group">
      <label for="an">Durée de remboursement en nb d'années :</label>
      <input type="text" class="form-control" placeholder="Durée du prêt en années" id="an" name="an"  value="<?php echo(!empty($_GET["an"]))? $_GET["an"]: ""  ?>" >
    </div>
    <div class="form-group form-check">
      <label class="form-check-label">
          <input class="form-check-input" type="checkbox" name="detail" value="ok" <?php if (isset( $_GET[
  'detail']))  echo  'checked="checked"'; ?> >Tableau d'amortissement.
      </label>
    </div>
   <div class="form-group form-button" id="btnsub" >
    <button type="submit" class="btn btn-primary">Submit</button>
  </div>

  <div class="form-group" id="echeance" >
    <label >Mensualité en €:</label>
      <input type="text" class="form-control" value="<?php echo(!empty($res))? round($res,2)." €": "NaN"  ?>" id="mens" name="mens" disabled=" disabled">
    </div>
    <fieldset>
  </form>

 <?php
   
      
     require_once("metier/service_financier.php");
     
    $res=0;

      
    if(isset($_GET["kal"]) && isset($_GET["ta"]) && isset($_GET["an"]) && isset($_GET["detail"]) && $_GET["detail"]=="ok")
    {
      
    $monfinancier=new financier($_GET['kal'],$_GET['ta'],$_GET['an']);
     
     //utilisation de la procedure ( methode d'instance qui ne renvoie rien mais fait de l'affichage) 
    $monfinancier->afficherTableau();
    }
    else 
    {
    echo "Affichage tableau impossible, case non cochée...";
      
    }


   

   

  ?>



    
     <!-- Optional JavaScript -->
      <!-- jQuery first, then Popper.js, then Bootstrap JS -->
      <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
      <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
      <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    </body>
  </html>