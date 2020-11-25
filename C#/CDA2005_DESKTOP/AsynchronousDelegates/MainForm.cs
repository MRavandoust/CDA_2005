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

namespace AsynchronousDelegates
{
    public partial class MainForm : Form
    {
        private bool jobCanceled = false;
        public delegate void StartJobDelegate();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_StatrJob_Click(object sender, EventArgs e)
        {
            btn_CancelJob.Enabled = true;
            btn_StatrJob.Enabled = false;
            //StartJobDelegate jobDelegate = new StartJobDelegate(StartJob);
            //jobDelegate.BeginInvoke(null, null);

            ////var sumDelegate = new Func<int, int, int>(Sum);              // Pour prendr la sortie d'une methode dans un thread
            ////AsyncCallback callBack = new AsyncCallback(asynchRes =>
            ////{
            ////    var finalresult = sumDelegate.EndInvoke(asynchRes);
            ////    MessageBox.Show("Final result: " + finalresult);
            ////});
            ////var result = sumDelegate.BeginInvoke(9,20, callBack, null);
            
            jobCanceled = false;
            StartJobDelegate jobDelegat = new StartJobDelegate(StartJob);
            jobDelegat.BeginInvoke(null, null);

        }


        //private int Sum(int num1, int num2)
        //{
        //    Thread.Sleep(2000);
        //    return num1 + num2;
        //}

        private void StartJob()
        {
            for(var counter = 1; counter<=100; counter++)
            {
                if (jobCanceled)
                    Thread.CurrentThread.Abort();
                Invoke(new Action(()=> txt_Log.Text += "Processing number " + counter + "..." + Environment.NewLine));
                Thread.Sleep(500);
            }
        }

        private void btn_CancelJob_Click(object sender, EventArgs e)
        {
            btn_StatrJob.Enabled = true;
            btn_CancelJob.Enabled = false;
            jobCanceled = true;

        }
    }
}
