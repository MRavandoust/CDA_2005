using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForet
{
    public class Feuille
    {
        int nbNervures;
        private EnumFormeFeuille formeDeFeuille;
        private EnumCouleur couleurDeFeuille;


        /***************************** Constructeur par defaut *******************************/
        public Feuille()
        {
            this.nbNervures = 2;
            this.formeDeFeuille = EnumFormeFeuille.ovale;
            this.couleurDeFeuille = EnumCouleur.Vert;
        }

        /************************ Constructeur avec deux parametres ***********************/
        public Feuille(int nbNervures, EnumFormeFeuille formeDeFeuille)
        {
            this.nbNervures = nbNervures;
            this.formeDeFeuille = formeDeFeuille;
            this.couleurDeFeuille = EnumCouleur.Vert; 
        }

        /************************** Constructeur avec trois parametres ***********************/
        public Feuille(int nbNervures, EnumFormeFeuille formeDeFeuille, EnumCouleur couleurDeFeuille)
        {
            this.nbNervures = nbNervures;
            this.formeDeFeuille = formeDeFeuille;
            this.couleurDeFeuille = couleurDeFeuille;
        }
        
        public int NbNervures
        { get => nbNervures; 
            //set => nbNervures = value; 
        }
        public EnumFormeFeuille FormeDeFeuille { get => formeDeFeuille;
            //set => formeDeFeuille = value; 
        }
        
        /***************************** Tomber la Feuille *******************************/
        public void Tomber()
        {
            Console.WriteLine("Je tombe");
        }


        /************************* Prendre couleur d'automne ***************************/
        public void PrendsTesCouleursDAutomne()
        {
            if (this.couleurDeFeuille.Equals(EnumCouleur.Jaune))
            {
                this.couleurDeFeuille = EnumCouleur.Rouge;
            }
            else
            {
                this.couleurDeFeuille = EnumCouleur.Jaune;
            }
        }

        /****************** Override ToString pour la classe Feuille ********************/
        public override string ToString()
        {
            return  base.ToString() +" Nombre de nervures: " + nbNervures + " Forme de feuille: " + formeDeFeuille + " Couleur de feuille: " + couleurDeFeuille;
        }
    }
}
