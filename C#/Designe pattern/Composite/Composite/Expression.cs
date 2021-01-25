using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Expression
    {
        public Expression()
        {

        }
    
        public abstract int Evaluer();

        public abstract string FormateGauche();

        public string Formate()
        {
            return FormateGauche() + " = " + Evaluer().ToString();
        }


    }
}
