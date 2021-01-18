using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogueProduit.Models
{
    [Table("PRODUITS")]
    public class Produit
    {
        [Key]
        [Display(Name ="Produit Id")]
        public int ProduitId { get; set; }
        [Required, MinLength(4), MaxLength(20)]
        [StringLength(100)]
        public string Designation { get; set; }
        [Required, Range(100,1000000)]
        public double Prix { get; set; }
        public int Quantite { get; set; }
        public int CategorieId { get; set; }
        [ForeignKey("CategorieId")]
        public virtual Categorie Categorie { get; set; }
    }
}
