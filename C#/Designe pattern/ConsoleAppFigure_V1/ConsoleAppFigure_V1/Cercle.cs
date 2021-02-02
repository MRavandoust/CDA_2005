using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFigure_V1
{
    public class Cercle : Figure
    {
        public override void Accept(IVisiteurPourFigure visiteur)
        {
            visiteur.Visit(this);
        }

        public override void SeDessiner()
        {
            throw new NotImplementedException();
        }
    }
}
