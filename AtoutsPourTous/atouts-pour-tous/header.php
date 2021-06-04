<!DOCTYPE html>
<html lang="<?php language_attributes(); ?>">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta http-equiv="x-ua-compatible" content="ie=edge" />
    <title><?php bloginfo('name'); wp_title(); ?></title>
    <link rel="stylesheet" href="<?php bloginfo('template_url'); ?>/css/style.css">
    <link rel="icon" href="<?php echo get_template_directory_uri(); ?>/images/logo.svg" type="image/x-icon" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.15.2/css/all.css" />
    <!-- Google Fonts Roboto -->
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link
        href="https://fonts.googleapis.com/css2?family=Oxygen&family=Lato:wght@700&family=Palanquin+Dark&family=Quicksand:wght@500;600&family=Roboto:wght@300;400;500;700&display=swap"
        rel="stylesheet">
    <!-- MDB -->
    <link rel="stylesheet" href="<?php bloginfo('template_url'); ?>/css/mdb.min.css" />
<?php wp_head() ?>
</head>

<body>
    <!-- Start your project here-->


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

                        <button type="button" class="login-btn"
                            style="background:url('<?php bloginfo('template_url'); ?>/images/button.svg'); background-size: cover;"
                            data-mdb-toggle="modal" data-mdb-target="#exampleCentralModal3">
                            <div class="login-icon">
                                <i class="fas fa-user"></i> <br> Accès membres
                            </div>
                        </button>

                        <!-- exampleCentralModal3 -->
                        <div class="modal fade " id="exampleCentralModal3" tabindex="-1"
                            aria-labelledby="exampleModalLabel" style="display: none;" aria-hidden="true">
                            <div class="modal-dialog modal-lg">
                                <div class="modal-content">
                                    <div class="modal-body p-4">
                                        <!-- Pills navs -->
                                        <ul class="nav nav-pills justify-content-between  mb-3 pill" id="ex1"
                                            role="tablist">
                                            <li class="nav-item flex-fill text-center" role="presentation ">
                                                <a class="nav-link active" id="mdb-tab-login" data-mdb-toggle="pill"
                                                    href="#pills-login" role="tab" aria-controls="pills-login"
                                                    aria-selected="true">Login</a>
                                            </li>
                                            <li class="nav-item flex-fill text-center" role="presentation">
                                                <a class="nav-link" id="mdb-tab-register" data-mdb-toggle="pill"
                                                    href="#pills-register" role="tab" aria-controls="pills-register"
                                                    aria-selected="false">Register</a>
                                            </li>
                                        </ul>
                                        <!-- Pills navs -->

                                        <!-- Pills content -->
                                        <div class="tab-content">
                                            <div class="tab-pane fade show active" id="pills-login" role="tabpanel"
                                aria-labelledby="mdb-tab-login">

<?php                                        
global $user_ID;
if(!$user_ID){
 $err = '';
 $success = '';
 
 if(isset($_POST['submit']))
 {
     
  //We shall SQL escape all inputs to avoid sql injection.
  $username = esc_sql($_POST['username']);
  $password = esc_sql($_POST['password']);
  $remember = esc_sql($_POST['remember']);


  if( $username == "" || $password == "" ) {
     
   $err = 'Please don\'t leave the required field.';
  } else {
    
   $user_data = array();
   $user_data['user_login'] = $username;
   $user_data['user_password'] = $password;
   $user_data['remember'] = $remember;
   $user = wp_signon( $user_data, true );

   if ( is_wp_error($user) ) {
      
    $err = $user->get_error_message();
    exit();
   } else {
    
    wp_set_current_user( $user->ID, $username );
    do_action('set_current_user');

die("*******************************");


    echo '<script language="Javascript">
    <!--
    document.location.replace("index.php");
    // -->
    </script>';

  
    //echo '<script type="text/javascript"> window.location.replace("index.php"); </script>';
    exit();
   }
  }
 
}else{
                                                
?>

                                                <form method="post">


                                                    <!-- Email input -->
                                                    <div class="form-outline mb-4">
                                                        <input type="text" id="loginName" class="form-control" name="username">
                                                        <label class="form-label" for="loginName"
                                                            style="margin-left: 0px;">Email or username</label>
                                                        <div class="form-notch">
                                                            <div class="form-notch-leading" style="width: 9px;"></div>
                                                            <div class="form-notch-middle" style="width: 114.4px;">
                                                            </div>
                                                            <div class="form-notch-trailing"></div>
                                                        </div>
                                                    </div>

                                                    <!-- Password input -->
                                                    <div class="form-outline mb-4">
                                                        <input type="password" id="loginPassword" class="form-control" name="password">
                                                        <label class="form-label" for="loginPassword"
                                                            style="margin-left: 0px;">Password</label>
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
                                                                <input class="form-check-input" type="checkbox" value="" name ="remember"
                                                                    id="loginCheck" checked="">
                                                                <label class="form-check-label" for="loginCheck">
                                                                    Remember
                                                                    me </label>
                                                            </div>
                                                        </div>

                                                        <div class="col">
                                                            <!-- Simple link -->
                                                            <a href="#!">Forgot password?</a>
                                                        </div>
                                                    </div>

                                                    <!-- Submit button -->
                                                    <button type="submit" class="btn btn-primary btn-block mb-4" name="submit">Sign
                                                        in</button>

                                                    <!-- Register buttons -->
                                                    <div class="text-center">
                                                        <p class="mb-1">Not a member? <a href="#!">Register</a></p>
                                                    </div>
</form>                                            
<?php  } } ?>
                                            </div>
                                            <div class="tab-pane fade" id="pills-register" role="tabpanel"
                                                aria-labelledby="mdb-tab-register">


