using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BL_PAPYRUS;
using DA_PAPYRUS;

namespace PAPYRUS
{
    public partial class Frm_Commandes : Form
    {
        BL_Frm_Commandes M;
        string mainCon = ConfigurationManager.ConnectionStrings["DB_PAPYRUS"].ConnectionString;
        public Frm_Commandes()
        {
            InitializeComponent();
            M = new BL_Frm_Commandes(mainCon);
            DataTable dt = M.Select();
            for (int i = 0; i < M.Select().Rows.Count; i++)
                cBoxFournisseurs.Items.Add(M.Select().Rows[i][1].ToString());
        }



        private void cBoxFournisseurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxFournisseurs.SelectedIndex == 0)
            {
                listBox_Commandes.Items.Clear();
                M = new BL_Frm_Commandes(mainCon);
                SqlDataReader dr = M.SelectAll();
                while (dr.Read())
                {
                    DateTime dd = (DateTime)dr["date_commande"];
                    listBox_Commandes.Items.Add(dr["id"].ToString() + "  -  " + dd.ToString("dd/MM/yyy") + "  -  " + dr["observations"].ToString());
                }
                M.UnLink();
            }
            else
            {
                listBox_Commandes.Items.Clear();
                M = new BL_Frm_Commandes(mainCon);
                M.Fornisseur = cBoxFournisseurs.SelectedItem.ToString();
                SqlDataReader dr1 = M.SelectID();
                dr1.Read();
                M.Id_f = dr1.GetInt32(0);    // ou  M.Id_f = (int)dr1["id_F"];
                M.UnLink();
                SqlDataReader dr = M.SelectOne();
                while (dr.Read())
                {
                    DateTime dd = (DateTime)dr["date_commande"];
                    listBox_Commandes.Items.Add(dr["id"].ToString() + "  -  " + dd.ToString("dd/MM/yyy") + "  -  " + dr["observations"].ToString());
                }
                M.UnLink();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
