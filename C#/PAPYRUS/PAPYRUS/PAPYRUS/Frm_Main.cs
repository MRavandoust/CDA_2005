using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAPYRUS
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            Frm_Connexion fr = new Frm_Connexion();
            fr.ShowDialog();
        }

        private void btn_Fournisseur_Click(object sender, EventArgs e)
        {
            Frm_CodeFurnisseur fr = new Frm_CodeFurnisseur();
            fr.ShowDialog();
        }

        private void btn_Produits_Click(object sender, EventArgs e)
        {
            Frm_Produits fr = new Frm_Produits();
            fr.ShowDialog();
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
