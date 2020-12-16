
namespace PAPYRUS
{
    partial class Frm_Connexion
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
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.btn_Deconnexion = new System.Windows.Forms.Button();
            this.btn_Connexion = new System.Windows.Forms.Button();
            this.txt_EtatDeConnexion = new System.Windows.Forms.TextBox();
            this.txt_BaseDeDonnees = new System.Windows.Forms.TextBox();
            this.txt_Serveur = new System.Windows.Forms.TextBox();
            this.lbl_Etat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Location = new System.Drawing.Point(233, 163);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(112, 28);
            this.btn_Quitter.TabIndex = 13;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // btn_Deconnexion
            // 
            this.btn_Deconnexion.Location = new System.Drawing.Point(233, 129);
            this.btn_Deconnexion.Name = "btn_Deconnexion";
            this.btn_Deconnexion.Size = new System.Drawing.Size(112, 28);
            this.btn_Deconnexion.TabIndex = 11;
            this.btn_Deconnexion.Text = "Déconnexion";
            this.btn_Deconnexion.UseVisualStyleBackColor = true;
            this.btn_Deconnexion.Click += new System.EventHandler(this.btn_Deconnexion_Click);
            // 
            // btn_Connexion
            // 
            this.btn_Connexion.Location = new System.Drawing.Point(72, 129);
            this.btn_Connexion.Name = "btn_Connexion";
            this.btn_Connexion.Size = new System.Drawing.Size(112, 28);
            this.btn_Connexion.TabIndex = 12;
            this.btn_Connexion.Text = "Connexion";
            this.btn_Connexion.UseVisualStyleBackColor = true;
            this.btn_Connexion.Click += new System.EventHandler(this.btn_Connexion_Click);
            // 
            // txt_EtatDeConnexion
            // 
            this.txt_EtatDeConnexion.Location = new System.Drawing.Point(29, 237);
            this.txt_EtatDeConnexion.Multiline = true;
            this.txt_EtatDeConnexion.Name = "txt_EtatDeConnexion";
            this.txt_EtatDeConnexion.Size = new System.Drawing.Size(341, 163);
            this.txt_EtatDeConnexion.TabIndex = 14;
            // 
            // txt_BaseDeDonnees
            // 
            this.txt_BaseDeDonnees.Location = new System.Drawing.Point(158, 67);
            this.txt_BaseDeDonnees.Name = "txt_BaseDeDonnees";
            this.txt_BaseDeDonnees.Size = new System.Drawing.Size(212, 20);
            this.txt_BaseDeDonnees.TabIndex = 10;
            // 
            // txt_Serveur
            // 
            this.txt_Serveur.Location = new System.Drawing.Point(158, 24);
            this.txt_Serveur.Name = "txt_Serveur";
            this.txt_Serveur.Size = new System.Drawing.Size(212, 20);
            this.txt_Serveur.TabIndex = 5;
            // 
            // lbl_Etat
            // 
            this.lbl_Etat.AutoSize = true;
            this.lbl_Etat.Location = new System.Drawing.Point(155, 212);
            this.lbl_Etat.Name = "lbl_Etat";
            this.lbl_Etat.Size = new System.Drawing.Size(0, 13);
            this.lbl_Etat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Etat de la connexion :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Base de données :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Serveur :";
            // 
            // Frm_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 443);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.btn_Deconnexion);
            this.Controls.Add(this.btn_Connexion);
            this.Controls.Add(this.txt_EtatDeConnexion);
            this.Controls.Add(this.txt_BaseDeDonnees);
            this.Controls.Add(this.txt_Serveur);
            this.Controls.Add(this.lbl_Etat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion à la base de données";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.Button btn_Deconnexion;
        private System.Windows.Forms.Button btn_Connexion;
        private System.Windows.Forms.TextBox txt_EtatDeConnexion;
        private System.Windows.Forms.TextBox txt_BaseDeDonnees;
        private System.Windows.Forms.TextBox txt_Serveur;
        private System.Windows.Forms.Label lbl_Etat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

