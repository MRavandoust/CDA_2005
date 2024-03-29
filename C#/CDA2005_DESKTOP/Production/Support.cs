﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProductionCaisses
{


    public enum StatutProduction
    {
        NonDemarré,
        Demarré,
        Suspendu,
        Redemarré,
        Terminé
    } 
    class Support
    {

        #region Champs

        private const int NombreMilliSecondesParHeure = 1000 * 60 * 60;


        public delegate void DelegateProduction(Production prodSender, StatutProduction prodStatut);
        public event DelegateProduction ChangementStatutProduction;
        public event DelegateProduction ChangementNbCaisses;

        string nom;
        DateTime dateTimeDemarrageProduction;
        StatutProduction statutDeLaProduction;
        int nbCaissesAProduire;
        int nbCaissesAProduireParHeure;
        int nbCaissesDepuisDemarrageTotal;
        int nbCaissesDepuisDemarrageAvecDefaut;
        #endregion

        #region Accesseurs
        public DateTime DateTimeDemarrageProduction
        {
            get => dateTimeDemarrageProduction; //set => dateTimeDemarrageProduction = value; 
        }
        public StatutProduction StatutDeLaProduction
        {
            get => statutDeLaProduction; //set => statutDeLaProduction = value; 
        }
        public int NbCaissesAProduire
        {
            get => nbCaissesAProduire; //set => nbCaissesAProduire = value; 
        }
        public int NbCaissesAProduireParHeure
        {
            get => nbCaissesAProduireParHeure; //set => nbCaissesAProduireParHeure = value; 
        }
        public int NbCaissesDepuisDemarrageTotal
        {
            get => nbCaissesDepuisDemarrageTotal; //set => nbCaissesDepuisDemarrageTotal = value; 
        }

        public int NbCaissesDepuisDemarrageAvecDefaut
        {
            get => nbCaissesDepuisDemarrageAvecDefaut; //set => nbCaissesDepuisDemarrageAvecDefaut = value; 
        }
        public string Nom
        {
            get => nom; //set => nom = value; 
        }
        #endregion

        #region Constructeur
        //public Production(string _nom, int _nbCaissesAProduire, int _nbCaissesAProduireParHeure)
        //{
        //    this.nom = _nom;
        //    this.nbCaissesAProduire = _nbCaissesAProduire;
        //    this.nbCaissesAProduireParHeure = _nbCaissesAProduireParHeure;
        //    this.statutDeLaProduction = StatutProduction.NonDemarré;
        //    this.Reinitialisation();

        //    this.ChangementStatutProduction += Production_ChangementStatutProduction;

        //}
        #endregion

        #region Event Changement Statut de la production
        private void Production_ChangementStatutProduction(Production prodSender, StatutProduction prodStatut)
        {
            if (prodStatut != StatutProduction.Terminé)
            {
                Thread t = new Thread(() => ThreadProduction());
                t.Start();
            }
        }
        #endregion

        #region Thread Production
        public void ThreadProduction()
        {
            int dureeDodo = NombreMilliSecondesParHeure / this.nbCaissesAProduireParHeure;
            bool continuerThread = true;
            while (continuerThread)
            {
                if (this.StatutDeLaProduction == StatutProduction.Demarré || this.StatutDeLaProduction == StatutProduction.Redemarré)
                {
                    Thread.Sleep(dureeDodo);
                    this.ProduireUneCaisse();
                }
                else
                {
                    continuerThread = false;
                }
            }
        }
        #endregion

        #region init/reinit champs
        public void Reinitialisation()
        {
            this.nbCaissesDepuisDemarrageTotal = 0;
            this.nbCaissesDepuisDemarrageAvecDefaut = 0;
            this.dateTimeDemarrageProduction = new DateTime();
        }
        #endregion

        #region Changement etat production
        public bool DemarrerProduction()
        {
            if (statutDeLaProduction == StatutProduction.NonDemarré
                || statutDeLaProduction == StatutProduction.Suspendu
                || statutDeLaProduction == StatutProduction.Terminé)
            {
                this.statutDeLaProduction = StatutProduction.Demarré;
                this.Reinitialisation();
                this.dateTimeDemarrageProduction = DateTime.Now;
                if (ChangementStatutProduction != null)
                {
                   // ChangementStatutProduction(this, this.statutDeLaProduction);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ArreterProduction()
        {
            if (statutDeLaProduction == StatutProduction.Demarré
                || statutDeLaProduction == StatutProduction.Redemarré)
            {
                this.statutDeLaProduction = StatutProduction.Suspendu;
                if (ChangementStatutProduction != null)
                {
                    //ChangementStatutProduction(this, this.statutDeLaProduction);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ContinuerProduction()
        {
            if (statutDeLaProduction == StatutProduction.Suspendu)
            {
                this.statutDeLaProduction = StatutProduction.Redemarré;
                if (ChangementStatutProduction != null)
                {
                    //ChangementStatutProduction(this, this.statutDeLaProduction);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        #region Production terminée
        public bool IsTermine()
        {
            if (this.nbCaissesDepuisDemarrageTotal == this.NbCaissesAProduire)
            {
                this.statutDeLaProduction = StatutProduction.Terminé;
                if (ChangementStatutProduction != null)
                {
                    //ChangementStatutProduction(this, this.statutDeLaProduction);
                }

                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #endregion

        #region Produire
        public void ProduireUneCaisse()
        {
            Random rdm = new Random();
            int random = rdm.Next(2);
            if (!this.IsTermine())
            {
                nbCaissesDepuisDemarrageTotal++;
                nbCaissesDepuisDemarrageAvecDefaut += random;
                if (ChangementNbCaisses != null)
                {
                    //ChangementNbCaisses(this, this.statutDeLaProduction);
                }
            }
        }
        #endregion

        #region Calculs taux defaut
        public double CalculTauxDefautHeure()
        {
            // methode a revoir
            TimeSpan tempsEcouleDepuisDemarrage = DateTime.Now - dateTimeDemarrageProduction;
            double nbHeuredepuisDemarrage = tempsEcouleDepuisDemarrage.TotalHours;
            if (nbCaissesDepuisDemarrageTotal > 0 && nbHeuredepuisDemarrage > 0)
            {
                return Math.Round(((double)nbCaissesDepuisDemarrageAvecDefaut / nbHeuredepuisDemarrage) / ((double)nbCaissesAProduireParHeure), 4);
            }
            else
            {
                return 0;
            }
        }
        public double CalculTauxDefautDepuisDemarrage()
        {
            if (nbCaissesDepuisDemarrageTotal > 0)
            {
                return Math.Round((double)nbCaissesDepuisDemarrageAvecDefaut / (double)nbCaissesDepuisDemarrageTotal, 4);
            }
            else
            {
                return 0;
            }
        }


        #endregion

        #region Calcul pourcentage d'avancement
        public int CalculAvancementEnPourcentage()
        {
            return Convert.ToInt32(((double)nbCaissesDepuisDemarrageTotal / (double)nbCaissesAProduire) * 100);
        }
        #endregion


    }
}
