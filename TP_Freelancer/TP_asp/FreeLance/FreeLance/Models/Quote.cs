using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FreeLance.Models
{
    public partial class Quote
    {
        public int QuoteId { get; set; }
        [Display(Name ="State")]
        public string QuoteState { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Date")]
        public DateTime QuoteDate { get; set; }
        [Display(Name ="Amount")]
        public int QuoteAmount { get; set; }
        [Display(Name = "Final date")]
        [DataType(DataType.Date)]
        public DateTime QuoteFinalDate { get; set; }
        [Display(Name =("Final amount"))]
        public int QuoteFinalAmount { get; set; }
        public int JobId { get; set; }

        public virtual Job Job { get; set; }
    }
}
