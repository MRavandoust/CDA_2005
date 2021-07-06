<?php
/*
Template Name: Connexion
*/
ob_start();
get_header();

$error = false;
if(!empty($_POST)){
   $user = wp_signon($_POST);
   if(is_wp_error($user)){
      $error = $user->get_error_message();
   }else{
      header('location:profil');
   }
}else{
   $user = wp_get_current_user();
   if($user->ID != 0){
      header('location:profil');
   }
}


?>


<section class="container" style="text-align: center; margin-top:50px;">
<div class="logo-rond">
   <a href="<?php bloginfo('url'); ?>" >
      <img src="<?php bloginfo('template_url'); ?>/images/logo.svg" alt="Atouts Pour Tous">
   </a>
</div>
   <h4 style="margin-top: 30px;">Se connecter</h4>
<?php if($error) : ?>
   <p><?= $error ?></p>
   <?php endif ?>

</section>



<section class=" p-4 d-flex justify-content-center mb-4">
   <form action="<?= $_SERVER['REQUEST_URI'] ?>" method="POST" style="width: 22rem;">
      <!-- Login input -->
      <div class="form-outline mb-4">
         <input type="text" id="user_login" class="form-control" name="user_login">
         <label class="form-label" for="user_login" style="margin-left: 0px;">Votre login</label>
         <div class="form-notch">
            <div class="form-notch-leading" style="width: 9px;"></div>
            <div class="form-notch-middle" style="width: 88.8px;"></div>
            <div class="form-notch-trailing"></div>
         </div>
      </div>

      <!-- Password input -->
      <div class="form-outline mb-4">
         <input type="password" id="user_password" class="form-control" name="user_password">
         <label class="form-label" for="user_password" style="margin-left: 0px;">Mot de pass</label>
         <div class="form-notch">
            <div class="form-notch-leading" style="width: 9px;"></div>
            <div class="form-notch-middle" style="width: 64.8px;"></div>
            <div class="form-notch-trailing"></div>
         </div>
      </div>

      <!-- 2 column grid layout for inline styling -->
      <div class="row mb-4">
         <div class="col d-flex justify-content-center">
            <!-- Checkbox -->
            <div class="form-check">
               <input class="form-check-input" type="checkbox" value="1" id="remember" checked="" name="remember">
               <label class="form-check-label" for="remember"> Se souvenir de moi </label>
            </div>
         </div>

         <div class="col">
            <!-- Simple link -->
            <a href="#!">Mot de pass oublié?</a>
         </div>
      </div>

      <!-- Submit button -->
      <button type="submit" class="btn btn-primary btn-block">Se connecter</button>
   </form>
</section>















<?php get_footer();
ob_end_flush();
?>