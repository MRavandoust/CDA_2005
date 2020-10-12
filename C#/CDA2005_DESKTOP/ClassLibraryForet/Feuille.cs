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

        public Feuille(int nbNervures)
        {
            this.nbNervures = nbNervures;
        }

        public Feuille(int nbNervures, EnumFormeFeuille formeDeFeuille, EnumCouleur couleurDeFeuille)
        {
            this.nbNervures = nbNervures;
            this.formeDeFeuille = EnumFormeFeuille.cordineForme;
            this.couleurDeFeuille = EnumCouleur.Vert;
        }

        public int NbNervures { get => nbNervures; 
            //set => nbNervures = value; 
        }

        public void Tomber()
        {
            Console.WriteLine("Je tombe");
        }

        public override string ToString()
        {
            return "Nombre de nervures: " + nbNervures + " Forme de feuille: " + formeDeFeuille + " Couleur de feuille: " + couleurDeFeuille;
        }
    }
}
