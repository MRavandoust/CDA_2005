<?php get_header() ?>

    <!------------------------------------ Titre --------------------------------------->

    <div class="container-fluide top-titr">
        <div class="row text-center  p-4">
            <div class="col">
                <h1>CONVENTION ATOUTS POUR TOUS Grand-Est</h1>
                <h3>Objectif ? Favoriser l'insertion professionnelle des étudiants en situation de handicap</h3>

            </div>
        </div>
    </div>

    <!------------------------------------ End of Titre --------------------------------------->



    <!------------------------------------ Main Carousel --------------------------------------->
    <div class="container" style="margin-top: 65px;">
        <div class="row text-center g-5 justify-content-center">
            <div class="col-md-8 xx">
                <div class="bg-image hover-overlay ripple " data-mdb-ripple-color="light">
                    <img src="<?php bloginfo('template_url'); ?>/images/Test 2.png" class="img-fluid" alt="..." />
                    <a href="#!">
                        <div class="mask" style="background-color: rgba(251, 251, 251, 0.15)"></div>
                    </a>
                </div>
            </div>

            <div class="col-md-3 xxx" style="position: relative; padding-right: 10px;">
                <div class="activity-header">
                    <h2>Actualité</h2>
                </div>
                <div class="activity">
                    <div id="carouselExampleControls" class="carousel slide" data-mdb-ride="carousel">
                        <div class="carousel-inner">
                            
                        <?php 
                    $q = new WP_Query (
                        array("category_name" => "actualites", "posts_per_page" => 1)
                        );

                        while($q->have_posts())
                        {
                            $q->the_post();
                        ?>

                            <div class="carousel-item active">
                                <a href="<?php the_permalink(); ?>"><img src="<?php the_post_thumbnail_url() ?>" class="d-block w-100" alt="..." /></a>
                            </div>

                <?php  }   ?>

                <?php 
                    $q = new WP_Query (
                        array("category_name" => "actualites", 'offset' => 1,  "posts_per_page" => 4)
                        );

                        while($q->have_posts())
                        {
                            $q->the_post();
                        ?>

                            <div class="carousel-item">
                                <a href="<?php the_permalink(); ?>"><img src="<?php the_post_thumbnail_url() ?>" class="d-block w-100" alt="..." /></a>
                            </div>

                <?php  }   ?>

                        </div>
                        <button class="carousel-control-prev" type="button" data-mdb-target="#carouselExampleControls" data-mdb-slide="prev">
                          <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                          <span class="visually-hidden">Previous</span>
                        </button>
                        <button class="carousel-control-next" type="button" data-mdb-target="#carouselExampleControls" data-mdb-slide="next">
                          <span class="carousel-control-next-icon" aria-hidden="true"></span>
                          <span class="visually-hidden">Next</span>
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!------------------------------------End of Carousel --------------------------------------->




    <!------------------------------------La Convention --------------------------------------->

    <div class="container " style="margin-top: 50px; ">

        <div class="row ">
            <div class="col-md-12 d-flex align-items-center p-4 ">

                <div class="card">
                    <div class="card-body" style="background-color:#EFF2F6;">
                        <p class="card-text">
                            La Convention Atouts pour tous est une convention-cadre de partenariat qui a pour but premier de faciliter l’insertion professionnelle des étudiants en situation de handicap, car il faut savoir que le taux de chômage des personnes handicapées en France,
                            est toujours le double de celui des valides. En effet, malgré le « quota » de 6% de travailleurs handicapés imposé aux entreprises depuis 2005, le taux de chômage des personnes en situation de handicap reste à 18 %. <br>                            C’est pourquoi la Convention Atouts pour tous s’articule sous plusieurs axes.
                        </p>
                    </div>
                </div>

            </div>

        </div>



    </div>

    <!------------------------------------End of La Convention --------------------------------------->




    <!------------------------------------ AXES --------------------------------------->
    <section class="card2 ">
        <div class="container text-center ">
            <h3 class="section-title ">Les 4 axes principales de la Convention Atouts pour tous</h3>
            <div class="row row-cols-1 row-cols-md-4 g-5 justify-content-between ">

                <?php 
                    $q = new WP_Query (
                        array("category_name" => "axes", "posts_per_page" => 4)
                        );

                        while($q->have_posts())
                        {
                            $q->the_post();
                            $excerpt = get_the_excerpt();
                        ?>

                        <div class="col ">
                            <div class="card h-100 ">

                                <div class="bg-image hover-overlay ripple " data-mdb-ripple-color="light ">
                                <img src="<?php the_post_thumbnail_url() ?>" class="img-fluid " />
                                    <a href="<?php the_permalink(); ?>">
                                        <div class="mask " style="background-color: rgba(251, 251, 251, 0.15) "></div>
                                    </a>
                                </div>
                                <div class="card-body ">
                                    <h5 class="card-title "><?php the_title(); ?></h5>
                                    <hr>
                                    <p class="card-text ">
                                        <?php echo substr($excerpt, 0, 100) . ' ...';  ?>
                                    </p>
                                </div>
                            </div>
                        </div>

                <?php  }   ?>
    
            </div>
        </div>
    </section>



    <!------------------------------------ End of AXES --------------------------------------->



    <!------------------------------------ Statistique  --------------------------------------->

    <div class="second ">

        <section class="statistiques ">
            <div class="container ">
                <div class=" row g-5 ">
                    <div class="col items ">
                        <div class="bg-image hover-overlay ripple " data-mdb-ripple-color="light ">
                            <img src="<?php bloginfo('template_url'); ?>/images/Membres_60px.png " alt=" " class="img-fuid ">
                            <a href="#! ">
                                <div class="mask " style="background-color: rgba(251, 251, 251, 0.15) "></div>
                            </a>
                        </div>

                        <p>6500</p>
                        <h2>membres</h2>
                    </div>

                    <div class="col items ">
                        <div class="bg-image hover-overlay ripple " data-mdb-ripple-color="light ">
                            <img src="<?php bloginfo('template_url'); ?>/images/offre_demploi_64px.png " alt=" " class="img-fuid ">
                            <a href="#! ">
                                <div class="mask " style="background-color: rgba(251, 251, 251, 0.15) "></div>
                            </a>
                        </div>

                        <p>12500</p>
                        <h2>ESHs Grand-Est</h2>
                    </div>

                    <div class="col items ">
                        <div class="bg-image hover-overlay ripple " data-mdb-ripple-color="light ">
                            <img src="<?php bloginfo('template_url'); ?>/images/recrutement_60px.png " alt=" " class="img-fuid ">
                            <a href="#! ">
                                <div class="mask " style="background-color: rgba(251, 251, 251, 0.15) "></div>
                            </a>
                        </div>

                        <p>480</p>
                        <h2>Recruteurs</h2>
                    </div>

                    <div class="col items ">
                        <div class="bg-image hover-overlay ripple " data-mdb-ripple-color="light ">
                            <img src="<?php bloginfo('template_url'); ?>/images/evenements_64px.png " alt=" " class="img-fuid ">
                            <a href="#! ">
                                <div class="mask " style="background-color: rgba(251, 251, 251, 0.15) "></div>
                            </a>
                        </div>

                        <p>420</p>
                        <h2>Missions handicaps</h2>
                    </div>


                    <div class="col items ">
                        <div class="bg-image hover-overlay ripple " data-mdb-ripple-color="light ">
                            <img src="<?php bloginfo('template_url'); ?>/images/recrutement_60px.png " alt=" " class="img-fuid ">
                            <a href="#! ">
                                <div class="mask " style="background-color: rgba(251, 251, 251, 0.15) "></div>
                            </a>
                        </div>

                        <p>480</p>
                        <h2> Etablissements publics</h2>
                    </div>
                </div>
            </div>
        </section>

    </div>
    <!------------------------------------ End of Statistique  --------------------------------------->



    <!------------------------------------ Calendrier --------------------------------------->
    <section class="card2 ">
        <div class="container text-center ">
            <h3 class="section-title ">CALENDRIER</h3>
            <div class="row row-cols-1 row-cols-md-4 g-4 justify-content-around ">

            <?php 
                    $q = new WP_Query (
                        array( "post_type" => "calendrier", "posts_per_page" => 3)
                        );

                        while($q->have_posts())
                        {
                            $q->the_post();
                        ?>



                <div class="col-md-4 evenements ">
                    <a href="<?php the_permalink(); ?> ">
                        <div style="border: 1px solid #DADADA; ">
                            <div class="bg-image hover-zoom ">
                                <img src="<?php the_post_thumbnail_url() ?> " class="w-100 " style="height: 160px; " />
                            </div>
                            <div class="card-body ">
                                <div class="even-date ">
                                    <h3><?php echo get_post_meta(get_the_ID(), 'jour', true)  ?></h3>
                                    <p><?php echo get_post_meta(get_the_ID(), 'mois', true)  ?></p>
                                    <p><?php echo get_post_meta(get_the_ID(), 'heure', true)  ?></p>
                                </div>
                                <p class="even-text ">
                                    <?php the_title( ) ; ?>
                                </p>
                            </div>
                        </div>
                    </a>
                </div>

                <?php  }   ?>


            </div>
            <a href="<?php  bloginfo('url'); ?>/calendar" class="btn m-3" style=" background-color: #ED7D31 !important; color:white ">Voir tous les évènement</a>
        </div>
    </section>

    <!------------------------------------ End of Calendrier --------------------------------------->



    <!-------------------------------------- Partenaires --------------------------------------->



    <div class="partenaires ">
        <div class="container text-center ">
            <h3 class="section-title ">PARTENAIRES</h3>
            <div class="row g-5 ">
                <div class="col-md-3 second-item ">
                    <div class="bg-image hover-overlay ripple " data-mdb-ripple-color="light ">
                        <img src="<?php bloginfo('template_url'); ?>/images/Orange_logo.svg.png " alt="Partenaires " class="img-fuid " style="height: 100px; ">
                        <a href="#! ">
                            <div class="mask " style="background-color: rgba(251, 251, 251, 0.15) "></div>
                        </a>
                    </div>
                </div>
                <div class="col-md-3 second-item ">
                    <div class="bg-image hover-overlay ripple " data-mdb-ripple-color="light ">
                        <img src="<?php bloginfo('template_url'); ?>/images/CRM.png " alt="Partenaires " class="img-fuid " style="height: 100px; ">
                        <a href="#! ">
                            <div class="mask " style="background-color: rgba(251, 251, 251, 0.15) "></div>
                        </a>
                    </div>
                </div>
                <div class="col-md-3 second-item ">
                    <div class="bg-image hover-overlay ripple " data-mdb-ripple-color="light ">
                        <img src="<?php bloginfo('template_url'); ?>/images/UHA.png " alt="Partenaires " class="img-fuid " style="height: 100px; ">
                        <a href="#! ">
                            <div class="mask " style="background-color: rgba(251, 251, 251, 0.15) "></div>
                        </a>
                    </div>
                </div>
                <div class="col-md-3 second-item ">
                    <div class="bg-image hover-overlay ripple " data-mdb-ripple-color="light ">
                        <img src="<?php bloginfo('template_url'); ?>/images/Academie-de-Strasbourg.jpg " alt="Partenaires " class="img-fuid " style="height: 100px; ">
                        <a href="#! ">
                            <div class="mask " style="background-color: rgba(251, 251, 251, 0.15) "></div>
                        </a>
                    </div>
                </div>
            </div>

        </div>

    </div>

    <!--------------------------------------End of Partenaires --------------------------------------->



<?php get_footer()  ?>


