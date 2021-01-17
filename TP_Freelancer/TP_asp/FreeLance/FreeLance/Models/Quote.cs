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
        public string QuoteState { get; set; }
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }
        public int QuoteAmount { get; set; }
        [DataType(DataType.Date)]
        public DateTime QuoteFinalDate { get; set; }
        public int QuoteFinalAmount { get; set; }
        public int JobId { get; set; }

        public virtual Job Job { get; set; }
    }
}
