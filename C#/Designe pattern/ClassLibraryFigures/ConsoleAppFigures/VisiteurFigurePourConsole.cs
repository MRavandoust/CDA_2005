using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryFigures;

namespace ConsoleAppFigures
{
    class VisiteurFigurePourConsole:IVisiteur<bool>
    {
        public bool Visit(Cercle _c)
        {
            Console.WriteLine(_c.ToString());
            return true;
        }

        public bool Visit(Rectangle _r)
        {
            Console.WriteLine(_r.ToString());
            return true;
        }

        public bool Visit(Figures _f)
        {
            Console.WriteLine(_f.ToString());
            return true;
        }
    }
}
