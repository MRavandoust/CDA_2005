
namespace PAPYRUS
{
    partial class Frm_Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Connexion = new System.Windows.Forms.Button();
            this.btn_Fournisseur = new System.Windows.Forms.Button();
            this.btn_Produits = new System.Windows.Forms.Button();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Connexion);
            this.groupBox1.Location = new System.Drawing.Point(43, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connexion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Fournisseur);
            this.groupBox2.Location = new System.Drawing.Point(43, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(903, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fournisseurs";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Produits);
            this.groupBox3.Location = new System.Drawing.Point(43, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(903, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produits";
            // 
            // btn_Connexion
            // 
            this.btn_Connexion.Location = new System.Drawing.Point(98, 35);
            this.btn_Connexion.Name = "btn_Connexion";
            this.btn_Connexion.Size = new System.Drawing.Size(220, 43);
            this.btn_Connexion.TabIndex = 0;
            this.btn_Connexion.Text = "Tester la connexion";
            this.btn_Connexion.UseVisualStyleBackColor = true;
            this.btn_Connexion.Click += new System.EventHandler(this.btn_Connexion_Click);
            // 
            // btn_Fournisseur
            // 
            this.btn_Fournisseur.Location = new System.Drawing.Point(98, 34);
            this.btn_Fournisseur.Name = "btn_Fournisseur";
            this.btn_Fournisseur.Size = new System.Drawing.Size(220, 43);
            this.btn_Fournisseur.TabIndex = 0;
            this.btn_Fournisseur.Text = "Fournisseur";
            this.btn_Fournisseur.UseVisualStyleBackColor = true;
            this.btn_Fournisseur.Click += new System.EventHandler(this.btn_Fournisseur_Click);
            // 
            // btn_Produits
            // 
            this.btn_Produits.Location = new System.Drawing.Point(98, 35);
            this.btn_Produits.Name = "btn_Produits";
            this.btn_Produits.Size = new System.Drawing.Size(220, 43);
            this.btn_Produits.TabIndex = 0;
            this.btn_Produits.Text = "Produits";
            this.btn_Produits.UseVisualStyleBackColor = true;
            this.btn_Produits.Click += new System.EventHandler(this.btn_Produits_Click);
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Location = new System.Drawing.Point(726, 418);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(220, 43);
            this.btn_Quitter.TabIndex = 0;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 473);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Connexion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Fournisseur;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Produits;
        private System.Windows.Forms.Button btn_Quitter;
    }
}