namespace Mercure
{
    partial class AjouterMarques
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
            this.labelTitreAjoutMarq = new System.Windows.Forms.Label();
            this.labelNameMarqu = new System.Windows.Forms.Label();
            this.textBoxNomMarq = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitreAjoutMarq
            // 
            this.labelTitreAjoutMarq.AutoSize = true;
            this.labelTitreAjoutMarq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreAjoutMarq.Location = new System.Drawing.Point(122, 13);
            this.labelTitreAjoutMarq.Name = "labelTitreAjoutMarq";
            this.labelTitreAjoutMarq.Size = new System.Drawing.Size(82, 13);
            this.labelTitreAjoutMarq.TabIndex = 0;
            this.labelTitreAjoutMarq.Text = "Ajout Marque";
            // 
            // labelNameMarqu
            // 
            this.labelNameMarqu.AutoSize = true;
            this.labelNameMarqu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNameMarqu.Location = new System.Drawing.Point(38, 65);
            this.labelNameMarqu.Name = "labelNameMarqu";
            this.labelNameMarqu.Size = new System.Drawing.Size(29, 13);
            this.labelNameMarqu.TabIndex = 1;
            this.labelNameMarqu.Text = "Nom";
            // 
            // textBoxNomMarq
            // 
            this.textBoxNomMarq.Location = new System.Drawing.Point(73, 62);
            this.textBoxNomMarq.Name = "textBoxNomMarq";
            this.textBoxNomMarq.Size = new System.Drawing.Size(195, 20);
            this.textBoxNomMarq.TabIndex = 2;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(41, 119);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 3;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnul
            // 
            this.buttonAnnul.Location = new System.Drawing.Point(193, 119);
            this.buttonAnnul.Name = "buttonAnnul";
            this.buttonAnnul.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnul.TabIndex = 4;
            this.buttonAnnul.Text = "Annuler";
            this.buttonAnnul.UseVisualStyleBackColor = true;
            this.buttonAnnul.Click += new System.EventHandler(this.buttonAnnul_Click);
            // 
            // AjouterMarques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 159);
            this.Controls.Add(this.buttonAnnul);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxNomMarq);
            this.Controls.Add(this.labelNameMarqu);
            this.Controls.Add(this.labelTitreAjoutMarq);
            this.Name = "AjouterMarques";
            this.Text = "AjouterMarque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitreAjoutMarq;
        private System.Windows.Forms.Label labelNameMarqu;
        private System.Windows.Forms.TextBox textBoxNomMarq;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnul;
    }
}