<?php get_header() ?>


<?php
while (have_posts()) {
    the_post();
?>

    <div style="background:linear-gradient(rgba(149, 149, 155, 0.8), rgba(255, 255, 255, 1)), url(<?php the_post_thumbnail_url() ?>) no-repeat; padding: 20px; background-size: 100%; ">



        <div class="container single-wrapper h-100">
            <div class="card text-center sngle-card">

                <div class="card-header">
                    <h3 class="single-title"><?php the_title(); ?></h3>
                </div>
                <div class="card-body h-100 single-body">
                    <img alt="atouts pour tous" class="img-fluid single-img" src="<?php the_post_thumbnail_url() ?>" />
                    <div class="single-text">

                        <?php the_content();  ?>

                    </div>


                </div>
                <div class="card-footer text-muted">2 days ago</div>
            </div>

        </div>

    </div>

<?php  }   ?>


<?php get_footer() ?>