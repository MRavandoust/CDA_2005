<?php get_header() ?>


<?php
while(have_posts())
    {
        the_post();
?>

<div style="background:linear-gradient(rgba(149, 149, 155, 0.2), rgba(255, 255, 255, 1)), url(<?php the_post_thumbnail_url() ?>) no-repeat; padding: 20px; background-size: 100%; ">



    <div class="container h-100" style="min-height: 700px; margin-top: 35px; ">
        <div class="card text-center" style="padding: 30px 0px;">


            <div class="card-header">
                <h5 class="card-title"><?php the_title() ; ?></h5>
            </div>
            <div class="card-body h-100">

                <a class="ripple" href="#!">
                    <img alt="example" class="img-fluid rounded" src="<?php the_post_thumbnail_url() ?>" />
                </a>
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