<?php                                        
global $user_ID;
if(!$user_ID){
 $err = '';
 $success = '';
 
 if(isset($_POST['submit']))
 {
    die("*******************************");  
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
   $user = wp_signon( $user_data, false );

   if ( is_wp_error($user) ) {
      
    $err = $user->get_error_message();
    exit();
   } else {
    
    wp_set_current_user( $user->ID, $username );
    do_action('set_current_user');




    echo '<script language="Javascript">
    <!--
    document.location.replace("index.php");
    // -->
    </script>';

  
    //echo '<script type="text/javascript"> window.location.replace("index.php"); </script>';
    exit();
   }
  }
}