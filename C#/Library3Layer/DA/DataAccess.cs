using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DA
{
    public class DataAccess
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;


        public DataAccess()
        {
            con = new SqlConnection();
            da = new SqlDataAdapter();
            cmd = new SqlCommand();
            cmd.Connection = con;
            da.SelectCommand = cmd;
        }


        public void Link()
        {
            con.ConnectionString = "Data Source=DESKTOP-EV6M1K5;Initial Catalog=DB_Library;Integrated Security=True";
            con.Open();
        }

        public void UnLink()
        {
            con.Close();
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
    }
}

