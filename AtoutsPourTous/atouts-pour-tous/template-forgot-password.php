<?php
/*
Template Name: Forgot Password
*/
ob_start();
get_header();

$err = false;
if (!empty($_POST)) {
   $d = $_POST;
   if($d['user_pass'] != $d['user_pass2']){
      $err = 'Les 2 moyt de pass ne coresspendent pas!';
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
   <h4 style="margin-top: 30px;">Mot de pass oublié ?</h4>
   <h5 style="margin-top: 30px;">Veuillez seisire votre identifiant ou adresse e-mail</h5>
   <?php if ($err) : ?>
      <p style="color: red;"><?= $err ?></p>
   <?php endif ?>

</section>



<section class=" p-4 d-flex justify-content-center mb-4">
   <form action="<?= $_SERVER['REQUEST_URI'] ?>" method="POST" style="width: 22rem;">

      
      <!-- Email input -->
      <div class="form-outline mb-4">
         <input type="text" id="user_email" class="form-control" name="user_email" value="<?= isset($d['user_email'])? $d['user_email'] :'';?>">
         <label class="form-label" for="user_email" style="margin-left: 0px;">Identifiant ou adresse e-mail</label>
         <div class="form-notch">
            <div class="form-notch-leading" style="width: 9px;"></div>
            <div class="form-notch-middle" style="width: 88.8px;"></div>
            <div class="form-notch-trailing"></div>
         </div>
      </div>

      
      <!-- Submit button -->
      <button type="submit" class="btn btn-primary btn-block">Générer un mot de passe</button>
   </form>
</section>

<div class="container" style="text-align: center;">
<a href="<?= bloginfo('url'); ?>/login">Se connecter</a> |  <a href="<?= bloginfo('url'); ?>/register">S'inscrire</a> | <a href="<?= bloginfo('url'); ?>">Page d'accueil</a>
</div>



 <!--        Vérifiez vos e-mails pour le lien de confirmation puis rendez-vous sur la page de connexion. -->









<?php get_footer();
ob_end_flush();
?>