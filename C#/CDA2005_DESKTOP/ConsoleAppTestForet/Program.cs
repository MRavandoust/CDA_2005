using ClassLibraryForet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestForet
{
    class Program
    {
        static void Main(string[] args)
        {
            // creer un arbre du printemps

            Arbre monArbre = new Arbre(25);
            monArbre.AddFeuille(new Feuille(4));
            monArbre.AddFeuille(new Feuille(4));

            //afficher l'etat de l'arbre avec un ToString

            //ajouter un comportement passer en automne (feuille jaune ou rouge)
            //afficher l'état de l'arbre
        }
    }
}
