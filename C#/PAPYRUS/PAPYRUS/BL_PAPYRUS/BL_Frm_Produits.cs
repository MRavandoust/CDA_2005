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
    public class BL_Frm_Produits: DataAccess
    {
        public string Id;
        public string Libelle;
        public int Stock_P;
        public int Stock_A;
        public int Quantite_A;
        public string Unite_Mesure;


        public BL_Frm_Produits(string strCon) : base(strCon)
        {

        }


        public DataSet Select()
        {
            base.Link();
            string Query = "select * from Produits";
            DataSet DS = base.SelectDataSet(Query);
            base.UnLink();
            return DS;
        }

        public SqlDataReader SelectRead()
        {
            base.Link();
            string Query = "select * from Produits where libelle = N'{0}'";
            Query = string.Format(Query, Libelle);
            SqlDataReader dr = SelectReader(Query);
            return dr;
        }


        public void MiseAJour()
        {
            base.Link();
            string Query = "update Produits set libelle = N'{0}', stock_alert = '{1}', stock_phys = '{2}', qt_annuelle = '{3}', unite_mesure = N'{4}' where id_Prod = N'{5}'";
            Query = string.Format(Query, Libelle, Stock_A, Stock_P, Quantite_A, Unite_Mesure, Id);
            base.CommandTex(Query);
            base.UnLink();
        }


        public void Delete()
        {
            base.Link();
            string Query = "delete from Produits where id_Prod = '{0}' ";
            Query = string.Format(Query, Id);
            base.CommandTex(Query);
            base.UnLink();
        }


        public void Add()
        {
            base.Link();
            string Query = "insert into Produits( id_Prod, libelle, stock_phys, stock_alert, qt_annuelle, unite_mesure) values (N'{0}', N'{1}', '{2}', '{3}', '{4}', N'{5}')";
            Query = string.Format(Query, Id, Libelle, Stock_P, Stock_A, Quantite_A, Unite_Mesure);
            base.CommandTex(Query);
            base.UnLink();
        }
    }
}
