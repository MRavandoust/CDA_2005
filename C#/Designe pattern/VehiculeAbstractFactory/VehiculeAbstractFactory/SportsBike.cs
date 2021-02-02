using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculeAbstractFactory
{
    public class SportsBike : IBike
    {
        public string Name()
        {
            return "Name : SportsBike";
        }
    }
}
