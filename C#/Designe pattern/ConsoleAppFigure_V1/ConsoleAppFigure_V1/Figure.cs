using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFigure_V1
{
    public abstract class Figure
    {
        private int x;
        private int y;


        public Figure():this(0,0)
        {

        }



        public Figure(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public int X
        {
            get { return x; }
            //set { x = value; }
        }

        public int Y
        {
            get { return y; }
           // set { y = value; }
        }

        public abstract void SeDessiner();

        public abstract void Accept(IVisiteurPourFigure visiteur);

    }
}
