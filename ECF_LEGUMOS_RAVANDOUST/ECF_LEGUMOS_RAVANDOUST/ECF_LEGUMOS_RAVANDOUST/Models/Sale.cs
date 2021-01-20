using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ECF_LEGUMOS_RAVANDOUST.Models
{
    public partial class Sale
    {
        public int SaleId { get; set; }
        [Display(Name = "Date de vente")]
        [DataType(DataType.Date)]
        public DateTime SaleDate { get; set; }

        public int SaleWeight { get; set; }
        public decimal SaleUnitPrice { get; set; }
        public int SaleActive { get; set; }
        [Display(Name = "Legume")]
        public int VegetableId { get; set; }

        [ForeignKey("VegetableId")]
        public virtual Vegetable Vegetable { get; set; }
    }
}
