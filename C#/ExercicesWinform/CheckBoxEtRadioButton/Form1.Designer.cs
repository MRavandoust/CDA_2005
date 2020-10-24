namespace CheckBoxEtRadioButton
{
    partial class Form1
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
            this.lblTitr = new System.Windows.Forms.Label();
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.gBChoix = new System.Windows.Forms.GroupBox();
            this.chkBoxCasse = new System.Windows.Forms.CheckBox();
            this.chkBoxCouleurCaracteres = new System.Windows.Forms.CheckBox();
            this.chkBoxCouleurFond = new System.Windows.Forms.CheckBox();
            this.gBoxFond = new System.Windows.Forms.GroupBox();
            this.rButtonBleuF = new System.Windows.Forms.RadioButton();
            this.rButtonVertF = new System.Windows.Forms.RadioButton();
            this.rButtonRougeF = new System.Windows.Forms.RadioButton();
            this.gBoxCaracteres = new System.Windows.Forms.GroupBox();
            this.rButtonNoirC = new System.Windows.Forms.RadioButton();
            this.rButtonRoogeC = new System.Windows.Forms.RadioButton();
            this.rButtonVertC = new System.Windows.Forms.RadioButton();
            this.gBoxCasse = new System.Windows.Forms.GroupBox();
            this.rButtonMaj = new System.Windows.Forms.RadioButton();
            this.rButtonMin = new System.Windows.Forms.RadioButton();
            this.gBChoix.SuspendLayout();
            this.gBoxFond.SuspendLayout();
            this.gBoxCaracteres.SuspendLayout();
            this.gBoxCasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitr
            // 
            this.lblTitr.AutoSize = true;
            this.lblTitr.Location = new System.Drawing.Point(12, 29);
            this.lblTitr.Name = "lblTitr";
            this.lblTitr.Size = new System.Drawing.Size(111, 16);
            this.lblTitr.TabIndex = 0;
            this.lblTitr.Text = "Tapez votre texte";
            // 
            // txtPhrase
            // 
            this.txtPhrase.Location = new System.Drawing.Point(15, 59);
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.Size = new System.Drawing.Size(310, 22);
            this.txtPhrase.TabIndex = 1;
            this.txtPhrase.TextChanged += new System.EventHandler(this.txtPhrase_TextChanged);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.BackColor = System.Drawing.SystemColors.Control;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(22, 129);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 20);
            this.lblResultat.TabIndex = 2;
            // 
            // gBChoix
            // 
            this.gBChoix.Controls.Add(this.chkBoxCasse);
            this.gBChoix.Controls.Add(this.chkBoxCouleurCaracteres);
            this.gBChoix.Controls.Add(this.chkBoxCouleurFond);
            this.gBChoix.Enabled = false;
            this.gBChoix.Location = new System.Drawing.Point(356, 29);
            this.gBChoix.Name = "gBChoix";
            this.gBChoix.Size = new System.Drawing.Size(217, 130);
            this.gBChoix.TabIndex = 3;
            this.gBChoix.TabStop = false;
            this.gBChoix.Text = "Choix";
            // 
            // chkBoxCasse
            // 
            this.chkBoxCasse.AutoSize = true;
            this.chkBoxCasse.Location = new System.Drawing.Point(19, 96);
            this.chkBoxCasse.Name = "chkBoxCasse";
            this.chkBoxCasse.Size = new System.Drawing.Size(66, 20);
            this.chkBoxCasse.TabIndex = 2;
            this.chkBoxCasse.Text = "Casse";
            this.chkBoxCasse.UseVisualStyleBackColor = true;
            this.chkBoxCasse.CheckedChanged += new System.EventHandler(this.chkBoxCasse_CheckedChanged);
            // 
            // chkBoxCouleurCaracteres
            // 
            this.chkBoxCouleurCaracteres.AutoSize = true;
            this.chkBoxCouleurCaracteres.Location = new System.Drawing.Point(19, 69);
            this.chkBoxCouleurCaracteres.Name = "chkBoxCouleurCaracteres";
            this.chkBoxCouleurCaracteres.Size = new System.Drawing.Size(166, 20);
            this.chkBoxCouleurCaracteres.TabIndex = 1;
            this.chkBoxCouleurCaracteres.Text = "Couleur des caractères";
            this.chkBoxCouleurCaracteres.UseVisualStyleBackColor = true;
            this.chkBoxCouleurCaracteres.CheckedChanged += new System.EventHandler(this.chkBoxCouleurCaracteres_CheckedChanged);
            // 
            // chkBoxCouleurFond
            // 
            this.chkBoxCouleurFond.AutoSize = true;
            this.chkBoxCouleurFond.Location = new System.Drawing.Point(19, 43);
            this.chkBoxCouleurFond.Name = "chkBoxCouleurFond";
            this.chkBoxCouleurFond.Size = new System.Drawing.Size(120, 20);
            this.chkBoxCouleurFond.TabIndex = 0;
            this.chkBoxCouleurFond.Text = "Couleur du fond";
            this.chkBoxCouleurFond.UseVisualStyleBackColor = true;
            this.chkBoxCouleurFond.CheckedChanged += new System.EventHandler(this.chkBoxCouleurFond_CheckedChanged);
            // 
            // gBoxFond
            // 
            this.gBoxFond.Controls.Add(this.rButtonBleuF);
            this.gBoxFond.Controls.Add(this.rButtonVertF);
            this.gBoxFond.Controls.Add(this.rButtonRougeF);
            this.gBoxFond.Location = new System.Drawing.Point(22, 232);
            this.gBoxFond.Name = "gBoxFond";
            this.gBoxFond.Size = new System.Drawing.Size(116, 110);
            this.gBoxFond.TabIndex = 4;
            this.gBoxFond.TabStop = false;
            this.gBoxFond.Text = "Fond";
            this.gBoxFond.Visible = false;
            // 
            // rButtonBleuF
            // 
            this.rButtonBleuF.AutoSize = true;
            this.rButtonBleuF.Location = new System.Drawing.Point(6, 73);
            this.rButtonBleuF.Name = "rButtonBleuF";
            this.rButtonBleuF.Size = new System.Drawing.Size(53, 20);
            this.rButtonBleuF.TabIndex = 0;
            this.rButtonBleuF.TabStop = true;
            this.rButtonBleuF.Text = "Bleu";
            this.rButtonBleuF.UseVisualStyleBackColor = true;
            this.rButtonBleuF.CheckedChanged += new System.EventHandler(this.rButtonBleuF_CheckedChanged);
            // 
            // rButtonVertF
            // 
            this.rButtonVertF.AutoSize = true;
            this.rButtonVertF.Location = new System.Drawing.Point(6, 47);
            this.rButtonVertF.Name = "rButtonVertF";
            this.rButtonVertF.Size = new System.Drawing.Size(50, 20);
            this.rButtonVertF.TabIndex = 0;
            this.rButtonVertF.TabStop = true;
            this.rButtonVertF.Text = "Vert";
            this.rButtonVertF.UseVisualStyleBackColor = true;
            this.rButtonVertF.CheckedChanged += new System.EventHandler(this.rButtonVertF_CheckedChanged);
            // 
            // rButtonRougeF
            // 
            this.rButtonRougeF.AutoSize = true;
            this.rButtonRougeF.Location = new System.Drawing.Point(6, 21);
            this.rButtonRougeF.Name = "rButtonRougeF";
            this.rButtonRougeF.Size = new System.Drawing.Size(67, 20);
            this.rButtonRougeF.TabIndex = 0;
            this.rButtonRougeF.TabStop = true;
            this.rButtonRougeF.Text = "Rouge";
            this.rButtonRougeF.UseVisualStyleBackColor = true;
            this.rButtonRougeF.CheckedChanged += new System.EventHandler(this.rButtonRougeF_CheckedChanged);
            // 
            // gBoxCaracteres
            // 
            this.gBoxCaracteres.Controls.Add(this.rButtonNoirC);
            this.gBoxCaracteres.Controls.Add(this.rButtonRoogeC);
            this.gBoxCaracteres.Controls.Add(this.rButtonVertC);
            this.gBoxCaracteres.Location = new System.Drawing.Point(144, 233);
            this.gBoxCaracteres.Name = "gBoxCaracteres";
            this.gBoxCaracteres.Size = new System.Drawing.Size(116, 110);
            this.gBoxCaracteres.TabIndex = 4;
            this.gBoxCaracteres.TabStop = false;
            this.gBoxCaracteres.Text = "Caractères";
            this.gBoxCaracteres.Visible = false;
            // 
            // rButtonNoirC
            // 
            this.rButtonNoirC.AutoSize = true;
            this.rButtonNoirC.Location = new System.Drawing.Point(6, 73);
            this.rButtonNoirC.Name = "rButtonNoirC";
            this.rButtonNoirC.Size = new System.Drawing.Size(51, 20);
            this.rButtonNoirC.TabIndex = 0;
            this.rButtonNoirC.TabStop = true;
            this.rButtonNoirC.Text = "Noir";
            this.rButtonNoirC.UseVisualStyleBackColor = true;
            this.rButtonNoirC.CheckedChanged += new System.EventHandler(this.rButtonNoirC_CheckedChanged);
            // 
            // rButtonRoogeC
            // 
            this.rButtonRoogeC.AutoSize = true;
            this.rButtonRoogeC.Location = new System.Drawing.Point(6, 21);
            this.rButtonRoogeC.Name = "rButtonRoogeC";
            this.rButtonRoogeC.Size = new System.Drawing.Size(67, 20);
            this.rButtonRoogeC.TabIndex = 0;
            this.rButtonRoogeC.TabStop = true;
            this.rButtonRoogeC.Text = "Rouge";
            this.rButtonRoogeC.UseVisualStyleBackColor = true;
            this.rButtonRoogeC.CheckedChanged += new System.EventHandler(this.rButtonRoogeC_CheckedChanged);
            // 
            // rButtonVertC
            // 
            this.rButtonVertC.AutoSize = true;
            this.rButtonVertC.Location = new System.Drawing.Point(6, 47);
            this.rButtonVertC.Name = "rButtonVertC";
            this.rButtonVertC.Size = new System.Drawing.Size(50, 20);
            this.rButtonVertC.TabIndex = 0;
            this.rButtonVertC.TabStop = true;
            this.rButtonVertC.Text = "Vert";
            this.rButtonVertC.UseVisualStyleBackColor = true;
            this.rButtonVertC.CheckedChanged += new System.EventHandler(this.rButtonVertC_CheckedChanged);
            // 
            // gBoxCasse
            // 
            this.gBoxCasse.Controls.Add(this.rButtonMaj);
            this.gBoxCasse.Controls.Add(this.rButtonMin);
            this.gBoxCasse.Location = new System.Drawing.Point(266, 267);
            this.gBoxCasse.Name = "gBoxCasse";
            this.gBoxCasse.Size = new System.Drawing.Size(116, 76);
            this.gBoxCasse.TabIndex = 4;
            this.gBoxCasse.TabStop = false;
            this.gBoxCasse.Text = "Casse";
            this.gBoxCasse.Visible = false;
            // 
            // rButtonMaj
            // 
            this.rButtonMaj.AutoSize = true;
            this.rButtonMaj.Location = new System.Drawing.Point(9, 47);
            this.rButtonMaj.Name = "rButtonMaj";
            this.rButtonMaj.Size = new System.Drawing.Size(94, 20);
            this.rButtonMaj.TabIndex = 0;
            this.rButtonMaj.TabStop = true;
            this.rButtonMaj.Text = "Majuscules";
            this.rButtonMaj.UseVisualStyleBackColor = true;
            this.rButtonMaj.CheckedChanged += new System.EventHandler(this.rButtonMaj_CheckedChanged);
            // 
            // rButtonMin
            // 
            this.rButtonMin.AutoSize = true;
            this.rButtonMin.Location = new System.Drawing.Point(9, 21);
            this.rButtonMin.Name = "rButtonMin";
            this.rButtonMin.Size = new System.Drawing.Size(93, 20);
            this.rButtonMin.TabIndex = 0;
            this.rButtonMin.TabStop = true;
            this.rButtonMin.Text = "Minuscules";
            this.rButtonMin.UseVisualStyleBackColor = true;
            this.rButtonMin.CheckedChanged += new System.EventHandler(this.rButtonMin_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 360);
            this.Controls.Add(this.gBoxCasse);
            this.Controls.Add(this.gBoxCaracteres);
            this.Controls.Add(this.gBoxFond);
            this.Controls.Add(this.gBChoix);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.txtPhrase);
            this.Controls.Add(this.lblTitr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CheckBox st RadioButton";
            this.gBChoix.ResumeLayout(false);
            this.gBChoix.PerformLayout();
            this.gBoxFond.ResumeLayout(false);
            this.gBoxFond.PerformLayout();
            this.gBoxCaracteres.ResumeLayout(false);
            this.gBoxCaracteres.PerformLayout();
            this.gBoxCasse.ResumeLayout(false);
            this.gBoxCasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitr;
        private System.Windows.Forms.TextBox txtPhrase;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.GroupBox gBChoix;
        private System.Windows.Forms.CheckBox chkBoxCasse;
        private System.Windows.Forms.CheckBox chkBoxCouleurCaracteres;
        private System.Windows.Forms.CheckBox chkBoxCouleurFond;
        private System.Windows.Forms.GroupBox gBoxFond;
        private System.Windows.Forms.RadioButton rButtonBleuF;
        private System.Windows.Forms.RadioButton rButtonVertF;
        private System.Windows.Forms.RadioButton rButtonRougeF;
        private System.Windows.Forms.GroupBox gBoxCaracteres;
        private System.Windows.Forms.RadioButton rButtonNoirC;
        private System.Windows.Forms.RadioButton rButtonRoogeC;
        private System.Windows.Forms.RadioButton rButtonVertC;
        private System.Windows.Forms.GroupBox gBoxCasse;
        private System.Windows.Forms.RadioButton rButtonMaj;
        private System.Windows.Forms.RadioButton rButtonMin;
    }
}

