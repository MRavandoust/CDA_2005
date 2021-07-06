<?php
/*
Template Name: CV
*/
ob_start();
get_header();

if (isset($_POST['submit'])) {
   $formations_array = $_POST['formations'];
   $compétences_array = $_POST['competences'];
   $expériences_array = $_POST['experiences'];

   print '<pre>';
   print_r($compétences_array);
   print_r($expériences_array);
   print_r($formations_array);
   print '</pre>';
}


$success = false;
$err = false;
$user = wp_get_current_user();
//print_r($user);
if ($user->ID == 0) {
   header('location:login');
} elseif (isset($_POST['update_info'])) {
   if (!wp_verify_nonce($_POST['info_nonce'], 'info_nonce')) {
      die('Token non valide !');
   }

   foreach ($_POST['keys'] as $key => $value) {
      if (empty($value)) {
         delete_user_meta(get_current_user_id(), $key, $value);
      } else {

         update_user_meta(get_current_user_id(), $key, $value);
      }
   }
} elseif (isset($_POST['pass_cange'])) {
   if (!wp_verify_nonce($_POST['pass_nonce'], 'pass_nonce')) {
      die('Token non valide !');
   }

   $user1 = get_userdata($user->ID);
   if ($user1) {
      $password = $_POST['pass_actuel'];
      $hash     = $user1->data->user_pass;
      if (wp_check_password($password, $hash)) {
         if ($_POST['nouveau_pass'] != $_POST['nouveau_pass2']) {
            $err = "Les deux nouveau mot de pass ne sont pas pareil";
         } else {
            wp_update_user(array('ID' => $user->ID, 'user_pass' => $_POST['nouveau_pass']));
            clean_user_cache($user->ID);
            $success = "Le mot de passe a été modifié avec succès";

            echo "
                <script type='text/javascript'>
                    $(document).ready(function(){
                        $('#staticBackdrop').modal('show');
                    });
                </script>
                ";

            // wp_logout();
            //  header('location:login');
         }
      } else
         $err = "Le mot de pass saisi ne correspend pas à mot de pass actuel";
   }
}
?>


<!-- Modal -->
<div class="modal fade" id="staticBackdrop" data-mdb-backdrop="static" data-mdb-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="false">
   <div class="modal-dialog">
      <div class="modal-content">
         <div class="modal-header">
            <h5 class="modal-title" id="staticBackdropLabel">Modal title</h5>
            <button type="button" class="btn-close" data-mdb-dismiss="modal" aria-label="Close"></button>
         </div>
         <div class="modal-body">
            <?php if ($success) : ?>
               <p style="color: green;"><?= $success ?></p>
            <?php endif ?>
         </div>
         <div class="modal-footer">
            <button type="button" class="btn btn-secondary" data-mdb-dismiss="modal">
               Fermer
            </button>
         </div>
      </div>
   </div>
</div>



<section class="container" style="text-align: center; margin-top:50px;">
   <div class="logo-rond">
      <a href="<?php bloginfo('url'); ?>">
         <img src="<?php bloginfo('template_url'); ?>/images/logo.svg" alt="Atouts Pour Tous">
      </a>
   </div>
   <h4 class="section-title" style="margin-top: 30px;">Mon CV</h4>
   <?php if ($err) : ?>
      <p style="color: red;"><?= $err ?></p>
   <?php endif ?>

</section>


<div class="container">
   <form action="<?= $_SERVER['REQUEST_URI'] ?>" method="POST">
      <div class="row">
         <div class="col-md-4 ">
            <div class="card text-center">
               <h5 class="card-header">COMPETENCES TECHNIQUES</h5>
               <div class="card-body field_wrapper1">
                  <div>
                     <!-- Input Field -->
                     <div class="form-outline mb-4" style="float: left; width: 85%">
                        <input type="text" id="field" class="form-control" name="competences[]" value="<?= isset($d['first_name']) ? $d['first_name'] : ''; ?>">
                        <label class="form-label" for="field" style="margin-left: 0px;">Compétence 1</label>
                        <div class="form-notch">
                           <div class="form-notch-leading" style="width: 9px;"></div>
                           <div class="form-notch-middle" style="width: 88.8px;"></div>
                           <div class="form-notch-trailing"></div>
                        </div>
                     </div>
                     <a href="javascript:void(0);" class="add_button1 btn btn-floating" title="Ajouter un champ"> + </a>
                  </div>
               </div>
            </div>
         </div>

         <div class="col-md-4 ">
            <div class="card text-center">
               <h5 class="card-header">EXPÉRIENCES PROFESSIONNELLES</h5>
               <div class="card-body field_wrapper2">
                  <div>
                     <!-- Input Field -->
                     <div class="form-outline mb-4" style="float: left; width: 85%">
                        <input type="text" id="field" class="form-control" name="experiences[]" value="<?= isset($d['first_name']) ? $d['first_name'] : ''; ?>">
                        <label class="form-label" for="field" style="margin-left: 0px;">Expérience 1</label>
                        <div class="form-notch">
                           <div class="form-notch-leading" style="width: 9px;"></div>
                           <div class="form-notch-middle" style="width: 88.8px;"></div>
                           <div class="form-notch-trailing"></div>
                        </div>
                     </div>
                     <a href="javascript:void(0);" class="add_button2 btn btn-primary btn-floating" title="Ajouter un champ"> + </a>
                  </div>
               </div>
            </div>
         </div>

         <div class="col-md-4 ">
            <div class="card text-center">
               <h5 class="card-header">FORMATIONS</h5>
               <div class="card-body field_wrapper3">
                  <div>
                     <!-- Input Field -->
                     <div class="form-outline mb-4" style="float: left; width: 85%">
                        <input type="text" id="field" class="form-control" name="formations[]" value="<?= isset($d['first_name']) ? $d['first_name'] : ''; ?>">
                        <label class="form-label" for="field" style="margin-left: 0px;">Formation 1</label>
                        <div class="form-notch">
                           <div class="form-notch-leading" style="width: 9px;"></div>
                           <div class="form-notch-middle" style="width: 88.8px;"></div>
                           <div class="form-notch-trailing"></div>
                        </div>
                     </div>
                     <a href="javascript:void(0);" class="add_button3 btn btn-primary btn-floating" title="Ajouter un champ"> + </a>
                  </div>
               </div>
            </div>
         </div>
      </div>

      <div class="row" style="margin-top: 20px;">
         <div class="col">
            <div class="card text-center">
               <h5 class="card-header" style="text-align: left;">LANGUES</h5>
               <div class="card-body">
                  <div class="form-outline">
                     <input type="text" id="Langues" class="form-control" aria-describedby="Langues" />
                     <label class="form-label" for="Langues">LANGUES</label>
                  </div>
                  <div id="Langues" class="form-text" style="text-align: left;">
                     Une expliquation de contenu de ce champ.
                  </div>
               </div>
            </div>
         </div>

         <div class="col">
            <div class="card text-center">
               <h5 class="card-header" style="text-align: left;">CENTRES D’INTÉRÊTS</h5>
               <div class="card-body">
                  <div class="form-outline">
                     <input type="text" id="interets" class="form-control" aria-describedby="interets" />
                     <label class="form-label" for="interets">CENTRES D’INTÉRÊTS</label>
                  </div>
                  <div id="textExample1" class="form-text" style="text-align: left;">
                     Une expliquation de contenu de ce champ.
                  </div>
               </div>
            </div>
         </div>
      </div>

      <div class="row" style="margin-top: 20px;">
         <!-- Textarea -->
         <div class="col " >
            <div class="card text-center">
               <h5 class="card-header" style="text-align: left;">Profile</h5>
               <div class="card-body">
                  <div class="form-outline">
                     <textarea class="form-control" id="textAreaExample" rows="4"></textarea>
                     <label class="form-label" for="textAreaExample">A propos de moi</label>
                  </div>
               </div>
            </div>
         </div>
      </div>


      <!-- Submit button -->
      <button type="submit" name="submit" id="submit" class="btn btn-block" style="margin-top: 25px; background-color: #ED7D31 !important; color: white">Enregistrer</button>
   </form>
