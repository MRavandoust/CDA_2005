using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Nombre : Expression
    {
        int valeur;

        public Nombre(int valeur): base()
        {
            this.valeur = valeur;
        }

        public override int Evaluer()
        {
            return valeur; 
        }

        public override string FormateGauche()
        {
            return valeur.ToString();
        }
    }
}
