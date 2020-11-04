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
using System.IO;

namespace CalculerPret
{
    public partial class FormEmprunt : Form
    {
        private Pret cp;

        public FormEmprunt()
        {
            InitializeComponent();
            cp = new Pret();
            MettreAJourLIHM();
        }

        public FormEmprunt(Pret _pretAModifier)
        {
            InitializeComponent();
            cp = _pretAModifier;
            MettreAJourLIHM();
        }




        //----------------------- Mettre à jour de l'IHM en fct de l'etat de Cp ----------------------
        public void MettreAJourLIHM()
        {
            txtName.Text = cp.Name;
            txtCapital.Text = cp.Capital.ToString();
            lblScroll.Text=cp.DureeEnMois.ToString();
            listBoxPeriodicite.SelectedItem = cp.Periodicite;
            if(cp.Taux == 7) radioButton7.Checked = true;
            if(cp.Taux == 8) radioButton8.Checked = true;
            if(cp.Taux == 9) radioButton9.Checked = true;
            lblMontant.Text = cp.MontanDRemboursement();
            
            //configure le scrollbar en fct de la periodicite
            lblScroll.Text = ChiffreDuree();

            //mise a jour des resultats
            lblNombreDRembours.Text = cp.NombreDRemboursement().ToString();
            CalculTaux();
            lblMontant.Text = cp.MontanDRemboursement();
        }




        //----------- Calculer le montant de remboursement et mise à jour de la vue par défilement -------------
        private void hScrollBarDureeMois_Scroll(object sender, ScrollEventArgs e)
        {
            if (txtCapital.Text != "")
            {
                switch (cp.NombreDeMoisDePeriodicite())
                {
                    case 1:
                        hScrollBarDureeMois.LargeChange = 1; hScrollBarDureeMois.SmallChange = 1; 
                        break;
                    case 2:
                        hScrollBarDureeMois.LargeChange = 2; hScrollBarDureeMois.SmallChange = 2; 
                        break;
                    case 3:
                        hScrollBarDureeMois.LargeChange = 3; hScrollBarDureeMois.SmallChange = 3; 
                        break;
                    case 6:
                        hScrollBarDureeMois.LargeChange = 6; hScrollBarDureeMois.SmallChange = 6; 
                        break;
                    case 12:
                        hScrollBarDureeMois.LargeChange = 12; hScrollBarDureeMois.SmallChange = 12; 
                        break;
                }
                cp.DureeEnMois = hScrollBarDureeMois.Value;
                MettreAJourLIHM();
            }
            else
            {
                MessageBox.Show("Ce champs ne peut pas être vide");
            }
            
        }



        //--- Calculer le montant de remboursement et mise à jour de la vue en chengement de la périodicité -------
        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            


            if (txtCapital.Text == "")
            {
                MessageBox.Show("Ce champs ne peut pas être vide");
            }
            else
            {
                if (Convert.ToInt32(lblScroll.Text) < 12)
                {
                    switch (listBoxPeriodicite.SelectedIndex)
                    {
                        case 0:
                            { hScrollBarDureeMois.Value = 1; }
                            break;
                        case 1:
                            { hScrollBarDureeMois.Value = 2; }
                            break;
                        case 2:
                            { hScrollBarDureeMois.Value = 3; }
                            break;
                        case 3:
                            { hScrollBarDureeMois.Value = 6; }
                            break;
                        case 4:
                            { hScrollBarDureeMois.Value = 12; }
                            break;
                    }
                }
                cp.Periodicite = listBoxPeriodicite.SelectedItem.ToString();
                cp.DureeEnMois = hScrollBarDureeMois.Value;
                MettreAJourLIHM();

            }
            
        }


