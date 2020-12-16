
namespace PAPYRUS
{
    partial class Frm_Produits
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
            this.listBox_Produits = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_Libelle = new System.Windows.Forms.TextBox();
            this.txt_Stock_Alert = new System.Windows.Forms.TextBox();
            this.txt_Stock_Ph = new System.Windows.Forms.TextBox();
            this.txt_Unite = new System.Windows.Forms.TextBox();
            this.txt_Q_Annuelle = new System.Windows.Forms.TextBox();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_MAJ = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Creer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Produits
            // 
            this.listBox_Produits.FormattingEnabled = true;
            this.listBox_Produits.ItemHeight = 20;
            this.listBox_Produits.Location = new System.Drawing.Point(21, 58);
            this.listBox_Produits.Name = "listBox_Produits";
            this.listBox_Produits.Size = new System.Drawing.Size(329, 144);
            this.listBox_Produits.TabIndex = 0;
            this.listBox_Produits.SelectedIndexChanged += new System.EventHandler(this.listBox_Produits_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "List des produits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock d\'alerte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Libellé";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Stock physique";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quantité annuelle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Unité de mesure";
            // 
            // txt_Code
            // 
            this.txt_Code.Enabled = false;
            this.txt_Code.Location = new System.Drawing.Point(171, 30);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(152, 26);
            this.txt_Code.TabIndex = 3;
            // 
            // txt_Libelle
            // 
            this.txt_Libelle.Enabled = false;
            this.txt_Libelle.Location = new System.Drawing.Point(171, 72);
            this.txt_Libelle.Name = "txt_Libelle";
            this.txt_Libelle.Size = new System.Drawing.Size(152, 26);
            this.txt_Libelle.TabIndex = 3;
            // 
            // txt_Stock_Alert
            // 
            this.txt_Stock_Alert.Enabled = false;
            this.txt_Stock_Alert.Location = new System.Drawing.Point(171, 112);
            this.txt_Stock_Alert.Name = "txt_Stock_Alert";
            this.txt_Stock_Alert.Size = new System.Drawing.Size(152, 26);
            this.txt_Stock_Alert.TabIndex = 3;
            // 
            // txt_Stock_Ph
            // 
            this.txt_Stock_Ph.Enabled = false;
            this.txt_Stock_Ph.Location = new System.Drawing.Point(171, 154);
            this.txt_Stock_Ph.Name = "txt_Stock_Ph";
            this.txt_Stock_Ph.Size = new System.Drawing.Size(152, 26);
            this.txt_Stock_Ph.TabIndex = 3;
            // 
            // txt_Unite
            // 
            this.txt_Unite.Enabled = false;
            this.txt_Unite.Location = new System.Drawing.Point(171, 243);
            this.txt_Unite.Name = "txt_Unite";
            this.txt_Unite.Size = new System.Drawing.Size(152, 26);
            this.txt_Unite.TabIndex = 3;
            // 
            // txt_Q_Annuelle
            // 
            this.txt_Q_Annuelle.Enabled = false;
            this.txt_Q_Annuelle.Location = new System.Drawing.Point(171, 198);
            this.txt_Q_Annuelle.Name = "txt_Q_Annuelle";
            this.txt_Q_Annuelle.Size = new System.Drawing.Size(152, 26);
            this.txt_Q_Annuelle.TabIndex = 3;
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Location = new System.Drawing.Point(21, 351);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(104, 28);
            this.btn_Quitter.TabIndex = 4;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Valider);
            this.groupBox1.Controls.Add(this.btn_Annuler);
            this.groupBox1.Controls.Add(this.txt_Q_Annuelle);
            this.groupBox1.Controls.Add(this.txt_Unite);
            this.groupBox1.Controls.Add(this.txt_Stock_Ph);
            this.groupBox1.Controls.Add(this.txt_Stock_Alert);
            this.groupBox1.Controls.Add(this.txt_Libelle);
            this.groupBox1.Controls.Add(this.txt_Code);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(371, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 353);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(105, 313);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(104, 30);
            this.btn_Valider.TabIndex = 6;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(224, 313);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(104, 30);
            this.btn_Annuler.TabIndex = 6;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_MAJ
            // 
            this.btn_MAJ.Enabled = false;
            this.btn_MAJ.Location = new System.Drawing.Point(134, 300);
            this.btn_MAJ.Name = "btn_MAJ";
            this.btn_MAJ.Size = new System.Drawing.Size(104, 30);
            this.btn_MAJ.TabIndex = 6;
            this.btn_MAJ.Text = "MAJ Base";
            this.btn_MAJ.UseVisualStyleBackColor = true;
            this.btn_MAJ.Click += new System.EventHandler(this.Btn_MAJ_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Enabled = false;
            this.btn_Supprimer.Location = new System.Drawing.Point(246, 300);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(104, 30);
            this.btn_Supprimer.TabIndex = 6;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Creer
            // 
            this.btn_Creer.Location = new System.Drawing.Point(21, 300);
            this.btn_Creer.Name = "btn_Creer";
            this.btn_Creer.Size = new System.Drawing.Size(104, 30);
            this.btn_Creer.TabIndex = 6;
            this.btn_Creer.Text = "Creer";
            this.btn_Creer.UseVisualStyleBackColor = true;
            this.btn_Creer.Click += new System.EventHandler(this.btn_Creer_Click);
            // 
            // Frm_Produits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 391);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Creer);
            this.Controls.Add(this.btn_MAJ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Produits);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Produits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Affichage des produits";
            this.Activated += new System.EventHandler(this.Frm_Produits_Activated);
            this.Load += new System.EventHandler(this.Frm_Produits_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Produits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.TextBox txt_Libelle;
        private System.Windows.Forms.TextBox txt_Stock_Alert;
        private System.Windows.Forms.TextBox txt_Stock_Ph;
        private System.Windows.Forms.TextBox txt_Unite;
        private System.Windows.Forms.TextBox txt_Q_Annuelle;
        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_MAJ;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Creer;
    }
}