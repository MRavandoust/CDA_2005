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

namespace ValidationSaisie
{
    public partial class FrmValidation : Form
    {
        Regex nomRegex = new Regex(@"[a-zA-Z]{2,30}");
        Regex dateRegex = new Regex(@"(\d{2})/(\d{2})/(\d{4})");
        Regex montantRegex = new Regex(@"(\d+\.\d{2})");
        Regex codePostalRegex = new Regex(@"\d{5}");
        public FrmValidation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

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

            if (!dateRegex.IsMatch(txtDate.Text))
            {
                MessageBox.Show("Le texte saisi n'est pas conforme à la réglementation", "Attention");
                txtDate.Focus();
                txtDate.SelectAll();
            }
                
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nom : " + txtNom.Text + "\n" 
                + "Date : " + txtDate.Text + "\n" 
                + "Montant : " + txtMontant.Text + "\n" 
                + "Code Postal : " + txtCodePostal.Text , "Récapitulatif");
        }


        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (!nomRegex.IsMatch(txtNom.Text))
            {
                MessageBox.Show("Le texte saisi n'est pas conforme à la réglementation", "Attention");
                txtNom.Focus();
                txtNom.SelectAll();
            }
                
        }

        private void txtMontant_Leave(object sender, EventArgs e)
        {
            if (!montantRegex.IsMatch(txtMontant.Text))
            {
                MessageBox.Show("Le texte saisi n'est pas conforme à la réglementation", "Attention");
                txtMontant.Focus();
                txtMontant.SelectAll();
            }
        }

        private void txtCodePostal_Leave(object sender, EventArgs e)
        {
            if (!codePostalRegex.IsMatch(txtCodePostal.Text))
            {
                MessageBox.Show("Le texte saisi n'est pas conforme à la réglementation", "Attention");
                txtCodePostal.Focus();
                txtCodePostal.SelectAll();
            }
        }

        private void FrmValidation_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Fin de l'application ?", "Fin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(x != DialogResult.Yes)
                e.Cancel = true;

           // Application.Exit();
           // else
                
        }

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
