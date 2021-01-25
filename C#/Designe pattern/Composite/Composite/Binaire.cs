using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Binaire : Expression
    {
        protected Expression operandeGauche;
        protected Expression operandeDroite;

        public Binaire(Expression _operandeGauche, Expression _operandeDroite)
        {
            operandeGauche = _operandeGauche;
            operandeDroite = _operandeDroite;
        }

    }
}
