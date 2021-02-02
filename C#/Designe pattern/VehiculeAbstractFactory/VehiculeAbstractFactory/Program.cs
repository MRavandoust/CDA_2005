using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculeAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory honda = new HondaFactory();
            VehicleClient hondaClient = new VehicleClient(honda, "Regular");

            Console.WriteLine("********** HONDA **********\n");
            Console.WriteLine(hondaClient.GetBikeName());
            Console.WriteLine(hondaClient.GetScooterName() + "\n");


            hondaClient = new VehicleClient(honda, "Sports");
            Console.WriteLine(hondaClient.GetBikeName());
            Console.WriteLine(hondaClient.GetScooterName() + "\n");

            IVehicleFactory hero = new HeroFactory();
            VehicleClient heroClient = new VehicleClient(hero, "Regular");

            Console.WriteLine("*********** HERO **********\n");
            Console.WriteLine(heroClient.GetBikeName());
            Console.WriteLine(heroClient.GetScooterName() + "\n");


            heroClient = new VehicleClient(hero, "Sports");
            Console.WriteLine(heroClient.GetBikeName());
            Console.WriteLine(heroClient.GetScooterName());


            Console.ReadKey();
        }
    }
}
