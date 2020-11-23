using Calculatrice;
using CalculerPret;
using CheckBoxEtRadioButton;
using Defilement;
using LesListesEtProprietes;
using ListBoxComboBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationSaisie;



namespace Synthese
{

    public partial class FrmMenu : Form
    {
        Login log = new Login();


        public FrmMenu()
        {
            InitializeComponent();
            toolStripStatusLabelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
        }


        private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {

            log.ShowDialog();
            if (log.IdentificationOk)
            {
                MessageBox.Show("Bienvenue");
                LoadWindows();
            }

        }


        public void LoadWindows()
        {
            phase1ToolStripMenuItem.Enabled = true;
            phase2ToolStripMenuItem.Enabled = true;
            phase3ToolStripMenuItem.Enabled = true;
            fenetresToolStripMenuItem.Enabled = true;
            toolStripSplitButtonPhase3.Enabled = true;
            toolStripButtonSaisie.Enabled = true;
            toolStripStatusLabelSIdentifier.Text = "S'identifier";

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelSIdentifier.Text = quitterToolStripMenuItem.Text;
            DialogResult x = MessageBox.Show("Fin de l'application ?", "Fin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                toolStripStatusLabelSIdentifier.Text = "";

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            log.ShowDialog();
            if (log.IdentificationOk)
            {
                MessageBox.Show("Bienvenue");
                LoadWindows();
            }
        }

        int childNumber = 1;
        private void calculatriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculatrice child = new FrmCalculatrice();
            child.MdiParent = this;
            child.Text += " N° " + childNumber++;
            child.Show();
            toolStripStatusLabelSIdentifier.Text = calculatriceToolStripMenuItem.Text;
        }

        int childNumber1 = 1;
        private void saisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaisieTexe child = new SaisieTexe();
            child.MdiParent = this;
            child.Text += " N° " + childNumber1++;
            child.Show();

            toolStripStatusLabelSIdentifier.Text = toolStripButtonSaisie.Text;
        }

        public void OpenForm(string str)
        {
            FrmCheckBox checkB = new FrmCheckBox(str);
            checkB.MdiParent = this.MdiParent ;
            checkB.Show();
        }
        //{
        //FrmCheckBox checkB = new FrmCheckBox(txtSaisie.Text);
        //checkB.MdiParent = this.MdiParent ;
        //    checkB.Show();
        //}
        //FrmChec}kBox

        int childNumber2 = 1;
        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCheckBox child = new FrmCheckBox();
            child.MdiParent = this;
            child.Text += " N° " + childNumber2++;
            child.Show();
            toolStripStatusLabelSIdentifier.Text = checkBoxToolStripMenuItem.Text;
        }
        int childNumber3 = 1;
        private void desListesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LesListes child = new LesListes();
            child.MdiParent = this;
            child.Text += " N° " + childNumber3++;
            child.Show();
            toolStripStatusLabelSIdentifier.Text = desListesToolStripMenuItem.Text;
        }
        int childNumber4 = 1;
        private void defilementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDefilement child = new FrmDefilement();
            child.MdiParent = this;
            child.Text += " N° " + childNumber4++;
            child.Show();
            toolStripStatusLabelSIdentifier.Text = defilementToolStripMenuItem.Text;
        }
        int childNumber5 = 1;
        private void listeComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeComboBox child = new FrmListeComboBox();
            child.MdiParent = this;
            child.Text += " N° " + childNumber5++;
            child.Show();
            toolStripStatusLabelSIdentifier.Text = listeComboBoxToolStripMenuItem.Text;
        }
        int childNumber6 = 1;
        private void syntheseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmprunt child = new FormEmprunt();
            child.MdiParent = this;
            child.Text += " N° " + childNumber6++;
            child.Show();
            toolStripStatusLabelSIdentifier.Text = syntheseToolStripMenuItem.Text;
        }

        private void checkBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCheckBox child = new FrmCheckBox();
            child.MdiParent = this;
            child.Text += " N° " + childNumber2++;
            child.Show();
            toolStripStatusLabelSIdentifier.Text = checkBoxToolStripMenuItem.Text;
        }

        private void desListesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LesListes child = new LesListes();
            child.MdiParent = this;
            child.Text += " N° " + childNumber3++;
            child.Show();
            toolStripStatusLabelSIdentifier.Text = desListesToolStripMenuItem1.Text;
        }

        private void defilementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDefilement child = new FrmDefilement();
            child.MdiParent = this;
            child.Text += " N° " + childNumber4++;
            child.Show();
            toolStripStatusLabelSIdentifier.Text = defilementToolStripMenuItem1.Text;
        }

        private void listeComboBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListeComboBox child = new FrmListeComboBox();
            child.MdiParent = this;
            child.Text += " N° " + childNumber5++;
            child.Show();
            toolStripStatusLabelSIdentifier.Text = listeComboBoxToolStripMenuItem1.Text;
        }

        private void syntheseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEmprunt child = new FormEmprunt();
            child.MdiParent = this;
            child.Text += " N° " + childNumber6++;
            child.Show();
            toolStripStatusLabelSIdentifier.Text = syntheseToolStripMenuItem1.Text;
        }


        private void fermerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            toolStripStatusLabelSIdentifier.Text = fermerToutToolStripMenuItem.Text;
        }

        private void arrangeWindows(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Text == "Cascade")
                LayoutMdi(MdiLayout.Cascade);
            if (((ToolStripMenuItem)sender).Text == "TileHorizontal")
                LayoutMdi(MdiLayout.TileHorizontal);
            if (((ToolStripMenuItem)sender).Text == "TileVertical")
                LayoutMdi(MdiLayout.TileVertical);

            foreach (ToolStripMenuItem x in fenetresToolStripMenuItem.DropDownItems)
            {
                if (x.Equals(sender))
                    x.Checked = true;
                else
                    x.Checked = false;
            }
        }

        private void toolStripButtonSaisie_Click(object sender, EventArgs e)
        {
            SaisieTexe child = new SaisieTexe();
            child.MdiParent = this;
            child.Text += " N° " + childNumber1++;
            child.Show();
            toolStripStatusLabelSIdentifier.Text = toolStripButtonSaisie.Text;
        }
    }
}
