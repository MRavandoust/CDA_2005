using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculeAbstractFactory
{
    public class HeroFactory : IVehicleFactory
    {
        public IBike GetBike(string bike)
        {
            switch (bike)
            {
                case "Sports":
                    return new SportsBike();
                case "Regular":
                    return new RegularBike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", bike));
            }
        }

        public IScooter GetScooter(string scooter)
        {
            switch (scooter)
            {
                case "Sports":
                    return new Scooty();
                case "Regular":
                    return new RegularScooter();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", scooter));
            }
        }
    }
}
