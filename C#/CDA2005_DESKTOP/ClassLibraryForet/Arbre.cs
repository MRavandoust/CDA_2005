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
        private List<Feuille> feuilles;
        private EnumFormeFeuille formeFeuilleImpose;

        public Arbre(int hauteur,EnumFormeFeuille _formeFeuille)
        {
            this.hauteur = hauteur;
            this.feuilles = new List<Feuille>();
            formeFeuilleImpose = _formeFeuille;
        }

        public Arbre(int hauteur, List<Feuille> feuilles) //ouvre porte aggregation
        {
            //a faire
            this.hauteur = hauteur;
            //verifier feuille 
            this.feuilles = feuilles;
        }

        public void AddFeuille(Feuille f)
        {
            if (f.FormeDeFeuille.Equals(this.formeFeuilleImpose))
            {
                //a faire
                feuilles.Add(f);
            }
            else
            {
                //
            }
        }

        public int Hauteur { get => hauteur; 
            //set => hauteur = value; 
        }
    }
}
