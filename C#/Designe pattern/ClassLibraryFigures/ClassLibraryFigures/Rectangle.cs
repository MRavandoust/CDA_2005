using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFigures
{
    public class Rectangle : Figure
    {
        private int langueur;
        private int largeur;

        public Rectangle(int _langueur, int _largeur)
        {
            langueur = _langueur;
            largeur = _largeur;
        }


        public void SeDessiner()
        {
            for(int i = 0; i < langueur; i++)
            {
                for(int j = 0; j< largeur; j++)
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}
