using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_PAPYRUS;
using System.Data.SqlClient;


namespace BL_PAPYRUS
{
    public class BL_Frm_Creer_Fournisseur: DataAccess
    {

        public string Code;
        public string Nom;
        public int Num_Rue;
        public string Nom_Rue;
        public int CP;
        public string Ville;
        public string Contact;
        public int Satisfaction;


        public BL_Frm_Creer_Fournisseur(string strCon) : base(strCon)
        {

        }


        public void CommandTXT()
        {
            base.Link();
            string Query = "insert into Fournisseurs( nom, vile, contact, satisfaction, num_rue, nom_rue, code_postal) values (N'{0}', N'{1}', N'{2}', '{3}', '{4}', N'{5}', '{6}')";
            Query = string.Format(Query, Nom, Ville, Contact, Satisfaction, Num_Rue , Nom_Rue, CP);
            base.CommandTex(Query);
            base.UnLink();
        }

    }
}
