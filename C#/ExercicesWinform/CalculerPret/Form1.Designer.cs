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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCapital = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.lblPeriodicite = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.listBoxPeriodicite = new System.Windows.Forms.ListBox();
            this.lblScroll = new System.Windows.Forms.Label();
            this.hScrollBarDureeMois = new System.Windows.Forms.HScrollBar();
            this.gBoxTauxDInteret = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblNombreDRembours = new System.Windows.Forms.Label();
            this.lblRemboursement = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBoxTauxDInteret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nom";
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Location = new System.Drawing.Point(18, 89);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(110, 16);
            this.lblCapital.TabIndex = 0;
            this.lblCapital.Text = "Capital Emprunté";
            // 
            // lblDuree
            // 
            this.lblDuree.Location = new System.Drawing.Point(18, 142);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(130, 40);
            this.lblDuree.TabIndex = 0;
            this.lblDuree.Text = "Durée en mois du remboursement";
            // 
            // lblPeriodicite
            // 
            this.lblPeriodicite.AutoSize = true;
            this.lblPeriodicite.Location = new System.Drawing.Point(18, 224);
            this.lblPeriodicite.Name = "lblPeriodicite";
            this.lblPeriodicite.Size = new System.Drawing.Size(188, 16);
            this.lblPeriodicite.TabIndex = 0;
            this.lblPeriodicite.Text = "Périodicité de remboursement";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(159, 83);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(176, 22);
            this.txtCapital.TabIndex = 1;
            this.txtCapital.TextChanged += new System.EventHandler(this.txtCapital_TextChanged);
            // 
            // listBoxPeriodicite
            // 
            this.listBoxPeriodicite.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxPeriodicite.FormattingEnabled = true;
            this.listBoxPeriodicite.ItemHeight = 16;
            this.listBoxPeriodicite.Items.AddRange(new object[] {
            "Mensuelle",
            "Bimestrielle",
            "Trimestrielle",
            "Semestrielle",
            "Annuelle"});
            this.listBoxPeriodicite.Location = new System.Drawing.Point(21, 243);
            this.listBoxPeriodicite.Name = "listBoxPeriodicite";
            this.listBoxPeriodicite.Size = new System.Drawing.Size(310, 84);
            this.listBoxPeriodicite.TabIndex = 2;
            this.listBoxPeriodicite.SelectedIndexChanged += new System.EventHandler(this.listBoxPeriodicite_SelectedIndexChanged);
            // 
            // lblScroll
            // 
            this.lblScroll.AutoSize = true;
            this.lblScroll.Location = new System.Drawing.Point(172, 145);
            this.lblScroll.Name = "lblScroll";
            this.lblScroll.Size = new System.Drawing.Size(0, 16);
            this.lblScroll.TabIndex = 0;
            // 
            // hScrollBarDureeMois
            // 
            this.hScrollBarDureeMois.LargeChange = 1;
            this.hScrollBarDureeMois.Location = new System.Drawing.Point(224, 145);
            this.hScrollBarDureeMois.Maximum = 180;
            this.hScrollBarDureeMois.Name = "hScrollBarDureeMois";
            this.hScrollBarDureeMois.Size = new System.Drawing.Size(194, 26);
            this.hScrollBarDureeMois.TabIndex = 3;
            this.hScrollBarDureeMois.Value = 1;
            this.hScrollBarDureeMois.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarDureeMois_Scroll);
            // 
            // gBoxTauxDInteret
            // 
            this.gBoxTauxDInteret.Controls.Add(this.radioButton9);
            this.gBoxTauxDInteret.Controls.Add(this.radioButton8);
            this.gBoxTauxDInteret.Controls.Add(this.radioButton7);
            this.gBoxTauxDInteret.Location = new System.Drawing.Point(458, 29);
            this.gBoxTauxDInteret.Name = "gBoxTauxDInteret";
            this.gBoxTauxDInteret.Size = new System.Drawing.Size(117, 187);
            this.gBoxTauxDInteret.TabIndex = 4;
            this.gBoxTauxDInteret.TabStop = false;
            this.gBoxTauxDInteret.Text = "Taux d\'intérêt";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(37, 133);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(45, 20);
            this.radioButton9.TabIndex = 0;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "9%";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(37, 87);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(45, 20);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "8%";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(37, 42);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(45, 20);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "7%";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(609, 48);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 28);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(609, 99);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(93, 28);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblNombreDRembours
            // 
            this.lblNombreDRembours.AutoSize = true;
            this.lblNombreDRembours.ForeColor = System.Drawing.Color.Red;
            this.lblNombreDRembours.Location = new System.Drawing.Point(446, 243);
            this.lblNombreDRembours.Name = "lblNombreDRembours";
            this.lblNombreDRembours.Size = new System.Drawing.Size(0, 16);
            this.lblNombreDRembours.TabIndex = 0;
            // 
            // lblRemboursement
            // 
            this.lblRemboursement.AutoSize = true;
            this.lblRemboursement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemboursement.Location = new System.Drawing.Point(513, 243);
            this.lblRemboursement.Name = "lblRemboursement";
            this.lblRemboursement.Size = new System.Drawing.Size(141, 18);
            this.lblRemboursement.TabIndex = 0;
            this.lblRemboursement.Text = "Remboursements";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.ForeColor = System.Drawing.Color.Red;
            this.lblMontant.Location = new System.Drawing.Point(540, 282);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(0, 16);
            this.lblMontant.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FormEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 342);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gBoxTauxDInteret);
            this.Controls.Add(this.hScrollBarDureeMois);
            this.Controls.Add(this.listBoxPeriodicite);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblPeriodicite);
            this.Controls.Add(this.lblCapital);
            this.Controls.Add(this.lblScroll);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblNombreDRembours);
            this.Controls.Add(this.lblRemboursement);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEmprunt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprunts";
            this.gBoxTauxDInteret.ResumeLayout(false);
            this.gBoxTauxDInteret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
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
        private System.Windows.Forms.ListBox listBoxPeriodicite;
        private System.Windows.Forms.Label lblScroll;
        private System.Windows.Forms.HScrollBar hScrollBarDureeMois;
        private System.Windows.Forms.GroupBox gBoxTauxDInteret;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblNombreDRembours;
        private System.Windows.Forms.Label lblRemboursement;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

