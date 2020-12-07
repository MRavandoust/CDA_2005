using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProductionCaisses
{

    //=================================== Enum Statut ==============================================
    public enum Statut
    {
        NonDemarré,
        Demarré,
        Suspendu,
        Redemarré,
        Terminé
    }

    //=================================== Classe Production ==========================================
    public class Production
    {
        public delegate void ProduitDelegate(Production sender, Statut statut);
        public event ProduitDelegate StatutChange;
        public event ProduitDelegate NbCaisseChange;

        private const int MS = 3600000;
        private string type;
        private int nbTotal;
        private int nbParHeure;
        private int nbDepuisDemarrage;
        private Statut statutPrd;


        public string Type { get => type; /*set => type = value;*/ }
        public int NbTotal { get => nbTotal; /*set => nbTotal = value;*/ }
        public int NbParHeure { get => nbParHeure;/* set => nbParHeure = value;*/ }
        public Statut StatutPrd { get => statutPrd; /*set => statutP = value;*/ }
        public int NbDepuisDemarrage { get => nbDepuisDemarrage; /*set => nbDepuisDemarrage = value;*/ }


        //================================== Constructeur de classe ========================================
        public Production(string _type, int _nbTotal, int _nbParHeure)
        {
            type = _type;
            nbTotal = _nbTotal;
            nbParHeure = _nbParHeure;
            statutPrd = Statut.NonDemarré;
            StatutChange += Production_StatutChange;
        }

        //=================================================================================
        private void Production_StatutChange(Production sender, Statut statut)
        {
            if (statut != Statut.Terminé)
            {
                Thread t = new Thread(() => Produire());
                t.Start();
            }
        }

        //==================================== Produire =============================================

        public void Produire()
        {
            int delait = MS / NbParHeure;

            for (int i = 0; i <= nbTotal; i++)
            {
                if (StatutPrd == Statut.Demarré || StatutPrd == Statut.Redemarré)
                {
                    if (!Termine())
                    {
                        nbDepuisDemarrage++;
                        if (NbCaisseChange != null)
                        {
                            NbCaisseChange(this, StatutPrd);
                        }
                    }
                    Thread.Sleep(delait);
                }

            }
        }

        //======================================= Reinitialisation ==========================================
        public void Reinitialisation()
        {
            nbDepuisDemarrage = 0;
        }


        //======================================== Demarrer =========================================
        public bool Demarrer()
        {
            if (StatutPrd == Statut.NonDemarré || StatutPrd == Statut.Suspendu || StatutPrd == Statut.Terminé)
            {
                statutPrd = Statut.Demarré;
                //Reinitialisation();
                if (StatutChange != null)
                {
                    StatutChange(this, StatutPrd);
                }
                return true;
            }
            else
            {
                return false;
            }
        }


        //============================================ Suspendre =====================================
        public bool Suspendre()
        {
            if (StatutPrd == Statut.Demarré || StatutPrd == Statut.Redemarré)
            {
                statutPrd = Statut.Suspendu;
                if (StatutChange != null)
                {
                    StatutChange(this, StatutPrd);
                }
                return true;
            }
            else
            {
                return false;
            }
        }


        //========================================== Reprendre =======================================
        public bool Reprendre()
        {
            if (StatutPrd == Statut.Suspendu)
            {
                statutPrd = Statut.Redemarré;
                if (StatutChange != null)
                {
                    StatutChange(this, StatutPrd);
                }
                return true;
            }
            else
            {
                return false;
            }
        }


        //========================================= Terminer ========================================
        public bool Termine()
        {
            if (NbDepuisDemarrage == NbTotal)
            {
                statutPrd = Statut.Terminé;
                if (StatutChange != null)
                {
                    StatutChange(this, StatutPrd);
                }

                return true;
            }
            else
            {
                return false;
            }
        }


        //=================================================================================
        public int CalculNbCaissesSansDefaut()
        {
            return this.NbDepuisDemarrage;
        }


        //=================================================================================
        public int CalculAvancement()
        {
            return Convert.ToInt32(((double)CalculNbCaissesSansDefaut() / (double)nbTotal) * 100);
        }


    }
}
