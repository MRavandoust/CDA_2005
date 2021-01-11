using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeLance.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public Decimal Prix { get; set; }
        public DateTime DevisDate { get; set; }
        public Job QuoteId { get; set; }


        public Quote()
        {

        }
    }
}
