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
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollRouge_Scroll(object sender, ScrollEventArgs e)
        {
            lblColorRouge.BackColor = Color.FromArgb(hScrollRouge.Value, 0, 0);
            numUpDownRouge.Value = hScrollRouge.Value;
        }

        private void hScrollVert_Scroll(object sender, ScrollEventArgs e)
        {
            lblColorVert.BackColor = Color.FromArgb(0, hScrollVert.Value, 0);
            numUpDownVert.Value = hScrollVert.Value;
        }

        private void hScrollBleu_Scroll(object sender, ScrollEventArgs e)
        {
            lblColorBleu.BackColor = Color.FromArgb(0, 0, hScrollBleu.Value);
            numUpDownBleu.Value = hScrollBleu.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblColorVert.BackColor = Color.Black;
            lblColorBleu.BackColor = Color.Black;
            lblColorRouge.BackColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFinalColor.BackColor = Color.FromArgb(hScrollRouge.Value, hScrollVert.Value, hScrollBleu.Value);
        }

        private void numUpDownRouge_ValueChanged(object sender, EventArgs e)
        {
             hScrollRouge.Value = Convert.ToInt32(numUpDownRouge.Value);
        }

        private void numUpDownVert_ValueChanged(object sender, EventArgs e)
        {
            hScrollVert.Value = Convert.ToInt32(numUpDownVert.Value);
        }

        private void numUpDownBleu_ValueChanged(object sender, EventArgs e)
        {
            hScrollBleu.Value = Convert.ToInt32(numUpDownBleu.Value);
        }
    }
}
