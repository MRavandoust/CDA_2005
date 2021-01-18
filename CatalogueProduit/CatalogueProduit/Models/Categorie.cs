using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogueProduit.Models
{
    [Table("CATEGORIES")]
    public class Categorie
    {
        [Key]
        public int CategorieId { get; set; }
        [StringLength(30)]
        public string NomCategorie { get; set; }
        public virtual ICollection<Produit> Produits { get; set; }
    }
}
