namespace ZedaphPatreonTool
{
    partial class DefaultPatronValues
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
            this.patronList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.patronList)).BeginInit();
            this.SuspendLayout();
            // 
            // patronList
            // 
            this.patronList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patronList.Location = new System.Drawing.Point(12, 12);
            this.patronList.Name = "patronList";
            this.patronList.Size = new System.Drawing.Size(744, 418);
            this.patronList.TabIndex = 1;
            this.patronList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.patronList_CellEndEdit);
            // 
            // DefaultPatronValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 442);
            this.Controls.Add(this.patronList);
            this.Name = "DefaultPatronValues";
            this.Text = "Patron Defaults";
            ((System.ComponentModel.ISupportInitialize)(this.patronList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView patronList;
    }
}