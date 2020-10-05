namespace Calculatrice
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
            this.btnCalculer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.txtAffichage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(194, 241);
            this.btnCalculer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(104, 37);
            this.btnCalculer.TabIndex = 0;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(29, 241);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(104, 37);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(29, 115);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(49, 44);
            this.btn0.TabIndex = 3;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Numbers);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(29, 165);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(49, 44);
            this.btn5.TabIndex = 3;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Numbers);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(84, 115);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(49, 44);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Numbers);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(84, 165);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(49, 44);
            this.btn6.TabIndex = 3;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Numbers);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(139, 115);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(49, 44);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Numbers);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(194, 115);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(49, 44);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Numbers);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(139, 165);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(49, 44);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Numbers);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(194, 165);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(49, 44);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Numbers);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(249, 115);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(49, 44);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Numbers);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(249, 165);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(49, 44);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Numbers);
            // 
            // txtAffichage
            // 
            this.txtAffichage.BackColor = System.Drawing.Color.White;
            this.txtAffichage.Location = new System.Drawing.Point(29, 25);
            this.txtAffichage.Multiline = true;
            this.txtAffichage.Name = "txtAffichage";
            this.txtAffichage.ReadOnly = true;
            this.txtAffichage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAffichage.Size = new System.Drawing.Size(269, 73);
            this.txtAffichage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 303);
            this.Controls.Add(this.txtAffichage);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnCalculer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Additionneur";
            this.Load += new System.EventHandler(this.Additionneur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.TextBox txtAffichage;
    }
}

