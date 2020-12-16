
namespace PAPYRUS
{
    partial class Frm_Commandes
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
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxFournisseurs = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_Commandes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir un fournisseur";
            // 
            // cBoxFournisseurs
            // 
            this.cBoxFournisseurs.FormattingEnabled = true;
            this.cBoxFournisseurs.Items.AddRange(new object[] {
            "Tous"});
            this.cBoxFournisseurs.Location = new System.Drawing.Point(225, 28);
            this.cBoxFournisseurs.Name = "cBoxFournisseurs";
            this.cBoxFournisseurs.Size = new System.Drawing.Size(211, 28);
            this.cBoxFournisseurs.TabIndex = 1;
            this.cBoxFournisseurs.SelectedIndexChanged += new System.EventHandler(this.cBoxFournisseurs_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_Commandes
            // 
            this.listBox_Commandes.FormattingEnabled = true;
            this.listBox_Commandes.ItemHeight = 20;
            this.listBox_Commandes.Location = new System.Drawing.Point(9, 81);
            this.listBox_Commandes.Name = "listBox_Commandes";
            this.listBox_Commandes.Size = new System.Drawing.Size(449, 204);
            this.listBox_Commandes.TabIndex = 3;
            // 
            // Frm_Commandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 370);
            this.Controls.Add(this.listBox_Commandes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cBoxFournisseurs);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Commandes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des commandes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxFournisseurs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_Commandes;
    }
}