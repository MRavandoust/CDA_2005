using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFigure_V1
{
    public interface IVisiteurPourFigure
    {
        void Visit(Cercle c);
        void Visit(Rectangle c);
        void Visit(Figures c);
    }
}
