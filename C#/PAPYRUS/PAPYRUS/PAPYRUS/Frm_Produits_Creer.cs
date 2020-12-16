using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_PAPYRUS;
using BL_PAPYRUS;

namespace PAPYRUS
{
    public partial class Frm_Produits_Creer : Form
    {

        string mainCon = ConfigurationManager.ConnectionStrings["DB_PAPYRUS"].ConnectionString;
        BL_Frm_Produits M;

        public Frm_Produits_Creer()
        {
            InitializeComponent();
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            M = new BL_Frm_Produits(mainCon);
            M.Id = txt_Code.Text;
            M.Libelle = txt_Libelle.Text;
            M.Stock_A = Convert.ToInt32(txt_Stock_Alert.Text);
            M.Stock_P = Convert.ToInt32(txt_Stock_Ph.Text);
            M.Quantite_A = Convert.ToInt32(txt_Q_Annuelle.Text);
            M.Unite_Mesure = txt_Unite.Text;
            try
            {
                M.Add();
                MessageBox.Show("Le produit a été ajouter avec succès !");
                //txt_Code.Text = "";
                txt_Libelle.Text = "";
                txt_Stock_Alert.Text = "";
                txt_Stock_Ph.Text = "";
                txt_Q_Annuelle.Text = "";
                txt_Unite.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
