using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFigure_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(8, 7 , 10, 10);
            Rectangle rc1 = new Rectangle(10, 2, 10, 20) ;
            Rectangle rc2 = new Rectangle(10, 2, 20, 20);

            //rc.SeDessiner();
            //rc1.SeDessiner();
            //rc2.SeDessiner();

            rc.Accept(new VisiteurPourConsole());

            Figures fs = new Figures();
            fs.Add(rc);
            fs.Add(rc1);
            fs.Add(rc2);

            // fs -> rc,rc1,rc2
            // fs2 -> fs , cr

            fs.SeDessiner();
        }
    }
}
