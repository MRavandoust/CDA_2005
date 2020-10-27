using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesListesEtProprietes
{
    public partial class LesListes : Form
    {
        public LesListes()
        {
            InitializeComponent();
        }

        private void btnAjoutListe_Click(object sender, EventArgs e)
        {
            AjoutText();
            btnAjoutListe.Enabled = false;
        }

        private void AjoutText()
        {
            if (txtNouvelElement.Text == "")
            {
                MessageBox.Show("Ce Champs ne pas être vide");
                txtNouvelElement.Focus();
            }
            else
            {
                if (listBoxLst.FindStringExact(txtNouvelElement.Text) == -1)
                {
                    listBoxLst.Items.Add(txtNouvelElement.Text);
                    txtNouvelElement.Text = "";
                    txtNouvelElement.Focus();
                    txtItemsCount.Text = listBoxLst.Items.Count.ToString();
                    btnViderListe.Enabled = true;
                }
                else
                {
                    MessageBox.Show("This word is alreedy exist in the list");
                }
            }
        }

        private void txtNouvelElement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Return)
            {

                if (txtNouvelElement.Text != "")
                {
                    if (listBoxLst.FindStringExact(txtNouvelElement.Text) == -1)
                    {
                        listBoxLst.Items.Add(txtNouvelElement.Text);
                        txtNouvelElement.Text = "";
                        txtNouvelElement.Focus();
                        e.Handled = true;
                        txtItemsCount.Text = listBoxLst.Items.Count.ToString();
                        btnViderListe.Enabled = true;
                        btnAjoutListe.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("This word is alreedy exist in the list");
                        e.Handled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Ce Champs ne pas être vide");
                    e.Handled = true;
                }
            }


        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtIndex.Text);
            if (index < listBoxLst.Items.Count)
            {
                listBoxLst.SelectedIndex = index;
                txtIndex.Text = "";
                txtIndex.Focus();
            }
            else
            {
                MessageBox.Show("L'index doit être moin de " + listBoxLst.Items.Count.ToString());
                txtIndex.Text = "";
                txtIndex.Focus();
            }

        }

        private void listBoxLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxLst.SelectedIndex;
            txtSelectedIndex.Text = index.ToString();
            txtText.Text = listBoxLst.SelectedItem.ToString();
        }

        private void btnViderListe_Click(object sender, EventArgs e)
        {
            listBoxLst.Items.Clear();
            txtSelectedIndex.Text = "";
            txtText.Text = "";
            txtItemsCount.Text = "";
            txtNouvelElement.Text = "";
            btnViderListe.Enabled = false;
            
        }


        private void txtIndex_TextChanged(object sender, EventArgs e)
        {
            int index;
            Regex isNumber = new Regex(@"^\d$");
            if (txtIndex.Text == "")
            {
                index = -1;
            }
            else
                index = Convert.ToInt32(txtIndex.Text);
            if (isNumber.IsMatch(txtIndex.Text) && index < listBoxLst.Items.Count)
            {
                btnSelectionner.Enabled = true;
                errorProvider1.SetError(txtIndex, "");
            }
            else
            {
                errorProvider1.SetError(txtIndex, "L'index doit être un chiffr et mins de " + listBoxLst.Items.Count.ToString());
            }

            if (txtIndex.Text == "")
            {
                errorProvider1.SetError(txtIndex, "");
                btnSelectionner.Enabled = false;
            }
        }

        private void txtNouvelElement_TextChanged(object sender, EventArgs e)
        {
            btnAjoutListe.Enabled = true;
        }
    }
}
