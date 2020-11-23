﻿using CheckBoxEtRadioButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Saisie
{
    
    public partial class FrmSaisie : Form
    {
        public delegate void LoadSaisie(string str);
        public event LoadSaisie ls;

        private static int nbDInstance=0;
        
        

        public FrmSaisie()
        {
            InitializeComponent();
            nbDInstance++;
            this.Text = nbDInstance.ToString();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //FrmCheckBox checkB = new FrmCheckBox(txtSaisie.Text);
            //checkB.MdiParent = this.MdiParent ;
            //checkB.Show();
            
            ls(txtSaisie.Text);
            txtSaisie.Text = "";
            this.Close();
        }
    }
}
