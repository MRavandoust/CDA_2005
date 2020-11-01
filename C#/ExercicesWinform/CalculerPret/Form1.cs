using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryCalculPret;
using System.Text.RegularExpressions;

namespace CalculerPret
{
    public partial class FormEmprunt : Form
    {
        
        public FormEmprunt()
        {
            InitializeComponent();
            radioButton7.Checked = true;
            hScrollBarDureeMois.Value = 1;
            lblScroll.Text = hScrollBarDureeMois.Value.ToString();
            txtName.Text = "";
            txtCapital.Text = "00";
            listBoxPeriodicite.SelectedIndex = 0;
        }

        CalculPret cp = new CalculPret();
        

        //------------------------------------ Mise à jour de la vue ---------------------------------------
        public void MiseAJourApp()
        {
            lblScroll.Text = ChiffreDuree();
            lblNombreDRembours.Text = NombreDRemboursement().ToString();
            CalculTaux();
        }



        //----------- Calculer le montant de remboursement et mise à jour de la vue par défilement -------------
        private void hScrollBarDureeMois_Scroll(object sender, ScrollEventArgs e)
        {
            lblScroll.Text = ChiffreDuree();
            MiseAJourApp();
            CalculeRemboursement();
        }



        //--- Calculer le montant de remboursement et mise à jour de la vue en chengement de la périodicité -------
        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {  
            MiseAJourApp();
            if(Convert.ToInt32(lblScroll.Text) <12)
            {
                switch (MoisDeDuree())
                {
                    case 1:
                        lblScroll.Text = "1";
                        break;
                    case 2:
                        lblScroll.Text = "2";
                        break;
                    case 3:
                        lblScroll.Text = "3";
                        break;
                    case 6:
                        lblScroll.Text = "6";
                        break;
                    case 12:
                        lblScroll.Text = "12";
                        break;
                }
            }
            
            CalculeRemboursement();
        }


        //--- Calculer le montant de remboursement et mise à jour de la vue en selection de RadioButtons -------
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            MiseAJourApp();
        }


        //--- Calculer le montant de remboursement et mise à jour de la vue en selection de RadioButtons -------
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            MiseAJourApp();
            CalculeRemboursement();
        }


        //--- Calculer le montant de remboursement et mise à jour de la vue en selection de RadioButtons -------
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            MiseAJourApp();
            CalculeRemboursement();
        }




        //---------------------------- Calculer le nombre de mois selon la périodicité -------------------------- 
        private int MoisDeDuree()
        {
            int n;
            switch (listBoxPeriodicite.SelectedIndex)
            {
                case 0:
                    n = 1;
                    break;
                case 1:
                    n = 2;
                    break;
                case 2:
                    n = 3;
                    break;
                case 3:
                    n = 6;
                    break;
                case 4:
                    n = 12;
                    break;
                default:
                    n = 1;
                    break;
            }
            return n;
        }




        //------------------------------------ Obtenir le taux de RadioButton ---------------------------------------
        public double CalculTaux()
        {
            double n = 0;
            if (radioButton7.Checked) n = 0.07;
            if (radioButton8.Checked) n = 0.08;
            if (radioButton9.Checked) n = 0.09;
            return n * MoisDeDuree() / 12;

        }




        //------------------------- Calculer le chiffre de durée en mois selon la périodicité ------------------------ 
        private string ChiffreDuree()
        {
            return (hScrollBarDureeMois.Value - hScrollBarDureeMois.Value % MoisDeDuree()).ToString();
        }




        //----------------------------------- Calculer le nombre de remboursement ------------------------------------- 
        private int NombreDRemboursement()
        {
            return Convert.ToInt32(lblScroll.Text) / MoisDeDuree();
        }





        //------------------------------------ Calculer le montant de remboursement -----------------------------------
        private void CalculeRemboursement()
        {
            try
            {
                cp.Capital = Convert.ToInt32(txtCapital.Text);
                cp.Taux = CalculTaux();
                int k = cp.Capital;
                double t = cp.Taux;
                double montant = k * (t / (1 - Math.Pow((1 + t), -NombreDRemboursement())));
                lblMontant.Text = montant.ToString("N") + "€";
            }catch(Exception e)
            {
                MessageBox.Show("Le champs de capital ne peut pas être vide");
            }
        }


        //----------------------- Calculer le montant de remboursement en cliquant sur le button OK---------------------
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCapital.Text == "")
            {
                MessageBox.Show("Le champs de capital ne peut pas être vide");
            }
            else
            {
                CalculeRemboursement();
            }
            
        }



        //---------------------------- Validation de saisie au champs Capital Emprunté ----------------------------
        private void txtCapital_TextChanged(object sender, EventArgs e)
        {
            Regex myReg = new Regex(@"^\d{2,10}$");
            if (!myReg.IsMatch(txtCapital.Text))
            {
                errorProvider1.SetError(txtCapital, "Le champs doit remplir par un nombre entre 2 et 10 chiffres");
            }
            else
            {
                errorProvider1.SetError(txtCapital, "");
            }
        }



        //---------------------------- Validation de saisie au champs Name ----------------------------
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Regex nomRegex = new Regex(@"^[a-zA-Z]{2,30}$");
            if (nomRegex.IsMatch(txtName.Text) || txtName.Text == "")
            {
                errorProvider2.SetError(txtName, "");
            }
            else
            {
                errorProvider2.SetError(txtName, "Ce champs prend que des lettres");
            }
        }



        //----------------------- Réinitialisation de la vue en cliquant sur le button Annuler---------------------
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
            hScrollBarDureeMois.Value = 1;
            lblScroll.Text = hScrollBarDureeMois.Value.ToString();
            txtName.Text = "";
            txtCapital.Text = "00";
            listBoxPeriodicite.SelectedIndex = 0;
        }

        
    }
}
