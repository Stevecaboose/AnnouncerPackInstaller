using System;
using System.IO;
using System.Windows.Forms;

namespace AnnouncerPackInstaller
{




    public partial class formMain : Form
    {
        //Globals
        string Leaguedir;
        string AnnouncerPackdir;
        const string wpkFileName = "Announcer_Global_Female1_VO_audio.wpk*";
        string[] wpkDir;
        string exeDir = Directory.GetCurrentDirectory();

        public formMain()
        {
            InitializeComponent();
        }

        private void dirSelectBtn_Click(object sender, EventArgs e)
        {

            //Button asks for directory location and saves it in the dir var and puts that value on the textbox
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



            //try
            //{
            //    // Only get files that begin with the letter "c."
            //    string[] dirs = Directory.GetFiles(@"c:\", "c*", SearchOption.AllDirectories);
            //    Console.WriteLine("The number of files starting with c is {0}.", dirs.Length);
            //    foreach (string dir in dirs)
            //    {
            //        Console.WriteLine(dir);
            //    }
            //}
            //catch (Exception b)
            //{
            //    Console.WriteLine("The process failed: {0}", b.ToString());
            //}




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
                    if (Directory.Exists(exeDir + "wpk_backup"))
                    {
                        Console.WriteLine("Directory already exists");

                    }//If not, then create it
                    else {
                        System.IO.Directory.CreateDirectory(exeDir + "wpk_backup");
                        System.IO.File.Copy(AnnouncerPackdir, exeDir, true);
                    }
                }

                }catch(Exception ex)
            {
                Console.WriteLine("Backup folder creation faled because of {0}", ex.ToString());
                
            }

            
            // If the checkbox is not checked, then just copy the new wpk to the old

            System.IO.File.Copy(AnnouncerPackdir, wpkDir[0], true);
            
        }

        private void AnnouncerPacktxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
