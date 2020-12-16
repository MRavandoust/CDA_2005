using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_PAPYRUS;
using BL_PAPYRUS;

namespace PAPYRUS
{
    public partial class Frm_Creer_Fournisseur : Form
    {
        BL_Frm_Creer_Fournisseur M;
        string mainCon = ConfigurationManager.ConnectionStrings["DB_PAPYRUS"].ConnectionString;
        public Frm_Creer_Fournisseur()
        {
            InitializeComponent();
            M = new BL_Frm_Creer_Fournisseur(mainCon);
        }


        private void btn_Creer_Click(object sender, EventArgs e)
        {
            M.Nom = txt_Nom.Text;
            M.Num_Rue = Convert.ToInt32(txt_Num_Rue.Text);
            M.Nom_Rue = txt_Rue.Text;
            M.CP = Convert.ToInt32(txt_CP.Text);
            M.Ville = txt_Ville.Text;
            M.Contact = txt_Contact.Text;
            M.Satisfaction = Convert.ToInt32(txt_Satisfaction.Text);
            try
            {
                M.CommandTXT();
                MessageBox.Show("Le fournisseur a été ajouter avec succès!");
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btn_Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
