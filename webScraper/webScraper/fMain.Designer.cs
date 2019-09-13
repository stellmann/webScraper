namespace webScraper
{
    partial class fMain
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
            this.tbxURL = new System.Windows.Forms.TextBox();
            this.btnWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxURL
            // 
            this.tbxURL.Location = new System.Drawing.Point(12, 12);
            this.tbxURL.Name = "tbxURL";
            this.tbxURL.Size = new System.Drawing.Size(324, 20);
            this.tbxURL.TabIndex = 0;
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(342, 10);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(75, 23);
            this.btnWork.TabIndex = 1;
            this.btnWork.Text = "Scrape";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 42);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.tbxURL);
            this.Name = "fMain";
            this.Text = "webScraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxURL;
        private System.Windows.Forms.Button btnWork;
    }
}

