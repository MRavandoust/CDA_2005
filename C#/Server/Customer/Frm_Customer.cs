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

namespace Customer
{
    public partial class Frm_Customer : Form
    {
        public Frm_Customer()
        {
            InitializeComponent();
        }


        TcpClient tcp;
        NetworkStream ns;
        StreamReader reader;
        StreamWriter writer;
        string str = "";


        private void btnTicket_Click(object sender, EventArgs e)
        {
            string tim, count, num;
            try
            {
                tcp = new TcpClient("127.0.0.1", 8086);
                tcp.ReceiveBufferSize = 25000;
                tcp.NoDelay = true;
                ns = tcp.GetStream();
                reader = new StreamReader(ns);
                writer = new StreamWriter(ns);
                writer.WriteLine("request");
                writer.Flush();
                str = reader.ReadLine();

                string[] strsplit = null;
                strsplit = str.Split(',');
                if(strsplit[0] != "NoEmlpoyee")
                {
                    tim = strsplit[0];
                    count = strsplit[1];
                    num = strsplit[2];

                    label1.Text = "You should waite about " + tim.ToString() + "minutes.";
                    label2.Text = "THere are " + count.ToString() + " persones in the queue.";
                    label3.Text = "Your number is " + num.ToString();
                }
                else
                {
                    MessageBox.Show("There are not any employees ");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error during connecting to the server ! \n  Start server please");
                return;
            }

            
        }
    }
}
