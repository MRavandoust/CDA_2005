<?php
ob_start();

$error = false;
if (!empty($_POST)) {
    $user = wp_signon($_POST);
    if (is_wp_error($user)) {
        $error = $user->get_error_message();
    } else {
        header('location:index.php');
    }
} else {
    $user = wp_get_current_user();
    if ($user->ID != 0) {
        // header('location:profil');
    }
}

?>



<!DOCTYPE html>
<html <?php language_attributes(); ?>>

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta http-equiv="x-ua-compatible" content="ie=edge" />
    <title><?php bloginfo('name');
            wp_title(); ?></title>
    <link rel="stylesheet" href="<?php bloginfo('template_url'); ?>/css/style.css">
    <link rel="stylesheet" href="<?php bloginfo('template_url'); ?>/css/pagination.css">
    <link rel="icon" href="<?php echo get_template_directory_uri(); ?>/images/logo.svg" type="image/x-icon" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.15.2/css/all.css" />
    <!-- Google Fonts Roboto -->
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Oxygen&family=Lato:wght@700&family=Palanquin+Dark&family=Quicksand:wght@500;600&family=Roboto:wght@300;400;500;700&display=swap" rel="stylesheet">
    <!-- MDB -->
    <link rel="stylesheet" href="<?php bloginfo('template_url'); ?>/css/mdb.min.css" />
    <!-------- Actualiser partenaires--------->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script>
        $(document).ready(function() {
            setInterval(function() {
                $('#div_refresh').load(' #div_refresh');
            }, 10000);
        });
    </script>
    <!--------End - Actualiser partenaires--------->

    <script src="<?php bloginfo('template_url'); ?>/js/jquery-1.10.2.min.js"></script>
    <script src="<?php bloginfo('template_url'); ?>/js/jquery-ui.js"></script>

    <?php wp_head() ?>
</head>

