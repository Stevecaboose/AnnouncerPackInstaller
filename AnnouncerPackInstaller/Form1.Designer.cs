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
            this.backupLabel = new System.Windows.Forms.Label();
            this.installStatusLabel = new System.Windows.Forms.Label();
            this.urlLinkLabel = new System.Windows.Forms.LinkLabel();
            this.authorLabel1 = new System.Windows.Forms.Label();
            this.authorLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dirSelectBtn
            // 
            this.dirSelectBtn.Location = new System.Drawing.Point(178, 27);
            this.dirSelectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dirSelectBtn.Name = "dirSelectBtn";
            this.dirSelectBtn.Size = new System.Drawing.Size(24, 19);
            this.dirSelectBtn.TabIndex = 0;
            this.dirSelectBtn.Text = "...";
            this.dirSelectBtn.UseVisualStyleBackColor = true;
            this.dirSelectBtn.Click += new System.EventHandler(this.dirSelectBtn_Click);
            // 
            // dirTextBox
            // 
            this.dirTextBox.Location = new System.Drawing.Point(10, 27);
            this.dirTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dirTextBox.Name = "dirTextBox";
            this.dirTextBox.Size = new System.Drawing.Size(165, 20);
            this.dirTextBox.TabIndex = 1;
            this.dirTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Location = new System.Drawing.Point(10, 11);
            this.dirLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(147, 13);
            this.dirLabel.TabIndex = 2;
            this.dirLabel.Text = "League of Legends Directory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Announcer Pack WPK File:";
            // 
            // AnnouncerPacktxtbox
            // 
            this.AnnouncerPacktxtbox.Location = new System.Drawing.Point(10, 63);
            this.AnnouncerPacktxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AnnouncerPacktxtbox.Name = "AnnouncerPacktxtbox";
            this.AnnouncerPacktxtbox.Size = new System.Drawing.Size(165, 20);
            this.AnnouncerPacktxtbox.TabIndex = 4;
            this.AnnouncerPacktxtbox.TextChanged += new System.EventHandler(this.AnnouncerPacktxtbox_TextChanged);
            // 
            // AnnouncerSelectBtn
            // 
            this.AnnouncerSelectBtn.Location = new System.Drawing.Point(178, 63);
            this.AnnouncerSelectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AnnouncerSelectBtn.Name = "AnnouncerSelectBtn";
            this.AnnouncerSelectBtn.Size = new System.Drawing.Size(24, 19);
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
            this.findWPKStatusLabel.Location = new System.Drawing.Point(7, 90);
            this.findWPKStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.findWPKStatusLabel.Name = "findWPKStatusLabel";
            this.findWPKStatusLabel.Size = new System.Drawing.Size(47, 13);
            this.findWPKStatusLabel.TabIndex = 6;
            this.findWPKStatusLabel.Text = "          ";
            this.findWPKStatusLabel.Click += new System.EventHandler(this.findWPKStatusLabel_Click);
            // 
            // findWPKBtn
            // 
            this.findWPKBtn.Location = new System.Drawing.Point(238, 22);
            this.findWPKBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.findWPKBtn.Name = "findWPKBtn";
            this.findWPKBtn.Size = new System.Drawing.Size(70, 19);
            this.findWPKBtn.TabIndex = 7;
            this.findWPKBtn.Text = "Find WPK";
            this.findWPKBtn.UseVisualStyleBackColor = true;
            this.findWPKBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // stepOneLabel
            // 
            this.stepOneLabel.AutoSize = true;
            this.stepOneLabel.Location = new System.Drawing.Point(218, 24);
            this.stepOneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stepOneLabel.Name = "stepOneLabel";
            this.stepOneLabel.Size = new System.Drawing.Size(16, 13);
            this.stepOneLabel.TabIndex = 8;
            this.stepOneLabel.Text = "1.";
            // 
            // backupCheckBox
            // 
            this.backupCheckBox.AutoSize = true;
            this.backupCheckBox.Location = new System.Drawing.Point(220, 54);
            this.backupCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backupCheckBox.Name = "backupCheckBox";
            this.backupCheckBox.Size = new System.Drawing.Size(91, 17);
            this.backupCheckBox.TabIndex = 9;
            this.backupCheckBox.Text = "Backup WPK";
            this.backupCheckBox.UseVisualStyleBackColor = true;
            this.backupCheckBox.CheckedChanged += new System.EventHandler(this.backupCheckBox_CheckedChanged);
            // 
            // stepTwoLabel
            // 
            this.stepTwoLabel.AutoSize = true;
            this.stepTwoLabel.Location = new System.Drawing.Point(218, 87);
            this.stepTwoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stepTwoLabel.Name = "stepTwoLabel";
            this.stepTwoLabel.Size = new System.Drawing.Size(16, 13);
            this.stepTwoLabel.TabIndex = 10;
            this.stepTwoLabel.Text = "2.";
            // 
            // replaceWPKBtn
            // 
            this.replaceWPKBtn.Location = new System.Drawing.Point(238, 84);
            this.replaceWPKBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.replaceWPKBtn.Name = "replaceWPKBtn";
            this.replaceWPKBtn.Size = new System.Drawing.Size(70, 19);
            this.replaceWPKBtn.TabIndex = 11;
            this.replaceWPKBtn.Text = "Install WPK";
            this.replaceWPKBtn.UseVisualStyleBackColor = true;
            this.replaceWPKBtn.Click += new System.EventHandler(this.replaceWPKBtn_Click);
            // 
            // backupLabel
            // 
            this.backupLabel.AutoSize = true;
            this.backupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.backupLabel.ForeColor = System.Drawing.Color.Tomato;
            this.backupLabel.Location = new System.Drawing.Point(7, 116);
            this.backupLabel.Name = "backupLabel";
            this.backupLabel.Size = new System.Drawing.Size(43, 13);
            this.backupLabel.TabIndex = 12;
            this.backupLabel.Text = "         ";
            // 
            // installStatusLabel
            // 
            this.installStatusLabel.AutoSize = true;
            this.installStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.installStatusLabel.ForeColor = System.Drawing.Color.Tomato;
            this.installStatusLabel.Location = new System.Drawing.Point(7, 140);
            this.installStatusLabel.Name = "installStatusLabel";
            this.installStatusLabel.Size = new System.Drawing.Size(43, 13);
            this.installStatusLabel.TabIndex = 13;
            this.installStatusLabel.Text = "         ";
            this.installStatusLabel.Click += new System.EventHandler(this.installStatusLabel_Click);
            // 
            // urlLinkLabel
            // 
            this.urlLinkLabel.ActiveLinkColor = System.Drawing.Color.Red;
            this.urlLinkLabel.AutoSize = true;
            this.urlLinkLabel.Location = new System.Drawing.Point(81, 207);
            this.urlLinkLabel.Name = "urlLinkLabel";
            this.urlLinkLabel.Size = new System.Drawing.Size(250, 13);
            this.urlLinkLabel.TabIndex = 14;
            this.urlLinkLabel.TabStop = true;
            this.urlLinkLabel.Text = "Click here to download my Bronze Announcer Pack";
            this.urlLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.urlLinkLabel_LinkClicked);
            // 
            // authorLabel1
            // 
            this.authorLabel1.AutoSize = true;
            this.authorLabel1.Location = new System.Drawing.Point(7, 169);
            this.authorLabel1.Name = "authorLabel1";
            this.authorLabel1.Size = new System.Drawing.Size(51, 13);
            this.authorLabel1.TabIndex = 15;
            this.authorLabel1.Text = "Made by:";
            // 
            // authorLabel2
            // 
            this.authorLabel2.AutoSize = true;
            this.authorLabel2.Location = new System.Drawing.Point(6, 182);
            this.authorLabel2.Name = "authorLabel2";
            this.authorLabel2.Size = new System.Drawing.Size(151, 13);
            this.authorLabel2.TabIndex = 16;
            this.authorLabel2.Text = "Stevecabbage/Stevecaboose";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 229);
            this.Controls.Add(this.authorLabel2);
            this.Controls.Add(this.authorLabel1);
            this.Controls.Add(this.urlLinkLabel);
            this.Controls.Add(this.installStatusLabel);
            this.Controls.Add(this.backupLabel);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label backupLabel;
        private System.Windows.Forms.Label installStatusLabel;
        private System.Windows.Forms.LinkLabel urlLinkLabel;
        private System.Windows.Forms.Label authorLabel1;
        private System.Windows.Forms.Label authorLabel2;
    }
}

