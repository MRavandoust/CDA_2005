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
        static string mainCon = ConfigurationManager.ConnectionStrings["DB_PAPYRUS"].ConnectionString;
       

        //Data Source=DESKTOP-EV6M1K5;Initial Catalog=DB_PAPYRUS;Integrated Security=True

        public Frm_Connexion()
        {
            InitializeComponent();
            M = new BL_Frm_Connexion(mainCon);
        }
        
        
        private void btn_Connexion_Click(object sender, EventArgs e)
        {

            try
            {
                M.Link();
                lbl_Etat.Text = M.Con.State.ToString();
            }
            catch(SqlException se)
            {
                txt_EtatDeConnexion.Text = se.Message.ToString();
            }
            finally
            {
                M.UnLink();
            }
            
            //txt_Serveur.Text = M.Con.DataSource.ToString();
            //txt_BaseDeDonnees.Text = M.Con.Database.ToString();
        }

        private void btn_Deconnexion_Click(object sender, EventArgs e)
        {
            M.UnLink();
            lbl_Etat.Text = M.Con.State.ToString();
            txt_Serveur.Clear();
            txt_BaseDeDonnees.Clear();
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
