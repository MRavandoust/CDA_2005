using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Addition : Binaire
    {
        public Addition(Expression operantGauche, Expression operantDroite) : base(operantGauche, operantDroite)
        {

        }

        public override int Evaluer()
        {
            return _operantGauche.Evaluer() + _operantDroite.Evaluer();
        }
    }
}
