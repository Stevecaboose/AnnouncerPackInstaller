namespace AnnouncerPackInstaller
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.dirSelectBtn = new System.Windows.Forms.Button();
            this.dirTextBox = new System.Windows.Forms.TextBox();
            this.dirLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnnouncerPacktxtbox = new System.Windows.Forms.TextBox();
            this.AnnouncerSelectBtn = new System.Windows.Forms.Button();
            this.findWPKStatusLabel = new System.Windows.Forms.Label();
            this.findWPKBtn = new System.Windows.Forms.Button();
            this.stepOneLabel = new System.Windows.Forms.Label();
            this.backupCheckBox = new System.Windows.Forms.CheckBox();
            this.stepTwoLabel = new System.Windows.Forms.Label();
            this.replaceWPKBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dirSelectBtn
            // 
            this.dirSelectBtn.Location = new System.Drawing.Point(238, 33);
            this.dirSelectBtn.Name = "dirSelectBtn";
            this.dirSelectBtn.Size = new System.Drawing.Size(32, 23);
            this.dirSelectBtn.TabIndex = 0;
            this.dirSelectBtn.Text = "...";
            this.dirSelectBtn.UseVisualStyleBackColor = true;
            this.dirSelectBtn.Click += new System.EventHandler(this.dirSelectBtn_Click);
            // 
            // dirTextBox
            // 
            this.dirTextBox.Location = new System.Drawing.Point(13, 33);
            this.dirTextBox.Name = "dirTextBox";
            this.dirTextBox.Size = new System.Drawing.Size(219, 22);
            this.dirTextBox.TabIndex = 1;
            this.dirTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Location = new System.Drawing.Point(13, 13);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(196, 17);
            this.dirLabel.TabIndex = 2;
            this.dirLabel.Text = "League of Legends Directory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Announcer Pack WPK File:";
            // 
            // AnnouncerPacktxtbox
            // 
            this.AnnouncerPacktxtbox.Location = new System.Drawing.Point(13, 78);
            this.AnnouncerPacktxtbox.Name = "AnnouncerPacktxtbox";
            this.AnnouncerPacktxtbox.Size = new System.Drawing.Size(219, 22);
            this.AnnouncerPacktxtbox.TabIndex = 4;
            this.AnnouncerPacktxtbox.TextChanged += new System.EventHandler(this.AnnouncerPacktxtbox_TextChanged);
            // 
            // AnnouncerSelectBtn
            // 
            this.AnnouncerSelectBtn.Location = new System.Drawing.Point(238, 78);
            this.AnnouncerSelectBtn.Name = "AnnouncerSelectBtn";
            this.AnnouncerSelectBtn.Size = new System.Drawing.Size(32, 23);
            this.AnnouncerSelectBtn.TabIndex = 5;
            this.AnnouncerSelectBtn.Text = "...";
            this.AnnouncerSelectBtn.UseVisualStyleBackColor = true;
            this.AnnouncerSelectBtn.Click += new System.EventHandler(this.AnnouncerSelectBtn_Click);
            // 
            // findWPKStatusLabel
            // 
            this.findWPKStatusLabel.AutoSize = true;
            this.findWPKStatusLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.findWPKStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findWPKStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.findWPKStatusLabel.Location = new System.Drawing.Point(13, 110);
            this.findWPKStatusLabel.Name = "findWPKStatusLabel";
            this.findWPKStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.findWPKStatusLabel.TabIndex = 6;
            // 
            // findWPKBtn
            // 
            this.findWPKBtn.Location = new System.Drawing.Point(317, 27);
            this.findWPKBtn.Name = "findWPKBtn";
            this.findWPKBtn.Size = new System.Drawing.Size(93, 23);
            this.findWPKBtn.TabIndex = 7;
            this.findWPKBtn.Text = "Find WPK";
            this.findWPKBtn.UseVisualStyleBackColor = true;
            this.findWPKBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // stepOneLabel
            // 
            this.stepOneLabel.AutoSize = true;
            this.stepOneLabel.Location = new System.Drawing.Point(291, 30);
            this.stepOneLabel.Name = "stepOneLabel";
            this.stepOneLabel.Size = new System.Drawing.Size(20, 17);
            this.stepOneLabel.TabIndex = 8;
            this.stepOneLabel.Text = "1.";
            // 
            // backupCheckBox
            // 
            this.backupCheckBox.AutoSize = true;
            this.backupCheckBox.Location = new System.Drawing.Point(294, 67);
            this.backupCheckBox.Name = "backupCheckBox";
            this.backupCheckBox.Size = new System.Drawing.Size(112, 21);
            this.backupCheckBox.TabIndex = 9;
            this.backupCheckBox.Text = "Backup WPK";
            this.backupCheckBox.UseVisualStyleBackColor = true;
            this.backupCheckBox.CheckedChanged += new System.EventHandler(this.backupCheckBox_CheckedChanged);
            // 
            // stepTwoLabel
            // 
            this.stepTwoLabel.AutoSize = true;
            this.stepTwoLabel.Location = new System.Drawing.Point(291, 107);
            this.stepTwoLabel.Name = "stepTwoLabel";
            this.stepTwoLabel.Size = new System.Drawing.Size(20, 17);
            this.stepTwoLabel.TabIndex = 10;
            this.stepTwoLabel.Text = "2.";
            // 
            // replaceWPKBtn
            // 
            this.replaceWPKBtn.Location = new System.Drawing.Point(317, 104);
            this.replaceWPKBtn.Name = "replaceWPKBtn";
            this.replaceWPKBtn.Size = new System.Drawing.Size(93, 23);
            this.replaceWPKBtn.TabIndex = 11;
            this.replaceWPKBtn.Text = "Install WPK";
            this.replaceWPKBtn.UseVisualStyleBackColor = true;
            this.replaceWPKBtn.Click += new System.EventHandler(this.replaceWPKBtn_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 282);
            this.Controls.Add(this.replaceWPKBtn);
            this.Controls.Add(this.stepTwoLabel);
            this.Controls.Add(this.backupCheckBox);
            this.Controls.Add(this.stepOneLabel);
            this.Controls.Add(this.findWPKBtn);
            this.Controls.Add(this.findWPKStatusLabel);
            this.Controls.Add(this.AnnouncerSelectBtn);
            this.Controls.Add(this.AnnouncerPacktxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dirLabel);
            this.Controls.Add(this.dirTextBox);
            this.Controls.Add(this.dirSelectBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMain";
            this.Text = "LoL Announcer Pack Installer";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dirSelectBtn;
        private System.Windows.Forms.TextBox dirTextBox;
        private System.Windows.Forms.Label dirLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AnnouncerPacktxtbox;
        private System.Windows.Forms.Button AnnouncerSelectBtn;
        private System.Windows.Forms.Label findWPKStatusLabel;
        private System.Windows.Forms.Button findWPKBtn;
        private System.Windows.Forms.Label stepOneLabel;
        private System.Windows.Forms.CheckBox backupCheckBox;
        private System.Windows.Forms.Label stepTwoLabel;
        private System.Windows.Forms.Button replaceWPKBtn;
    }
}

