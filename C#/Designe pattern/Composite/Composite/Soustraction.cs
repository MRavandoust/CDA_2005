using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Soustraction : Binaire
    {


        public Soustraction(Expression _operandeGauche, Expression _operandeDroite) : base(_operandeGauche, _operandeDroite)
        {
            
        }

        public override int Evaluer()
        {
            return  operandeGauche.Evaluer() - operandeDroite.Evaluer();
        }

        public override string FormateGauche()
        {
            return operandeGauche.FormateGauche() + " - " + operandeDroite.FormateGauche(); ;
        }
    }
}
