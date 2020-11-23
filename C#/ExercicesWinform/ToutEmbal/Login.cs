using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToutEmbal
{
    public partial class Login : Form
    {
        private bool identificationOk;


        public bool IdentificationOk { get => identificationOk; }

        public Login()
        {
            InitializeComponent();
        }



        private void btnIdentifier_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "admin" && txtPassword.Text == "root")
            {
                identificationOk = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong ! \nTray again please", "worning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }
}
