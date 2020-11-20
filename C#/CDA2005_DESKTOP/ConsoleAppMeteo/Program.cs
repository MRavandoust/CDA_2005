using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTemp;

namespace ConsoleAppMeteo
{
    class Program
    {
        static void Main(string[] args)
        {
            // je m'interese au fait que le temperature de gal est là, et que mon jardin risque de gelee..

            Temperature t = new Temperature();
            t.ChangementTemp += RentrerPlantes;


            for(int i =0; i <20; i++)
            {
                t.Diminuer();
            }

        }



        private static void RentrerPlantes()
        {
            Console.WriteLine("Je rentre les plantes !");
        }
    }
}
