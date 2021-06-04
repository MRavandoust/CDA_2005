<?php

if ( function_exists( 'add_theme_support' ) ) { 
    add_theme_support( 'post-thumbnails' );
    add_post_type_support('calendrier', 'thumbnail');
    add_post_type_support('calendrier', 'custom-fields');
    //set_post_thumbnail_size( 150, 150, true ); // default Post Thumbnail dimensions (cropped)
}

function register_my_menus() {
    register_nav_menus(
      array(
        'header-menu' => __( 'Header Menu' )
       )
     );
   }
   add_action( 'init', 'register_my_menus' );
  


function add_classes_on_li($classes, $item, $args) {
  $classes[] = 'nav-item';
  return $classes;
}
add_filter('nav_menu_css_class','add_classes_on_li',10,4);


function add_classes_on_li_a($classes, $item, $args) {
    $classes['class'] = 'nav-link nav-top';
    return $classes;
}
  add_filter('nav_menu_link_attributes','add_classes_on_li_a',10,4);

/*
add_action( 'init', 'creat_post_type' );
  function creat_post_type() {
      register_post_type( 'calendrier', 
      array(
        'labels' => array(
          'name' => 'Calendrier',
          'singular_name' => 'Calendrier'
        ),
        'public' => true,
        'has_archive' => true,
        'menu_icon'   => 'dashicons-calendar-alt'

      ) );
}
*/
add_action('init', 'atpt_register_taxonamies', 0);
function atpt_register_taxonamies(){
  $labels = array(
        'name'            => 'mon_calendrier',
        'singular_name'   => 'mon_Calendrier'
  );

  $args = array(
        'labels'            => $labels,
        'hierarchical'      => true,
        'publicly_queryable'=> true,
        'public'            => true,
        'show_ui'           => true,
        'show_admin_column' => true,
        'query_var'         => true,
        'rewrite'           => array( 'slug' => 'calend' ),
        'show_in_rest'      => true,
  );

  register_taxonomy('calendrier_type', array('calendrier'), $args);

}

add_action( 'pre_get_posts', 'add_my_post_types_to_query' );
 
function add_my_post_types_to_query( $query ) {
    if ( is_home() && $query->is_main_query() )
        $query->set( 'post_type', array( 'post', 'page', 'calendrier' ) );
    return $query;
}





