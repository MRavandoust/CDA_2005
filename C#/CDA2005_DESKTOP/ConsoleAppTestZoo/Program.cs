using ClassLibraryZoo.Animaux;
using ClassLibraryZoo.Employes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestZoo
{
    class Program
    {
        private static DateTime dateDeNaissance;

        static void Main(string[] args)
        {

            List<AnimalDuZoo> mesAnimauxDuZoo = new List<AnimalDuZoo>();
            mesAnimauxDuZoo.Add(new Lapin());
            mesAnimauxDuZoo.Add(new Lapin());
            mesAnimauxDuZoo.Add(new Lion());
            mesAnimauxDuZoo.Add(new Perroquet());

            //le feu arrive, il faut deplacer tout le monde
            foreach(AnimalDuZoo a in mesAnimauxDuZoo)
            {
                a.SeDeplacer();
            }

            //il faut mettre un peu d'ordre dans l'evacuation...du plus vieux au plus jeune
            List<AnimalDuZoo> lesAnimaux = new List<AnimalDuZoo>();
            mesAnimauxDuZoo.Add(new Lapin(new DateTime(2018, 06, 10, 0, 0, 0)));
            mesAnimauxDuZoo.Add(new Lapin(new DateTime(2015, 07, 10, 0, 0, 0)));
            mesAnimauxDuZoo.Add(new Lion(new DateTime(2010, 06, 10, 0, 0, 0)));
            mesAnimauxDuZoo.Add(new Perroquet(new DateTime(2017, 06, 10, 0, 0, 0)));


            lesAnimaux.Sort();

            //foreach (AnimalDuZoo a in lesAnimaux)
            //{
                
            //}





            //mais que fait le gardien? il reste sur place?
            Gardien gardien = new Gardien();
            if (gardien.SeDeplacer())
            {
                Console.WriteLine("Garien ne rest pas sur place");
            }


            //et qui va appeller les secours? 
            Gardien gardien1 = new Gardien();
            if (gardien1.PeutParler())
            {
                Console.WriteLine("Garien appele les secours");
            }
        }
    }
}
