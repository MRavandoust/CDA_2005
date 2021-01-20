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
    public partial class FormDiplome : Form
    {
        private DateTime dateDobtention;
        private EnumDiplomes diplomeObtenu;

        public DateTime DateDobtention { get => dateDobtention; }
        public EnumDiplomes DiplomeObtenu { get => diplomeObtenu; }


        public FormDiplome()
        {
            InitializeComponent();
            dateDobtention = DateTime.Now;
            diplomeObtenu = EnumDiplomes.Bac;
        }


        public FormDiplome(string _dateDobtention , string _diplomeObtenu)
        {
            InitializeComponent();
            dateDobtention = Convert.ToDateTime(_dateDobtention);
            EnumDiplomes diplom = (EnumDiplomes)Enum.Parse(typeof(EnumDiplomes), _diplomeObtenu);
            diplomeObtenu = diplom;
        }


        private void FormDiplome_Load(object sender, EventArgs e)
        {
            this.dateTimePickerDateDobtention.Value = dateDobtention;
            foreach (string dNom in Enum.GetNames(typeof(EnumDiplomes)))
            {
                this.comboBoxDiplomes.Items.Add(dNom);
            }
            this.comboBoxDiplomes.SelectedItem = this.diplomeObtenu.ToString();
        }



        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (dateTimePickerDateDobtention.Value > DateTime.Now || dateTimePickerDateDobtention.Value < Convert.ToDateTime("01/01/1975 00:00:00"))
            {
                MessageBox.Show("La date n'est pas valide");
                return;
            }
            else
            {
                dateDobtention = dateTimePickerDateDobtention.Value;
                diplomeObtenu = (EnumDiplomes)comboBoxDiplomes.SelectedIndex;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            
        }

       
    }
}
