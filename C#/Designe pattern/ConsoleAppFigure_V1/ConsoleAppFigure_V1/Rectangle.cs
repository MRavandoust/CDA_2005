using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFigure_V1
{
    public class Rectangle : Figure
    {
        private int langueur;
        private int largeur;

        public Rectangle( int _langueur, int _largeur , int x, int y):base(x , y)
        {
            langueur = _langueur;
            largeur = _largeur;
        }

        public override void Accept(IVisiteurPourFigure visiteur)
        {
            throw new NotImplementedException();
        }

        public override void SeDessiner()
        {
            string space = "";
            for (int i = 0; i < X; i++)
                space += " ";

            for (int i = 0; i < langueur; i++)
            {
                Console.Write(space);
                for (int j = 0; j < largeur; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
