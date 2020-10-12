using System;
using System.Collections;
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


        public Arbre(int hauteur)
        {
            this.hauteur = hauteur;
            feuilles = new List<Feuille>();
        }
        public Arbre(int hauteur,EnumFormeFeuille _formeFeuille)
        {
            this.hauteur = hauteur;
            this.feuilles = new List<Feuille>();
            formeFeuilleImpose = _formeFeuille;
        }

        public List<Feuille> Feuilles 
        { 
            get => feuilles; 
            //set => feuilles = value; 
        }

        //public Arbre(int hauteur, List<Feuille> feuilles) //ouvre porte aggregation
        //{
        //    //a faire
        //    this.hauteur = hauteur;
        //    //verifier feuille 
        //    this.feuilles = feuilles;
        //}

        private void AddFeuille(Feuille f)
        {
            Feuilles.Add(f);
        }

        public void AddFeuille(int _nbNervures, EnumFormeFeuille _formeDeFeuille , EnumCouleur _couleurFeuille)
        {
            this.AddFeuille(new Feuille(_nbNervures, _formeDeFeuille, _couleurFeuille));
        }

        public int Hauteur { get => hauteur; 
            //set => hauteur = value; 
        }

        public override string ToString()
        {
            String resu = base.ToString() + "Hauteur = " + Hauteur;

            foreach(Feuille f in Feuilles)
            {
                resu += "\n" + f.ToString();
            }
            return resu;
        }

        public void PasserEnAutomne()
        {
            foreach(Feuille f in Feuilles)
            {
                f.PrendsTesCouleursDAutomne();
            }
        }

        public  Feuille this [int i]
        {
            get { return  feuilles[i]; }
           // set { };
            
        }

    }
}
