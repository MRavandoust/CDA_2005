using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Soustraction : Binaire
    {


        public Soustraction(Expression operantGauche, Expression operantDroite) : base(operantGauche, operantDroite)
        {
            
        }

        public override int Evaluer()
        {
            return  _operantGauche.Evaluer() - _operantDroite.Evaluer();
        }

    }
}
