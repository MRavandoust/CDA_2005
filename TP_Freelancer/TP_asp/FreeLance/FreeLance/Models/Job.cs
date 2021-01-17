using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FreeLance.Models
{
    public partial class Job
    {
        public Job()
        {
            Quotes = new HashSet<Quote>();
        }

        public int JobId { get; set; }
        public string JobState { get; set; }
        public string JobTitle { get; set; }
        [DataType(DataType.Date)]
        public DateTime JobStart { get; set; }
        [DataType(DataType.Date)]
        public DateTime JobEnd { get; set; }
        public string JobDescription { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
    }
}
