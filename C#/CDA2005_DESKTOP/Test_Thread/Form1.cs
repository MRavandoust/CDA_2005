using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Test_Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        static void my_thread1()
        {
            Random rnd = new Random();
            for (int i = 0; i < 100000000; i++)
            {
                int number = rnd.Next(10000, 20000);
                i += number;
                i -= number;
            }
            MessageBox.Show("Thread 1: " + DateTime.Now.ToUniversalTime());
        }

        static void my_thread2()
        {
            for (int i = 0; i < 100000000; i++)
            {

            }
            MessageBox.Show("Thread 2: " + DateTime.Now.ToUniversalTime());
        }

        private void btn_Asynchrone_Click(object sender, EventArgs e)
        {
            btn_Asynchrone.Enabled = false;
            btn_synchrone.Enabled = false;

            Thread t1 = new Thread(my_thread1);
            Thread t2 = new Thread(my_thread2);
            t1.Start();
            t2.Start();

            btn_Asynchrone.Enabled = true;
            btn_synchrone.Enabled = true;
        }

        private void btn_synchrone_Click(object sender, EventArgs e)
        {
            btn_Asynchrone.Enabled = false;
            btn_synchrone.Enabled = false;

            my_thread1();
            my_thread2();

            btn_Asynchrone.Enabled = true;
            btn_synchrone.Enabled = true;
        }
    }
}
