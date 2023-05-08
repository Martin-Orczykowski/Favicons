namespace Favicons
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.btnDownloadIcons = new System.Windows.Forms.Button();
            this.flpIcons = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(13, 13);
            this.tbxUrl.Multiline = true;
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(204, 267);
            this.tbxUrl.TabIndex = 0;
            // 
            // btnDownloadIcons
            // 
            this.btnDownloadIcons.Location = new System.Drawing.Point(224, 13);
            this.btnDownloadIcons.Name = "btnDownloadIcons";
            this.btnDownloadIcons.Size = new System.Drawing.Size(115, 23);
            this.btnDownloadIcons.TabIndex = 1;
            this.btnDownloadIcons.Text = "Download Icons";
            this.btnDownloadIcons.UseVisualStyleBackColor = true;
            this.btnDownloadIcons.Click += new System.EventHandler(this.btnDownloadIcons_Click);
            // 
            // flpIcons
            // 
            this.flpIcons.Location = new System.Drawing.Point(13, 287);
            this.flpIcons.Name = "flpIcons";
            this.flpIcons.Size = new System.Drawing.Size(326, 136);
            this.flpIcons.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 488);
            this.Controls.Add(this.flpIcons);
            this.Controls.Add(this.btnDownloadIcons);
            this.Controls.Add(this.tbxUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Button btnDownloadIcons;
        private System.Windows.Forms.FlowLayoutPanel flpIcons;
    }
}

