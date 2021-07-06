<h4 class="meta-box-item-title" style="margin-bottom: 0; margin-top:8px;" >
    <?= $name; ?>
</h4>
<div class="meta-box-item-content">

<?php if(!empty($value)): ?>

<img src="<?= $value; ?>" style="max-width: 200px; max-height:200px;">   

<?php endif; ?>

    <input type="text" name="<?= $id; ?>" id="<?= $id; ?>" value="<?= $value ?>">
    <a href="#" class="button js-uploader" data-id="<?= $id ?>" data-multiple="true">
        Uploader
    </a>
</div>