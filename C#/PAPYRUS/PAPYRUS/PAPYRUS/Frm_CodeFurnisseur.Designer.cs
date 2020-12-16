
namespace PAPYRUS
{
    partial class Frm_CodeFurnisseur
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
            this.lbl_codeFurnisseur = new System.Windows.Forms.Label();
            this.txt_CodeFurnisseur = new System.Windows.Forms.TextBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Qitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_codeFurnisseur
            // 
            this.lbl_codeFurnisseur.AutoSize = true;
            this.lbl_codeFurnisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codeFurnisseur.Location = new System.Drawing.Point(27, 30);
            this.lbl_codeFurnisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codeFurnisseur.Name = "lbl_codeFurnisseur";
            this.lbl_codeFurnisseur.Size = new System.Drawing.Size(130, 20);
            this.lbl_codeFurnisseur.TabIndex = 0;
            this.lbl_codeFurnisseur.Text = "Code fournisseur";
            // 
            // txt_CodeFurnisseur
            // 
            this.txt_CodeFurnisseur.Location = new System.Drawing.Point(210, 27);
            this.txt_CodeFurnisseur.Name = "txt_CodeFurnisseur";
            this.txt_CodeFurnisseur.Size = new System.Drawing.Size(172, 26);
            this.txt_CodeFurnisseur.TabIndex = 1;
            this.txt_CodeFurnisseur.TextChanged += new System.EventHandler(this.txt_CodeFurnisseur_TextChanged);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Enabled = false;
            this.btn_Valider.Location = new System.Drawing.Point(31, 99);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(144, 38);
            this.btn_Valider.TabIndex = 2;
            this.btn_Valider.Text = "Rechercher";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // btn_Qitter
            // 
            this.btn_Qitter.Location = new System.Drawing.Point(238, 99);
            this.btn_Qitter.Name = "btn_Qitter";
            this.btn_Qitter.Size = new System.Drawing.Size(144, 38);
            this.btn_Qitter.TabIndex = 2;
            this.btn_Qitter.Text = "Quitter";
            this.btn_Qitter.UseVisualStyleBackColor = true;
            this.btn_Qitter.Click += new System.EventHandler(this.btn_Qitter_Click);
            // 
            // Frm_CodeFurnisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 175);
            this.Controls.Add(this.btn_Qitter);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.txt_CodeFurnisseur);
            this.Controls.Add(this.lbl_codeFurnisseur);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_CodeFurnisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Affichage Fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codeFurnisseur;
        private System.Windows.Forms.TextBox txt_CodeFurnisseur;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Qitter;
    }
}