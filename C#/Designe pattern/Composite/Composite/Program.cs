using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression exp1 = new Addition(new Nombre(45), new Nombre(25));
            int result1 = exp1.Evaluer();

            Expression exp2 = new Soustraction(new Nombre(68), new Nombre(26));
            int result2 = exp2.Evaluer();

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }
}
