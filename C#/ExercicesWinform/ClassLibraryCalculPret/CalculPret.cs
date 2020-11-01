using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ClassLibraryCalculPret
{
    public class CalculPret
    {
        private string name;
        private int capital;
        private string periodicite;
        private int dureeEnMois;
        private double taux;

        public string Name { get => name; set => name = value; }
        public int Capital { get => capital; set => capital = value; }
        public string Periodicite { get => periodicite; set => periodicite = value; }
        public int DureeEnMois { get => dureeEnMois; set => dureeEnMois = value; }
        public double Taux { get => taux; set => taux = value; }
        

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public CalculPret()
        {
            //Name = "";
            //Capital = 0;
            //Periodicite = "Mensuelle";
            //DureeEnMois = 1;
            //Taux = 7;
        }

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_capital"></param>
        /// <param name="_periodicite"></param>
        /// <param name="_dureeEnMois"></param>
        /// <param name="_taux"></param>
        public CalculPret(string _name, int _capital, string _periodicite, int _dureeEnMois, double _taux)
        {
            Name = _name;
            Capital = _capital;
            Periodicite = _periodicite;
            DureeEnMois = _dureeEnMois;
            Taux = _taux;
        }



        /// <summary>
        /// La méthode de calculer lenombre de remboursement
        /// </summary>
        /// <param name="_periodicite"></param>
        /// <returns></returns>
        //public int NombreDRemboursement()
        //{
        //    int n;
        //    switch (Periodicite)
        //    {
        //        case "Mensuelle": n = 1;
        //            break;
        //        case "Bimestrielle": n = 2;
        //            break;
        //        case "Trimestrielle": n = 3;
        //            break;
        //        case "Semestrielle": n = 6;
        //            break;
        //        case "Annuelle": n = 12;
        //            break;
        //        default: n = 1;
        //            break;
        //    }
        //    return DureeEnMois/n;
        //}


        /// <summary>
        /// La méthode de calculer le montante de remnoursement
        /// </summary>
        /// <returns></returns>
        //public double MontanDRemboursement()
        //{
        //    int k = Capital;
        //    int t = Taux;
        //    return k * (t / (1 - 1 / Math.Pow((1 + t), NombreDRemboursement())));
        //}




    }
}
