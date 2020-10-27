using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Defilement
{
    public partial class Form1 : Form
    {
        private Color couleurChoisie;
        public Form1()
        {
            InitializeComponent();
            couleurChoisie = Color.FromArgb(0, 0, 0);
            MiseAJourDeLaVue();
        }

        public void MiseAJourDeLaVue()
        {
            this.hScrollRouge.Value = couleurChoisie.R;
            this.numUpDownRouge.Value = couleurChoisie.R;
            this.lblColorRouge.BackColor = Color.FromArgb(couleurChoisie.R, 0 , 0);
            this.hScrollVert.Value = couleurChoisie.G;
            this.numUpDownVert.Value = couleurChoisie.G;
            this.lblColorVert.BackColor = Color.FromArgb( 0, couleurChoisie.G, 0);
            this.hScrollBleu.Value = couleurChoisie.B;
            this.numUpDownBleu.Value = couleurChoisie.B;
            this.lblColorBleu.BackColor = Color.FromArgb(0, 0, couleurChoisie.B);
            this.lblFinalColor.BackColor = Color.FromArgb(couleurChoisie.R, couleurChoisie.G, couleurChoisie.B);
            lblCouleurFinal.Text = "RGB( " + this.hScrollRouge.Value.ToString() + ", " + this.hScrollVert.Value.ToString() + ", " + this.hScrollBleu.Value.ToString() + " )";
        }

        private void hScrollRouge_Scroll(object sender, ScrollEventArgs e)
        {
            couleurChoisie = Color.FromArgb(hScrollRouge.Value, couleurChoisie.G, couleurChoisie.B);
            MiseAJourDeLaVue();
        }



        private void hScrollVert_Scroll(object sender, ScrollEventArgs e)
        {
            couleurChoisie = Color.FromArgb(couleurChoisie.R, hScrollVert.Value, couleurChoisie.B);
            MiseAJourDeLaVue();
        }

        private void hScrollBleu_Scroll(object sender, ScrollEventArgs e)
        {
            couleurChoisie = Color.FromArgb(couleurChoisie.R, couleurChoisie.G, hScrollBleu.Value);
            MiseAJourDeLaVue();
        }


        private void numUpDownRouge_ValueChanged(object sender, EventArgs e)
        {
            hScrollRouge.Value = Convert.ToInt32(numUpDownRouge.Value);
            couleurChoisie = Color.FromArgb(hScrollRouge.Value, couleurChoisie.G, couleurChoisie.B);
            MiseAJourDeLaVue();
        }

        private void numUpDownVert_ValueChanged(object sender, EventArgs e)
        {
            hScrollVert.Value = Convert.ToInt32(numUpDownVert.Value);
            couleurChoisie = Color.FromArgb(couleurChoisie.R, hScrollVert.Value, couleurChoisie.B);
            MiseAJourDeLaVue();
        }

        private void numUpDownBleu_ValueChanged(object sender, EventArgs e)
        {
            hScrollBleu.Value = Convert.ToInt32(numUpDownBleu.Value);
            couleurChoisie = Color.FromArgb(couleurChoisie.R, couleurChoisie.G, hScrollBleu.Value);
            MiseAJourDeLaVue();
        }
    }
}
