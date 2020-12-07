using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductionCaisse;


namespace ToutEmbal_v2
{
    public partial class Frm_ToutEmbal : Form
    {
        Random rnd = new Random();
        public Frm_ToutEmbal()
        {
            InitializeComponent();
            production.Add(new ProductionCaissess.ProductionCaisse("A", 1000));
            production.Add(new ProductionCaissess.ProductionCaisse("B", 5000));
            production.Add(new ProductionCaissess.ProductionCaisse("C", 10000));
        }

        List<ProductionCaissess.ProductionCaisse> production = new List<ProductionCaissess.ProductionCaisse>();

        

        public void ResetIHM()
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar_A.Value == 100)
            {
                timer1.Stop();
                aToolStripMenuItem.Enabled = true;
                aToolStripMenuItem1.Enabled = false;
                aToolStripMenuItem2.Enabled = false;
            }
            else
            {
                progressBar_A.Increment(1);
                txtNombr_A.Text = (progressBar_A.Value * production[0].Rythme()).ToString();
                txtTauxDefautDDemarrage_A.Text = rnd.NextDouble().ToString("N4");
                txtTauxDefautHeure_A.Text = rnd.NextDouble().ToString("N4");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(progressBar_B.Value == 100)
            {
                timer2.Stop();
                bToolStripMenuItem.Enabled = true;
                bToolStripMenuItem1.Enabled = false;
                bToolStripMenuItem2.Enabled = false;
            }
            else
            {
                progressBar_B.Increment(1);
                txtNombr_B.Text = (progressBar_B.Value * production[1].Rythme()).ToString();
                txtTauxDefautDDemarrage_B.Text = rnd.NextDouble().ToString("N4");
                txtTauxDefautHeure_B.Text = rnd.NextDouble().ToString("N4");
            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (progressBar_C.Value == 100)
            {
                timer3.Stop();
                cToolStripMenuItem.Enabled = true;
                cToolStripMenuItem1.Enabled = false;
                cToolStripMenuItem2.Enabled = false;
            }
            else
            {
                progressBar_C.Increment(1);
                txtNombr_C.Text = (progressBar_C.Value * production[2].Rythme()).ToString();
                txtTauxDefautDDemarrage_C.Text = rnd.NextDouble().ToString("N4");
                txtTauxDefautHeure_C.Text = rnd.NextDouble().ToString("N4");
            }
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
