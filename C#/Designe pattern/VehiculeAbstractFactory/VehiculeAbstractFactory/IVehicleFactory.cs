using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculeAbstractFactory
{

    // The 'AbstractFactory' interface.
    public interface IVehicleFactory
    {
        IBike GetBike(string bike);
        IScooter GetScooter(string scooter);
    }
}
