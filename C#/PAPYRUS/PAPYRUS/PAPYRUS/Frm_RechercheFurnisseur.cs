using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using BL_PAPYRUS;

namespace PAPYRUS
{
    public partial class Frm_RechercheFurnisseur : Form
    {
        string mainCon = ConfigurationManager.ConnectionStrings["DB_PAPYRUS"].ConnectionString;
        public Frm_RechercheFurnisseur()
        {
            InitializeComponent();
        }
        private string ID;
        public Frm_RechercheFurnisseur(string id, string nom, string ville, string contact, string nombr, string rue, string cp, string satisfaction )
        {
            InitializeComponent();
            txt_Nom.Text = nom;
            txt_Num_Rue.Text = nombr.ToString();
            txt_Rue.Text = rue;
            txt_CP.Text = cp.ToString();
            txt_Ville.Text = ville;
            txt_Contact.Text = contact;
            txt_Satisfaction.Text = satisfaction.ToString();
            ID = id;
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Creer_Click(object sender, EventArgs e)
        {
            Frm_Creer_Fournisseur fr = new Frm_Creer_Fournisseur();
            fr.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            BL_Frm_RechercheFurnisseur M = new BL_Frm_RechercheFurnisseur(mainCon);
            M.Code = ID;
            M.Nom = txt_Nom.Text;
            M.Num_Rue =Convert.ToInt32(txt_Num_Rue.Text);
            M.Nom_Rue = txt_Rue.Text;
            M.Contact = txt_Contact.Text;
            M.Satisfaction = Convert.ToInt32(txt_Satisfaction.Text);
            M.CP = Convert.ToInt32(txt_CP.Text);
            M.Ville = txt_Ville.Text;
            try
            {
                M.Update();
                MessageBox.Show("Le fournisseur a été mise à jour avec succès !");
            }
            catch(SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            BL_Frm_RechercheFurnisseur M = new BL_Frm_RechercheFurnisseur(mainCon);
            BL_Frm_Commandes N = new BL_Frm_Commandes(mainCon);
            M.Code = ID;
            N.Id = Convert.ToInt32(ID);
            DialogResult x = MessageBox.Show("Voulez-vous vraiment supprimer ce fournisseur?", "Suppression du fournisseur", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(x == DialogResult.Yes)
            {
                try
                {
                    M.Delete();
                    MessageBox.Show("Le fournisseur a été supprimer avec succès !");
                    this.Close();
                }
                catch(Exception ep)
                {
                    DialogResult y = MessageBox.Show("Ce fournisseur a des commandes !. \n Voulez-vous supprimer toutes? \n\n" , "Suppression du fournisseur", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (y == DialogResult.Yes)
                    {
                        N.Delete();
                        M.UnLink();
                        M.Delete();
                        MessageBox.Show("Le fournisseur a été supprimer avec succès !");
                        this.Close();
                    }
                }
               
            }

        }
    }
}
