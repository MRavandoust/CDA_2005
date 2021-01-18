using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Companies.Models
{
    [Table("COMPANY")]
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string City { get; set; }
        [Required]
        [StringLength(100)]
        public string ContactName { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Email")]
        public string ContactEmail { get; set; }
        [Required]
        [StringLength(15)]
        [Display(Name = "Phone")]
        public string ContactPhone { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateAdd { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateUpdate { get; set; }
        [StringLength(1500)]
        public string Comment { get; set; }
    }
}
