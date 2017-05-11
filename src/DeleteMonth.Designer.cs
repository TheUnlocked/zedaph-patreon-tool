namespace ZedaphPatreonTool
{
    partial class DeleteMonth
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
            this.monthListDelete = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backup = new System.Windows.Forms.CheckBox();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthListDelete
            // 
            this.monthListDelete.FormattingEnabled = true;
            this.monthListDelete.Location = new System.Drawing.Point(89, 9);
            this.monthListDelete.Name = "monthListDelete";
            this.monthListDelete.Size = new System.Drawing.Size(129, 21);
            this.monthListDelete.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Month Name:";
            // 
            // backup
            // 
            this.backup.AutoSize = true;
            this.backup.Checked = true;
            this.backup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backup.Location = new System.Drawing.Point(12, 36);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(103, 17);
            this.backup.TabIndex = 7;
            this.backup.Text = "Create Backup?";
            this.backup.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(8, 59);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(210, 23);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete Month";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // DeleteMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 90);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.backup);
            this.Controls.Add(this.monthListDelete);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeleteMonth";
            this.Text = "Delete Month";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox monthListDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox backup;
        private System.Windows.Forms.Button delete;
    }
}