        //--- Calculer le montant de remboursement et mise à jour de la vue en selection de RadioButtons -------
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (txtCapital.Text == "")
            {
                MessageBox.Show("Ce champs ne peut pas être vide");
            }
            else
            {
                MettreAJourLIHM();
            }
            
        }



        //--- Calculer le montant de remboursement et mise à jour de la vue en selection de RadioButtons -------
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (txtCapital.Text == "")
            {
                MessageBox.Show("Ce champs ne peut pas être vide");
            }
            else
            {
                MettreAJourLIHM();
            }
            
        }



        //--- Calculer le montant de remboursement et mise à jour de la vue en selection de RadioButtons -------
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (txtCapital.Text == "")
            {
                MessageBox.Show("Ce champs ne peut pas être vide");
            }
            else
            {
                MettreAJourLIHM();
                
            }
            
        }




        //------------------------------------ Obtenir le taux de RadioButton ---------------------------------------
        public double CalculTaux()
        {
            double n = 0;
            if (radioButton7.Checked) n = 0.07;
            if (radioButton8.Checked) n = 0.08;
            if (radioButton9.Checked) n = 0.09;
            double m = n * cp.NombreDeMoisDePeriodicite() / 12;
            cp.Taux = m;
            return m;

        }




        //------------------------- Calculer le chiffre de durée en mois selon la périodicité ------------------------ 
        private string ChiffreDuree()
        {
            return (hScrollBarDureeMois.Value - hScrollBarDureeMois.Value % cp.NombreDeMoisDePeriodicite()).ToString();
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
                //-----------  Enregistrer les informations de la forme dans le fochier texte ------
                MettreAJourLIHM();
                string filePath = @"D:\GitHub\CDA_2005\C#\ExercicesWinform\CalculerPret\emprunt.txt";
                List<string> emprunts = new List<string>();
                if (cbArchive.FindString(txtName.Text) == -1)
                {
                    emprunts.Add(cp.ToString());
                    File.AppendAllLines(filePath, emprunts);
                    cbArchive.Items.Clear();
                    LoadArchive();
                    cbArchive.Text = "";
                    MessageBox.Show("La caluel a été enregistré !");
                }
                else
                    MessageBox.Show(txtName.Text + " exsite dans le liste");
                
            }

            
        }



        //---------------------------- Validation de saisie au champs Capital Emprunté ----------------------------
        private void txtCapital_TextChanged(object sender, EventArgs e)
        {
            Regex myReg = new Regex(@"^\d{1,10}$");
            if (!myReg.IsMatch(txtCapital.Text))
            {
                errorProvider1.SetError(txtCapital, "Le champs doit remplir par un nombre entre 2 et 10 chiffres");
                cp.Capital = 0;
                MettreAJourLIHM();
            }
            else
            {
                errorProvider1.SetError(txtCapital, "");
                cp.Capital = int.Parse(txtCapital.Text);
                MettreAJourLIHM();
            }
        }



        //---------------------------- Validation de saisie au champs Name ----------------------------
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Regex nomRegex = new Regex(@"^[a-zA-Z]{2,30}$");
            if (nomRegex.IsMatch(txtName.Text) || txtName.Text == "")
            {
                errorProvider2.SetError(txtName, "");
                cp.Name = txtName.Text;
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
            txtCapital.Text = "0";
            listBoxPeriodicite.SelectedIndex = 0;
            lblMontant.Text = "0";
            cbArchive.Text = "";
        }



        //----------------------- Load information from file on Form loading ---------------------
        private void FormEmprunt_Load(object sender, EventArgs e)
        {
            LoadArchive();

        }


        //----------------------- La méthode d'initialisation de ComboBox en chargher la feuil ---------------------
        private void LoadArchive()
        {
            string filePath = @"D:\GitHub\CDA_2005\C#\ExercicesWinform\CalculerPret\emprunt.txt";
            List<string> emprunts = new List<string>();
            //List<Pret> pret = new List<Pret>();
            emprunts = File.ReadAllLines(filePath).ToList();
            foreach (string emprunt in emprunts)
            {
                string[] items = emprunt.Split('-');
                    cbArchive.Items.Add(items[0] + "-" + items[1] + "-" + items[2] + "-" + items[3] + "-" + items[4]);
            }
            MettreAJourLIHM();
        }



        //----------------------- Select a client from list ---------------------
        private void cbArchive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] emprunts = cbArchive.SelectedItem.ToString().Split('-');
            txtName.Text = emprunts[0];
            txtCapital.Text = emprunts[1];
            listBoxPeriodicite.SelectedItem = emprunts[2];
            cp.Periodicite = emprunts[2];
            hScrollBarDureeMois.Value = int.Parse(emprunts[3]);
            lblScroll.Text = emprunts[3];
            cp.DureeEnMois = int.Parse(emprunts[3]);
            cp.Taux = Convert.ToInt32(Convert.ToDouble(emprunts[4])*1200/ cp.NombreDeMoisDePeriodicite());
            MettreAJourLIHM();
            cbArchive.Text = "";
        }
    }
}
