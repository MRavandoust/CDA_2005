using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCreationDUneException
{
    class Fraction
    {
        int numerator;
        int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction(int numerator)
        {
            this.numerator = numerator;
        }

        public void Inverser()
        {
            int temps = numerator;
            this.numerator = denominator;
            this.denominator = temps;
        }

        public double Evaluer()
        {
            int r;
            try
            {
                r = numerator / denominator;
            }
            catch(DivideByZeroException e)
            {
                throw new ImposibleToEvaluationOfFraction("Le denominateur vaut zero", e);
            }
            //DivideByZeroException
        }

    }
}