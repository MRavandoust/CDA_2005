<?php
/*
Template Name: Register
*/
ob_start();
get_header();

$err = false;
if (!empty($_POST)) {
   $d = $_POST;
   if($d['user_pass'] != $d['user_pass2']){
      $err = 'Les 2 mots de passe ne coresspendent pas!';
   }else{
      if(!is_email($d['user_email'])){
         $err = 'Veuillez entrer un email valid';
      }else{
         $user = wp_insert_user(array(
            'first_name' => $d['first_name'],
            'last_name' => $d['last_name'],
            'user_login' => $d['user_login'],
            'user_email' => $d['user_email'],
            'user_pass' => $d['user_pass'],
            'user_registered' => date('Y-m-d H:i:s')
         ));
         if(is_wp_error($user)){
            $err = $user->get_error_message();
         }else{
            $msg = 'Vous êtes maintenant inscrit.';
            $header = 'From : '. get_option('admin_email')."\r\n";
            wp_mail($d['user_email'] , 'Inscription réussie' , $msg , $header);
            $d = array();
            wp_signon($_POST);
            header('Location:profil');
         }
      }
   }

}


?>


<section class="container" style="text-align: center; margin-top:50px;">
<div class="logo-rond">
   <a href="<?php bloginfo('url'); ?>">
      <img src="<?php bloginfo('template_url'); ?>/images/logo.svg" alt="Atouts Pour Tous">
   </a>
</div>
   <h4 style="margin-top: 30px;">S'inscrire</h4>
   <?php if ($err) : ?>
      <p style="color: red;"><?= $err ?></p>
   <?php endif ?>

</section>



<section class=" p-4 d-flex justify-content-center mb-4">
   <form action="<?= $_SERVER['REQUEST_URI'] ?>" method="POST" style="width: 22rem;">

      <!-- First name input -->
      <div class="form-outline mb-4">
         <input type="text" id="first_name" class="form-control" name="first_name" value="<?= isset($d['first_name'])? $d['first_name'] :'';?>">
         <label class="form-label" for="first_name" style="margin-left: 0px;">Prenom</label>
         <div class="form-notch">
            <div class="form-notch-leading" style="width: 9px;"></div>
            <div class="form-notch-middle" style="width: 88.8px;"></div>
            <div class="form-notch-trailing"></div>
         </div>
      </div> 
      

       <!-- Laste name input -->
       <div class="form-outline mb-4">
         <input type="text" id="last_name" class="form-control" name="last_name" value="<?= isset($d['last_name'])? $d['last_name'] :'';?>">
         <label class="form-label" for="last_name" style="margin-left: 0px;">Nom</label>
         <div class="form-notch">
            <div class="form-notch-leading" style="width: 9px;"></div>
            <div class="form-notch-middle" style="width: 88.8px;"></div>
            <div class="form-notch-trailing"></div>
         </div>
      </div>
      
      <!-- Username input -->
      <div class="form-outline mb-4">
         <input type="text" id="user_login" class="form-control" name="user_login" value="<?= isset($d['user_login'])? $d['user_login'] :'';?>">
         <label class="form-label" for="user_login" style="margin-left: 0px;">Identifiant</label>
         <div class="form-notch">
            <div class="form-notch-leading" style="width: 9px;"></div>
            <div class="form-notch-middle" style="width: 88.8px;"></div>
            <div class="form-notch-trailing"></div>
         </div>
      </div>

      <!-- Email input -->
      <div class="form-outline mb-4">
         <input type="email" id="user_email" class="form-control" name="user_email" value="<?= isset($d['user_email'])? $d['user_email'] :'';?>">
         <label class="form-label" for="user_email" style="margin-left: 0px;">Email</label>
         <div class="form-notch">
            <div class="form-notch-leading" style="width: 9px;"></div>
            <div class="form-notch-middle" style="width: 88.8px;"></div>
            <div class="form-notch-trailing"></div>
         </div>
      </div>

      <!-- Password input -->
      <div class="form-outline mb-4">
         <input type="password" id="user_pass" class="form-control" name="user_pass" value="<?= isset($d['user_pass'])? $d['user_pass'] :'';?>">
         <label class="form-label" for="user_pass" style="margin-left: 0px;">Mot de pass</label>
         <div class="form-notch">
            <div class="form-notch-leading" style="width: 9px;"></div>
            <div class="form-notch-middle" style="width: 64.8px;"></div>
            <div class="form-notch-trailing"></div>
         </div>
      </div>


      <!-- Confirm Password input -->
      <div class="form-outline mb-4">
         <input type="password" id="user_pass2" class="form-control" name="user_pass2" value="<?= isset($d['user_pass2'])? $d['user_pass2'] :'';?>">
         <label class="form-label" for="user_pass2" style="margin-left: 0px;">Confirmez mot de pass</label>
         <div class="form-notch">
            <div class="form-notch-leading" style="width: 9px;"></div>
            <div class="form-notch-middle" style="width: 64.8px;"></div>
            <div class="form-notch-trailing"></div>
         </div>
      </div>

      
      <!-- Submit button -->
      <button type="submit" class="btn btn-primary btn-block">S'inscrire</button>
   </form>
</section>















<?php get_footer();
ob_end_flush();
?>