<?php
get_header();  



$args = array(
    'post_type' => 'post',
    'post_status' => 'publish',
    'category_name' => 'axes',
    'posts_per_page' => 5,
);
$arr_posts = new WP_Query( $args );
 
if ( $arr_posts->have_posts() ) :
 
    while ( $arr_posts->have_posts() ) :
        $arr_posts->the_post();
        ?>
<div class="container" style="margin-top:50px">
<div class="row">
    <div class="card mb-3" >
        <div class="row g-0">
            <div class="col-md-4">
                <img src="<?php the_post_thumbnail_url() ?>" alt="..." class="img-fluid" />
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
</div>
<?php
    endwhile;
endif;

?>














<?php get_footer();  ?>