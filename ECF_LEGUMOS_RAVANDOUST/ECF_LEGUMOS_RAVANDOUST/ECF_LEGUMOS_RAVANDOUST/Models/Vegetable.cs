using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ECF_LEGUMOS_RAVANDOUST.Models
{
    public partial class Vegetable
    {
        public Vegetable()
        {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        [Display(Name = "Nom")]
        public string Name { get; set; }
        [Display(Name = "Variété")]
        public string Variety { get; set; }
        [Display(Name = "Couleur")]
        public string PrimaryColor { get; set; }
        [Display(Name = "Durée Conservation")]
        public int LifeTime { get; set; }
        [Display(Name = "Frais")]
        public int Fresh { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
