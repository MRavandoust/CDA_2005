using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionCaisses
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

        public double Rythme()   // Rythme par dix mili secendes
        {
            return TotalNumberOfBox / 100;
        }

        public int NomreDeProduit(int secends)
        {
            return (int)(secends*Rythme());  
        }
    }
}
