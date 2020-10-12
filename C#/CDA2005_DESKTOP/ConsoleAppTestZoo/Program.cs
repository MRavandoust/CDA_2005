using ClassLibraryZoo;
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

            /******************* le feu arrive, il faut deplacer tout le monde *********************/

            foreach(AnimalDuZoo a in mesAnimauxDuZoo)
            {
                a.SeDeplacer();
            }

            /**************************  il faut mettre un peu d'ordre dans l'evacuation...du plus vieux au plus jeune ********************/

            List<AnimalDuZoo> lesAnimaux = new List<AnimalDuZoo>();
            lesAnimaux.Add(new Lapin(DateTime.Parse("2018/06/10"), true));
            lesAnimaux.Add(new Lapin(DateTime.Parse("2015/07/10"), true));
            lesAnimaux.Add(new Lion(DateTime.Parse("2010/06/10"), true));
            lesAnimaux.Add(new Perroquet(DateTime.Parse("2017/06/10"),true));


            Console.WriteLine("\n");
            Console.WriteLine("Liste des animaux avant les trier ");
            Console.WriteLine("======================================== \n");
            foreach (AnimalDuZoo anim in lesAnimaux)
            {
                Console.WriteLine($"{anim.GetType().Name} :\n\t" +
                    $"date de naissance -> {anim.dateDeNaissance} \n\t" +
                    $"s'il est né au zoo -> {anim.estNeeAuZoo} \n\t"
                    );
            }


            lesAnimaux.Sort();
            // lesAnimaux.Reverse();
            Console.WriteLine("\n");
            Console.WriteLine("L'ordre de deplacement parraport l'age ");
            Console.WriteLine("======================================== \n");

            foreach (AnimalDuZoo anim in lesAnimaux)
            {
                Console.WriteLine($"{anim.GetType().Name} :\n\t" +
                    $"date de naissance -> {anim.dateDeNaissance} \n\t" +
                    $"s'il est né au zoo -> {anim.estNeeAuZoo} \n\t"
                    );
            }





            /****************** mais que fait le gardien? il reste sur place? ***************************/

            Gardien gardien = new Gardien();
            if (gardien.SeDeplacer())
            {
                Console.WriteLine("Garien ne rest pas sur place");
            }


            /********************** et qui va appeller les secours? ********************/

            Gardien gardien1 = new Gardien();
            if (gardien1.Parler())
            {
                Console.WriteLine("Garien appele les secours");
            }

            List<IParler> parlant = new List<IParler>();
            parlant.Add(gardien1);
            parlant.Add(new Perroquet());

            foreach (IParler parleur in parlant)
            {
                parleur.Parler();
          
            }

            



        }
    }
}
