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

namespace Library3Layer
{
    public partial class Frm_Search : Form
    {
        public Frm_Search()
        {
            InitializeComponent();
        }

        private void Frm_Search_Load(object sender, EventArgs e)
        {
            cbSubject.SelectedIndex = 1;
            BL_Frm_Search M = new BL_Frm_Search();
            dataGridView1.DataSource = M.Select();
        }

        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {
            BL_Frm_Search M = new BL_Frm_Search();
            M.reng = cbSubject.SelectedIndex;
            M.TexCommand = txtKeyWord.Text;
            dataGridView1.DataSource = M.Select_Search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows.Count != 0 && dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                Frm_Edit_Book fo = new Frm_Edit_Book();
                fo.txtISBN.Text = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                fo.txtTitle.Text = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                fo.CaseBook = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                fo.txtAuthor.Text = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                fo.txtPublisher.Text = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                fo.txtYear.Text = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                fo.txtNbPages.Text = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                fo.txtPrice.Text = dataGridView1[9, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                fo.ShowDialog();
            }
            else if(dataGridView1.Rows.Count != 0 && dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                BL_Frm_Search M = new BL_Frm_Search();
                M.ISBN = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                if (MessageBox.Show("Do you want to delete this book?", "Delet Book", MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    M.Delete();
                    Frm_Search_Load(null, null);
                }
                
            }
        }

        private void Frm_Search_Activated(object sender, EventArgs e)
        {
            Frm_Search_Load(null, null);
        }
    }
}
