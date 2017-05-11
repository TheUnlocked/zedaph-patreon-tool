namespace ZedaphPatreonTool
{
    partial class Report
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
            this.reportOut = new System.Windows.Forms.TextBox();
            this.export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportOut
            // 
            this.reportOut.AcceptsReturn = true;
            this.reportOut.Location = new System.Drawing.Point(12, 12);
            this.reportOut.Multiline = true;
            this.reportOut.Name = "reportOut";
            this.reportOut.ReadOnly = true;
            this.reportOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reportOut.Size = new System.Drawing.Size(392, 322);
            this.reportOut.TabIndex = 0;
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(12, 340);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(392, 23);
            this.export.TabIndex = 1;
            this.export.Text = "Export to File";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 375);
            this.Controls.Add(this.export);
            this.Controls.Add(this.reportOut);
            this.Name = "Report";
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reportOut;
        private System.Windows.Forms.Button export;
    }
}