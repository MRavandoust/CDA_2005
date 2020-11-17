using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA;
using BL;

namespace Library3Layer
{
    public partial class Frm_Add_Book : Form
    {
        public Frm_Add_Book()
        {
            InitializeComponent();
        }

        private void Frm_Add_Book_Load(object sender, EventArgs e)
        {
            BL_Frm_Add_Book M = new BL_Frm_Add_Book();
            for(int i = 0; i < M.Select().Rows.Count ; i++)
            {
                cbSubject.Items.Add(M.Select().Rows[i][1].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BL_Frm_Add_Book M = new BL_Frm_Add_Book();
            M.ISBN = txtISBN.Text;
            M.Title = txtTitle.Text;
            M.Subject = cbSubject.SelectedIndex + 1;
            M.Writer = txtAuthor.Text;
            M.publisher = txtPublisher.Text;
            M.Year_Date = txtYear.Text;
            M.NumPage = int.Parse(txtNbPages.Text);
            M.Price = int.Parse(txtPrice.Text);
            M.Add();
            //Reset text boxs
            txtISBN.Focus();
            txtISBN.ResetText();
            txtTitle.ResetText();
            cbSubject.SelectedIndex = -1;
            txtAuthor.ResetText();
            txtPublisher.ResetText();
            txtYear.ResetText();
            txtNbPages.ResetText();
            txtPrice.ResetText();
        }
    }
}
