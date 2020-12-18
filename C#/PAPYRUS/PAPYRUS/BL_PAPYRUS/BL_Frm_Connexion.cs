using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DA_PAPYRUS;

namespace BL_PAPYRUS
{
    public class BL_Frm_Connexion
    {
        public string Serveur;
        public string BaseDeDonnees;

        //DESKTOP-EV6M1K5
        //PAPYRUS

        public SqlConnection Connexion()
        {
            string link = "Data Source='{0}';Initial Catalog='{1}';Integrated Security=True";
            link = string.Format(link, Serveur, BaseDeDonnees);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = link;
            return con;
        }
    }
}
