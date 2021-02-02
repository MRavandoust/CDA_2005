using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculeAbstractFactory
{
    public class RegularBike : IBike
    {
        public string Name()
        {
            return "Name : RegularBike";
        }
    }
}
