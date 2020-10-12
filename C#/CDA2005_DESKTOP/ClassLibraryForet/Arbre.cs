using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForet
{
    public class Arbre
    {
        int hauteur;
        private List<Feuille> feuilles = new List<Feuille>();

        public Arbre(int hauteur)
        {
            this.hauteur = hauteur;
            //this.feuilles = new List<Feuille>();
        }

        public Arbre(int hauteur, List<Feuille> feuilles) //ouvre porte aggregation
        {
            //a faire
            this.hauteur = hauteur;
            this.feuilles = feuilles;
        }

        public void AddFeuille(Feuille f)
        {
            //a faire
            feuilles.Add(f);
        }

        public int Hauteur { get => hauteur; 
            //set => hauteur = value; 
        }
    }
}
