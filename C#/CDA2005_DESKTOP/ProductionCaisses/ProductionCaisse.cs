using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProductionCaissess
{

    public class ProductionCaisse
    {
        public int TotalNumberOfBox { get ; set; }
        public int NombreDeCaisse { get; set; }
        public string Type { get; set; }




        public ProductionCaisse(string type, int totalNumber)
        {
            Type = type;
            TotalNumberOfBox = totalNumber;
        }

        
        //string str;
        public int Production()
        {
            int n = 0;
            for (int i = 0; i <= 100; i++)
            {
                n += 1;
                Thread.Sleep(500);
            }
            return n;
        }


        public void NewProduct()
        {

        }


        public double Rythme()   // Rythme par dix mili secendes
        {
            return TotalNumberOfBox / 100;
        }



        public int NombreDeProduit(int secends)
        {
            return (int)(secends*Rythme());  
        }
    }
}
