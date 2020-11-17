using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using System.Data;
using System.Data.SqlClient;

namespace BL
{
    public class BL_Frm_Edit_Book: DataAccess
    {
        public string ISBN;
        public string Title;
        public int Subject;
        public string Writer;
        public string publisher;
        public string Year_Date;
        public int NumPage;
        public int Price;


        public DataTable Select()
        {
            base.Link();
            string Query = "select * from TB_Subject";
            DataTable Output_Q = base.SelectData(Query);
            base.UnLink();
            return Output_Q;
        }


        public void Update()
        {
            base.Link();
            string Query = "";
            Query = "update TB_Book set Title = N'{0}', Subject = N'{1}', Writer = N'{2}', publisher = N'{3}', Year_Date = N'{4}', NumPage ='{5}' , Price ='{6}'  where ISBN = N'{7}'";
            Query = string.Format(Query, Title, Subject, Writer, publisher, Year_Date, NumPage, Price, ISBN);
            base.CommandTex(Query);
            base.UnLink();
        }


    }
}
