using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFigures
{
    public class Figures : Figure
    {
        List<Figure> listes;

        public Figures()
        {
            listes = new List<Figure>();
        }

        public List<Figure> Listes 
        {
            get { return listes; } 
            
        }

        public void Add(Figure _figure)
        {
            listes.Add(_figure);
        }

        public void Remove(Figure _figure)
        {
            if (listes.Contains(_figure))
            {
                listes.Add(_figure);
            }
            
        }

    }
}
