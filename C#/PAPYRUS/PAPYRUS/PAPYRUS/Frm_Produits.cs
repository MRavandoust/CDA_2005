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
    public partial class Frm_Produits : Form
    {
        string mainCon = ConfigurationManager.ConnectionStrings["DB_PAPYRUS"].ConnectionString;
        BL_Frm_Produits M;
        public Frm_Produits()
        {
            InitializeComponent();
        }

        private void Frm_Produits_Load(object sender, EventArgs e)
        {
            M = new BL_Frm_Produits(mainCon);
            //dataGridView1.DataSource = M.Select().Tables[0];
            DataSet d = M.Select();
            List<string> produits = new List<string>();
            foreach (DataRow dr in d.Tables[0].Rows)
            {
                produits.Add(dr["libelle"].ToString());
            }
            listBox_Produits.DataSource = produits;
        }

        private void listBox_Produits_SelectedIndexChanged(object sender, EventArgs e)
        {
            M = new BL_Frm_Produits(mainCon);
            M.Libelle = listBox_Produits.SelectedItem.ToString();
            SqlDataReader dr = M.SelectRead();
            dr.Read();
            txt_Code.Text = dr["id_Prod"].ToString();
            txt_Libelle.Text = dr["libelle"].ToString();
            txt_Stock_Alert.Text = dr["stock_alert"].ToString();
            txt_Stock_Ph.Text = dr["stock_phys"].ToString();
            txt_Q_Annuelle.Text = dr["qt_annuelle"].ToString();
            txt_Unite.Text = dr["unite_mesure"].ToString();
            M.UnLink();
        }




        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            btn_MAJ.Enabled = true;
            btn_Supprimer.Enabled = true;
            txt_Code.Enabled = true;
            txt_Libelle.Enabled = true;
            txt_Stock_Alert.Enabled = true;
            txt_Stock_Ph.Enabled = true;
            txt_Q_Annuelle.Enabled = true;
            txt_Unite.Enabled = true;
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            btn_MAJ.Enabled = false;
            btn_Supprimer.Enabled = false;
            txt_Code.Enabled = false;
            txt_Libelle.Enabled = false;
            txt_Stock_Alert.Enabled = false;
            txt_Stock_Ph.Enabled = false;
            txt_Q_Annuelle.Enabled = false;
            txt_Unite.Enabled = false;
        }

        private void Btn_MAJ_Click(object sender, EventArgs e)
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
                M.MiseAJour();
                MessageBox.Show("Le produit a été mise à jour avec succès !");
                Frm_Produits_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            M = new BL_Frm_Produits(mainCon);
            M.Id = txt_Code.Text;
            DialogResult y = MessageBox.Show("Voulez-vous supprimer ce produit? \n\n", "Suppression du produit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (y == DialogResult.Yes)
            {
                try
                {
                    M.Delete();
                    MessageBox.Show("Le produit a été supprimer avec succès !");
                    Frm_Produits_Load(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btn_Creer_Click(object sender, EventArgs e)
        {
            Frm_Produits_Creer fr = new Frm_Produits_Creer();
            fr.ShowDialog();
        }

        private void Frm_Produits_Activated(object sender, EventArgs e)
        {
            Frm_Produits_Load(null, null);
        }
    }
}
