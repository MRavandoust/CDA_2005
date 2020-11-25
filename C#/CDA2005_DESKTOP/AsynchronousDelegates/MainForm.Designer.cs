
namespace AsynchronousDelegates
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_StatrJob = new System.Windows.Forms.Button();
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.btn_CancelJob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_StatrJob
            // 
            this.btn_StatrJob.Location = new System.Drawing.Point(12, 21);
            this.btn_StatrJob.Name = "btn_StatrJob";
            this.btn_StatrJob.Size = new System.Drawing.Size(133, 30);
            this.btn_StatrJob.TabIndex = 0;
            this.btn_StatrJob.Text = "Start Job";
            this.btn_StatrJob.UseVisualStyleBackColor = true;
            this.btn_StatrJob.Click += new System.EventHandler(this.btn_StatrJob_Click);
            // 
            // txt_Log
            // 
            this.txt_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Log.Location = new System.Drawing.Point(12, 57);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Log.Size = new System.Drawing.Size(596, 417);
            this.txt_Log.TabIndex = 1;
            // 
            // btn_CancelJob
            // 
            this.btn_CancelJob.Enabled = false;
            this.btn_CancelJob.Location = new System.Drawing.Point(151, 21);
            this.btn_CancelJob.Name = "btn_CancelJob";
            this.btn_CancelJob.Size = new System.Drawing.Size(133, 30);
            this.btn_CancelJob.TabIndex = 0;
            this.btn_CancelJob.Text = "Cancel Job";
            this.btn_CancelJob.UseVisualStyleBackColor = true;
            this.btn_CancelJob.Click += new System.EventHandler(this.btn_CancelJob_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 486);
            this.Controls.Add(this.txt_Log);
            this.Controls.Add(this.btn_CancelJob);
            this.Controls.Add(this.btn_StatrJob);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StatrJob;
        private System.Windows.Forms.TextBox txt_Log;
        private System.Windows.Forms.Button btn_CancelJob;
    }
}

