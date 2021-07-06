<?php
get_header();

?>




<div class="container" style="margin-top:50px">
    <div class="row">
        <div class="card mb-3">
            <div class="row g-0">

                <div class="container">
                    <div class="col-md-10">
                        <div class="card-body">
                            <h5 class="card-title"><?php the_title(); ?></h5>
                            <p class="card-text">
                                <?php the_content(); ?>
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
</div>
<?php



?>














<?php get_footer();  ?>