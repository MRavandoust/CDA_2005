using ClassLibraryTemp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleAppHumain
{
    class Program
    {

        static void Main(string[] args)
        {
            // declencher rdv chez le medcin si l'evenement fievre arrive

            Temperature t = new Temperature();
            t.ChangementTemp += PrendrRDV;



            for (int i = 0; i < 45; i++)
            {
                t.Monter();
            }

        }


        private static void PrendrRDV()
        {
            Console.WriteLine("Je prend un RDV chez mon medcin! \nMa temperature est 38°");
            Console.ReadLine();
        }




    }
}
