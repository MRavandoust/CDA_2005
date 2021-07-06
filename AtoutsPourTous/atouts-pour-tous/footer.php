<!------------------------------------- Footer----------------------------------->

<footer class="bg text-center text-lg-start ">
    <!-- Grid container -->
    <div class="container p-4 ">
        <!--Footer-->
        <div class="row ">
                                                            <!-- Footer 1 -->
            <div class="col-lg-6 col-md-12 mb-4 mb-md-0 ">

                <?php
                if (is_active_sidebar('footer-sidebar1')) {
                    ob_start();
                    dynamic_sidebar('footer-sidebar1');
                    $sidebar = ob_get_contents();
                    ob_end_clean();

                    $sidebar_corrected_ul = str_replace("<ul>", '<ul class="list-unstyled mb-0 plan">', $sidebar);

                    echo $sidebar_corrected_ul;

                }
                ?>
                <h5 class="text-uppercase ">Atouts Pour Tous</h5>
                <p>
                    <a href=" " style="color: #4F4F4F !important; ">mentions légales</a>
                </p>
                <p>
                    <a href=" " style="color: #4F4F4F !important; ">Conditions Générales d'utilisation du site</a>
                </p>
            </div>
                                                            <!--Footer 1-->


                                                            <!--Footer 2 -->
            <div class="col-lg-3 col-md-6 mb-4 mb-md-0 ">
                <?php
                if (is_active_sidebar('footer-sidebar2')) {
                    ob_start();
                    dynamic_sidebar('footer-sidebar2');
                    $sidebar = ob_get_contents();
                    ob_end_clean();

                    $sidebar_corrected_ul = str_replace("<ul>", '<ul class="list-unstyled mb-0 plan">', $sidebar);

                    echo $sidebar_corrected_ul;
                }
                ?>
            </div>
                                                                <!--Footer 2 -->


                                                                <!--Footer 3 -->
            <div class="col-lg-3 col-md-6 mb-4 mb-md-0 ">
                <?php
                if (is_active_sidebar('footer-sidebar3')) {
                    dynamic_sidebar('footer-sidebar3');
                }
                ?>
                <h5 class="text-uppercase mb-0 ">Trouvez nous sur</h5>

                <ul class="list-unstyled reseau ">
                    <li>
                        <a href="#! "><i class="fab fa-facebook-square "></i></a>
                    </li>
                    <li>
                        <a href="#! "><i class="fab fa-linkedin "></i></a>
                    </li>
                    <li>
                        <a href="#! "><i class="fab fa-youtube-square "></i></a>
                    </li>
                </ul>
            </div>
                                                                <!--Footer 3-->
        </div>
        <!--Footer-->
    </div>
    <!-- Grid container -->

    <!-- Copyright -->
    <div class="text-center p-3 " style="background-color: rgba(0, 0, 0, 0.2); ">
        <?= get_option('copy_right'); ?>
        <?php $text = get_bloginfo('url'); ?>

        <a class="text-dark " href="<?php bloginfo('url'); ?>"><?php echo str_replace("http://", " ", $text); ?></a>
    </div>
    <!-- Copyright -->
</footer>

<!------------------------------------- End of Footer----------------------------------->








<!-- End your project here-->



<!-- MDB -->
<script type="text/javascript " src="<?php bloginfo('template_url'); ?>/js/mdb.min.js "></script>
<!-- Custom scripts -->
<script type="text/javascript "></script>
<?php wp_footer(); ?>
</body>
</html>