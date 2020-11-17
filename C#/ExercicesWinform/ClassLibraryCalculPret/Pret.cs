using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ClassLibraryCalculPret
{
    public class Pret
    {
        private string name;
        private int capital;
        private Periode periodicite;
        private int dureeEnMois;
        private double taux;



        public enum Periode
        {
            Mensuelle = 1,
            Bimestrielle = 2,
            Trimestrielle = 3,
            Semestrielle = 6,
            Annuelle = 12
        }

        /// <summary>
        /// -----------------------Les properties ----------------------------------------------
        /// </summary>
        public string Name { get => name; set => name = value; }
        public int Capital { get => capital; set => capital = value; }
        public Periode Periodicite { get => periodicite; set => periodicite = value; }
        public int DureeEnMois { get => dureeEnMois; set => dureeEnMois = value; }
        public double Taux { get => taux; set => taux = value; }





        /// <summary>
        /// Constructeur par défaut --------------------------------------------------------------
        /// </summary>
        public Pret()
        {
            Name = "";
            Capital = 00;
            Periodicite = Periode.Mensuelle;
            DureeEnMois = 1;
            Taux = 7;
        }




        /// <summary>
        /// Constructeur de la classe ------------------------------------------------------------------
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_capital"></param>
        /// <param name="_periodicite"></param>
        /// <param name="_dureeEnMois"></param>
        /// <param name="_taux"></param>
        public Pret(string _name, int _capital, Periode _periodicite, int _dureeEnMois, float _taux)
        {
            Name = _name;
            Capital = _capital;
            Periodicite = _periodicite;
            DureeEnMois = _dureeEnMois;
            Taux = _taux;
        }




        /// <summary>
        /// La méthode de calculer lenombre de remboursement ----------------------------------------------
        /// </summary>
        /// <param name="_periodicite"></param>
        /// <returns></returns>
        public int NombreDRemboursement()
        {
            return DureeEnMois / (int)Periodicite;
        }




        /// <summary>
        /// La méthode de calculer le montante de remnoursement --------------------------------------
        /// </summary>
        /// <returns></returns>
        public double MontanDRemboursement()
        {
            double montant = Capital * (CalculTaux() / (1 - Math.Pow((1 + CalculTaux()), -NombreDRemboursement())));
            return montant;
        }



        public double Total()
        {
            return MontanDRemboursement() * NombreDRemboursement();
        }



        public double CalculTaux()
        {
            double m = Taux * (int)Periodicite / 1200;
            return m;
        }



        public override string ToString()
        {
            return name + "-" + capital + "-" + periodicite + "-" + dureeEnMois + "-" + taux;
        }

    }
}
