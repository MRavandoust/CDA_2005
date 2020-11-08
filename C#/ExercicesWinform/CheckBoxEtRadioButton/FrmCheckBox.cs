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
    public partial class FrmCheckBox : Form
    {
        public FrmCheckBox()
        {
            InitializeComponent();
        }
        public FrmCheckBox(string msg)
        {
            InitializeComponent();
            txtPhrase.Text = msg;
        }

        string firstText = "";
        private void txtPhrase_TextChanged(object sender, EventArgs e)
        {
            lblResultat.Text = txtPhrase.Text;
            gBChoix.Enabled = true;
            if (lblResultat.Text == "")
            {
                chkBoxCouleurFond.Checked = false;
                chkBoxCouleurCaracteres.Checked = false;
                chkBoxCasse.Checked = false;
                gBChoix.Enabled = false;
                gBoxFond.Visible = false;
                gBoxCaracteres.Visible = false;
                gBoxCasse.Visible = false;

            }
            firstText = lblResultat.Text;
        }
        
        private void chkBoxCouleurFond_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxCouleurFond.Checked)
            {
                
                gBoxFond.Visible = true;
            }
            else
            {
                
                chkBoxCouleurFond.Checked = false;
                gBoxFond.Visible = false;
                rButtonRougeF.Checked = false;
                rButtonVertF.Checked = false;
                rButtonBleuF.Checked = false;
                lblResultat.BackColor = Color.Empty;
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
                rButtonRoogeC.Checked = false;
                rButtonVertC.Checked = false;
                rButtonNoirC.Checked = false;
                lblResultat.ForeColor = Color.Black;
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
                rButtonMin.Checked = false;
                rButtonMaj.Checked = false;
                lblResultat.Text = firstText;

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

        private void FrmCheckBox_Load(object sender, EventArgs e)
        {

        }
    }
}
