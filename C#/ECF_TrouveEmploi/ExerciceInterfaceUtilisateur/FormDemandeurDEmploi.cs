using ClassLibraryMetier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceInterfaceUtilisateur
{
    public partial class FormDemandeurDEmploi : Form
    {
        DemandeurDEmploi unDemandeurDEmploi;
        public DemandeurDEmploi UnDemandeurDEmploi { get => unDemandeurDEmploi; }

        public FormDemandeurDEmploi()
        {
            InitializeComponent();
            unDemandeurDEmploi = new DemandeurDEmploi();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            //listView1.Columns.Add("Date d'obtantion de diplome", 150);
            //listView1.Columns.Add("Diplome", 100);
        }


        private void buttonValider_Click(object sender, EventArgs e)
        {
            // acoder
            unDemandeurDEmploi = new DemandeurDEmploi(Convert.ToInt64(textBoxPuce.Text), dateTimePicker1.Value, textBoxNom.Text, textBoxPrenom.Text);
        }


        private void buttonAjouterDiplome_Click(object sender, EventArgs e)
        {
            using (FormDiplome form = new FormDiplome())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem item = new ListViewItem(form.DateDobtention.ToString());
                    item.SubItems.Add(form.DiplomeObtenu.ToString());
                    listView1.Items.Add(item);
                }
            }
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                buttonModifier.Enabled = true;
                buttonSupprimer.Enabled = true;
            }
            else
            {
                buttonModifier.Enabled = false;
                buttonSupprimer.Enabled = false;
            }
        }





        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count !=0)
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
        }




        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
                using (FormDiplome form = new FormDiplome(listView1.SelectedItems[0].SubItems[0].Text, listView1.SelectedItems[0].SubItems[1].Text))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    listView1.SelectedItems[0].SubItems[0].Text = form.DateDobtention.ToString();
                    listView1.SelectedItems[0].SubItems[1].Text = form.DiplomeObtenu.ToString();
                }
            }
        }
    }
}
