using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFigure_V1
{
    public class Figures : Figure
    {
        List<Figure> listes;

        public Figures()
        {
            listes = new List<Figure>();
        }

        public override void Accept(IVisiteurPourFigure visiteur)
        {
            throw new NotImplementedException();
        }

        public void Add(Figure _figure)
        {
            listes.Add(_figure);
        }

        public void Remove(Figure _figure)
        {
            if (listes.Contains(_figure))
            {
                listes.Remove(_figure);
            }
        }

        public override void SeDessiner()
        {
            foreach (Figure  figure in listes)
            {
                figure.SeDessiner();
            }
            Console.ReadLine();
        }
    }
}
