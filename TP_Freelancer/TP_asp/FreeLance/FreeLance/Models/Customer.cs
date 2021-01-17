using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FreeLance.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Jobs = new HashSet<Job>();
        }
        [Display(Name ="Customer Id")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Ce champs est obligatoir")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You should fill this area")]
        public string Email { get; set; }
        public int CatId { get; set; }

        public virtual CustomersCat Cat { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
