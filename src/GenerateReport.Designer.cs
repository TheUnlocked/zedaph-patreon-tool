namespace ZedaphPatreonTool
{
    partial class GenerateReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.patreonName = new System.Windows.Forms.CheckBox();
            this.email = new System.Windows.Forms.CheckBox();
            this.pledge = new System.Windows.Forms.CheckBox();
            this.producerName = new System.Windows.Forms.CheckBox();
            this.discordName = new System.Windows.Forms.CheckBox();
            this.whitelistCommand = new System.Windows.Forms.CheckBox();
            this.lifetimePledge = new System.Windows.Forms.CheckBox();
            this.ignoreAnonymousProducer = new System.Windows.Forms.CheckBox();
            this.ignoreAnonymousMC = new System.Windows.Forms.CheckBox();
            this.ignoreAnonymousDiscord = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currentMonth = new System.Windows.Forms.ComboBox();
            this.compareTo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.specialCommand = new System.Windows.Forms.CheckBox();
            this.whitelistMinBox = new System.Windows.Forms.NumericUpDown();
            this.whitelistMin = new System.Windows.Forms.CheckBox();
            this.discordMinBox = new System.Windows.Forms.NumericUpDown();
            this.discordMin = new System.Windows.Forms.CheckBox();
            this.specialMinBox = new System.Windows.Forms.NumericUpDown();
            this.specialMin = new System.Windows.Forms.CheckBox();
            this.producerMinBox = new System.Windows.Forms.NumericUpDown();
            this.producerMin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.whitelistMinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discordMinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialMinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerMinBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filters:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Include:";
            // 
            // patreonName
            // 
            this.patreonName.AutoSize = true;
            this.patreonName.Checked = true;
            this.patreonName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.patreonName.Location = new System.Drawing.Point(12, 90);
            this.patreonName.Name = "patreonName";
            this.patreonName.Size = new System.Drawing.Size(94, 17);
            this.patreonName.TabIndex = 4;
            this.patreonName.Text = "Patreon Name";
            this.patreonName.UseVisualStyleBackColor = true;
            this.patreonName.CheckedChanged += new System.EventHandler(this.patreonName_CheckedChanged);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(12, 113);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(92, 17);
            this.email.TabIndex = 5;
            this.email.Text = "Email Address";
            this.email.UseVisualStyleBackColor = true;
            this.email.CheckedChanged += new System.EventHandler(this.email_CheckedChanged);
            // 
            // pledge
            // 
            this.pledge.AutoSize = true;
            this.pledge.Checked = true;
            this.pledge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pledge.Location = new System.Drawing.Point(12, 136);
            this.pledge.Name = "pledge";
            this.pledge.Size = new System.Drawing.Size(98, 17);
            this.pledge.TabIndex = 6;
            this.pledge.Text = "Pledge Amount";
            this.pledge.UseVisualStyleBackColor = true;
            this.pledge.CheckedChanged += new System.EventHandler(this.pledge_CheckedChanged);
            // 
            // producerName
            // 
            this.producerName.AutoSize = true;
            this.producerName.Checked = true;
            this.producerName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.producerName.Location = new System.Drawing.Point(12, 159);
            this.producerName.Name = "producerName";
            this.producerName.Size = new System.Drawing.Size(100, 17);
            this.producerName.TabIndex = 7;
            this.producerName.Text = "Producer Name";
            this.producerName.UseVisualStyleBackColor = true;
            // 
            // discordName
            // 
            this.discordName.AutoSize = true;
            this.discordName.Checked = true;
            this.discordName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.discordName.Location = new System.Drawing.Point(12, 205);
            this.discordName.Name = "discordName";
            this.discordName.Size = new System.Drawing.Size(93, 17);
            this.discordName.TabIndex = 8;
            this.discordName.Text = "Discord Name";
            this.discordName.UseVisualStyleBackColor = true;
            // 
            // whitelistCommand
            // 
            this.whitelistCommand.AutoSize = true;
            this.whitelistCommand.Checked = true;
            this.whitelistCommand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.whitelistCommand.Location = new System.Drawing.Point(12, 251);
            this.whitelistCommand.Name = "whitelistCommand";
            this.whitelistCommand.Size = new System.Drawing.Size(116, 17);
            this.whitelistCommand.TabIndex = 9;
            this.whitelistCommand.Text = "Whitelist Command";
            this.whitelistCommand.UseVisualStyleBackColor = true;
            // 
            // lifetimePledge
            // 
            this.lifetimePledge.AutoSize = true;
            this.lifetimePledge.Location = new System.Drawing.Point(12, 320);
            this.lifetimePledge.Name = "lifetimePledge";
            this.lifetimePledge.Size = new System.Drawing.Size(121, 17);
            this.lifetimePledge.TabIndex = 10;
            this.lifetimePledge.Text = "Lifetime Contribution";
            this.lifetimePledge.UseVisualStyleBackColor = true;
            this.lifetimePledge.CheckedChanged += new System.EventHandler(this.lifetimePledge_CheckedChanged);
            // 
            // ignoreAnonymousProducer
            // 
            this.ignoreAnonymousProducer.AutoSize = true;
            this.ignoreAnonymousProducer.Checked = true;
            this.ignoreAnonymousProducer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ignoreAnonymousProducer.Location = new System.Drawing.Point(153, 159);
            this.ignoreAnonymousProducer.Name = "ignoreAnonymousProducer";
            this.ignoreAnonymousProducer.Size = new System.Drawing.Size(158, 17);
            this.ignoreAnonymousProducer.TabIndex = 11;
            this.ignoreAnonymousProducer.Text = "Ignore \"\\\\\" producer names";
            this.ignoreAnonymousProducer.UseVisualStyleBackColor = true;
            // 
            // ignoreAnonymousMC
            // 
            this.ignoreAnonymousMC.AutoSize = true;
            this.ignoreAnonymousMC.Checked = true;
            this.ignoreAnonymousMC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ignoreAnonymousMC.Location = new System.Drawing.Point(153, 251);
            this.ignoreAnonymousMC.Name = "ignoreAnonymousMC";
            this.ignoreAnonymousMC.Size = new System.Drawing.Size(160, 17);
            this.ignoreAnonymousMC.TabIndex = 12;
            this.ignoreAnonymousMC.Text = "Ignore \"\\\\\" Minecraft names";
            this.ignoreAnonymousMC.UseVisualStyleBackColor = true;
            // 
            // ignoreAnonymousDiscord
            // 
            this.ignoreAnonymousDiscord.AutoSize = true;
            this.ignoreAnonymousDiscord.Checked = true;
            this.ignoreAnonymousDiscord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ignoreAnonymousDiscord.Location = new System.Drawing.Point(153, 205);
            this.ignoreAnonymousDiscord.Name = "ignoreAnonymousDiscord";
            this.ignoreAnonymousDiscord.Size = new System.Drawing.Size(152, 17);
            this.ignoreAnonymousDiscord.TabIndex = 13;
            this.ignoreAnonymousDiscord.Text = "Ignore \"\\\\\" Discord names";
            this.ignoreAnonymousDiscord.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Current Month:";
            // 
            // currentMonth
            // 
            this.currentMonth.FormattingEnabled = true;
            this.currentMonth.Location = new System.Drawing.Point(95, 12);
            this.currentMonth.Name = "currentMonth";
            this.currentMonth.Size = new System.Drawing.Size(137, 21);
            this.currentMonth.TabIndex = 16;
            this.currentMonth.SelectedIndexChanged += new System.EventHandler(this.currentMonth_SelectedIndexChanged);
            // 
            // compareTo
            // 
            this.compareTo.FormattingEnabled = true;
            this.compareTo.Location = new System.Drawing.Point(95, 39);
            this.compareTo.Name = "compareTo";
            this.compareTo.Size = new System.Drawing.Size(137, 21);
            this.compareTo.TabIndex = 18;
            this.compareTo.SelectedIndexChanged += new System.EventHandler(this.compareTo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Compare To:";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(12, 343);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(309, 23);
            this.generate.TabIndex = 19;
            this.generate.Text = "Generate Report";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // specialCommand
            // 
            this.specialCommand.AutoSize = true;
            this.specialCommand.Checked = true;
            this.specialCommand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.specialCommand.Location = new System.Drawing.Point(12, 297);
            this.specialCommand.Name = "specialCommand";
            this.specialCommand.Size = new System.Drawing.Size(111, 17);
            this.specialCommand.TabIndex = 20;
            this.specialCommand.Text = "Special Command";
            this.specialCommand.UseVisualStyleBackColor = true;
            // 
            // whitelistMinBox
            // 
            this.whitelistMinBox.Location = new System.Drawing.Point(265, 273);
            this.whitelistMinBox.Name = "whitelistMinBox";
            this.whitelistMinBox.Size = new System.Drawing.Size(57, 20);
            this.whitelistMinBox.TabIndex = 22;
            this.whitelistMinBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // whitelistMin
            // 
            this.whitelistMin.AutoSize = true;
            this.whitelistMin.Checked = true;
            this.whitelistMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.whitelistMin.Location = new System.Drawing.Point(153, 274);
            this.whitelistMin.Name = "whitelistMin";
            this.whitelistMin.Size = new System.Drawing.Size(106, 17);
            this.whitelistMin.TabIndex = 21;
            this.whitelistMin.Text = "Minimum Pledge:";
            this.whitelistMin.UseVisualStyleBackColor = true;
            // 
            // discordMinBox
            // 
            this.discordMinBox.Location = new System.Drawing.Point(265, 227);
            this.discordMinBox.Name = "discordMinBox";
            this.discordMinBox.Size = new System.Drawing.Size(57, 20);
            this.discordMinBox.TabIndex = 24;
            this.discordMinBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // discordMin
            // 
            this.discordMin.AutoSize = true;
            this.discordMin.Checked = true;
            this.discordMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.discordMin.Location = new System.Drawing.Point(153, 228);
            this.discordMin.Name = "discordMin";
            this.discordMin.Size = new System.Drawing.Size(106, 17);
            this.discordMin.TabIndex = 23;
            this.discordMin.Text = "Minimum Pledge:";
            this.discordMin.UseVisualStyleBackColor = true;
            // 
            // specialMinBox
            // 
            this.specialMinBox.Location = new System.Drawing.Point(265, 296);
            this.specialMinBox.Name = "specialMinBox";
            this.specialMinBox.Size = new System.Drawing.Size(57, 20);
            this.specialMinBox.TabIndex = 26;
            this.specialMinBox.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // specialMin
            // 
            this.specialMin.AutoSize = true;
            this.specialMin.Checked = true;
            this.specialMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.specialMin.Location = new System.Drawing.Point(153, 297);
            this.specialMin.Name = "specialMin";
            this.specialMin.Size = new System.Drawing.Size(106, 17);
            this.specialMin.TabIndex = 25;
            this.specialMin.Text = "Minimum Pledge:";
            this.specialMin.UseVisualStyleBackColor = true;
            // 
            // producerMinBox
            // 
            this.producerMinBox.Location = new System.Drawing.Point(265, 181);
            this.producerMinBox.Name = "producerMinBox";
            this.producerMinBox.Size = new System.Drawing.Size(57, 20);
            this.producerMinBox.TabIndex = 29;
            this.producerMinBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // producerMin
            // 
            this.producerMin.AutoSize = true;
            this.producerMin.Checked = true;
            this.producerMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.producerMin.Location = new System.Drawing.Point(153, 182);
            this.producerMin.Name = "producerMin";
            this.producerMin.Size = new System.Drawing.Size(106, 17);
            this.producerMin.TabIndex = 28;
            this.producerMin.Text = "Minimum Pledge:";
            this.producerMin.UseVisualStyleBackColor = true;
            // 
            // GenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 375);
            this.Controls.Add(this.producerMinBox);
            this.Controls.Add(this.producerMin);
            this.Controls.Add(this.specialMinBox);
            this.Controls.Add(this.specialMin);
            this.Controls.Add(this.discordMinBox);
            this.Controls.Add(this.discordMin);
            this.Controls.Add(this.whitelistMinBox);
            this.Controls.Add(this.whitelistMin);
            this.Controls.Add(this.specialCommand);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.compareTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currentMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ignoreAnonymousDiscord);
            this.Controls.Add(this.ignoreAnonymousMC);
            this.Controls.Add(this.ignoreAnonymousProducer);
            this.Controls.Add(this.lifetimePledge);
            this.Controls.Add(this.whitelistCommand);
            this.Controls.Add(this.discordName);
            this.Controls.Add(this.producerName);
            this.Controls.Add(this.pledge);
            this.Controls.Add(this.email);
            this.Controls.Add(this.patreonName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GenerateReport";
            this.Text = "Generate Report";
            this.Load += new System.EventHandler(this.GenerateReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.whitelistMinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discordMinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialMinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerMinBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox patreonName;
        private System.Windows.Forms.CheckBox email;
        private System.Windows.Forms.CheckBox pledge;
        private System.Windows.Forms.CheckBox producerName;
        private System.Windows.Forms.CheckBox discordName;
        private System.Windows.Forms.CheckBox whitelistCommand;
        private System.Windows.Forms.CheckBox lifetimePledge;
        private System.Windows.Forms.CheckBox ignoreAnonymousProducer;
        private System.Windows.Forms.CheckBox ignoreAnonymousMC;
        private System.Windows.Forms.CheckBox ignoreAnonymousDiscord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox currentMonth;
        private System.Windows.Forms.ComboBox compareTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.CheckBox specialCommand;
        private System.Windows.Forms.NumericUpDown whitelistMinBox;
        private System.Windows.Forms.CheckBox whitelistMin;
        private System.Windows.Forms.NumericUpDown discordMinBox;
        private System.Windows.Forms.CheckBox discordMin;
        private System.Windows.Forms.NumericUpDown specialMinBox;
        private System.Windows.Forms.CheckBox specialMin;
        private System.Windows.Forms.NumericUpDown producerMinBox;
        private System.Windows.Forms.CheckBox producerMin;
    }
}