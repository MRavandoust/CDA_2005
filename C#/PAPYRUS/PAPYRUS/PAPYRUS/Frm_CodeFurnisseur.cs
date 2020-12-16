using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using BL_PAPYRUS;

namespace PAPYRUS
{
    public partial class Frm_CodeFurnisseur : Form
    {
        BL_Frm_RechercheFurnisseur M;
        string mainCon = ConfigurationManager.ConnectionStrings["DB_PAPYRUS"].ConnectionString;
        public static string ID;

        public Frm_CodeFurnisseur()
        {
            InitializeComponent();
            M = new BL_Frm_RechercheFurnisseur(mainCon);
            ID = txt_CodeFurnisseur.Text;
        }


        private void btn_Valider_Click(object sender, EventArgs e)
        {
            M.Code = txt_CodeFurnisseur.Text;
            SqlDataReader reader = M.Select();
            reader.Read();
            try
            {
                Frm_RechercheFurnisseur F = new Frm_RechercheFurnisseur(reader["id_F"].ToString(), reader["nom"].ToString(), reader["vile"].ToString(), reader["contact"].ToString(), reader["num_rue"].ToString(), reader["nom_rue"].ToString(), reader["code_postal"].ToString(), reader["satisfaction"].ToString());
                F.ShowDialog();
                M.UnLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                M.UnLink();
            }

        }

        private void txt_CodeFurnisseur_TextChanged(object sender, EventArgs e)
        {
            if(txt_CodeFurnisseur.Text=="")
                btn_Valider.Enabled = false;
            else
                btn_Valider.Enabled = true;
        }

        private void btn_Qitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
