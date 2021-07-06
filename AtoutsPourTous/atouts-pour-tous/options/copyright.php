<?php

class CopyRight
{
    const GROUP = 'apt_options';

    public static function register()
    {
        add_action('admin_menu', [self::class, 'addMenu']);
        add_action('admin_init', [self::class, 'registerSettings']);
    }

    public static function registerSettings()
    {
        register_setting(self::GROUP, 'copy_right');
        add_settings_section('apt_options_section', 'Parametres', function () {
            echo "Vous pouvez ici définir le text de copyrigt du site";
        }, self::GROUP);
        add_settings_field('apt_options_copyright', "Site copyright text", function () {
        ?>
          
                <input name="copy_right" type="text"  value="<?= get_option('copy_right') ?>" class="regular-text" />
           
        <?php
        }, self::GROUP, 'apt_options_section');
    }

    public static function addMenu()
    {
        add_options_page("Gestion de la page", "Copyright text", "manage_options", self::GROUP, [self::class, 'render']);
    }

    public static function render()
    {
        ?>
        <h1>Text du copyright</h1>
        <form action="options.php" method="post">
            <?php settings_fields(self::GROUP);
            do_settings_sections(self::GROUP);
            submit_button(); ?>
        </form>
<?php
    }
}
