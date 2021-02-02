using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFigure_V1
{
   public  class VisiteurPourConsole : IVisiteurPourFigure
    {
        public void Visit(Cercle c)
        {
            Console.WriteLine("Je suis un cercle de rayon" + c.X);
        }

        public void Visit(Rectangle c)
        {
            throw new NotImplementedException();
        }

        public void Visit(Figures c)
        {
            throw new NotImplementedException();
        }
    }
}
