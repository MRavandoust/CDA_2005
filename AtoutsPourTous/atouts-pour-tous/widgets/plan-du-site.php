<?php
class PlanDuSite extends WP_Widget
{

    public function __construct()
    {
        parent::__construct('plan_du_site', 'Plan du site');
    }

    public function widget($args, $instance)
    {
        echo 'Bonjour';
    }

    public function form($instance)
    {
    }

    public function update($new_instance, $old_instance)
    {
        return[];
    }
}
