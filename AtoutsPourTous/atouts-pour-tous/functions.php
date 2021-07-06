<?php

require('metas/functions.php');

if (function_exists('add_theme_support')) {
  add_theme_support('post-thumbnails');
  add_post_type_support('calendrier', 'thumbnail');
  add_post_type_support('calendrier', 'custom-fields');
  //set_post_thumbnail_size( 150, 150, true ); // default Post Thumbnail dimensions (cropped)
}

function register_my_menus()
{
  register_nav_menus(
    array(
      'header-menu' => __('Header Menu')
    )
  );
}
add_action('init', 'register_my_menus');



function add_classes_on_li($classes, $item, $args)
{
  $classes[] = 'nav-item';
  return $classes;
}
add_filter('nav_menu_css_class', 'add_classes_on_li', 10, 4);


function add_classes_on_li_a($classes, $item, $args)
{
  $classes['class'] = 'nav-link nav-top';
  return $classes;
}
add_filter('nav_menu_link_attributes', 'add_classes_on_li_a', 10, 4);



function add_classes_on_li1($classes, $item, $args)
{
  $classes[] = 'nav-item';
  return $classes;
}
add_filter('nav_menu_css_class', 'add_classes_on_li1', 10, 4);


function add_classes_on_li_a1($classes, $item, $args)
{
  $classes['class'] = 'nav-link nav-top';
  return $classes;
}
add_filter('nav_menu_link_attributes', 'add_classes_on_li_a1', 10, 4);



/**
 * Add Taxonamies
 */

add_action('init', 'atpt_register_taxonomies', 0);
function atpt_register_taxonomies()
{
  $labels = array(
    'name'            => 'Catégories',
    'singular_name'   => 'mon_Calendrier'
  );

  $args = array(
    'labels'            => $labels,
    'hierarchical'      => true,
    'publicly_queryable' => true,
    'public'            => true,
    'show_ui'           => true,
    'show_admin_column' => true,
    'query_var'         => true,
    'rewrite'           => array('slug' => 'calendar'),
    'show_in_rest'      => true,
  );

  register_taxonomy('calendrier_type', array('calendrier'), $args);
}


add_action('init', 'apt_partenaire_taxonamies', 0);
function apt_partenaire_taxonamies()
{
  $labels = array(
    'name'            => 'Catégories',
    'singular_name'   => 'Partenaires'
  );

  $args = array(
    'labels'            => $labels,
    'hierarchical'      => true,
    'publicly_queryable' => true,
    'public'            => true,
    'show_ui'           => true,
    'show_admin_column' => true,
    'query_var'         => true,
    'rewrite'           => array('slug' => 'part'),
    'show_in_rest'      => true,
  );

  register_taxonomy('partenaire_type', array('partenaire'), $args);
}


add_action('pre_get_posts', 'add_my_post_types_to_query');

function add_my_post_types_to_query($query)
{
  if (is_home() && $query->is_main_query())
    $query->set('post_type', array('post', 'page', 'calendrier'));
  return $query;
}


/**
 * Admin form logo
 */
function my_login_logo()
{ ?>
  <style type="text/css">
    #login h1 a,
    .login h1 a {
      background-image: url(<?php echo get_stylesheet_directory_uri(); ?>/images/logo.svg);
      height: 65px;
      width: 320px;
      background-size: 320px 65px;
      background-repeat: no-repeat;
      padding-bottom: 30px;
    }
  </style>
<?php }
add_action('login_enqueue_scripts', 'my_login_logo');

function my_login_logo_url()
{
  return home_url();
}
add_filter('login_headerurl', 'my_login_logo_url');

function my_login_logo_url_title()
{
  return 'Atouts Pour Tous';
}
add_filter('login_headertext', 'my_login_logo_url_title');

require_once('widgets/plan-du-site.php');

function apt_register_widget()
{
  register_widget(PlanDuSite::class);
  register_sidebar([
    'id'              => 'footer-sidebar1',
    'name'            => 'Footer One',
    'before_widget'   => '<div id="%1$s" class="widget %2$s">',
    'after_widget'    => '</div>',
    'before_title'    => '<h5 class="text-uppercase">',
    'after_titler'    => '</h5>'
  ]);

  register_sidebar([
    'id'              => 'footer-sidebar2',
    'name'            => 'Footer Two',
    'before_widget'   => '<div id="%1$s" class="widget %2$s">',
    'after_widget'    => '</div>',
    'before_title'    => '<h5 class="text-uppercase">',
    'after_titler'    => '</h5>'
  ]);

  register_sidebar([
    'id'              => 'footer-sidebar3',
    'name'            => 'Footer Three',
    'before_widget'   => '<div id="%1$s" class="widget %2$s">',
    'after_widget'    => '</div>',
    'before_title'    => '<h5 class="text-uppercase">',
    'after_titler'    => '</h5>'
  ]);
}


require_once('options/copyright.php');
CopyRight::register();

add_action('widgets_init', 'apt_register_widget');



// numbered pagination
function pagination($pages = '', $range = 4)
{
  $showitems = ($range * 2) + 1;

  global $paged;
  if (empty($paged)) $paged = 1;

  if ($pages == '') {
    global $wp_query;
    $pages = $wp_query->max_num_pages;
    if (!$pages) {
      $pages = 1;
    }
  }

  if (1 != $pages) {
    echo "<div class=\"pagination\"><span>Page " . $paged . " sur " . $pages . "&nbsp</span>&nbsp ";
    if ($paged > 2 && $paged > $range + 1 && $showitems < $pages) echo "<a href='" . get_pagenum_link(1) . "'>&laquo; First</a>";
    if ($paged > 1 && $showitems < $pages) echo "<a href='" . get_pagenum_link($paged - 1) . "'>&lsaquo; Previous</a>";

    for ($i = 1; $i <= $pages; $i++) {
      if (1 != $pages && (!($i >= $paged + $range + 1 || $i <= $paged - $range - 1) || $pages <= $showitems)) {
        echo ($paged == $i) ? "<span class=\"current\">" . $i . "</span>" : "<a href='" . get_pagenum_link($i) . "' class=\"inactive\">" . $i . "</a>";
      }
    }

    if ($paged < $pages && $showitems < $pages) echo "<a href=\"" . get_pagenum_link($paged + 1) . "\">Next &rsaquo;</a>";
    if ($paged < $pages - 1 &&  $paged + $range - 1 < $pages && $showitems < $pages) echo "<a href='" . get_pagenum_link($pages) . "'>Last &raquo;</a>";
    echo "</div>\n";
  }
}



add_action('send_headers', 'site_router');

function site_router(){
  $root = str_replace('index.php' , '' , $_SERVER['SCRIPT_NAME']);
  $url = str_replace($root , '' , $_SERVER['REQUEST_URI']);
  $url = explode('/' , $url);
  if(count($url) == 1 && $url[0] == 'login'){
    require 'template-login.php';
    die();
  }else if(count($url) == 1 && $url[0] == 'profil'){
    require 'template-profil.php';
    die();
  }else if(count($url) == 1 && $url[0] == 'register'){
    require 'template-register.php';
    die();
  }else if(count($url) == 1 && $url[0] == 'cv'){
    require 'template-cv.php';
    die();
  }else if(count($url) == 1 && $url[0] == 'forgotPassword'){
    require 'template-forgot-password.php';
    die();
  }else if(count($url) == 1 && $url[0] == 'logout'){
    wp_logout();
    header('location:'. $root);
    die();
  }
}

add_filter('show_admin_bar', '__return_false');




