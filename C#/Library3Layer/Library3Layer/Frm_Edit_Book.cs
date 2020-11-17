using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DA;

namespace Library3Layer
{
    public partial class Frm_Edit_Book : Form
    {
        public string CaseBook;
        public Frm_Edit_Book()
        {
            InitializeComponent();
        }

        private void Frm_Edit_Book_Load(object sender, EventArgs e)
        {
            BL_Frm_Edit_Book M = new BL_Frm_Edit_Book();
            for (int i = 0; i < M.Select().Rows.Count; i++)
            {
                cbSubject.Items.Add(M.Select().Rows[i][1].ToString());
                if (CaseBook == cbSubject.Items[i].ToString())
                    cbSubject.SelectedIndex = i;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            BL_Frm_Edit_Book M = new BL_Frm_Edit_Book();
            M.ISBN = txtISBN.Text;
            M.Title= txtTitle.Text;
            M.Subject= cbSubject.SelectedIndex + 1;
            M.Writer = txtAuthor.Text;
            M.publisher = txtPublisher.Text;
            M.Year_Date = txtYear.Text;
            M.NumPage = Convert.ToInt16(txtNbPages.Text);
            M.Price = Convert.ToInt32(txtPrice.Text);
            M.Update();
            this.Close();
        }
    }
}
