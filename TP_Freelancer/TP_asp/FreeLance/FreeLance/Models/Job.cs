using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeLance.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string Title { get; set; }
        public DateTime JobStart { get; set; }
        public DateTime JobEnd{ get; set; }
        public string JobDescription{ get; set; }
        public Customer Customer_Id { get; set; }

        public Job()
        {

        }
    }
}
