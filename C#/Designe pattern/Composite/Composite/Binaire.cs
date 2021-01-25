using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Binaire : Expression
    {
        protected Expression _operantGauche;
        protected Expression _operantDroite;

        public Binaire(Expression operantGauche, Expression operantDroite)
        {
            _operantGauche = operantGauche;
            _operantDroite = operantDroite;
        }

    }
}
