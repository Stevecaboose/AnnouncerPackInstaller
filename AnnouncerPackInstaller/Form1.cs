using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AnnouncerPackInstaller
{




    public partial class formMain : Form
    {
        //Globals
        string Leaguedir; // league of legends dir
        string AnnouncerPackdir; //Stores the dir of the new wpk file
        const string wpkFileName = "Announcer_Global_Female1_VO_audio.wpk";
        string[] wpkDir; // dir of the origonal wpk in the league of legends folder
        string exeDir = Directory.GetCurrentDirectory(); // dir of the exe

        FileStream fs;

        private bool install_suc = true;

        /// ////////////////////////////////////////////////////


        public formMain()
        {
            InitializeComponent();
        }

        private void dirSelectBtn_Click(object sender, EventArgs e)
        {

            //Button asks for directory location and saves it in the dir var and puts that value on the textbox.
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Leaguedir = fbd.SelectedPath;

                dirTextBox.Text = Leaguedir;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnnouncerSelectBtn_Click(object sender, EventArgs e)
        {
            //Button asks for directory location and saves it in the dir var and puts that value on the textbox
            OpenFileDialog fbd = new OpenFileDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                AnnouncerPackdir = fbd.FileName;

                AnnouncerPacktxtbox.Text = AnnouncerPackdir;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



            try
            {

                wpkDir = Directory.GetFiles(Leaguedir, wpkFileName, SearchOption.AllDirectories);

                if (wpkDir.Length == 0)
                {
                    Console.WriteLine("Could not find file");
                }


                foreach (string dir in wpkDir)
                {
                    Console.WriteLine(dir);
                }

            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Null exception");
                findWPKStatusLabel.Text = "Error finding file";
                
            }

            try {

                if (dirTextBox.Text != "")
                {
                    findWPKStatusLabel.ForeColor = System.Drawing.Color.LimeGreen;
                    findWPKStatusLabel.Text = "Found WPK file";
                }
            }catch (System.ArgumentNullException)
            {
                Console.WriteLine("Error finding file");
                findWPKStatusLabel.ForeColor = System.Drawing.Color.Tomato;
                findWPKStatusLabel.Text = "Error finding file";
                
            }
          
        }

        private void backupCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void replaceWPKBtn_Click(object sender, EventArgs e)
        {
            // If the check box is checked, want to copy it to a folder
            try {

                if (backupCheckBox.Checked)
                {

                    //Check if the directory exits
                    if (Directory.Exists(exeDir + "\\wpk_backup"))
                    {


                        Console.WriteLine("Directory already exists");

                       System.IO.File.Create(exeDir + "\\wpk_backup\\" + wpkFileName);

                        


                        
                        backupLabel.ForeColor = Color.LimeGreen;
                        backupLabel.Text = "Backup successful";
                        

                    }//If not, then create it
                    else {
                        Console.WriteLine("Directory does not exsist. Making directory...");

                        System.IO.Directory.CreateDirectory(exeDir + "\\wpk_backup");

                        Console.WriteLine("Made backup directory");

                        System.IO.File.Copy(wpkDir[0], exeDir + "\\wpk_backup\\" + wpkFileName, true);
                        

                        Console.WriteLine("Copied file");
                        
                        
                        backupLabel.ForeColor = Color.LimeGreen;
                        backupLabel.Text = "Backup successful";
                        Console.WriteLine("Backup successful");
                        
                        
                    }
                }

                }catch(Exception ex)
                {
                    string except = ex.ToString();
                    Console.WriteLine("Backup folder creation failed because of {0}", except);
                    backupLabel.Text = "Error backing up folder";
                    MessageBox.Show("Backup folder creation failed because of " + except);


            }


            // Copy the new wpk to the old

            


            System.IO.File.Copy(AnnouncerPackdir, wpkDir[0], true);
            installStatusLabel.ForeColor = Color.LimeGreen;
            installStatusLabel.Text = "Announcer pack successfully installed";
            Console.WriteLine("Announcer pack successfully installed");

        }

        private void AnnouncerPacktxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void findWPKStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void installStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void urlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.urlLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://drive.google.com/open?id=0B-kHaYkqfUzIdnJuMmt4bzdBc2c");
        }
    }
}
