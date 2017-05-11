namespace ZedaphPatreonTool
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.patronListSelected = new System.Windows.Forms.DataGridView();
            this.monthListSelected = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.compareValues = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthListCompare = new System.Windows.Forms.ComboBox();
            this.patronListCompare = new System.Windows.Forms.DataGridView();
            this.lockEditing = new System.Windows.Forms.CheckBox();
            this.addMonth = new System.Windows.Forms.Button();
            this.generateReport = new System.Windows.Forms.Button();
            this.switchSelected = new System.Windows.Forms.Button();
            this.deleteMonth = new System.Windows.Forms.Button();
            this.defaults = new System.Windows.Forms.Button();
            this.defaultsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.applyDefaults = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyDefaults = new System.Windows.Forms.ToolStripMenuItem();
            this.debug = new System.Windows.Forms.Button();
            this.debugMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createAnonymousBackup = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.patronListSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronListCompare)).BeginInit();
            this.defaultsMenu.SuspendLayout();
            this.debugMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // patronListSelected
            // 
            this.patronListSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patronListSelected.Location = new System.Drawing.Point(12, 39);
            this.patronListSelected.Name = "patronListSelected";
            this.patronListSelected.Size = new System.Drawing.Size(743, 250);
            this.patronListSelected.TabIndex = 0;
            this.patronListSelected.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patronListSelected_CellContentClick);
            this.patronListSelected.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.patronListSelected_CellEndEdit);
            this.patronListSelected.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.patronListSelected_CellEndEdit);
            this.patronListSelected.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.patronListSelected_UserDeletedRow);
            // 
            // monthListSelected
            // 
            this.monthListSelected.FormattingEnabled = true;
            this.monthListSelected.Location = new System.Drawing.Point(67, 12);
            this.monthListSelected.Name = "monthListSelected";
            this.monthListSelected.Size = new System.Drawing.Size(121, 21);
            this.monthListSelected.TabIndex = 1;
            this.monthListSelected.SelectedIndexChanged += new System.EventHandler(this.monthListSelected_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // compareValues
            // 
            this.compareValues.AutoSize = true;
            this.compareValues.Checked = true;
            this.compareValues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compareValues.Location = new System.Drawing.Point(764, 322);
            this.compareValues.Name = "compareValues";
            this.compareValues.Size = new System.Drawing.Size(110, 17);
            this.compareValues.TabIndex = 3;
            this.compareValues.Text = "Show Differences";
            this.compareValues.UseVisualStyleBackColor = true;
            this.compareValues.CheckedChanged += new System.EventHandler(this.compareValues_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Compare to:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // monthListCompare
            // 
            this.monthListCompare.FormattingEnabled = true;
            this.monthListCompare.Location = new System.Drawing.Point(82, 295);
            this.monthListCompare.Name = "monthListCompare";
            this.monthListCompare.Size = new System.Drawing.Size(121, 21);
            this.monthListCompare.TabIndex = 5;
            this.monthListCompare.SelectedIndexChanged += new System.EventHandler(this.monthListCompare_SelectedIndexChanged);
            // 
            // patronListCompare
            // 
            this.patronListCompare.AllowUserToAddRows = false;
            this.patronListCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patronListCompare.Cursor = System.Windows.Forms.Cursors.Default;
            this.patronListCompare.Location = new System.Drawing.Point(15, 322);
            this.patronListCompare.Name = "patronListCompare";
            this.patronListCompare.ReadOnly = true;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.patronListCompare.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.patronListCompare.Size = new System.Drawing.Size(743, 250);
            this.patronListCompare.TabIndex = 4;
            this.patronListCompare.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patronListCompare_CellContentClick);
            // 
            // lockEditing
            // 
            this.lockEditing.AutoSize = true;
            this.lockEditing.Location = new System.Drawing.Point(761, 39);
            this.lockEditing.Name = "lockEditing";
            this.lockEditing.Size = new System.Drawing.Size(85, 17);
            this.lockEditing.TabIndex = 7;
            this.lockEditing.Text = "Lock Editing";
            this.lockEditing.UseVisualStyleBackColor = true;
            this.lockEditing.CheckedChanged += new System.EventHandler(this.lockEditing_CheckedChanged);
            // 
            // addMonth
            // 
            this.addMonth.Location = new System.Drawing.Point(194, 10);
            this.addMonth.Name = "addMonth";
            this.addMonth.Size = new System.Drawing.Size(86, 23);
            this.addMonth.TabIndex = 11;
            this.addMonth.Text = "New Month";
            this.addMonth.UseVisualStyleBackColor = true;
            this.addMonth.Click += new System.EventHandler(this.addMonth_Click);
            // 
            // generateReport
            // 
            this.generateReport.Location = new System.Drawing.Point(396, 10);
            this.generateReport.Name = "generateReport";
            this.generateReport.Size = new System.Drawing.Size(114, 23);
            this.generateReport.TabIndex = 12;
            this.generateReport.Text = "Generate Report";
            this.generateReport.UseVisualStyleBackColor = true;
            this.generateReport.Click += new System.EventHandler(this.generateReport_Click);
            // 
            // switchSelected
            // 
            this.switchSelected.Location = new System.Drawing.Point(683, 293);
            this.switchSelected.Name = "switchSelected";
            this.switchSelected.Size = new System.Drawing.Size(75, 23);
            this.switchSelected.TabIndex = 13;
            this.switchSelected.Text = "↑ Switch ↓";
            this.switchSelected.UseVisualStyleBackColor = true;
            this.switchSelected.Click += new System.EventHandler(this.switchSelected_Click);
            // 
            // deleteMonth
            // 
            this.deleteMonth.Location = new System.Drawing.Point(286, 10);
            this.deleteMonth.Name = "deleteMonth";
            this.deleteMonth.Size = new System.Drawing.Size(104, 23);
            this.deleteMonth.TabIndex = 14;
            this.deleteMonth.Text = "Delete Month";
            this.deleteMonth.UseVisualStyleBackColor = true;
            this.deleteMonth.Click += new System.EventHandler(this.deleteMonth_Click);
            // 
            // defaults
            // 
            this.defaults.Location = new System.Drawing.Point(516, 10);
            this.defaults.Name = "defaults";
            this.defaults.Size = new System.Drawing.Size(75, 23);
            this.defaults.TabIndex = 15;
            this.defaults.Text = "Defaults";
            this.defaults.UseVisualStyleBackColor = true;
            this.defaults.Click += new System.EventHandler(this.defaults_Click);
            // 
            // defaultsMenu
            // 
            this.defaultsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyDefaults,
            this.applyDefaults});
            this.defaultsMenu.Name = "defaultsMenu";
            this.defaultsMenu.Size = new System.Drawing.Size(159, 70);
            // 
            // applyDefaults
            // 
            this.applyDefaults.Name = "applyDefaults";
            this.applyDefaults.Size = new System.Drawing.Size(158, 22);
            this.applyDefaults.Text = "Apply Defaults";
            this.applyDefaults.Click += new System.EventHandler(this.applyDefaults_Click);
            // 
            // modifyDefaults
            // 
            this.modifyDefaults.Name = "modifyDefaults";
            this.modifyDefaults.Size = new System.Drawing.Size(158, 22);
            this.modifyDefaults.Text = "Modify Defaults";
            this.modifyDefaults.Click += new System.EventHandler(this.modifyDefaults_Click);
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(771, 549);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(94, 23);
            this.debug.TabIndex = 17;
            this.debug.Text = "Debug";
            this.debug.UseVisualStyleBackColor = true;
            this.debug.Click += new System.EventHandler(this.debug_Click);
            // 
            // debugMenu
            // 
            this.debugMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAnonymousBackup});
            this.debugMenu.Name = "debugMenu";
            this.debugMenu.Size = new System.Drawing.Size(219, 26);
            // 
            // createAnonymousBackup
            // 
            this.createAnonymousBackup.Name = "createAnonymousBackup";
            this.createAnonymousBackup.Size = new System.Drawing.Size(218, 22);
            this.createAnonymousBackup.Text = "Create Anonymous Backup";
            this.createAnonymousBackup.Click += new System.EventHandler(this.createAnonymousBackup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 588);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.defaults);
            this.Controls.Add(this.deleteMonth);
            this.Controls.Add(this.switchSelected);
            this.Controls.Add(this.generateReport);
            this.Controls.Add(this.addMonth);
            this.Controls.Add(this.lockEditing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthListCompare);
            this.Controls.Add(this.patronListCompare);
            this.Controls.Add(this.compareValues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthListSelected);
            this.Controls.Add(this.patronListSelected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Zedaph Patreon Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.patronListSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patronListCompare)).EndInit();
            this.defaultsMenu.ResumeLayout(false);
            this.debugMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patronListSelected;
        private System.Windows.Forms.ComboBox monthListSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox compareValues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox monthListCompare;
        private System.Windows.Forms.DataGridView patronListCompare;
        private System.Windows.Forms.CheckBox lockEditing;
        private System.Windows.Forms.Button addMonth;
        private System.Windows.Forms.Button generateReport;
        private System.Windows.Forms.Button switchSelected;
        private System.Windows.Forms.Button deleteMonth;
        private System.Windows.Forms.Button defaults;
        private System.Windows.Forms.ContextMenuStrip defaultsMenu;
        private System.Windows.Forms.ToolStripMenuItem applyDefaults;
        private System.Windows.Forms.ToolStripMenuItem modifyDefaults;
        private System.Windows.Forms.Button debug;
        private System.Windows.Forms.ContextMenuStrip debugMenu;
        private System.Windows.Forms.ToolStripMenuItem createAnonymousBackup;
    }
}

