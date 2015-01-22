namespace Mercure
{
    partial class ConfigUrlService
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_ConfURL_Valider = new System.Windows.Forms.Button();
            this.buttonConfURLQuit = new System.Windows.Forms.Button();
            this.textbox_UrlServiceWeb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL Service Web";
            // 
            // button_ConfURL_Valider
            // 
            this.button_ConfURL_Valider.Location = new System.Drawing.Point(201, 102);
            this.button_ConfURL_Valider.Name = "button_ConfURL_Valider";
            this.button_ConfURL_Valider.Size = new System.Drawing.Size(75, 23);
            this.button_ConfURL_Valider.TabIndex = 1;
            this.button_ConfURL_Valider.Text = "Valider";
            this.button_ConfURL_Valider.UseVisualStyleBackColor = true;
            this.button_ConfURL_Valider.Click += new System.EventHandler(this.button_ConfURL_Valider_Click);
            // 
            // buttonConfURLQuit
            // 
            this.buttonConfURLQuit.Location = new System.Drawing.Point(326, 102);
            this.buttonConfURLQuit.Name = "buttonConfURLQuit";
            this.buttonConfURLQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonConfURLQuit.TabIndex = 2;
            this.buttonConfURLQuit.Text = "Quiter";
            this.buttonConfURLQuit.UseVisualStyleBackColor = true;
            this.buttonConfURLQuit.Click += new System.EventHandler(this.button_ConfURL_Annuler_Click);
            // 
            // textbox_UrlServiceWeb
            // 
            this.textbox_UrlServiceWeb.AllowDrop = true;
            this.textbox_UrlServiceWeb.Location = new System.Drawing.Point(125, 46);
            this.textbox_UrlServiceWeb.Name = "textbox_UrlServiceWeb";
            this.textbox_UrlServiceWeb.Size = new System.Drawing.Size(263, 20);
            this.textbox_UrlServiceWeb.TabIndex = 3;
            this.textbox_UrlServiceWeb.Text = "http://localhost:1438/Sources/Mercure.asmx";
            // 
            // ConfigUrlService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 154);
            this.Controls.Add(this.textbox_UrlServiceWeb);
            this.Controls.Add(this.buttonConfURLQuit);
            this.Controls.Add(this.button_ConfURL_Valider);
            this.Controls.Add(this.label1);
            this.Name = "ConfigUrlService";
            this.Text = "Configuration URL Service Web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ConfURL_Valider;
        private System.Windows.Forms.Button buttonConfURLQuit;
        private System.Windows.Forms.TextBox textbox_UrlServiceWeb;
    }
}