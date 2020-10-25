namespace LesListesEtProprietes
{
    partial class LesListes
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
            this.lblNouvelElement = new System.Windows.Forms.Label();
            this.lblIndexElement = new System.Windows.Forms.Label();
            this.lblLst = new System.Windows.Forms.Label();
            this.lblProprietes = new System.Windows.Forms.Label();
            this.txtNouvelElement = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnAjoutListe = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnViderListe = new System.Windows.Forms.Button();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.lblSelectedIndex = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.txtItemsCount = new System.Windows.Forms.TextBox();
            this.txtSelectedIndex = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.listBoxLst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNouvelElement
            // 
            this.lblNouvelElement.AutoSize = true;
            this.lblNouvelElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNouvelElement.Location = new System.Drawing.Point(12, 25);
            this.lblNouvelElement.Name = "lblNouvelElement";
            this.lblNouvelElement.Size = new System.Drawing.Size(134, 20);
            this.lblNouvelElement.TabIndex = 0;
            this.lblNouvelElement.Text = "Nouvel Elément";
            // 
            // lblIndexElement
            // 
            this.lblIndexElement.AutoSize = true;
            this.lblIndexElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexElement.Location = new System.Drawing.Point(304, 25);
            this.lblIndexElement.Name = "lblIndexElement";
            this.lblIndexElement.Size = new System.Drawing.Size(124, 20);
            this.lblIndexElement.TabIndex = 0;
            this.lblIndexElement.Text = "Index Elément";
            // 
            // lblLst
            // 
            this.lblLst.AutoSize = true;
            this.lblLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLst.Location = new System.Drawing.Point(12, 196);
            this.lblLst.Name = "lblLst";
            this.lblLst.Size = new System.Drawing.Size(73, 20);
            this.lblLst.TabIndex = 0;
            this.lblLst.Text = "LstListe";
            // 
            // lblProprietes
            // 
            this.lblProprietes.AutoSize = true;
            this.lblProprietes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProprietes.Location = new System.Drawing.Point(304, 196);
            this.lblProprietes.Name = "lblProprietes";
            this.lblProprietes.Size = new System.Drawing.Size(91, 20);
            this.lblProprietes.TabIndex = 0;
            this.lblProprietes.Text = "Propriétés";
            // 
            // txtNouvelElement
            // 
            this.txtNouvelElement.Location = new System.Drawing.Point(18, 66);
            this.txtNouvelElement.Name = "txtNouvelElement";
            this.txtNouvelElement.Size = new System.Drawing.Size(214, 26);
            this.txtNouvelElement.TabIndex = 0;
            this.txtNouvelElement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNouvelElement_KeyPress);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(308, 66);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(59, 26);
            this.txtIndex.TabIndex = 1;
            this.txtIndex.TextChanged += new System.EventHandler(this.txtIndex_TextChanged);
            // 
            // btnAjoutListe
            // 
            this.btnAjoutListe.Location = new System.Drawing.Point(19, 114);
            this.btnAjoutListe.Name = "btnAjoutListe";
            this.btnAjoutListe.Size = new System.Drawing.Size(212, 28);
            this.btnAjoutListe.TabIndex = 2;
            this.btnAjoutListe.Text = "Ajout Liste";
            this.btnAjoutListe.UseVisualStyleBackColor = true;
            this.btnAjoutListe.Click += new System.EventHandler(this.btnAjoutListe_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(395, 66);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(200, 26);
            this.btnSelectionner.TabIndex = 2;
            this.btnSelectionner.Text = "Séléctionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // btnViderListe
            // 
            this.btnViderListe.Location = new System.Drawing.Point(395, 114);
            this.btnViderListe.Name = "btnViderListe";
            this.btnViderListe.Size = new System.Drawing.Size(200, 26);
            this.btnViderListe.TabIndex = 2;
            this.btnViderListe.Text = "Vider la Liste";
            this.btnViderListe.UseVisualStyleBackColor = true;
            this.btnViderListe.Click += new System.EventHandler(this.btnViderListe_Click);
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.AutoSize = true;
            this.lblItemsCount.Location = new System.Drawing.Point(304, 253);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(96, 20);
            this.lblItemsCount.TabIndex = 3;
            this.lblItemsCount.Text = "Items.Count";
            // 
            // lblSelectedIndex
            // 
            this.lblSelectedIndex.AutoSize = true;
            this.lblSelectedIndex.Location = new System.Drawing.Point(304, 303);
            this.lblSelectedIndex.Name = "lblSelectedIndex";
            this.lblSelectedIndex.Size = new System.Drawing.Size(111, 20);
            this.lblSelectedIndex.TabIndex = 3;
            this.lblSelectedIndex.Text = "SelectedIndex";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(304, 349);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(39, 20);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "Text";
            // 
            // txtItemsCount
            // 
            this.txtItemsCount.Enabled = false;
            this.txtItemsCount.Location = new System.Drawing.Point(448, 247);
            this.txtItemsCount.Name = "txtItemsCount";
            this.txtItemsCount.Size = new System.Drawing.Size(53, 26);
            this.txtItemsCount.TabIndex = 4;
            // 
            // txtSelectedIndex
            // 
            this.txtSelectedIndex.Enabled = false;
            this.txtSelectedIndex.Location = new System.Drawing.Point(448, 297);
            this.txtSelectedIndex.Name = "txtSelectedIndex";
            this.txtSelectedIndex.Size = new System.Drawing.Size(53, 26);
            this.txtSelectedIndex.TabIndex = 4;
            // 
            // txtText
            // 
            this.txtText.Enabled = false;
            this.txtText.Location = new System.Drawing.Point(448, 343);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(147, 26);
            this.txtText.TabIndex = 4;
            // 
            // listBoxLst
            // 
            this.listBoxLst.FormattingEnabled = true;
            this.listBoxLst.ItemHeight = 20;
            this.listBoxLst.Location = new System.Drawing.Point(20, 232);
            this.listBoxLst.Name = "listBoxLst";
            this.listBoxLst.Size = new System.Drawing.Size(211, 144);
            this.listBoxLst.TabIndex = 5;
            this.listBoxLst.SelectedIndexChanged += new System.EventHandler(this.listBoxLst_SelectedIndexChanged);
            // 
            // LesListes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 398);
            this.Controls.Add(this.listBoxLst);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtSelectedIndex);
            this.Controls.Add(this.txtItemsCount);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblSelectedIndex);
            this.Controls.Add(this.lblItemsCount);
            this.Controls.Add(this.btnViderListe);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnAjoutListe);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtNouvelElement);
            this.Controls.Add(this.lblIndexElement);
            this.Controls.Add(this.lblProprietes);
            this.Controls.Add(this.lblLst);
            this.Controls.Add(this.lblNouvelElement);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LesListes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les Listes et leurs propriétés";
            this.Load += new System.EventHandler(this.LesListes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNouvelElement;
        private System.Windows.Forms.Label lblIndexElement;
        private System.Windows.Forms.Label lblLst;
        private System.Windows.Forms.Label lblProprietes;
        private System.Windows.Forms.TextBox txtNouvelElement;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btnAjoutListe;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnViderListe;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.Label lblSelectedIndex;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtItemsCount;
        private System.Windows.Forms.TextBox txtSelectedIndex;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.ListBox listBoxLst;
    }
}

