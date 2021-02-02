using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeublesAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            MeublesFactory ikea = new IKEA();
            Client ikeaClient = new Client(ikea, "Classique");

            Console.WriteLine("\n\n         ************** IKEA *****************");
            Console.WriteLine("    " + ikeaClient.GetChaise());
            Console.WriteLine("    " + ikeaClient.GetSofa());
            Console.WriteLine("    " + ikeaClient.GetTable());


            ikeaClient = new Client(ikea, "Modern");

            Console.WriteLine("\n         ************** IKEA *****************");
            Console.WriteLine("    " + ikeaClient.GetChaise());
            Console.WriteLine("    " + ikeaClient.GetSofa());
            Console.WriteLine("    " + ikeaClient.GetTable());


            Console.WriteLine("\n\n\n   =========================================================\n");

            MeublesFactory comforama = new Conframa();
            Client conforamaClient = new Client(comforama, "Modern");

            Console.WriteLine("\n\n        ************* COMFORAMA *************");
            Console.WriteLine("    " + conforamaClient.GetChaise());
            Console.WriteLine("    " + conforamaClient.GetSofa());
            Console.WriteLine("    " + conforamaClient.GetTable());



            conforamaClient = new Client(comforama, "Classique");

            Console.WriteLine("\n        ************* COMFORAMA *************");
            Console.WriteLine("    " + conforamaClient.GetChaise());
            Console.WriteLine("    " + conforamaClient.GetSofa());
            Console.WriteLine("    " + conforamaClient.GetTable());



            Console.ReadKey();
        }
    }
}
