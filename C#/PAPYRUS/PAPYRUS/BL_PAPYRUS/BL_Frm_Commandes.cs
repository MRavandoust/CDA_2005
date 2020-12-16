using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DA_PAPYRUS;

namespace BL_PAPYRUS
{
    public class BL_Frm_Commandes : DataAccess
    {
        public int Id;
        public string Observations;
        public DateTime Date_Commande;
        public int Id_f;
        public string Fornisseur;


        public BL_Frm_Commandes(string confstring) : base(confstring)
        {
            //inistialiser autres attributs
        }


        public DataTable Select()
        {
            base.Link();
            string Query = "select * from [Fournisseurs]";
            DataTable DT = base.SelectData(Query);
            base.UnLink();
            return DT;
        }


        public SqlDataReader SelectAll()
        {
            base.Link();
            string Query = "select * from [commandes]";
            SqlDataReader DR = base.SelectReader(Query);
            //base.UnLink();
            return DR;
        }

        public SqlDataReader SelectOne()
        {
            base.Link();
            string Query = "select * from [commandes] where id_F = {0}";
            Query = string.Format(Query, Id_f);
            SqlDataReader DR = base.SelectReader(Query);
            return DR;
        }


        public SqlDataReader SelectID()
        {
            base.Link();
            string Query = "select * from [Fournisseurs] where nom = '{0}' ";
            Query = string.Format(Query, Fornisseur);
            SqlDataReader DR = base.SelectReader(Query);
            return DR;
        }


        public void Delete()
        {
            base.Link();
            string Query = "delete from Commandes where id_F = '{0}' ";
            Query = string.Format(Query, Id);
            base.CommandTex(Query);
            base.UnLink();
        }


    }


    
}
