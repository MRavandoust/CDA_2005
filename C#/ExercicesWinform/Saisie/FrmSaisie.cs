using CheckBoxEtRadioButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saisie
{
    public partial class FrmSaisie : Form
    {
        public FrmSaisie()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            FrmCheckBox checkB = new FrmCheckBox(txtSaisie.Text);
            checkB.MdiParent = this.MdiParent ;
            checkB.Show();
            txtSaisie.Text = "";
            this.Close();
        }
    }
}
