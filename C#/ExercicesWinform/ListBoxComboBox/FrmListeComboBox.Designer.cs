namespace ListBoxComboBox
{
    partial class FrmListeComboBox
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
            this.lblSource = new System.Windows.Forms.Label();
            this.lblCible = new System.Windows.Forms.Label();
            this.comboSource = new System.Windows.Forms.ComboBox();
            this.listBoxCible = new System.Windows.Forms.ListBox();
            this.btnDroite = new System.Windows.Forms.Button();
            this.btnDroiteAll = new System.Windows.Forms.Button();
            this.btnGaucheAll = new System.Windows.Forms.Button();
            this.btnGauche = new System.Windows.Forms.Button();
            this.btnBas = new System.Windows.Forms.Button();
            this.btnHaut = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(97, 18);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(51, 16);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source";
            // 
            // lblCible
            // 
            this.lblCible.AutoSize = true;
            this.lblCible.Location = new System.Drawing.Point(445, 18);
            this.lblCible.Name = "lblCible";
            this.lblCible.Size = new System.Drawing.Size(39, 16);
            this.lblCible.TabIndex = 0;
            this.lblCible.Text = "Cible";
            // 
            // comboSource
            // 
            this.comboSource.FormattingEnabled = true;
            this.comboSource.Items.AddRange(new object[] {
            "France",
            "Belgique",
            "Allemagne",
            "Japon",
            "Portugal",
            "Grece",
            "Espagne"});
            this.comboSource.Location = new System.Drawing.Point(11, 47);
            this.comboSource.Name = "comboSource";
            this.comboSource.Size = new System.Drawing.Size(218, 24);
            this.comboSource.TabIndex = 0;
            this.comboSource.SelectedIndexChanged += new System.EventHandler(this.comboSource_SelectedIndexChanged);
            this.comboSource.TextChanged += new System.EventHandler(this.comboSource_TextChanged);
            this.comboSource.Click += new System.EventHandler(this.comboSource_Click);
            // 
            // listBoxCible
            // 
            this.listBoxCible.FormattingEnabled = true;
            this.listBoxCible.ItemHeight = 16;
            this.listBoxCible.Location = new System.Drawing.Point(347, 47);
            this.listBoxCible.Name = "listBoxCible";
            this.listBoxCible.Size = new System.Drawing.Size(210, 244);
            this.listBoxCible.TabIndex = 5;
            this.listBoxCible.SelectedIndexChanged += new System.EventHandler(this.listBoxCible_SelectedIndexChanged);
            // 
            // btnDroite
            // 
            this.btnDroite.Enabled = false;
            this.btnDroite.Location = new System.Drawing.Point(258, 47);
            this.btnDroite.Name = "btnDroite";
            this.btnDroite.Size = new System.Drawing.Size(69, 24);
            this.btnDroite.TabIndex = 1;
            this.btnDroite.Text = ">";
            this.btnDroite.UseVisualStyleBackColor = true;
            this.btnDroite.Click += new System.EventHandler(this.btnDroite_Click);
            // 
            // btnDroiteAll
            // 
            this.btnDroiteAll.Location = new System.Drawing.Point(258, 77);
            this.btnDroiteAll.Name = "btnDroiteAll";
            this.btnDroiteAll.Size = new System.Drawing.Size(69, 24);
            this.btnDroiteAll.TabIndex = 4;
            this.btnDroiteAll.Text = ">>";
            this.btnDroiteAll.UseVisualStyleBackColor = true;
            this.btnDroiteAll.Click += new System.EventHandler(this.btnDroiteAll_Click);
            // 
            // btnGaucheAll
            // 
            this.btnGaucheAll.Location = new System.Drawing.Point(258, 267);
            this.btnGaucheAll.Name = "btnGaucheAll";
            this.btnGaucheAll.Size = new System.Drawing.Size(69, 24);
            this.btnGaucheAll.TabIndex = 3;
            this.btnGaucheAll.Text = "<<";
            this.btnGaucheAll.UseVisualStyleBackColor = true;
            this.btnGaucheAll.Click += new System.EventHandler(this.btnGaucheAll_Click);
            // 
            // btnGauche
            // 
            this.btnGauche.Enabled = false;
            this.btnGauche.Location = new System.Drawing.Point(258, 237);
            this.btnGauche.Name = "btnGauche";
            this.btnGauche.Size = new System.Drawing.Size(69, 24);
            this.btnGauche.TabIndex = 5;
            this.btnGauche.Text = "<";
            this.btnGauche.UseVisualStyleBackColor = true;
            this.btnGauche.Click += new System.EventHandler(this.btnGauche_Click);
            // 
            // btnBas
            // 
            this.btnBas.Enabled = false;
            this.btnBas.Image = global::ListBoxComboBox.Properties.Resources.Down;
            this.btnBas.Location = new System.Drawing.Point(461, 297);
            this.btnBas.Name = "btnBas";
            this.btnBas.Size = new System.Drawing.Size(31, 41);
            this.btnBas.TabIndex = 7;
            this.btnBas.UseVisualStyleBackColor = true;
            this.btnBas.Click += new System.EventHandler(this.btnBas_Click);
            // 
            // btnHaut
            // 
            this.btnHaut.Enabled = false;
            this.btnHaut.Image = global::ListBoxComboBox.Properties.Resources.Up1;
            this.btnHaut.Location = new System.Drawing.Point(416, 297);
            this.btnHaut.Name = "btnHaut";
            this.btnHaut.Size = new System.Drawing.Size(31, 41);
            this.btnHaut.TabIndex = 6;
            this.btnHaut.UseVisualStyleBackColor = true;
            this.btnHaut.Click += new System.EventHandler(this.btnHaut_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 359);
            this.Controls.Add(this.btnBas);
            this.Controls.Add(this.btnHaut);
            this.Controls.Add(this.btnDroiteAll);
            this.Controls.Add(this.btnGauche);
            this.Controls.Add(this.btnGaucheAll);
            this.Controls.Add(this.btnDroite);
            this.Controls.Add(this.listBoxCible);
            this.Controls.Add(this.comboSource);
            this.Controls.Add(this.lblCible);
            this.Controls.Add(this.lblSource);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblCible;
        private System.Windows.Forms.ComboBox comboSource;
        private System.Windows.Forms.ListBox listBoxCible;
        private System.Windows.Forms.Button btnDroite;
        private System.Windows.Forms.Button btnDroiteAll;
        private System.Windows.Forms.Button btnGaucheAll;
        private System.Windows.Forms.Button btnGauche;
        private System.Windows.Forms.Button btnHaut;
        private System.Windows.Forms.Button btnBas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

