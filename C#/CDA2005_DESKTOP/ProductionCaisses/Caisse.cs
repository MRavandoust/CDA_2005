using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionCaisses
{
    public enum Type
    {
        A = 1000,
        B = 5000,
        C = 10000
    }

    public class Caisse
    {
        public Type CaisseType { get ; set; }
        public int NombreDeCaisse { get; set; }
        public float Price { get; set; }


        public Caisse(Type type)
        {
            this.CaisseType = type;
        }


        public double Rythme()   // Rythme par dix mili secendes
        {
            return  (int)CaisseType / 100;
        }

        public int NomreDeProduit(int secends)
        {
            return (int)(secends*Rythme());  
        }
    }
}
