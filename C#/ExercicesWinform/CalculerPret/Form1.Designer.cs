namespace CalculerPret
{
    partial class FormEmprunt
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblCapital = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.lblPeriodicite = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nom";
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Location = new System.Drawing.Point(41, 108);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(110, 16);
            this.lblCapital.TabIndex = 0;
            this.lblCapital.Text = "Capital Emprunté";
            // 
            // lblDuree
            // 
            this.lblDuree.Location = new System.Drawing.Point(41, 161);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(130, 40);
            this.lblDuree.TabIndex = 0;
            this.lblDuree.Text = "Durée en mois du remboursement";
            // 
            // lblPeriodicite
            // 
            this.lblPeriodicite.AutoSize = true;
            this.lblPeriodicite.Location = new System.Drawing.Point(41, 235);
            this.lblPeriodicite.Name = "lblPeriodicite";
            this.lblPeriodicite.Size = new System.Drawing.Size(188, 16);
            this.lblPeriodicite.TabIndex = 0;
            this.lblPeriodicite.Text = "Périodicité de remboursement";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(182, 102);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(176, 22);
            this.txtCapital.TabIndex = 1;
            // 
            // FormEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 554);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblPeriodicite);
            this.Controls.Add(this.lblCapital);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEmprunt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprunts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.Label lblPeriodicite;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCapital;
    }
}

