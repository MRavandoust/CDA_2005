using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library3Layer
{
    public partial class Frm_Library : Form
    {
        public Frm_Library()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Frm_Add_Book fo2 = new Frm_Add_Book();
            fo2.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_Search fo3 = new Frm_Search();
            fo3.ShowDialog();
        }
    }
}
