<?php
/**
 * Template Name: Calendar template
 */
 
get_header();  
?>


<?php 
$paged = (get_query_var( 'paged' )) ? get_query_var( 'paged' ) : 1;
/* $args = array(
    'post_type'     => 'post',
    'post_status'   => 'publish',
    'posts_per_page' => 8,
    'category_name' => 'axes',
    'paged'         => $paged,
);

$arr_posts = new wp_query($args);

    while($arr_posts->have_posts())
    $arr_posts->the_post(); */


    $q = new WP_Query (
        array( "post_type" => "calendrier", "posts_per_page" => 5, 'paged'=> $paged)
        );

        while($q->have_posts())
        {
            $q->the_post();
?>






<div class="container" style="margin-top:50px">

<div class="card mb-3" >
  <div class="row g-0">
    <div class="col-md-4">
      <img style="max-height: 250px; max-width: 250px;"
        src="<?php the_post_thumbnail_url() ?>"
        alt="..."
        class="img-fluid"
      />
    </div>
    <div class="col-md-8">
      <div class="card-body">
        <h5 class="card-title"><?php the_title() ; ?></h5>
        <p class="card-text">
        <?php the_excerpt() ; ?>
        </p>
        <p class="card-text">
          <small class="text-muted">Last updated 3 mins ago</small>
        </p>
      </div>
    </div>
  </div>
</div>
</div>

<?php }  ?>











<?php get_footer();  ?>