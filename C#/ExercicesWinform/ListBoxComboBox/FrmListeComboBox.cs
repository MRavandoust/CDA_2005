using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxComboBox
{
    public partial class FrmListeComboBox : Form
    {
        public FrmListeComboBox()
        {
            InitializeComponent();
            if (comboSource.Items.Count == 0) btnDroiteAll.Enabled = false;
            if (listBoxCible.Items.Count == 0) btnGaucheAll.Enabled = false;
        }

        private void comboSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSource.Text != "")
                btnDroite.Enabled = true;
            if (comboSource.Items.Count == 0)
            {
                btnDroite.Enabled = false;
                btnDroiteAll.Enabled = false;
            }
        }

        private void btnDroite_Click(object sender, EventArgs e)
        {
            listBoxCible.Items.Add(comboSource.Text);
            comboSource.Text = "";
            comboSource.Focus();
            btnDroite.Enabled = false;
            if (comboSource.SelectedIndex != -1)
                comboSource.Items.RemoveAt(comboSource.SelectedIndex);
            btnGaucheAll.Enabled = true;
            if (comboSource.Items.Count == 0)
                btnDroiteAll.Enabled = false;


        }


        private void btnDroiteAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < comboSource.Items.Count; i++)
            {
                listBoxCible.Items.Add(comboSource.Items[i]);
            }
            comboSource.Text = "";
            comboSource.Items.Clear();
            btnDroiteAll.Enabled = false;
            btnDroite.Enabled = false;
            btnGaucheAll.Enabled = true;
        }

        private void listBoxCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCible.SelectedIndex != -1)
                btnGauche.Enabled = true;

            if (listBoxCible.SelectedIndex > 0 && listBoxCible.SelectedIndex != -1)
                btnHaut.Enabled = true;
            else
                btnHaut.Enabled = false;
            if (listBoxCible.SelectedIndex < listBoxCible.Items.Count - 1 && listBoxCible.SelectedIndex != -1)
                btnBas.Enabled = true;
            else
                btnBas.Enabled = false;
        }

        private void btnGauche_Click(object sender, EventArgs e)
        {
            if (listBoxCible.SelectedIndex != -1)
            {
                comboSource.Items.Add(listBoxCible.SelectedItem.ToString());
                listBoxCible.Items.RemoveAt(listBoxCible.SelectedIndex);
                btnGauche.Enabled = false;
                btnDroiteAll.Enabled = true;
                if (listBoxCible.Items.Count == 0)
                {
                    btnGaucheAll.Enabled = false;
                    btnGauche.Enabled = false;
                }
                else
                    btnGaucheAll.Enabled = true;
            }

        }

        private void btnGaucheAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxCible.Items.Count; i++)
            {
                comboSource.Items.Add(listBoxCible.Items[i]);
            }
            listBoxCible.Items.Clear();
            btnGaucheAll.Enabled = false;
            btnGauche.Enabled = false;
            btnDroite.Enabled = false;
            btnDroiteAll.Enabled = true;
        }

        private void btnHaut_Click(object sender, EventArgs e)
        {
            int index = listBoxCible.SelectedIndex;
            string temp = listBoxCible.Items[index - 1].ToString();
            listBoxCible.Items[index - 1] = listBoxCible.Items[index];
            listBoxCible.Items[index] = temp;
            listBoxCible.SelectedItem = listBoxCible.Items[index - 1];

        }

        private void btnBas_Click(object sender, EventArgs e)
        {
            int index = listBoxCible.SelectedIndex;
            string temp = listBoxCible.Items[index + 1].ToString();
            listBoxCible.Items[index + 1] = listBoxCible.Items[index];
            listBoxCible.Items[index] = temp;
            listBoxCible.SelectedItem = listBoxCible.Items[index + 1];
        }

        private void comboSource_TextChanged(object sender, EventArgs e)
        {
            if (comboSource.FindStringExact(comboSource.Text) == -1)
            {
                errorProvider1.SetError(comboSource, "");
            }
            else
            {
                errorProvider1.SetError(comboSource, "Ce texte déjà existe dans la liste");
            }
        }

        private void comboSource_Click(object sender, EventArgs e)
        {
            if (comboSource.Text != "")
            {
                if (comboSource.FindStringExact(comboSource.Text) == -1 && listBoxCible.FindStringExact(comboSource.Text) == -1)
                {
                    comboSource.Items.Add(comboSource.Text);
                    comboSource.Text = "";
                    comboSource.Focus();
                }
                else
                {
                    comboSource.Text = "";
                    comboSource.Focus();
                }

            }

        }
    }
}
