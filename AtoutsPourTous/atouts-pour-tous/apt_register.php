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
        
        wp_create_user($username, $password, $email);
        /* echo "User Created Successfully";
        exit();*/

        



        // if($new_user_id){
        //     wp_new_user_notification( $new_user->ID );

        //     wp_clear_auth_cookie(  );
        //     wp_set_current_user( $new_user->ID );
        //     wp_set_auth_cookie( $new_user->ID );

        //     wp_safe_redirect(home_url());
        //     exit();
        // }

        echo '<script language="Javascript">
        <!--
        document.location.replace("index.php");
        // -->
        </script>';


    }else{
        
        print_r($error);
        
    }
}}
