using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxEtRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPhrase_TextChanged(object sender, EventArgs e)
        {
            lblResultat.Text = txtPhrase.Text;
            gBChoix.Enabled = true;
            if(lblResultat.Text=="")
                gBChoix.Enabled = false;
        }

        private void chkBoxCouleurFond_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxCouleurFond.Checked)
            {
                
                gBoxFond.Visible = true;
            }
            
            
        }

        private void chkBoxCouleurCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxCouleurCaracteres.Checked)
            {

                gBoxCaracteres.Visible = true;
            }
            else
            {
                chkBoxCouleurCaracteres.Checked = false;
                gBoxCaracteres.Visible = false;
            }
        }

        private void chkBoxCasse_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxCasse.Checked)
            {

                gBoxCasse.Visible = true;
            }
            else
            {
                chkBoxCasse.Checked = false;
                gBoxCasse.Visible = false;
            }
        }

        private void rButtonRougeF_CheckedChanged(object sender, EventArgs e)
        {
            lblResultat.BackColor = Color.Red;
        }

        private void rButtonVertF_CheckedChanged(object sender, EventArgs e)
        {
            lblResultat.BackColor = Color.Green;
        }

        private void rButtonBleuF_CheckedChanged(object sender, EventArgs e)
        {
            lblResultat.BackColor = Color.Blue;
        }

        private void rButtonRoogeC_CheckedChanged(object sender, EventArgs e)
        {
            lblResultat.ForeColor = Color.Red;
        }

        private void rButtonVertC_CheckedChanged(object sender, EventArgs e)
        {
            lblResultat.ForeColor = Color.Green;
        }

        private void rButtonNoirC_CheckedChanged(object sender, EventArgs e)
        {
            lblResultat.ForeColor = Color.Black;
        }

        private void rButtonMin_CheckedChanged(object sender, EventArgs e)
        {
            lblResultat.Text=lblResultat.Text.ToLower();
        }

        private void rButtonMaj_CheckedChanged(object sender, EventArgs e)
        {
            lblResultat.Text = lblResultat.Text.ToUpper();
        }
    }
}
