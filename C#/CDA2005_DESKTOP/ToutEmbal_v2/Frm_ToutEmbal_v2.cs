using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using ProductionCaisses;


namespace ToutEmbal_v2
{
    public partial class Frm_ToutEmbal_v2 : Form
    {

        List<Production> production = new List<Production>();
        Random rnd = new Random();
        
        public Frm_ToutEmbal_v2()
        {
            InitializeComponent();
            production.Add(new Production("A", 1000, 3600));
            production.Add(new Production("B", 5000, 7200));
            production.Add(new Production("C", 10000, 14400));

            production[0].NbCaisseChange += Production_NbCaisseChange;
            production[1].NbCaisseChange += Production_NbCaisseChange;
            production[2].NbCaisseChange += Production_NbCaisseChange;

        }


        private void Production_NbCaisseChange(Production sender, Statut statut)
        {
            ResetIHM();
        }




        //private void MiseAjourIHM()
        //{
        //    this.ActiverDesactiverBoutonsActions();
        //    this.ProgressBarsAJour();
        //    this.StatutProductionLabelAJour();
        //    this.TauxDefautHeureAJour();
        //    this.TauxDefautDepuisDemarrageAJour();
        //    this.NombreCaissesDepuisDemarrageAjour();
        //    this.AvancementAJour();
        //}


        public void ResetIHM()
        {
            ResetProgressBar();
            ResetNbCaisseDDemarrage();
            StatusLabelUpdate();
        }


        private void ResetProgressBar()
        {
            progressBar_A.Invoke((MethodInvoker)(() => progressBar_A.Value = production[0].CalculAvancement()));
            progressBar_B.Invoke((MethodInvoker)(() => progressBar_B.Value = production[1].CalculAvancement()));
            progressBar_C.Invoke((MethodInvoker)(() => progressBar_C.Value = production[2].CalculAvancement()));
        }

        private void ResetNbCaisseDDemarrage()
        {
            txtNombr_A.Invoke((MethodInvoker)(() => txtNombr_A.Text = production[0].NbDepuisDemarrage.ToString()));
            txtNombr_B.Invoke((MethodInvoker)(() => txtNombr_B.Text = production[1].NbDepuisDemarrage.ToString()));
            txtNombr_C.Invoke((MethodInvoker)(() => txtNombr_C.Text = production[2].NbDepuisDemarrage.ToString()));
        }


        private void StatusLabelUpdate()
        {
            toolStripStatusLabel_A.Text = production[0].StatutPrd.ToString();
            toolStripStatusLabel_B.Text = production[1].StatutPrd.ToString();
            toolStripStatusLabel_C.Text = production[2].StatutPrd.ToString();
        }


        private void AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            production[0].Demarrer();
            ResetIHM();

            aToolStripMenuItem.Enabled = false;
            aToolStripMenuItem1.Enabled = true;
            aToolStripMenuItem2.Enabled = false;
        }



        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {

            production[1].Demarrer();
            ResetIHM();

            bToolStripMenuItem.Enabled = false;
            bToolStripMenuItem1.Enabled = true;
            bToolStripMenuItem2.Enabled = false;
        }


        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            production[2].Demarrer();
            ResetIHM();

            cToolStripMenuItem.Enabled = false;
            cToolStripMenuItem1.Enabled = true;
            cToolStripMenuItem2.Enabled = false;
        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            production[0].Suspendre();
            ResetIHM();

            aToolStripMenuItem1.Enabled = false;
            aToolStripMenuItem2.Enabled = true;
        }

        private void bToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            production[1].Suspendre();
            ResetIHM();

            bToolStripMenuItem1.Enabled = false;
            bToolStripMenuItem2.Enabled = true;
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            production[2].Suspendre();
            ResetIHM();

            cToolStripMenuItem1.Enabled = false;
            cToolStripMenuItem2.Enabled = true;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ToutEmbal_v2_FormClosing(this, null);
        }

        private void btn_Green_A_Click(object sender, EventArgs e)
        {
            tabControlA.SelectedTab = tabPage1;
            production[0].Demarrer();
            ResetIHM();
            btn_Green_A.Enabled = false;
            btn_Red_A.Enabled = true;
        }

        private void btn_Red_A_Click(object sender, EventArgs e)
        {
            tabControlA.SelectedTab = tabPage1;
            production[0].Suspendre();
            ResetIHM();
            btn_Red_A.Enabled = false;
            btn_Yellow_A.Enabled = true;
        }

        private void btn_Yellow_A_Click(object sender, EventArgs e)
        {
            tabControlA.SelectedTab = tabPage1;
            production[0].Demarrer();
            ResetIHM();
            btn_Yellow_A.Enabled = false;
            btn_Red_A.Enabled = true;
        }

        private void btn_Green_B_Click(object sender, EventArgs e)
        {
            tabControlA.SelectedTab = tabPage2;
            production[1].Demarrer();
            ResetIHM();
            btn_Green_B.Enabled = false;
            btn_Red_B.Enabled = true;
        }

        private void btn_Red_B_Click(object sender, EventArgs e)
        {
            tabControlA.SelectedTab = tabPage2;
            production[1].Suspendre();
            ResetIHM();
            btn_Red_B.Enabled = false;
            btn_Yellow_B.Enabled = true;
        }

        private void btn_Yellow_B_Click(object sender, EventArgs e)
        {
            tabControlA.SelectedTab = tabPage2;
            production[1].Demarrer();
            ResetIHM();
            btn_Yellow_B.Enabled = false;
            btn_Red_B.Enabled = true;
        }

        private void btn_Green_C_Click(object sender, EventArgs e)
        {
            tabControlA.SelectedTab = tabPage3;
            production[2].Demarrer();
            ResetIHM();
            btn_Green_C.Enabled = false;
            btn_Red_C.Enabled = true;
        }

        private void btn_Red_C_Click(object sender, EventArgs e)
        {
            tabControlA.SelectedTab = tabPage3;
            production[2].Suspendre();
            ResetIHM();
            btn_Red_C.Enabled = false;
            btn_Yellow_C.Enabled = true;
        }

        private void btn_Yellow_C_Click(object sender, EventArgs e)
        {
            tabControlA.SelectedTab = tabPage3;
            production[2].Demarrer();
            ResetIHM();
            btn_Yellow_C.Enabled = false;
            btn_Red_C.Enabled = true;
        }

        private void Frm_ToutEmbal_v2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show
           ("Fin de l’application", "Quitter",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                Environment.Exit(0);
                //Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            toolStripStatusLabel_Time.Text = time.ToString("HH:mm:ss");
        }
    }
}
