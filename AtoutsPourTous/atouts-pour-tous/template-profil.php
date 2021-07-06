<?php
/*
Template Name: Profile
*/
ob_start();
get_header();

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
            $success = "Vos informations ont été modifié avec succès";
            echo "
                <script type='text/javascript'>
                    $(document).ready(function(){
                        $('#staticBackdrop').modal('show');
                    });
                </script>
                ";
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
               </script>
                <script>
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
    <h4 class="section-title" style="margin-top: 30px;">Mes informations</h4>

    <?php if ($err) : ?>
        <p style="color: red;"><?= $err ?></p>
    <?php endif ?>

</section>

<div class="container">
    <div id="mdb-panel-tab-content" class="tab-content pt-5">

        <!--Grid row-->
        <div class="row mb-4">



            <!--Grid column-->
            <div class="col-md-6 mb-4">

                <!--Card-->
                <div class="card">
                    <div id="mdb-settings-public-preloader" class="checkout-preloader-container" style="display: none;">
                        <div class="preloader-wrapper big active">
                            <div class="spinner-layer spinner-blue-only">
                                <div class="circle-clipper left">
                                    <div class="circle"></div>
                                </div>
                                <div class="gap-patch">
                                    <div class="circle"></div>
                                </div>
                                <div class="circle-clipper right">
                                    <div class="circle"></div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- Card header -->
                    <h5 class="card-header">Informations personnelles</h5>

                    <!--Card content-->
                    <div class="card-body">

                        <!-- Form -->
                        <form id="edit-user-form" action="<?= $_SERVER['REQUEST_URI'] ?>" method="POST">

                            <!--Input Nom-->
                            <input type="text" id="edit-last-name" class="form-control mb-3" placeholder="Nom" name="keys[last_name]" value="<?= $user->last_name ? $user->last_name  : '' ?>">

                            <!--Input Prenom-->
                            <input type="text" id="edit-first-name" class="form-control mb-3" placeholder="Prenom" name="keys[first_name]" value="<?= $user->first_name ? $user->first_name  : '' ?>">

                            <!--Input Date de naissance-->
                            <label for="edit-country">Date de naissance:</label>
                            <input type="date" id="edit-country" class="form-control mb-3" placeholder="date de naissance" name="keys[birt_day]" value="<?= $user->birt_day ? $user->birt_day  : '' ?>">

                            <!--Input Portable-->
                            <input type="text" id="edit-company" class="form-control mb-3" placeholder="Mobile" name="keys[mobile]" value="<?= $user->mobile ? $user->mobile  : '' ?>">

                            <!--Input Téléphone fix-->
                            <input type="tel" id="edit-position" class="form-control mb-3" placeholder="Téléphone fixe" name="keys[tel_fix]" value="<?= $user->tel_fix ? $user->tel_fix  : '' ?>">

                            <!--Input Adresse-->
                            <input type="text" id="edit-country" class="form-control mb-3" placeholder="Adresse" name="keys[adresse]" value="<?= $user->adresse ? $user->adresse  : '' ?>">

                            <!-- Descrition Textarea -->
                            <textarea type="text" id="edit-description" class="form-control md-textarea" placeholder="Description" name="keys[description]"><?= $user->description ? $user->description  : '' ?></textarea>

                            <!--Input Nonce -->
                            <input type="hidden" id="edit-none" name="info_nonce" value="<?= wp_create_nonce('info_nonce') ?>">

                            <!-- Action button -->
                            <div class="text-center">
                                <button id="edit-user" type="submit" name="update_info" class="btn btn-info btn-md waves-effect waves-light" style="margin-top: 15px;">Sauvegarder les modifications</button>
                            </div>

                        </form>
                        <!-- Form -->

                    </div>

                </div>
                <!--/.Card-->

            </div>
            <!--Grid column-->


            <!--Grid column-->
            <div class="col-md-6 mb-4">

                <!--Card-->
                <div class="card mb-4">

                    <div id="mdb-settings-account-preloader" class="checkout-preloader-container" style="display: none;">
                        <div class="preloader-wrapper big active">
                            <div class="spinner-layer spinner-blue-only">
                                <div class="circle-clipper left">
                                    <div class="circle"></div>
                                </div>
                                <div class="gap-patch">
                                    <div class="circle"></div>
                                </div>
                                <div class="circle-clipper right">
                                    <div class="circle"></div>
                                </div>
                            </div>
                        </div>
                    </div>


                    <!-- Card header -->
                    <h5 class="card-header">Paramètres du compte</h5>

                    <!--Card content-->
                    <div class="card-body">

                        <!-- Form -->
                        <form id="edit-user-account-form" action="<?= $_SERVER['REQUEST_URI'] ?>" method="POST">

                            <!--Input Identifiant-->
                            <input type="text" id="display_name" class="form-control mb-3" placeholder="Identifiant" name="user_login" value="<?= $user->user_login ? $user->user_login  : ''; ?>">

                            <!--Input Email-->
                            <input type="email" id="user_email" class="form-control mb-3" placeholder="Email" name="user_email" value="<?= $user->user_email ? $user->user_email  : ''; ?>">

                            <!-- Action button -->
                            <div class="text-center">
                                <button id="edit-user-account" class="btn btn-info btn-md waves-effect waves-light">Sauvegarder les modifications</button>
                            </div>

                        </form>
                        <!-- Form -->

                    </div>

                </div>
                <!--/.Card-->

                <!--Card-->
                <div class="card mb-4">

                    <div id="mdb-settings-password-preloader" class="checkout-preloader-container" style="display: none;">
                        <div class="preloader-wrapper big active">
                            <div class="spinner-layer spinner-blue-only">
                                <div class="circle-clipper left">
                                    <div class="circle"></div>
                                </div>
                                <div class="gap-patch">
                                    <div class="circle"></div>
                                </div>
                                <div class="circle-clipper right">
                                    <div class="circle"></div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- Card header -->
                    <h5 class="card-header">Changer mot de passe</h5>

                    <!--Card content-->
                    <div class="card-body">

                        <!-- Form -->
                        <form id="user-reset-password-form" action="<?= $_SERVER['REQUEST_URI'] ?>" method="POST">

                            <!--Input Name-->
                            <input type="password" id="current_password" class="form-control mb-3" placeholder="Mot de passe actuel" name="pass_actuel">

                            <!--Input Name-->
                            <input type="password" id="new_password" class="form-control mb-3" placeholder="Nouveau mot de passe" name="nouveau_pass" value="<?= isset($_POST['nouveau_pass']) ? $_POST['nouveau_pass'] : ''; ?>">

                            <!--Input Name-->
                            <input type="password" id="confirm_new_password" class="form-control mb-3" placeholder="Confirmer le nouveau mot de passe" name="nouveau_pass2" value="<?= isset($_POST['nouveau_pass2']) ? $_POST['nouveau_pass2'] : ''; ?>">

                            <!--Input Nonce -->
                            <input type="hidden" id="edit-none" name="pass_nonce" value="<?= wp_create_nonce('pass_nonce') ?>">
                            <!-- Action button -->
                            <div class="text-center">
                                <button id="user-reset-password" class="btn btn-info btn-md waves-effect waves-light" name="pass_cange">Réinitialiser le mot de passe</button>
                            </div>

                        </form>
                        <!-- Form -->

                    </div>

                </div>
                <!--/.Card-->

            </div>
            <!--Grid column-->





        </div>
        <!--Grid row-->
    </div>
</div>







<?php get_footer();
ob_end_flush();
?>