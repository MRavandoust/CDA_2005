<?php

class APT_Metabox
{
    private $id;
    private $title;
    private $post_type;
    private $fields = [];

    public static function addJS()
    {
        add_action('admin_enqueue_scripts', function () {
            wp_register_script('uploaderjs', get_template_directory_uri() . '/js/uploader.js');
            wp_enqueue_script('uploaderjs');
        });
    }

    public function __construct($id, $title, $post_type)
    {
        add_action('admin_init', array($this, 'create'));
        add_action('save_post', array($this, 'save'));
        $this->id = $id;
        $this->title = $title;
        $this->post_type = $post_type;
    }

    public function create()
    {
        if (function_exists('add_meta_box')) {
            add_meta_box($this->id, $this->title, array($this, 'render'), $this->post_type);
        }
    }

    public function save($post_id)
    {
        // On ne fait rien en cas de save Ajax
    
        foreach ($this->fields as $field) {
            $meta = $field['id'];
            if (isset($_POST[$meta])) {

                $value = $_POST[$meta];

                if (get_post_meta($post_id, $meta)) {
                    update_post_meta($post_id, $meta, $value);
                } else {
                    if ($value === '') {
                        delete_post_meta($post_id, $meta);
                    } else {
                        add_post_meta($post_id, $meta, $value);
                    }
                }

            }
        }
    }

    public function render()
    {
        global $post;
        foreach ($this->fields as $field) {
            extract($field);
            $value = get_post_meta($post->ID, $id, true);
            if ($value == '') {
                $value = $default;
            }
            require(__DIR__ . '/' . $field['type'] . '.php');
        }
        

        echo ' <input type="hidden" name="' .$this->id. '_nonce" value="' . wp_create_nonce($this->id) . ' ">';
    }

    public function add($id, $label, $type = 'text', $default = '')
    {
        $this->fields[] = [
            'id' => $id,
            'name' => $label,
            'type' => $type,
            'default' => $default
        ];
        return $this;
    }
}

APT_Metabox::addJS();
$box = new APT_Metabox('atp_cal', 'L\'information d\'événement', 'Calendrier');
$box->add('jour', 'Le jour : ');
$box->add('mois', 'Le mois : ');
$box->add('heure', 'L\'heure : ');
//$box->add('apt_long', 'Description courte', 'wysiwyg');
//$box->add('apt_image', 'Image', 'uploader');


$box = new APT_Metabox('atp_cal', 'L\'information de partenaire', 'partenaire');
$box->add('apt_contact', 'Contact : ');
$box->add('apt_telephone', 'Téléphone : ');
$box->add('apt_email', 'Email : ');
$box->add('apt_site', 'Site Web : ');
//$box->add('apt_long', 'Description courte', 'wysiwyg');
//$box->add('apt_image', 'Image', 'uploader');
