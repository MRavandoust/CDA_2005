using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int chiffre = 0;
        private void Numbers(object sender, EventArgs e)
        {
            txtAffichage.Text += ((Button)sender).Text + "+";
            chiffre += Convert.ToInt32(((Button)sender).Text);
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            
            txtAffichage.Text += "=" + Convert.ToString(chiffre) + "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAffichage.Text = "";
            chiffre = 0;
        }

        private void Additionneur_Load(object sender, EventArgs e)
        {

        }
    }

}
