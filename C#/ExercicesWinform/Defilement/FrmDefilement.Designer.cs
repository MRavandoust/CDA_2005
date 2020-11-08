namespace Defilement
{
    partial class FrmDefilement
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
            this.lblRouge = new System.Windows.Forms.Label();
            this.lblVert = new System.Windows.Forms.Label();
            this.lblBleu = new System.Windows.Forms.Label();
            this.hScrollRouge = new System.Windows.Forms.HScrollBar();
            this.hScrollVert = new System.Windows.Forms.HScrollBar();
            this.hScrollBleu = new System.Windows.Forms.HScrollBar();
            this.numUpDownRouge = new System.Windows.Forms.NumericUpDown();
            this.numUpDownVert = new System.Windows.Forms.NumericUpDown();
            this.numUpDownBleu = new System.Windows.Forms.NumericUpDown();
            this.lblColorRouge = new System.Windows.Forms.Label();
            this.lblColorVert = new System.Windows.Forms.Label();
            this.lblColorBleu = new System.Windows.Forms.Label();
            this.lblFinalColor = new System.Windows.Forms.Label();
            this.lblCouleurFin = new System.Windows.Forms.Label();
            this.lblCouleurFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBleu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRouge
            // 
            this.lblRouge.AutoSize = true;
            this.lblRouge.Location = new System.Drawing.Point(14, 67);
            this.lblRouge.Name = "lblRouge";
            this.lblRouge.Size = new System.Drawing.Size(49, 16);
            this.lblRouge.TabIndex = 0;
            this.lblRouge.Text = "Rouge";
            // 
            // lblVert
            // 
            this.lblVert.AutoSize = true;
            this.lblVert.Location = new System.Drawing.Point(14, 116);
            this.lblVert.Name = "lblVert";
            this.lblVert.Size = new System.Drawing.Size(32, 16);
            this.lblVert.TabIndex = 0;
            this.lblVert.Text = "Vert";
            // 
            // lblBleu
            // 
            this.lblBleu.AutoSize = true;
            this.lblBleu.Location = new System.Drawing.Point(14, 158);
            this.lblBleu.Name = "lblBleu";
            this.lblBleu.Size = new System.Drawing.Size(35, 16);
            this.lblBleu.TabIndex = 0;
            this.lblBleu.Text = "Bleu";
            // 
            // hScrollRouge
            // 
            this.hScrollRouge.LargeChange = 1;
            this.hScrollRouge.Location = new System.Drawing.Point(88, 56);
            this.hScrollRouge.Maximum = 255;
            this.hScrollRouge.Name = "hScrollRouge";
            this.hScrollRouge.Size = new System.Drawing.Size(202, 27);
            this.hScrollRouge.TabIndex = 1;
            this.hScrollRouge.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollRouge_Scroll);
            // 
            // hScrollVert
            // 
            this.hScrollVert.LargeChange = 1;
            this.hScrollVert.Location = new System.Drawing.Point(88, 105);
            this.hScrollVert.Maximum = 255;
            this.hScrollVert.Name = "hScrollVert";
            this.hScrollVert.Size = new System.Drawing.Size(202, 27);
            this.hScrollVert.TabIndex = 1;
            this.hScrollVert.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollVert_Scroll);
            // 
            // hScrollBleu
            // 
            this.hScrollBleu.LargeChange = 1;
            this.hScrollBleu.Location = new System.Drawing.Point(88, 147);
            this.hScrollBleu.Maximum = 255;
            this.hScrollBleu.Name = "hScrollBleu";
            this.hScrollBleu.Size = new System.Drawing.Size(202, 27);
            this.hScrollBleu.TabIndex = 1;
            this.hScrollBleu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBleu_Scroll);
            // 
            // numUpDownRouge
            // 
            this.numUpDownRouge.Location = new System.Drawing.Point(326, 61);
            this.numUpDownRouge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDownRouge.Name = "numUpDownRouge";
            this.numUpDownRouge.Size = new System.Drawing.Size(72, 22);
            this.numUpDownRouge.TabIndex = 2;
            this.numUpDownRouge.ValueChanged += new System.EventHandler(this.numUpDownRouge_ValueChanged);
            // 
            // numUpDownVert
            // 
            this.numUpDownVert.Location = new System.Drawing.Point(326, 110);
            this.numUpDownVert.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDownVert.Name = "numUpDownVert";
            this.numUpDownVert.Size = new System.Drawing.Size(72, 22);
            this.numUpDownVert.TabIndex = 2;
            this.numUpDownVert.ValueChanged += new System.EventHandler(this.numUpDownVert_ValueChanged);
            // 
            // numUpDownBleu
            // 
            this.numUpDownBleu.Location = new System.Drawing.Point(326, 152);
            this.numUpDownBleu.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDownBleu.Name = "numUpDownBleu";
            this.numUpDownBleu.Size = new System.Drawing.Size(72, 22);
            this.numUpDownBleu.TabIndex = 2;
            this.numUpDownBleu.ValueChanged += new System.EventHandler(this.numUpDownBleu_ValueChanged);
            // 
            // lblColorRouge
            // 
            this.lblColorRouge.Location = new System.Drawing.Point(427, 65);
            this.lblColorRouge.Name = "lblColorRouge";
            this.lblColorRouge.Size = new System.Drawing.Size(67, 18);
            this.lblColorRouge.TabIndex = 3;
            // 
            // lblColorVert
            // 
            this.lblColorVert.Location = new System.Drawing.Point(427, 116);
            this.lblColorVert.Name = "lblColorVert";
            this.lblColorVert.Size = new System.Drawing.Size(68, 16);
            this.lblColorVert.TabIndex = 3;
            // 
            // lblColorBleu
            // 
            this.lblColorBleu.Location = new System.Drawing.Point(427, 158);
            this.lblColorBleu.Name = "lblColorBleu";
            this.lblColorBleu.Size = new System.Drawing.Size(68, 16);
            this.lblColorBleu.TabIndex = 3;
            // 
            // lblFinalColor
            // 
            this.lblFinalColor.Location = new System.Drawing.Point(17, 214);
            this.lblFinalColor.Name = "lblFinalColor";
            this.lblFinalColor.Size = new System.Drawing.Size(477, 94);
            this.lblFinalColor.TabIndex = 4;
            // 
            // lblCouleurFin
            // 
            this.lblCouleurFin.AutoSize = true;
            this.lblCouleurFin.Location = new System.Drawing.Point(18, 316);
            this.lblCouleurFin.Name = "lblCouleurFin";
            this.lblCouleurFin.Size = new System.Drawing.Size(116, 16);
            this.lblCouleurFin.TabIndex = 5;
            this.lblCouleurFin.Text = "Code de couleur : ";
            // 
            // lblCouleurFinal
            // 
            this.lblCouleurFinal.AutoSize = true;
            this.lblCouleurFinal.Location = new System.Drawing.Point(131, 316);
            this.lblCouleurFinal.Name = "lblCouleurFinal";
            this.lblCouleurFinal.Size = new System.Drawing.Size(0, 16);
            this.lblCouleurFinal.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 341);
            this.Controls.Add(this.lblCouleurFinal);
            this.Controls.Add(this.lblCouleurFin);
            this.Controls.Add(this.lblFinalColor);
            this.Controls.Add(this.lblColorBleu);
            this.Controls.Add(this.lblColorVert);
            this.Controls.Add(this.lblColorRouge);
            this.Controls.Add(this.numUpDownBleu);
            this.Controls.Add(this.numUpDownVert);
            this.Controls.Add(this.numUpDownRouge);
            this.Controls.Add(this.hScrollBleu);
            this.Controls.Add(this.hScrollVert);
            this.Controls.Add(this.hScrollRouge);
            this.Controls.Add(this.lblBleu);
            this.Controls.Add(this.lblVert);
            this.Controls.Add(this.lblRouge);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBleu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRouge;
        private System.Windows.Forms.Label lblVert;
        private System.Windows.Forms.Label lblBleu;
        private System.Windows.Forms.HScrollBar hScrollRouge;
        private System.Windows.Forms.HScrollBar hScrollVert;
        private System.Windows.Forms.HScrollBar hScrollBleu;
        private System.Windows.Forms.NumericUpDown numUpDownRouge;
        private System.Windows.Forms.NumericUpDown numUpDownVert;
        private System.Windows.Forms.NumericUpDown numUpDownBleu;
        private System.Windows.Forms.Label lblColorRouge;
        private System.Windows.Forms.Label lblColorVert;
        private System.Windows.Forms.Label lblColorBleu;
        private System.Windows.Forms.Label lblFinalColor;
        private System.Windows.Forms.Label lblCouleurFin;
        private System.Windows.Forms.Label lblCouleurFinal;
    }
}

