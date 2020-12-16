
namespace PAPYRUS
{
    partial class Frm_RechercheFurnisseur
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
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Rue = new System.Windows.Forms.TextBox();
            this.txt_CP = new System.Windows.Forms.TextBox();
            this.txt_Ville = new System.Windows.Forms.TextBox();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.txt_Satisfaction = new System.Windows.Forms.TextBox();
            this.btn_Retour = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Creer = new System.Windows.Forms.Button();
            this.txt_Num_Rue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(166, 24);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(247, 26);
            this.txt_Nom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "CP/Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Satisfaction";
            // 
            // txt_Rue
            // 
            this.txt_Rue.Location = new System.Drawing.Point(210, 74);
            this.txt_Rue.Name = "txt_Rue";
            this.txt_Rue.Size = new System.Drawing.Size(203, 26);
            this.txt_Rue.TabIndex = 2;
            // 
            // txt_CP
            // 
            this.txt_CP.Location = new System.Drawing.Point(166, 119);
            this.txt_CP.Name = "txt_CP";
            this.txt_CP.Size = new System.Drawing.Size(82, 26);
            this.txt_CP.TabIndex = 3;
            // 
            // txt_Ville
            // 
            this.txt_Ville.Location = new System.Drawing.Point(263, 119);
            this.txt_Ville.Name = "txt_Ville";
            this.txt_Ville.Size = new System.Drawing.Size(150, 26);
            this.txt_Ville.TabIndex = 4;
            // 
            // txt_Contact
            // 
            this.txt_Contact.Location = new System.Drawing.Point(166, 194);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(247, 26);
            this.txt_Contact.TabIndex = 5;
            // 
            // txt_Satisfaction
            // 
            this.txt_Satisfaction.Location = new System.Drawing.Point(166, 256);
            this.txt_Satisfaction.Name = "txt_Satisfaction";
            this.txt_Satisfaction.Size = new System.Drawing.Size(54, 26);
            this.txt_Satisfaction.TabIndex = 6;
            // 
            // btn_Retour
            // 
            this.btn_Retour.Location = new System.Drawing.Point(297, 316);
            this.btn_Retour.Name = "btn_Retour";
            this.btn_Retour.Size = new System.Drawing.Size(116, 37);
            this.btn_Retour.TabIndex = 0;
            this.btn_Retour.Text = "Retour";
            this.btn_Retour.UseVisualStyleBackColor = true;
            this.btn_Retour.Click += new System.EventHandler(this.btn_Retour_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(164, 316);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(116, 37);
            this.btn_Edit.TabIndex = 0;
            this.btn_Edit.Text = "Mise à jour";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(30, 316);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(116, 37);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "Supprimer";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Creer
            // 
            this.btn_Creer.Location = new System.Drawing.Point(297, 251);
            this.btn_Creer.Name = "btn_Creer";
            this.btn_Creer.Size = new System.Drawing.Size(116, 37);
            this.btn_Creer.TabIndex = 0;
            this.btn_Creer.Text = "Créer";
            this.btn_Creer.UseVisualStyleBackColor = true;
            this.btn_Creer.Click += new System.EventHandler(this.btn_Creer_Click);
            // 
            // txt_Num_Rue
            // 
            this.txt_Num_Rue.Location = new System.Drawing.Point(164, 74);
            this.txt_Num_Rue.Name = "txt_Num_Rue";
            this.txt_Num_Rue.Size = new System.Drawing.Size(40, 26);
            this.txt_Num_Rue.TabIndex = 2;
            // 
            // Frm_RechercheFurnisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 378);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Creer);
            this.Controls.Add(this.btn_Retour);
            this.Controls.Add(this.txt_Ville);
            this.Controls.Add(this.txt_Satisfaction);
            this.Controls.Add(this.txt_Contact);
            this.Controls.Add(this.txt_CP);
            this.Controls.Add(this.txt_Num_Rue);
            this.Controls.Add(this.txt_Rue);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_RechercheFurnisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_RechercheFurnisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Rue;
        private System.Windows.Forms.TextBox txt_CP;
        private System.Windows.Forms.TextBox txt_Ville;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.TextBox txt_Satisfaction;
        private System.Windows.Forms.Button btn_Retour;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Creer;
        private System.Windows.Forms.TextBox txt_Num_Rue;
    }
}