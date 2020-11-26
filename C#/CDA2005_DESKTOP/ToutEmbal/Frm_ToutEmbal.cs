using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductionCaisses;


namespace ToutEmbal
{
    public partial class Frm_ToutEmbal : Form
    {
        Random rnd = new Random();
        public Frm_ToutEmbal()
        {
            InitializeComponent();
            txtTauxDefautDDemarrage_A.Text = rnd.NextDouble().ToString("N4");
            txtTauxDefautHeure_A.Text = rnd.NextDouble().ToString("N4");
            txtTauxDefautDDemarrage_B.Text = rnd.NextDouble().ToString("N4");
            txtTauxDefautHeure_B.Text = rnd.NextDouble().ToString("N4");
            txtTauxDefautDDemarrage_C.Text = rnd.NextDouble().ToString("N4");
            txtTauxDefautHeure_C.Text = rnd.NextDouble().ToString("N4");
        }
        
        Caisse caisseA = new Caisse(ProductionCaisses.Type.A);
        Caisse caisseB = new Caisse(ProductionCaisses.Type.B);
        Caisse caisseC = new Caisse(ProductionCaisses.Type.C);
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar_A.Increment(1);
            txtNombr_A.Text = (progressBar_A.Value*caisseA.Rythme()).ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar_B.Increment(1);
            txtNombr_B.Text = (progressBar_B.Value * caisseB.Rythme()).ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar_C.Increment(1);
            txtNombr_C.Text = (progressBar_C.Value * caisseC.Rythme()).ToString();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
            aToolStripMenuItem.Enabled = false;
            aToolStripMenuItem1.Enabled = true;
            aToolStripMenuItem2.Enabled = false;
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer2.Start();
            bToolStripMenuItem.Enabled = false;
            bToolStripMenuItem1.Enabled = true;
            bToolStripMenuItem2.Enabled = false;
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer3.Start();
            cToolStripMenuItem.Enabled = false;
            cToolStripMenuItem1.Enabled = true;
            cToolStripMenuItem2.Enabled = false;
        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            aToolStripMenuItem1.Enabled = false;
            aToolStripMenuItem2.Enabled = true;
        }

        private void bToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            bToolStripMenuItem1.Enabled = false;
            bToolStripMenuItem2.Enabled = true;
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            cToolStripMenuItem1.Enabled = false;
            cToolStripMenuItem2.Enabled = true;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
