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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDroite.Enabled = false;
            btnHaut.Enabled = false;
            btnGauche.Enabled = false;
            btnBas.Enabled = false;
        }

        private void comboSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDroite.Enabled = true;
        }

        private void btnDroite_Click(object sender, EventArgs e)
        {
            listBoxCible.Items.Add(comboSource.SelectedItem.ToString());
            comboSource.Items.RemoveAt(comboSource.SelectedIndex);
            btnDroite.Enabled = false;
        }

        private void btnDroiteAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < comboSource.Items.Count; i++)
            {
                listBoxCible.Items.Add(comboSource.Items[i]);
            }
            comboSource.Items.Clear();
            btnDroiteAll.Enabled = false;
            btnGaucheAll.Enabled = true;
        }

        private void listBoxCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGauche.Enabled = true;
            if (listBoxCible.SelectedIndex > 0)
                btnHaut.Enabled = true;
            else
                btnHaut.Enabled = false;
            if (listBoxCible.SelectedIndex < listBoxCible.Items.Count - 1)
                btnBas.Enabled = true;
            else
                btnBas.Enabled = false;
        }

        private void btnGauche_Click(object sender, EventArgs e)
        {
            comboSource.Items.Add(listBoxCible.SelectedItem.ToString());
            listBoxCible.Items.RemoveAt(listBoxCible.SelectedIndex);
            btnGauche.Enabled = false;
        }

        private void btnGaucheAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxCible.Items.Count; i++)
            {
                comboSource.Items.Add(listBoxCible.Items[i]);
            }
            listBoxCible.Items.Clear();
            btnGaucheAll.Enabled = false;
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
    }
}
