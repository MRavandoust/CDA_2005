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

        // ---------------------------------  Watermark du champs de la date ------------------------------
        private void txtDate_Enter(object sender, EventArgs e)
        {
            if (txtDate.Text == "JJ/MM/AAAA")
            {
                txtDate.Text = "";
                txtDate.ForeColor = Color.Black;
            }
        }

        private void txtDate_Leave(object sender, EventArgs e)
        {
            if (txtDate.Text == "")
            {
                txtDate.Text = "JJ/MM/AAAA";
                txtDate.ForeColor = Color.Silver;
            }

            if (!ClassVerifications.VerifDate(txtDate.Text))
            {
                MessageBox.Show("Le texte saisi n'est pas conforme à la réglementation", "Attention");
                txtDate.Focus();
                txtDate.SelectAll();
            }
                
        }


        // --------------------------------  Button de validation -----------------------------------------
        private void btnValider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nom : " + txtNom.Text + "\n" 
                + "Date : " + txtDate.Text + "\n" 
                + "Montant : " + txtMontant.Text + "\n" 
                + "Code Postal : " + txtCodePostal.Text , "Récapitulatif");
        }



        // ----------------------  Verification du Nom en quittant le champs du nom ----------------------------
        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (!ClassVerifications.Name(this.txtNom.Text))
            {
                MessageBox.Show("Le texte saisi n'est pas conforme à la réglementation", "Attention");
                txtNom.Focus();
                txtNom.SelectAll();
            }
                
        }


        // ---------------  Verification du montant en quittant le champs du montant ---------------------------
        private void txtMontant_Leave(object sender, EventArgs e)
        {
            if (!ClassVerifications.Montant(txtMontant.Text))
            {
                MessageBox.Show("Le texte saisi n'est pas conforme à la réglementation", "Attention");
                txtMontant.Focus();
                txtMontant.SelectAll();
            }
        }



        // ---------------  Verification du code postal en quittant le champs du code postal -----------------
        private void txtCodePostal_Leave(object sender, EventArgs e)
        {
            if (!ClassVerifications.CodePostal(txtCodePostal.Text))
            {
                MessageBox.Show("Le texte saisi n'est pas conforme à la réglementation", "Attention");
                txtCodePostal.Focus();
                txtCodePostal.SelectAll();
            }
        }


        // --------------------------  Confirmation de la Fin d'application  ------------------------------
        private void FrmValidation_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Fin de l'application ?", "Fin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(x != DialogResult.Yes)
                e.Cancel = true;  
        }


        // ------------------------------------  Vider tout les champs  -------------------------------------
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtDate.Text = "";
            txtMontant.Text = "";
            txtCodePostal.Text = "";
            txtNom.Focus();
        }
    }
}