<body>
    <!------------------------------------ Header --------------------------------------->

    <header>
        <div class="container-fluid" style="padding-right: 0px !important;">
            <div class="container-fluid head-top d-flex" style="padding-right: 0px !important;">

                <!------------------------------------ Logo  --------------------------------------->
                <div class="logo me-auto">
                    <a href="<?php bloginfo('url'); ?>">
                        <img src="<?php bloginfo('template_url'); ?>/images/logo.svg" alt="Atouts Pour Tous">
                    </a>
                    <div class="text ">
                        <p>Convention Partenariat </p>
                        <p>pour l'insertion professionnelle</p>
                        <p>des jeunes en situation de handicap</p>
                    </div>
                </div>

                <!------------------------------------ End of Logo --------------------------------------->


                <!------------------------------------ Login button--------------------------------------->

                <section id="section-advanced-examples ">



                    <div class="container" style="position : relative">
                        <?php $user = wp_get_current_user();
                        if ($user->ID == 0) : ?>
                            <button type="button" class="login-btn" style="background:url('<?php bloginfo('template_url'); ?>/images/button.svg'); background-size: cover;" data-mdb-toggle="modal" data-mdb-target="#exampleCentralModal3">
                                <div class="login-icon">
                                    <i class="fas fa-user-alt" style="font-size: 13px;"></i>&nbsp Se connecter
                                </div>
                            </button>

                        <?php else : ?>

                            <button type="button" class="login-btn" style="background:url('<?php bloginfo('template_url'); ?>/images/button.svg'); background-size: cover;">
                                <!-- Login dropdown  -->
                                <a href="" class="login-icon dropdown-toggle" data-mdb-toggle="dropdown" aria-expanded="false">
                                    <i class="fas fa-user-alt" style="font-size: 13px;"></i>&nbsp <?= $f = $user->first_name ?  ($user->first_name[0] . '. ')  : '';
                                                                                                    echo  $l = $user->last_name ? $user->last_name : '';
                                                                                                    if ($f == '' && $l == '') echo $user->user_login; ?>
                                </a>
                                <ul class="dropdown-menu">
                                    <li><a class="dropdown-item" href="<?= bloginfo('url'); ?>/profil">Profil</a></li>
                                    <li><a class="dropdown-item" href="<?= bloginfo('url'); ?>/cv">Mon CV</a></li>
                                    <li>
                                        <hr class="dropdown-divider" />
                                    </li>
                                    <li><a class="dropdown-item" href="<?= bloginfo('url'); ?>/logout">Se déconnecter</a></li>
                                </ul>

                            </button>

                        <?php endif ?>






                        <div class="modal fade " id="exampleCentralModal3" tabindex="-1" aria-labelledby="exampleModalLabel" style="display: none;" aria-hidden="true">
                            <div class="modal-dialog" role="document">

                                <!-- Modal content -->
                                <div class="modal-content">
                                    <!-- Modal body -->
                                    <div class="modal-body">

                                        <!-- Pills navs -->
                                        <ul class="nav nav-pills nav-justified mb-3">
                                            <li class="nav-item" role="presentation">
                                                <a class="nav-link show active" data-mdb-toggle="pill" href="#navbarLogin-login" role="tab" aria-selected="true">Login</a>
                                            </li>
                                            <li class="nav-item" role="presentation">
                                                <a class="nav-link" data-mdb-toggle="pill" href="#navbarLogin-signup" role="tab" aria-selected="false">Register</a>
                                            </li>
                                        </ul>

                                        <!-- Pills panels -->
                                        <div class="tab-content">

                                            <!--Panel 1-->
                                            <div class="tab-pane fade in active show" id="navbarLogin-login" role="tabpanel">


                                                <!---------------------------------- Default form login  --------------------------------------->

                                                <form id="login" class="text-center" action="<?= $_SERVER['REQUEST_URI'] ?>" method="post" novalidate="novalidate">

                                                    <?php if ($error) : ?>
                                                        <p><?= $error ?></p>
                                                    <?php endif ?>


                                                    <input type="hidden" id="security" name="security" value="b9b4f8b86d"><input type="hidden" name="_wp_http_referer" value="/wp-admin/admin-ajax.php?p=0">
                                                    <p class="status"></p>


                                                    <div class="text-center mb-3">
                                                        <!---- Message  ---->
                                                    </div>



                                                    <!-- Email input -->
                                                    <div class="form-outline form-auth-mdb mb-4">
                                                        <input type="text" id="user_login" class="form-control" name="user_login">
                                                        <label class="form-label" for="user_login" style="margin-left: 0px;"> Email ou identifiant</label>
                                                        <div class="form-notch">
                                                            <div class="form-notch-leading" style="width: 9px;"></div>
                                                            <div class="form-notch-middle" style="width: 146.4px;">
                                                            </div>
                                                            <div class="form-notch-trailing"></div>
                                                        </div>
                                                    </div>

                                                    <!-- Password input -->
                                                    <div class="form-outline form-auth-mdb mb-4">
                                                        <input type="password" id="user_password" class="form-control" name="user_password" autocomplete="off">
                                                        <label class="form-label" for="user_password" style="margin-left: 0px;">Mot de pass</label>
                                                        <div class="form-notch">
                                                            <div class="form-notch-leading" style="width: 9px;"></div>
                                                            <div class="form-notch-middle" style="width: 92.8px;"></div>
                                                            <div class="form-notch-trailing"></div>
                                                        </div>
                                                    </div>

                                                    <!-- 2 column grid layout for inline styling -->
                                                    <div class="justify-content-center mb-4">
                                                        <a href="<?= bloginfo('url'); ?>/forgotPassword" type="submit">Mot de pass oublié?</a>
                                                    </div>

                                                    <button class="btn btn-primary btn-block mb-4" type="submit" name="login" value="LOGIN">Se connecter</button>

                                                    <!-- Register buttons -->
                                                    <div class="text-center">
                                                        <p>Not a member? <a href="#" class="auth-modal-toggle" data-auth-modal-tab="sign-up">Register</a></p>
                                                    </div>

                                                </form>
                                                <!-- Default form login -->

                                            </div>
                                            <!--/.Panel 1-->

                                            <!--Panel 2-->
                                            <div class="tab-pane fade" id="navbarLogin-signup" role="tabpanel">


                                                <!---------------------------------- traitement de form register   --------------------------------------->
                                                <?php
                                                $err = false;
                                                if (!empty($_POST)) {
                                                    $d = $_POST;
                                                    if ($d['user_pass'] != $d['user_pass2']) {
                                                        $err = 'Les 2 moyt de pass ne coresspendent pas!';
                                                    } else {
                                                        if (!is_email($d['user_email'])) {
                                                            $err = 'Veuillez entrer un email valid';
                                                        } else {
                                                            $user = wp_insert_user(array(
                                                                'first_name' => $d['first_name'],
                                                                'last_name' => $d['last_name'],
                                                                'user_login' => $d['user_login'],
                                                                'user_email' => $d['user_email'],
                                                                'user_pass' => $d['user_pass'],
                                                                'user_registered' => date('Y-m-d H:i:s')
                                                            ));
                                                            if (is_wp_error($user)) {
                                                                $err = $user->get_error_message();
                                                            } else {
                                                                $msg = 'Vous êtes maintenant inscrit.';
                                                                $header = 'From : ' . get_option('admin_email') . "\r\n";
                                                                wp_mail($d['user_email'], 'Inscription réussie', $msg, $header);
                                                                $d = array();
                                                                wp_signon($_POST);
                                                                header('Location:profil');
                                                            }
                                                        }
                                                    }
                                                }
                                                ?>

                                                <!---------------------------------- Default form register  --------------------------------------->
                                                <form id="register" class="text-center" action="register" method="post" novalidate="novalidate">

                                                    <input type="hidden" id="signonsecurity" name="signonsecurity" value="c388596795"><input type="hidden" name="_wp_http_referer" value="/wp-admin/admin-ajax.php?p=0">


                                                    <div class="text-center mb-3">
                                                        <!---- Message  ---->
                                                        <?php if ($err) : ?>
                                                            <p style="color: red;"><?= $err ?></p>
                                                        <?php endif ?>
                                                    </div>


                                                    <!-- First name input -->
                                                    <div class="form-outline form-auth-mdb mb-4">
                                                        <input type="text" id="first_name" class="form-control" name="first_name" value="<?= isset($d['first_name']) ? $d['first_name'] : ''; ?>">
                                                        <label for="first_name" class="form-label" style="margin-left: 0px;">Prenom</label>
                                                        <div class="form-notch">
                                                            <div class="form-notch-leading" style="width: 9px;"></div>
                                                            <div class="form-notch-middle" style="width: 68.8px;"></div>
                                                            <div class="form-notch-trailing"></div>
                                                        </div>
                                                    </div>

                                                    <!-- Last name input -->
                                                    <div class="form-outline form-auth-mdb mb-4">
                                                        <input type="text" id="last_name" class="form-control" name="last_name" value="<?= isset($d['last_name']) ? $d['last_name'] : ''; ?>">
                                                        <label for="last_name" class="form-label" style="margin-left: 0px;">Nom</label>
                                                        <div class="form-notch">
                                                            <div class="form-notch-leading" style="width: 9px;"></div>
                                                            <div class="form-notch-middle" style="width: 68.8px;"></div>
                                                            <div class="form-notch-trailing"></div>
                                                        </div>
                                                    </div>

                                                    <!-- Username input -->
                                                    <div class="form-outline form-auth-mdb mb-4">
                                                        <input type="text" id="user_login" class="form-control" name="user_login" value="<?= isset($d['user_login']) ? $d['user_login'] : ''; ?>">
                                                        <label for="user_login" class="form-label" style="margin-left: 0px;">Identifiant</label>
                                                        <div class="form-notch">
                                                            <div class="form-notch-leading" style="width: 9px;"></div>
                                                            <div class="form-notch-middle" style="width: 93.6px;"></div>
                                                            <div class="form-notch-trailing"></div>
                                                        </div>
                                                    </div>

                                                    <!-- Email input -->
                                                    <div class="form-outline form-auth-mdb mb-4">
                                                        <input type="email" id="user_email" class="form-control" name="user_email" value="<?= isset($d['user_email']) ? $d['user_email'] : ''; ?>">
                                                        <label for="user_email" class="form-label" style="margin-left: 0px;">Email</label>
                                                        <div class="form-notch">
                                                            <div class="form-notch-leading" style="width: 9px;"></div>
                                                            <div class="form-notch-middle" style="width: 68px;"></div>
                                                            <div class="form-notch-trailing"></div>
                                                        </div>
                                                    </div>

                                                    <!-- Password input -->
                                                    <div class="form-outline form-auth-mdb mb-4">
                                                        <input type="password" id="user_pass" class="form-control" name="user_pass" autocomplete="off" aria-autocomplete="list" value="<?= isset($d['user_pass']) ? $d['user_pass'] : ''; ?>">
                                                        <label for="user_pass" class="form-label" style="margin-left: 0px;">Mot de pass</label>
                                                        <div class="form-notch">
                                                            <div class="form-notch-leading" style="width: 9px;"></div>
                                                            <div class="form-notch-middle" style="width: 92.8px;"></div>
                                                            <div class="form-notch-trailing"></div>
                                                        </div>
                                                    </div>

                                                    <!-- Repeat Password input -->
                                                    <div class="form-outline form-auth-mdb mb-4">
                                                        <input type="password" id="user_pass2" class="form-control" name="user_pass2" autocomplete="off" value="<?= isset($d['user_pass2']) ? $d['user_pass2'] : ''; ?>">
                                                        <label for="user_pass2" class="form-label" style="margin-left: 0px;">Confirmez mot de pas</label>
                                                        <div class="form-notch">
                                                            <div class="form-notch-leading" style="width: 9px;"></div>
                                                            <div class="form-notch-middle" style="width: 106.4px;">
                                                            </div>
                                                            <div class="form-notch-trailing"></div>
                                                        </div>
                                                    </div>


                                                    <div class="d-none">


                                                        <!-- Subscribe checkbox -->
                                                        <div class="form-check d-flex justify-content-center">
                                                            <input type="checkbox" class="form-check-input me-1" id="newsletter" name="newsletter" value="subscribe">
                                                            <label class="form-check-label" for="newsletter">I agree to
                                                                sign up for MDB account notifications and
                                                                newsletter</label>
                                                        </div>

                                                        <!-- Subscribe checkbox -->

                                                        <div class="form-text text-center small text-muted mb-4">
                                                            By signing up you agree to data processing by the
                                                            administrator: StartupFlow s.c. located in Kijowska 7,
                                                            Warsaw. The administrator processes data following the <a target="_blank" href="https://mdbootstrap.com/privacy-policy/">Privacy
                                                                Policy</a>.
                                                        </div>

                                                    </div>



                                                    <button class="btn btn-primary btn-block mb-3" id="AJAXAuthRegisterBtn" type="submit" value="SIGNUP">
                                                        S'inscrire </button>

                                                </form>
                                                <!-- Default form register  -->

                                            </div>
                                            <!--/.Panel 2-->

                                        </div>
                                        <!-- Pills panels -->

                                    </div>
                                    <!-- Modal footer -->
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-secondary" data-mdb-dismiss="modal">
                                            Fermer </button>
                                    </div>
                                </div>
                                <!-- Modal content -->
                            </div>
                        </div>
                </section>
                <!------------------------------------ End ofLogin button--------------------------------------->
            </div>
        </div>
    </header>

    <!------------------------------------ End of Header --------------------------------------->




    <!------------------------------------ Navbar --------------------------------------->


    <nav class="navbar navbar-expand-lg navbar-light  nav-top-height">
        <div class="nav-bar container">
            <button class="navbar-toggler" type="button" data-mdb-toggle="collapse" data-mdb-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <i class="fas fa-bars"></i>
            </button>
            <div class="collapse navbar-collapse justify-content-center" id="navbarNav">
                <?php
                wp_nav_menu(array(
                    'theme_location' => 'header-menu',
                    'menu_class' => 'navbar-nav',
                ));
                ?>
            </div>
        </div>
    </nav>

    <!------------------------------------ End of Navbar --------------------------------------->