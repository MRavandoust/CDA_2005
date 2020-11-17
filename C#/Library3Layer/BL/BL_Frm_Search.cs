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
    public class BL_Frm_Search: DataAccess
    {
        public string TexCommand;
        public int reng;
        public string ISBN;
        public DataTable Select()
        {
            base.Link();
            string Query = "select ISBN as [Book Code], Title, SubjectName as [Subject], Writer as [Author], publisher, Year_Date as [Year], NumPage as [Nb of Pages], Price from TB_Book, TB_Subject where TB_Book.[Subject] = TB_Subject.[Subject]";
            DataTable Output_Q = base.SelectData(Query);
            base.UnLink();
            return Output_Q;
        }

        public DataTable Select_Search()
        {
            base.Link();
            string Query = "";
            if (reng == 0)
            {
                Query = "select ISBN as [Book Code], Title, SubjectName as [Subject], Writer as [Author], publisher, Year_Date as [Year], NumPage as [Nb of Pages], Price from TB_Book, TB_Subject where TB_Book.[Subject] = TB_Subject.[Subject] and ISBN Like '{0}%'";
            }else if(reng == 1)
            {
                Query = "select ISBN as [Book Code], Title, SubjectName as [Subject], Writer as [Author], publisher, Year_Date as [Year], NumPage as [Nb of Pages], Price from TB_Book, TB_Subject where TB_Book.[Subject] = TB_Subject.[Subject] and Title Like '{0}%'";
            }
            else if (reng == 2)
            {
                Query = "select ISBN as [Book Code], Title, SubjectName as [Subject], Writer as [Author], publisher, Year_Date as [Year], NumPage as [Nb of Pages], Price from TB_Book, TB_Subject where TB_Book.[Subject] = TB_Subject.[Subject] and Writer Like '{0}%'";
            }
            else if (reng == 3)
            {
                Query = "select ISBN as [Book Code], Title, SubjectName as [Subject], Writer as [Author], publisher, Year_Date as [Year], NumPage as [Nb of Pages], Price from TB_Book, TB_Subject where TB_Book.[Subject] = TB_Subject.[Subject] and publisher Like '{0}%'";
            }
            else if (reng == 4)
            {
                Query = "select ISBN as [Book Code], Title, SubjectName as [Subject], Writer as [Author], publisher, Year_Date as [Year], NumPage as [Nb of Pages], Price from TB_Book, TB_Subject where TB_Book.[Subject] = TB_Subject.[Subject] and Year_Date Like '{0}%'";
            }
            Query = string.Format(Query, TexCommand);

            DataTable Output_Q = base.SelectData(Query);
            base.UnLink();
            return Output_Q;
        }

        public void Delete()
        {
            base.Link();
            string Query = "delete from TB_Book where ISBN = N'{0}'";
            Query = string.Format(Query, ISBN);
            base.CommandTex(Query);
            base.UnLink();
        }
    }
}