<?php                                               
if(!$user_ID){
if (isset($_POST['register'])) {
    
    $username = esc_sql($_POST['username']);
    $email = esc_sql($_POST['email']);
    $password = esc_sql($_POST['password']);
    $ConfPassword = esc_sql($_POST['password1']);
    
    $error = array();
    if (strpos($username, ' ') !== FALSE) {
        
        $error['username_space'] = "Username has Space";
    }

    if (empty($username)) {
        $error['username_empty'] = "Needed Username must";
    }

    if (username_exists($username)) {
        $error['username_exists'] = "Username already exists";
    }

    if (!is_email($email)) {
        $error['email_valid'] = "Email has no valid value";
    }

    if (email_exists($email)) {
        $error['email_existence'] = "Email already exists";
    }

    if (strcmp($password, $ConfPassword) !== 0) {
        $error['password'] = "Password didn't match";
    }

    if (count($error) == 0) {
        
        $new_user = wp_create_user($username, $password, $email);
        /* echo "User Created Successfully";
        exit();*/

        



        if($new_user_id){
            wp_new_user_notification( $new_user->ID );

            wp_clear_auth_cookie(  );
            wp_set_current_user( $new_user->ID );
            wp_set_auth_cookie( $new_user->ID );

            wp_safe_redirect(home_url());
            exit();
        }

        echo '<script language="Javascript">
        <!--
        document.location.replace("index.php");
        // -->
        </script>';


    }else{
        
        print_r($error);
        
    }
}else{                                                         
?>
                                                
                                                
                                                <form method="post" >


                                                    <!-- Name input -->
                                                    <div class="form-outline mb-4">
                                                        <input type="text" id="registerName" class="form-control" name="name">
                                                        <label class="form-label" for="registerName"
                                                            style="margin-left: 0px;">Name</label>
                                                        <div class="form-notch">
                                                            <div class="form-notch-leading" style="width: 9px;"></div>
                                                            <div class="form-notch-middle" style="width: 8px;"></div>
                                                            <div class="form-notch-trailing"></div>
                                                        </div>
                                                    </div>

                                                    <!-- Username input -->
                                                    <div class="form-outline mb-4">
                                                        <input type="text" id="registerUsername" class="form-control" name="username">
                                                        <label class="form-label" for="registerUsername"
                                                            style="margin-left: 0px;">Username</label>
                                                        <div class="form-notch">
                                                            <div class="form-notch-leading" style="width: 9px;"></div>
                                                            <div class="form-notch-middle" style="width: 8px;"></div>
                                                            <div class="form-notch-trailing"></div>
                                                        </div>
                                                    </div>

                                                    <!-- Email input -->
                                                    <div class="form-outline mb-4">
                                                        <input type="email" id="registerEmail" class="form-control" name="email">
                                                        <label class="form-label" for="registerEmail"
                                                            style="margin-left: 0px;">Email</label>
                                                        <div class="form-notch">
                                                            <div class="form-notch-leading" style="width: 9px;"></div>
                                                            <div class="form-notch-middle" style="width: 8px;"></div>
                                                            <div class="form-notch-trailing"></div>
                                                        </div>
                                                    </div>

                                                    <!-- Password input -->
                                                    <div class="form-outline mb-4">
                                                        <input type="password" id="registerPassword"
                                                            class="form-control" name="password">
                                                        <label class="form-label" for="registerPassword"
                                                            style="margin-left: 0px;">Password</label>
                                                        <div class="form-notch">
                                                            <div class="form-notch-leading" style="width: 9px;"></div>
                                                            <div class="form-notch-middle" style="width: 8px;"></div>
                                                            <div class="form-notch-trailing"></div>
                                                        </div>
                                                    </div>

                                                    <!-- Repeat Password input -->
                                                    <div class="form-outline mb-4">
                                                        <input type="password" id="registerRepeatPassword"
                                                            class="form-control" name="password1">
                                                        <label class="form-label" for="registerRepeatPassword"
                                                            style="margin-left: 0px;">Repeat password</label>
                                                        <div class="form-notch">
                                                            <div class="form-notch-leading" style="width: 9px;"></div>
                                                            <div class="form-notch-middle" style="width: 8px;"></div>
                                                            <div class="form-notch-trailing"></div>
                                                        </div>
                                                    </div>

                                                    <!-- Checkbox -->
                                                    <div class="form-check d-flex justify-content-center mb-4">
                                                        <input class="form-check-input me-2" type="checkbox" value=""
                                                            id="registerCheck" checked=""
                                                            aria-describedby="registerCheckHelpText">
                                                        <label class="form-check-label" for="registerCheck">
                                                            I have read and agree to the terms
                                                        </label>
                                                    </div>

                                                    <!-- Submit button -->
                                                    <button type="submit" class="btn btn-primary btn-block mb-1" name="register">Sign
                                                        in</button>
</form>
<?php  } }?>
                                            </div>
                                        </div>
                                        <!-- Pills content -->
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- exampleCentralModal3 -->
                </section>
                <!------------------------------------ End ofLogin button--------------------------------------->
            </div>
        </div>
    </header>

    <!------------------------------------ End of Header --------------------------------------->




    <!------------------------------------ Navbar --------------------------------------->


    <nav class="navbar navbar-expand-lg navbar-light  nav-top-height">
        <div class="nav-bar container">
            <button class="navbar-toggler" type="button" data-mdb-toggle="collapse" data-mdb-target="#navbarNav"
                aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
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