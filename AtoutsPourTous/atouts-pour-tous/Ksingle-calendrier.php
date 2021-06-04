<?php get_header() ?>
                        <?php 
                            while ( have_posts() ) : the_post();

                            // Include the page content template.
                            get_template_part( 'content', 'page' );
                        ?>

<div style="background:linear-gradient(rgba(149, 149, 155, 0.2), rgba(255, 255, 255, 1)), url(<?php the_post_thumbnail_url() ?>) no-repeat; padding: 20px; background-size: 100%; ">

    <div class="container h-100" style="min-height: 700px; margin-top: 35px; ">
        <div class="card text-center" style="padding: 30px 0px;">


            <div class="card-header">
                <h5 class="card-title"><?php the_title() ; ?></h5>
            </div>
            <div class="card-body h-100">

                <a class="ripple" href="">
                    <img alt="example" class="img-fluid rounded" src="<?php the_post_thumbnail_url() ?>" />
                </a>
                <div class="single-text">

                    <h5 style="text-align: center;">La date d'evenement : </h5>
                    <h4 style="text-align: center;"> <?php echo get_post_meta(get_the_ID(), 'jour', true)  ?> <?php echo get_post_meta(get_the_ID(), 'mois', true)  ?> à <?php echo get_post_meta(get_the_ID(), 'heure', true)  ?></h4>

                    <?php the_content();  ?>
                   
                </div>


            </div>
            <div class="card-footer text-muted">2 days ago</div>
        </div>

    </div>

</div>

<?php  endwhile;  ?>


<?php get_footer() ?>