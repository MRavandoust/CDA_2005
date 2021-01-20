using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryPersistance
{
    public class PersistanceTrouveUnEmploi
    {

        public SqlConnection CommentRecupererConnexion()
        {
            SqlConnection connexion = new SqlConnection();
            connexion.ConnectionString= ConfigurationManager.ConnectionStrings["TrouveUnEmploi_BD"].ConnectionString;
            return connexion;
        }



        public void AddDemandeurDEmploi()
        {
            SqlConnection connexion = CommentRecupererConnexion();

            if (connexion.State != System.Data.ConnectionState.Open)
            {
                connexion.Open();
            }
            try
            {
                //SqlCommand cmd = new SqlCommand("AddDemandeurDEmploi", connexion);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add(new SqlParameter("NSecu", this.numeroSecuriteSocial));
                //cmd.Parameters.Add(new SqlParameter("Nom", this.nom));
                //cmd.Parameters.Add(new SqlParameter("Prenom", this.prenom));
                //cmd.Parameters.Add(new SqlParameter("Date", this.dateDInscription));
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Demandeur d'emploi a été ajouté avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        //public bool Sauvegarder(...)
        //{

        // acoder 
        //}
    }
}
