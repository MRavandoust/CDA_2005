using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace Employee
{
    public partial class Frm_Employee : Form
    {
        public Frm_Employee()
        {
            InitializeComponent();
        }

        TcpClient tcp;
        NetworkStream ns;
        StreamReader reader;
        StreamWriter writer;
        string str = "";

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                tcp = new TcpClient("127.0.0.1", 8086);
                tcp.ReceiveBufferSize = 25000;
                tcp.NoDelay = true;
                ns = tcp.GetStream();
                reader = new StreamReader(ns);
                writer = new StreamWriter(ns);
                writer.WriteLine("employee_register");
                writer.Flush();
                str = reader.ReadLine();
                string[] strsplit = null;
                strsplit = str.Split(',');
                if(strsplit[0] == "registerd")
                {
                    btnStart.Visible = false;
                    this.Text = "Employee number" + strsplit[1];
                    label1.Text = "Is in service to customer number " + strsplit[2];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error during connecting to server ! \n Start server please.");
            }
        }

        private void btnCallCustemer_Click(object sender, EventArgs e)
        {
            try
            {
                tcp = new TcpClient("127.0.0.1", 8086);
                tcp.ReceiveBufferSize = 25000;
                tcp.NoDelay = true;
                ns = tcp.GetStream();
                reader = new StreamReader(ns);
                writer = new StreamWriter(ns);
                writer.WriteLine("employee_nex");
                writer.Flush();
                if (str != "")
                {
                    label1.Text = "In service to customer" + str;
                }
                else
                {
                    label1.Text = "There is not any customer.";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error during connecting to server ! \n Start server please.");
            }
        }
    }
}
