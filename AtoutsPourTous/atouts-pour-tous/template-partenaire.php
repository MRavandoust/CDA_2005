<?php

/**
 * Template Name: Partenaires
 */
get_header();



$value = 'Tous les partenaires';
$user = wp_get_current_user();
if ($user->ID == 0) {
?>

  <div class="container" style="margin-top: 15px;  ">
    <div class="alert alert-warning" role="alert" data-mdb-color="warning" style="border-radius:0 !important; color: red; text-align: center; font-weight: bold;">
      Pour voir les coordonnées de contact, connectez vous !
    </div>
  </div>

<?php } ?>



<form method="post">
  <div class="container  d-flex justify-content-end" style="margin-top: 15px;">

    <div class="col-md-1">
      <p style="text-align: right; margin-right:8px; line-height:40px ; font-weight: 500">Triez par </p>
    </div>
    <div class="col-md-4">
      <select name="type" id="select-css" class="select-css">
        <option value="all"><?= $value; ?></option>
        <option value="all">Tous les partenaires</option>
        <option value="etablissements-es">Etablissements d’enseignements supérieurs</option>
        <option value="collectivites-locales">Collectivités locales</option>
        <option value="entreprises">Entreprises</option>
      </select>
    </div>

    <div class="col-md-1" style="margin-left: 8px;">
      <button type="submit" name="sort" class="btn" style="background-color: #ED7D31 !important; border-radius:0 !important; color:white; ">Trier</button>
    </div>
  </div>
</form>




<div class="container d-flex justify-content-start">
  <div class="m-3 form-check">
    <label><input type="checkbox" class="common_selector form-check-input entreprise" value="entreprise"> Entreprises</label>
  </div>
  <div class="m-3 form-check">
    <label><input type="checkbox" class="common_selector form-check-input collectivite" value="collectivite"> Collectivités locales</label>
  </div>
  <div class="m-3 form-check">
    <label><input type="checkbox" class="common_selector form-check-input etablissement" value="etablissement"> Etablissements d’enseignements supérieurs</label>
  </div>
</div>



<div class="filter_data">
</div>


<?php
$paged = (get_query_var('paged')) ? get_query_var('paged') : 1;
$term = array();
if (!isset($_POST['sort'])) {
  $args = array(
    'post_type' => 'partenaire',
    "posts_per_page" => 10,
    'paged' => $paged
  );
} else {
  if ($_POST['type'] == 'entreprises') {
    array_push($term, 'entreprises');
    $value = 'Entreprises';
  }
  if ($_POST['type'] == 'etablissements-es') {
    array_push($term, 'etablissements-es');
    $value = 'Etablissements d’enseignements supérieurs';
  }
  if ($_POST['type'] == 'collectivites-locales') {
    array_push($term, 'collectivites-locales');
    $value = 'Collectivités locales';
  }
  if ($_POST['type'] == 'all') {
    array_push($term, 'entreprises', 'collectivites-locales', 'etablissements-es');
    $value = 'Tous les partenaires';
  }

  $args = array(
    'post_type' => 'partenaire',
    'posts_per_page' => 10,
    'paged' => $paged,
    'tax_query' => array(
      array(
        'taxonomy' => 'partenaire_type',
        'field'     => 'slug', //slug , name or term_id
        'terms'    => $term,
      )
    )
  );
}
?>


<div class="partenaire" style="margin-top: 15px;">
  <?php
  $q = new WP_Query($args);
  while ($q->have_posts()) {
    $q->the_post();
  ?>

    <div class="container" style="margin-bottom:50px; ">
      <div class="card mb-4 underline" style="background-color: #F5F5F5; padding: 10px; height: 250px; border-radius:0 !important;">
        <div class="row g-0" style=" padding: 8px;">
          <div class="col-md-4">
            <img style="height: 215px;" src="<?php the_post_thumbnail_url() ?>" alt="..." class="img-fluid" />
          </div>
          <div class="col-md-8">
            <div class="card-body">
              <h3 class="card-title" style="color: #17296A; font-size:19px; font-weight: bold"><?php the_title(); ?></h3>
              <p class="card-text" style="float: left;">
                <strong style="color: #17296A;"> Description: </strong>&nbsp&nbsp
              <div><?php the_excerpt(); ?></div>
              </p>
              <p class="card-text" style="float: left;">
                <strong style="color: #17296A;"> Site Web: </strong>&nbsp&nbsp
              <div><a href="<?= get_post_meta($post->ID, 'apt_site', true); ?>" target="_blanc"><?= get_post_meta($post->ID, 'apt_site', true); ?></a> </div>
              </p>
              <?php if ($user->ID != 0) { ?>
                <p class="card-text" style="float: left;">
                  <strong style="color: #17296A;"> Contact: </strong>&nbsp&nbsp
                <div><?= get_post_meta($post->ID, 'apt_contact', true); ?></div>
                </p>
                <p class="card-text" style="float: left;">
                  <strong style="color: #17296A;"> Téléphone: </strong>&nbsp&nbsp
                <div><?= get_post_meta($post->ID, 'apt_telephone', true); ?></div>
                </p>
                <a href="<?php the_permalink(); ?>" class="btn m-3" style="background-color: #ED7D31 !important; border-radius:0 !important; color:white; position: absolute; right: 0; bottom: 0;  ">Voir plus</a>
              <?php } ?>
            </div>
          </div>
        </div>
      </div>
    </div>

  <?php }  ?>
</div>

<section class=" p-4 d-flex justify-content-center mb-4">
  <?php the_posts_pagination(); ?>
  <?php if (function_exists("pagination")) {
    pagination($q->max_num_pages);
  } ?>
</section>




<script>
  $(document).ready(function() {

    filter_data();

    function filter_data() {
      var action = 'fetch_data';
      var entreprise = get_filter('entreprise');
      var collectivite = get_filter('collectivite');
      var etablissement = get_filter('etablissement');
      $.ajax({
        url: "fetch_data.php",
        method: "POST",
        data: {
          action: action,
          entreprise: entreprise,
          collectivite: collectivite,
          etablissement: etablissement
        },
        success: function(data) {
          $('.filter_data').html(data);
        }
      });
    }

    function get_filter(class_name) {
      var filter = [];
      $('.' + class_name + ':checked').each(function() {
        filter.push($(this).val());
      });
      return filter;
    }

    $('.common_selector').click(function() {
      filter_data();
    });


  });
</script>



<?php get_footer();  ?>