</div>




<script>
   $(document).ready(function() {
      var maxField1 = 10;
      var addButton1 = $('.add_button1');
      var wrapper1 = $('.field_wrapper1');
      var x1 = 1;
      $(addButton1).click(function() {
         if (x1 < maxField1) {
            x1++;
            $(wrapper1).append('<div><div class="form-outline mb-4" style="float: left; width: 85%"><input type="text" id="field" class="form-control" name="competences[]" value="<?= isset($d['first_name']) ? $d['first_name'] : ''; ?>"><label class="form-label" for="field" style="margin-left: 0px;">Compétence ' + x1 + '</label><div class="form-notch"><div class="form-notch-leading" style="width: 9px;"></div><div class="form-notch-middle" style="width: 88.8px;"></div><div class="form-notch-trailing"></div></div></div><a href="javascript:void(0);" class="remove_button1 btn btn-danger btn-floating" title="supprimer le champ" style="margin-top:22px;"> - </a></div>');
         }
      });
      $(wrapper1).on('click', '.remove_button1', function(e) {
         e.preventDefault();
         $(this).parent('div').remove();
         x1--;
      });

      var maxField2 = 10;
      var addButton2 = $('.add_button2');
      var wrapper2 = $('.field_wrapper2');
      var x2 = 1;
      $(addButton2).click(function() {
         if (x2 < maxField2) {
            x2++;
            $(wrapper2).append('<div><div class="form-outline mb-4" style="float: left; width: 85%"><input type="text" id="field" class="form-control" name="experiences[]" value="<?= isset($d['first_name']) ? $d['first_name'] : ''; ?>"><label class="form-label" for="field" style="margin-left: 0px;">Expérience ' + x2 + '</label><div class="form-notch"><div class="form-notch-leading" style="width: 9px;"></div><div class="form-notch-middle" style="width: 88.8px;"></div><div class="form-notch-trailing"></div></div></div><a href="javascript:void(0);" class="remove_button2 btn btn-danger btn-floating" title="supprimer le champ" style="margin-top:22px;"> - </a></div>');
         }
      });
      $(wrapper2).on('click', '.remove_button2', function(e) {
         e.preventDefault();
         $(this).parent('div').remove();
         x2--;
      });



      var maxField3 = 10;
      var addButton3 = $('.add_button3');
      var wrapper3 = $('.field_wrapper3');
      var x3 = 1;
      $(addButton3).click(function() {
         if (x3 < maxField3) {
            x3++;
            $(wrapper3).append('<div><div class="form-outline mb-4" style="float: left; width: 85%"><input type="text" id="field" class="form-control" name="formations[]" value="<?= isset($d['first_name']) ? $d['first_name'] : ''; ?>"><label class="form-label" for="field" style="margin-left: 0px;">Formation ' + x3 + '</label><div class="form-notch"><div class="form-notch-leading" style="width: 9px;"></div><div class="form-notch-middle" style="width: 88.8px;"></div><div class="form-notch-trailing"></div></div></div><a href="javascript:void(0);" class="remove_button3 btn btn-danger btn-floating" title="supprimer le champ" style=" margin-top:22px;"> - </a></div>');
         }
      });
      $(wrapper3).on('click', '.remove_button3', function(e) {
         e.preventDefault();
         $(this).parent('div').remove();
         x3--;
      });
   });
</script>








<?php get_footer();
ob_end_flush();
?>