using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections;

namespace Server
{
    public partial class Frm_Server : Form
    {
        public Frm_Server()
        {
            InitializeComponent();
        }

        TcpListener tc;
        Socket s;
        Queue customer = new Queue(2000);
        int numberCustomer = 0;
        int numberEmployee = 0;
        int time, count, num;
        List<string> employees = new List<string>();
        List<string> customers = new List<string>();

        private void Init()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            tc = new TcpListener(ip, 8086);
            tc.Start();
            while (true)
            {
                s = tc.AcceptSocket();
                Thread t = new Thread(new ThreadStart(reply));
                t.IsBackground = true;
                t.Start();
            }
        }

        private void reply()
        {
            Socket sc = s;
            NetworkStream ns = new NetworkStream(sc);
            StreamReader reader = new StreamReader(ns);
            StreamWriter writer = new StreamWriter(ns);

            string str = "";
            string response = "";
            try
            {
                str = reader.ReadLine();
            }
            catch (Exception)
            {
                str = "error";
            }

            if (str == "request")
            {
                if(employees.Count > 0)
                {
                    AddQueue();
                    response = time.ToString() + "," + count.ToString() + "," + num.ToString();
                }
                else
                {
                    response = "NoEmployee, , ";
                }
            }else if(str == "employee_register")
            {
                numberEmployee++;
                employees.Add("Employee number " + numberEmployee.ToString());
                string nc = "";
                if(customers.Count > 0)
                {
                    nc = customer.Dequeue().ToString();
                    customers.Remove("Customer number "+ nc.ToString());
                }
                response = "registered, "+ numberEmployee.ToString() + ", " + nc;
            }else if( str == "employee_nex")
            {
                string nc = "";
                if (customers.Count > 0)
                {
                    nc = customer.Dequeue().ToString();
                    customers.Remove("Customer number " + nc.ToString());
                }
                response = nc;
            }
            writer.WriteLine(response);
            writer.Flush();
            ns.Close();
            sc.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(customers.Count != lsbCustomers.Items.Count)
            {
                lsbCustomers.Items.Clear();
                foreach(string item in customers)
                {
                    lsbCustomers.Items.Add(item);
                }
            }
            if(employees.Count != lsbEmployees.Items.Count)
            {
                lsbEmployees.Items.Clear();
                foreach(string item in employees)
                {
                    lsbEmployees.Items.Add(item);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() != "")
            {
                textBox1.BackColor = Color.White;
                Thread t = new Thread(new ThreadStart(Init));
                t.IsBackground = true;
                t.Start();

                MessageBox.Show("Server is started");

                btnStart.Enabled = false;
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
        }

        public void AddQueue()
        {
            numberCustomer += 1;
            customer.Enqueue(numberCustomer);
            time = ((int.Parse(customer.Count.ToString()))*int.Parse(textBox1.Text))/employees.Count;
            count = int.Parse(customer.Count.ToString());
            num = numberCustomer;
            customers.Add("Customer number " + numberCustomer.ToString());
        }
    }
}
