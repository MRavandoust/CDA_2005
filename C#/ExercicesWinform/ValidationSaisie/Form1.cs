using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ClassLibraryToolsVerification;
using ClassLibraryFacture;

namespace ValidationSaisie
{
    public partial class FrmValidation : Form
    {
        public FrmValidation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        // ----------------------  Verification du Nom  ----------------------------
        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (!ClassVerifications.Name(this.txtNom.Text))
            {

                errorProvider1.SetError(txtNom, "Le text doit etre entre 2 à 30 lettres");
                errorProvider2.SetError(txtNom, "");
                txtNom.Focus();
            }
            else
            {
                errorProvider1.SetError(txtNom, "");
                errorProvider2.SetError(txtNom, "Correct");
            }
        }



        // ----------------------  Verification de la date ----------------------------
        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            if (!ClassVerifications.VerifDate(txtDate.Text))
            {
                errorProvider1.SetError(txtDate, "Le montant دoit être un nombre avec deux décimales");
                errorProvider2.SetError(txtDate, "");
                txtDate.Focus();
                //txtDate.SelectAll();
            }
            else
            {
                errorProvider1.SetError(txtDate, "");
                errorProvider2.SetError(txtDate, "Correct");
            }
        }


        // ----------------------  Verification du montant ----------------------------
        private void txtMontant_TextChanged_1(object sender, EventArgs e)
        {
            if (!ClassVerifications.Montant(txtMontant.Text))
            {
                errorProvider1.SetError(txtMontant, "Le montant دoit être un nombre avec deux décimales");
                errorProvider2.SetError(txtMontant, "");
                txtMontant.Focus();
                //txtMontant.SelectAll();
            }
            else
            {
                errorProvider1.SetError(txtMontant, "");
                errorProvider2.SetError(txtMontant, "Correct");
            }
        }



        // ---------------  Verification du code postal en quittant le champs du code postal -----------------
        private void txtCodePostal_TextChanged(object sender, EventArgs e)
        {
            if (!ClassVerifications.CodePostal(txtCodePostal.Text))
            {
                errorProvider1.SetError(txtCodePostal, "Le code postale doit être  chiffres");
                errorProvider2.SetError(txtCodePostal, "");
                txtCodePostal.Focus();
                //txtCodePostal.SelectAll();
            }
            else
            {
                errorProvider1.SetError(txtCodePostal, "");
                errorProvider2.SetError(txtCodePostal, "Correct");
            }
        }




        // --------------------------  Confirmation de la Fin d'application  ------------------------------
        private void FrmValidation_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Fin de l'application ?", "Fin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(x != DialogResult.Yes)
                e.Cancel = true;  
        }




        // --------------------------------  Button de validation -----------------------------------------
        private void btnValider_Click(object sender, EventArgs e)
        {
               if (txtNom.Text == "" || txtDate.Text == "" || txtMontant.Text == "" || txtCodePostal.Text == "")
            {
                MessageBox.Show("Il faut remplir tout les champs!");
                txtNom.Focus();
                return;
            }
                

            Facture MaFactur = new Facture(txtNom.Text, DateTime.Parse(txtDate.Text), Convert.ToDouble(txtMontant.Text), Convert.ToInt32(txtCodePostal.Text));

            if (MaFactur.DateIsValid())
            {
                MessageBox.Show("Nom : " + txtNom.Text + "\n"
                + "Date : " + txtDate.Text + "\n"
                + "Montant : " + txtMontant.Text + "\n"
                + "Code Postal : " + txtCodePostal.Text, "Récapitulatif");
            }
            else
            {
                MessageBox.Show("La date n'est pas Valid");
                txtDate.Focus();
            }
            
        }





        // ------------------------------------  Vider tout les champs  -------------------------------------
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            errorProvider1.SetError(txtNom, "");
            errorProvider2.SetError(txtNom, "");
            txtDate.Text = "";
            errorProvider1.SetError(txtDate, "");
            errorProvider2.SetError(txtDate, "");
            txtMontant.Text = "";
            errorProvider1.SetError(txtMontant, "");
            errorProvider2.SetError(txtMontant, "");
            txtCodePostal.Text = "";
            errorProvider1.SetError(txtCodePostal, "");
            errorProvider2.SetError(txtCodePostal, "");
            txtNom.Focus();
        }

        
    }
}
