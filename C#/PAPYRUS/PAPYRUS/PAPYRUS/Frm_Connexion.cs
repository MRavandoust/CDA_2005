using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BL_PAPYRUS;
using DA_PAPYRUS;


namespace PAPYRUS
{
    public partial class Frm_Connexion : Form
    {
        BL_Frm_Connexion M;

        public Frm_Connexion()
        {
            InitializeComponent();
            M = new BL_Frm_Connexion();
        }
        
        
        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            M.Serveur = txt_Serveur.Text;
            M.BaseDeDonnees = txt_BaseDeDonnees.Text;
            SqlConnection con = M.Connexion();
            try
            {
                con.Open();
                lbl_Etat.Text = con.State.ToString();
            }
            catch(SqlException se)
            {
                txt_EtatDeConnexion.Text = se.Message.ToString();
            }
            finally
            {
                con.Close();
            }

        }

        private void btn_Deconnexion_Click(object sender, EventArgs e)
        {
            SqlConnection con = M.Connexion();
            con.Close();
            lbl_Etat.Text = con.State.ToString();
            //txt_Serveur.Clear();
            //txt_BaseDeDonnees.Clear();
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
