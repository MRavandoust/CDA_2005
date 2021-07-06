<?php

/**
 * Template Name: Calendar template
 */
get_header();

$paged = (get_query_var('paged')) ? get_query_var('paged') : 1;
$q = new WP_Query(
  array("post_type" => "calendrier", "posts_per_page" => 10, 'paged' => $paged)
); ?>

<div class="container">
  <div class="row row-cols-sm-1 row-cols-md-2 row-cols-lg-3 d-flex justify-content-center ">

    <?php
    while ($q->have_posts()) {
      $q->the_post();
    ?>


      <div class="col" style="padding: 5px !important; max-width: 320px; margin: 23px;">
        <a href="<?php the_permalink(); ?>" >
          <div class="card underline" style="border-radius: 0 !important;  width: 310px;">
            <img class="card-img-top" src="<?php the_post_thumbnail_url() ?>" alt="atouts pour tous" style="border-radius: 0 !important; height:190px" />
            <div class="card-body">
              <h5 class="" style="text-align: left; color:#003E79; font-weight: bold; "><?php the_title(); ?></h5>
              <div class="" style="color: #5A3339; margin-top: 18px; margin-bottom: 55px !important;">
                <?php echo substr(get_the_excerpt(), 0, 150) . ' ...';  ?>
              </div>
              <div class="d-flex flex-row justify-content-between">
                <div class="card-actu-date">
                  <?= get_the_date('d/m/Y'); ?> </div>
                <div class="text-center card-categorie">

                <?php 
                //$term = get_terms('calendrier_type');
                //the_taxonomies();  
                //echo $term[0]->name;
               $t = get_the_terms($post->ID, 'calendrier_type');
                echo $t[0]->name;
                ?>       
               
                  <?php the_category(' '); ?>
                </div>
              </div>
            </div>
          </div>
        </a>
      </div>

    <?php }  ?>
  </div>

</div>




<section class=" p-4 d-flex justify-content-center mb-4">
  <?php the_posts_pagination(); ?>
  <?php if (function_exists("pagination")) {
    pagination($q->max_num_pages);
  } ?>
</section>



<?php get_footer();  ?>