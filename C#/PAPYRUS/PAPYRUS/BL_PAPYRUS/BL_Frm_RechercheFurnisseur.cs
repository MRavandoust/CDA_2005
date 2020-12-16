using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_PAPYRUS;
using System.Data.SqlClient;

namespace BL_PAPYRUS
{
    public class BL_Frm_RechercheFurnisseur : DataAccess
    {
        public string Code;
        public string Nom;
        public string Adresse;
        public int Num_Rue;
        public string Nom_Rue;
        public int CP;
        public string Ville;
        public string Contact;
        public int Satisfaction;


        public BL_Frm_RechercheFurnisseur(string confstring) : base(confstring)
        {
            //inistialiser autres attributs
        }

        public SqlDataReader Select()
        {
            base.Link();
            string Query = "select * from [Fournisseurs] where id_F = N'{0}' ";
            Query = string.Format(Query, Code);
            base.CommandTex(Query);
            SqlDataReader reader = base.SelectReader(Query);
            return reader;
        }


        public void Update()
        {
            base.Link();
            string Query = "update Fournisseurs set nom = N'{0}', vile = N'{1}', contact = N'{2}', satisfaction = '{3}', num_rue = '{4}', nom_rue = N'{5}', code_postal = '{6}' where id_F = '{7}' ";
            Query = string.Format(Query, Nom, Ville, Contact, Satisfaction, Num_Rue, Nom_Rue, CP, Code);
            base.CommandTex(Query);
            base.UnLink();
        }

        public void Delete()
        {
            base.Link();
            string Query = "delete from Fournisseurs where id_F = '{0}' ";
            Query = string.Format(Query, Code);
            base.CommandTex(Query);
            base.UnLink();
        }

    }


}

