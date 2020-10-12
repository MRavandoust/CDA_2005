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
            monArbre.AddFeuille(6, EnumFormeFeuille.ovale, EnumCouleur.Vert);
            monArbre.AddFeuille(6, EnumFormeFeuille.ovale, EnumCouleur.Rouge);

            //afficher l'etat de l'arbre avec un ToString
            Console.WriteLine(monArbre.ToString());


            //ajouter un comportement passer en automne (feuille jaune ou rouge)
            monArbre.PasserEnAutomne();


            //afficher l'état de l'arbre
            Console.WriteLine(monArbre.ToString());




            //--------------------------Cerise sur le gateau--------------------------

            //tomber les feuilles de l'arbre //appeler chaque methode Tomber de l'arb

            for (int i = 0; i < monArbre.Feuilles.Count; i++) //Count -> Propriete
            {
                Feuille f = monArbre[i]; // voir cours -> Définir un indexeur pour une classe de scharp2008
                f.Tomber();
                if (i == monArbre.Feuilles.Count - 1)
                    Console.WriteLine("Il n'y a plus de feuille");
            }


        }
    }
}
