<?php
/*
Template Name: CVtheque
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




<section class="p-4 mb-4 d-flex justify-content-center">

    <form method="post" action="/employeurs/recherche/index/page/1">
        <h3>Consultation de la CVThèque</h3>
        <div class="cadre_fieldset_3quart">
            <fieldset>
                <dl>
                    <label for="region" class="formlabel optional">Région :</label>
                    <div>
                        <select class="form-select" name="region" id="region">
                            <option value="" label="-- Indifférent --">-- Indifférent --</option>
                            <optgroup id="region-optgroup-France" label="France">
                                <option value="1" label="Alsace">Alsace</option>
                                <option value="2" label="Aquitaine">Aquitaine</option>
                                <option value="3" label="Auvergne">Auvergne</option>
                                <option value="4" label="Basse-Normandie">Basse-Normandie</option>
                                <option value="5" label="Bourgogne">Bourgogne</option>
                                <option value="6" label="Bretagne">Bretagne</option>
                                <option value="7" label="Centre">Centre</option>
                                <option value="8" label="Champagne-Ardenne">Champagne-Ardenne</option>
                                <option value="9" label="Corse">Corse</option>
                                <option value="10" label="Franche-Comté">Franche-Comté</option>
                                <option value="11" label="Haute-Normandie">Haute-Normandie</option>
                                <option value="12" label="Languedoc-Roussillon">Languedoc-Roussillon</option>
                                <option value="13" label="Limousin">Limousin</option>
                                <option value="14" label="Lorraine">Lorraine</option>
                                <option value="15" label="Midi-Pyrénées">Midi-Pyrénées</option>
                                <option value="16" label="Nord-Pas-de-Calais">Nord-Pas-de-Calais</option>
                                <option value="17" label="Pays de la Loire">Pays de la Loire</option>
                                <option value="18" label="Picardie">Picardie</option>
                                <option value="19" label="Poitou-Charentes">Poitou-Charentes</option>
                                <option value="20" label="Provence-Alpes-Côte d'Azur">Provence-Alpes-Côte d'Azur</option>
                                <option value="21" label="Rhône-Alpes">Rhône-Alpes</option>
                                <option value="22" label="Île-de-France">Île-de-France</option>
                                <option value="34" label="Guadeloupe">Guadeloupe</option>
                                <option value="35" label="Guyane">Guyane</option>
                                <option value="36" label="La Réunion">La Réunion</option>
                                <option value="37" label="Martinique">Martinique</option>
                                <option value="38" label="Mayotte">Mayotte</option>
                                <option value="39" label="Nouvelle Calédonie">Nouvelle Calédonie</option>
                            </optgroup>
                            <optgroup id="region-optgroup-Luxembourg" label="Luxembourg">
                                <option value="33" label="Luxembourg">Luxembourg</option>
                            </optgroup>
                            <optgroup id="region-optgroup-Belgique" label="Belgique">
                                <option value="23" label="Flandre Occidentale">Flandre Occidentale</option>
                                <option value="24" label="Flandre Orientale">Flandre Orientale</option>
                                <option value="25" label="Anvers">Anvers</option>
                                <option value="26" label="Brabant Flamand">Brabant Flamand</option>
                                <option value="27" label="Limbourg">Limbourg</option>
                                <option value="28" label="Hainaut">Hainaut</option>
                                <option value="29" label="Brabant Wallon">Brabant Wallon</option>
                                <option value="30" label="Namur">Namur</option>
                                <option value="31" label="Liege">Liege</option>
                                <option value="32" label="Luxembourg">Luxembourg</option>
                            </optgroup>
                        </select>
                    </div>
                    <label for="fonction" class="formlabel optional">Fonction :</label>
                    <div>
                        <select class="form-select" name="fonction" id="fonction">
                            <option value="" label="-- Indifférent --">-- Indifférent --</option>
                            <option value="17" label="Autres">Autres</option>
                            <option value="3" label="Commercial, Distribution">Commercial, Distribution</option>
                            <option value="4" label="Comptabilité, Gestion, Finances">Comptabilité, Gestion, Finances</option>
                            <option value="16" label="Direction">Direction</option>
                            <option value="9" label="Droit,Juridique, Fiscalité">Droit,Juridique, Fiscalité</option>
                            <option value="7" label="Enseignement">Enseignement</option>
                            <option value="10" label="Informatique, Télécommunications">Informatique, Télécommunications</option>
                            <option value="15" label="Journalisme, Documentation">Journalisme, Documentation</option>
                            <option value="13" label="Logistique, Achat, Stock">Logistique, Achat, Stock</option>
                            <option value="2" label="Marketing, Publicité, Graphisme">Marketing, Publicité, Graphisme</option>
                            <option value="6" label="Métiers de la Banque, Assurance">Métiers de la Banque, Assurance</option>
                            <option value="12" label="Metallurgie, Electricite, Chimie, Textile, Bois">Metallurgie, Electricite, Chimie, Textile, Bois</option>
                            <option value="8" label="RH, Formation, Recrutement">RH, Formation, Recrutement</option>
                            <option value="5" label="Secteur médical, Santé, Social">Secteur médical, Santé, Social</option>
                            <option value="19" label="Service Client">Service Client</option>
                            <option value="18" label="Services a la personne">Services a la personne</option>
                            <option value="14" label="Tourisme, Restauration">Tourisme, Restauration</option>
                            <option value="11" label="Travaux, Chantiers, Urbanisme">Travaux, Chantiers, Urbanisme</option>
                        </select>
                    </div>
                    <label for="niveau_etude" class="formlabel optional">Niveau d'études :</label>
                    <div>
                        <select class="form-select" name="niveau_etude" id="niveau_etude">
                            <option value="" label="-- Indifférent --">-- Indifférent --</option>
                            <option value="11" label="Bac + 2 : DEUG, DEUST, classe préparatoire">Bac + 2 : DEUG, DEUST, classe préparatoire</option>
                            <option value="13" label="Bac + 3 : licence">Bac + 3 : licence</option>
                            <option value="6" label="Bac + 5 et plus : DEA, DESS, mastère, MBA...">Bac + 5 et plus : DEA, DESS, mastère, MBA...</option>
                            <option value="1" label="Bac général - Bac techno - Bac pro">Bac général - Bac techno - Bac pro</option>
                            <option value="12" label="BTS - DUT">BTS - DUT</option>
                            <option value="9" label="CAP - BEP">CAP - BEP</option>
                            <option value="8" label="Ecoles d'ingénieurs">Ecoles d'ingénieurs</option>
                            <option value="7" label="Ecoles de commerce">Ecoles de commerce</option>
                            <option value="2" label="Ecoles spécialisées">Ecoles spécialisées</option>
                            <option value="5" label="IEP (Institut d'études politiques)">IEP (Institut d'études politiques)</option>
                            <option value="4" label="IUP (Institut universitaire professionnalisé)">IUP (Institut universitaire professionnalisé)</option>
                            <option value="3" label="Maîtrise - MST">Maîtrise - MST</option>
                            <option value="10" label="Post BTS - DUT">Post BTS - DUT</option>
                        </select>
                    </div>
                    <label for="annees_experiences" class="formlabel optional">Années d'expérience :</label>
                    <div>
                        <select class="form-select" name="annees_experiences" id="annees_experiences">
                            <option value="" label="-- Indifférent --">-- Indifférent --</option>
                            <option value="1" label="Débutant">Débutant</option>
                            <option value="2" label="Entre 1 et 3 ans d'expérience">Entre 1 et 3 ans d'expérience</option>
                            <option value="3" label="Entre 3 et 5 ans d'expérience">Entre 3 et 5 ans d'expérience</option>
                            <option value="4" label="Entre 5 et 10 ans d'expérience">Entre 5 et 10 ans d'expérience</option>
                            <option value="5" label="Plus de 10 ans d'expérience">Plus de 10 ans d'expérience</option>
                        </select>
                    </div>
                    <label for="mots_clef" class="formlabel optional">Mots clé :</label>
                    <div>
                        <input type="text" name="mots_clef" id="mots_clef" value="" size="50" />
                    </div>
                    <span class="infos_saisie">Séparés par des virgules ex.: word, excel</span>
                </dl>
                <div class="cadre_boutons">
                    <input type="reset" class="btn btn-danger" value="Annuler" id="cancel" name="cancel" /> &nbsp;&nbsp;&nbsp;
                    <input type="submit" class="btn btn-danger" value="Valider" id="submit" name="submit" />

                </div>
            </fieldset>


        </div>

        <fieldset class="advert_search_right">
            <!-- RechercheEmployeursDroite200x200 -->
            <div id='div-gpt-ad-1394600652690-5' style='width:300px; height:250px;'>
                <script type='text/javascript'>
                    googletag.cmd.push(function() {
                        googletag.display('div-gpt-ad-1394600652690-5');
                    });
                </script>
            </div>
        </fieldset><br style="clear:both;" />

    </form>

</section>







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