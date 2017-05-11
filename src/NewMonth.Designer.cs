namespace ZedaphPatreonTool
{
    partial class NewMonth
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
            this.monthListCopy = new System.Windows.Forms.ComboBox();
            this.optionCopy = new System.Windows.Forms.RadioButton();
            this.optionSpreadsheet = new System.Windows.Forms.RadioButton();
            this.optionNew = new System.Windows.Forms.RadioButton();
            this.addNewMonth = new System.Windows.Forms.Button();
            this.monthList = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.fileDialogue = new System.Windows.Forms.OpenFileDialog();
            this.fileSelect = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.SuspendLayout();
            // 
            // monthListCopy
            // 
            this.monthListCopy.FormattingEnabled = true;
            this.monthListCopy.Location = new System.Drawing.Point(96, 42);
            this.monthListCopy.Name = "monthListCopy";
            this.monthListCopy.Size = new System.Drawing.Size(117, 21);
            this.monthListCopy.TabIndex = 4;
            this.monthListCopy.SelectedIndexChanged += new System.EventHandler(this.monthListCopy_SelectedIndexChanged);
            // 
            // optionCopy
            // 
            this.optionCopy.AutoSize = true;
            this.optionCopy.Checked = true;
            this.optionCopy.Location = new System.Drawing.Point(12, 43);
            this.optionCopy.Name = "optionCopy";
            this.optionCopy.Size = new System.Drawing.Size(78, 17);
            this.optionCopy.TabIndex = 5;
            this.optionCopy.TabStop = true;
            this.optionCopy.Text = "Copy From:";
            this.optionCopy.UseVisualStyleBackColor = true;
            this.optionCopy.CheckedChanged += new System.EventHandler(this.optionCopy_CheckedChanged);
            // 
            // optionSpreadsheet
            // 
            this.optionSpreadsheet.AutoSize = true;
            this.optionSpreadsheet.Location = new System.Drawing.Point(12, 70);
            this.optionSpreadsheet.Name = "optionSpreadsheet";
            this.optionSpreadsheet.Size = new System.Drawing.Size(139, 17);
            this.optionSpreadsheet.TabIndex = 7;
            this.optionSpreadsheet.TabStop = true;
            this.optionSpreadsheet.Text = "Load from Patreon CSV:";
            this.optionSpreadsheet.UseVisualStyleBackColor = true;
            this.optionSpreadsheet.CheckedChanged += new System.EventHandler(this.optionSpreadsheet_CheckedChanged);
            // 
            // optionNew
            // 
            this.optionNew.AutoSize = true;
            this.optionNew.Location = new System.Drawing.Point(12, 96);
            this.optionNew.Name = "optionNew";
            this.optionNew.Size = new System.Drawing.Size(52, 17);
            this.optionNew.TabIndex = 9;
            this.optionNew.TabStop = true;
            this.optionNew.Text = "Blank";
            this.optionNew.UseVisualStyleBackColor = true;
            this.optionNew.CheckedChanged += new System.EventHandler(this.optionNew_CheckedChanged);
            // 
            // addNewMonth
            // 
            this.addNewMonth.Location = new System.Drawing.Point(12, 129);
            this.addNewMonth.Name = "addNewMonth";
            this.addNewMonth.Size = new System.Drawing.Size(358, 23);
            this.addNewMonth.TabIndex = 10;
            this.addNewMonth.Text = "Create New Month!";
            this.addNewMonth.UseVisualStyleBackColor = true;
            this.addNewMonth.Click += new System.EventHandler(this.addNewMonth_Click);
            // 
            // monthList
            // 
            this.monthList.FormattingEnabled = true;
            this.monthList.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthList.Location = new System.Drawing.Point(13, 13);
            this.monthList.Name = "monthList";
            this.monthList.Size = new System.Drawing.Size(77, 21);
            this.monthList.TabIndex = 11;
            this.monthList.Text = "January";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(96, 14);
            this.year.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(59, 20);
            this.year.TabIndex = 12;
            this.year.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // fileDialogue
            // 
            this.fileDialogue.ReadOnlyChecked = true;
            this.fileDialogue.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialogue_FileOk);
            // 
            // fileSelect
            // 
            this.fileSelect.AutoSize = true;
            this.fileSelect.Location = new System.Drawing.Point(147, 72);
            this.fileSelect.Name = "fileSelect";
            this.fileSelect.Size = new System.Drawing.Size(94, 13);
            this.fileSelect.TabIndex = 13;
            this.fileSelect.TabStop = true;
            this.fileSelect.Text = "Click to Select File";
            this.fileSelect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fileSelect_LinkClicked);
            // 
            // NewMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 162);
            this.Controls.Add(this.fileSelect);
            this.Controls.Add(this.year);
            this.Controls.Add(this.monthList);
            this.Controls.Add(this.addNewMonth);
            this.Controls.Add(this.optionNew);
            this.Controls.Add(this.optionSpreadsheet);
            this.Controls.Add(this.optionCopy);
            this.Controls.Add(this.monthListCopy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewMonth";
            this.Text = "New Month";
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox monthListCopy;
        private System.Windows.Forms.RadioButton optionCopy;
        private System.Windows.Forms.RadioButton optionSpreadsheet;
        private System.Windows.Forms.RadioButton optionNew;
        private System.Windows.Forms.Button addNewMonth;
        private System.Windows.Forms.ComboBox monthList;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.OpenFileDialog fileDialogue;
        private System.Windows.Forms.LinkLabel fileSelect;
    }
}