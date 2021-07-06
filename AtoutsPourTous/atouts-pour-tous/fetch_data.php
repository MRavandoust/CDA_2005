
<?php
$paged = (get_query_var('paged')) ? get_query_var('paged') : 1;
$term = array();
$args = array(
    'post_type' => 'partenaire',
    "posts_per_page" => 10,
    'paged' => $paged
  );
if (isset($_POST['action'])){
  if ($_POST['entreprise']) {
    array_push($term, 'entreprises');
  }
  if ($_POST['etablissement']) {
    array_push($term, 'etablissements-es');
  }
  if ($_POST['collectivite']) {
    array_push($term, 'collectivites-locales');
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