
namespace Test_Thread
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
            this.btn_synchrone = new System.Windows.Forms.Button();
            this.btn_Asynchrone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_synchrone
            // 
            this.btn_synchrone.Location = new System.Drawing.Point(55, 54);
            this.btn_synchrone.Name = "btn_synchrone";
            this.btn_synchrone.Size = new System.Drawing.Size(127, 34);
            this.btn_synchrone.TabIndex = 0;
            this.btn_synchrone.Text = "Synchrone";
            this.btn_synchrone.UseVisualStyleBackColor = true;
            this.btn_synchrone.Click += new System.EventHandler(this.btn_synchrone_Click);
            // 
            // btn_Asynchrone
            // 
            this.btn_Asynchrone.Location = new System.Drawing.Point(244, 54);
            this.btn_Asynchrone.Name = "btn_Asynchrone";
            this.btn_Asynchrone.Size = new System.Drawing.Size(127, 34);
            this.btn_Asynchrone.TabIndex = 0;
            this.btn_Asynchrone.Text = "Asynchrone";
            this.btn_Asynchrone.UseVisualStyleBackColor = true;
            this.btn_Asynchrone.Click += new System.EventHandler(this.btn_Asynchrone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 156);
            this.Controls.Add(this.btn_Asynchrone);
            this.Controls.Add(this.btn_synchrone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_synchrone;
        private System.Windows.Forms.Button btn_Asynchrone;
    }
}

