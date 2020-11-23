using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synthese
{
    public partial class SaisieTexe : Form
    {
        public SaisieTexe()
        {
            InitializeComponent();
            nbDInstance++;
            this.Text = nbDInstance.ToString();
        }

        private static int nbDInstance = 0;

        private void btnValider_Click_1(object sender, EventArgs e)
        {
            //FrmCheckBox checkB = new FrmCheckBox(txtSaisie.Text);
            //checkB.MdiParent = this.MdiParent ;
            //checkB.Show();

            txtSaisie.Text = "";
            this.Close();
        }
    }
}
