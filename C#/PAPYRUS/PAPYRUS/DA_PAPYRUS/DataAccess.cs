using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace DA_PAPYRUS
{
    public class DataAccess
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;
        SqlDataReader reader;
        DataSet ds;


        public SqlConnection Con { get => con; /*set; */}


        public DataAccess(string consString)
        {
            con = new SqlConnection();
            con.ConnectionString = consString;
            da = new SqlDataAdapter();
            cmd = new SqlCommand();
            cmd.Connection = con;
            da.SelectCommand = cmd;
            //reader = cmd.ExecuteReader();
        }


        public void Link()
        {
            con.Open();
        }

        public void UnLink()
        {
            con.Close();
        }

        public DataSet SelectDataSet(string StrSql)
        {
            cmd.CommandText = StrSql;
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public DataTable SelectData(string StrSql)
        {
            cmd.CommandText = StrSql;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public void CommandTex(string StrSql)
        {
            cmd.CommandText = StrSql;
            cmd.ExecuteNonQuery();
        }


        public SqlDataReader SelectReader(string strSql)
        {
            cmd.CommandText = strSql;
            reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
