
using ImageMagick;
using System.Diagnostics;
using System.IO;

namespace Picture_transformations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FolderBrowserDialog folderBrowserDialog;
        FileInfo fileInfo;

        string HEIC_Folder;
        string JPEG_folder;
        string gbox1 = "HEIC";
        string gbox2 = ".JPEG";

        private void button1_Click(object sender, EventArgs e)
        {

            folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            HEIC_Folder = folderBrowserDialog.SelectedPath;
            label2.Text = HEIC_Folder;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.HorizontalScrollbar = true;
            listBox2.HorizontalScrollbar = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            JPEG_folder = folderBrowserDialog.SelectedPath;
            label4.Text = JPEG_folder;


        }

        Thread thread;
        private void button3_Click(object sender, EventArgs e)
        {

            Control.CheckForIllegalCrossThreadCalls = false;
thread= new Thread(thread1);
            thread.Start();

        }

        public void thread1()
        {
            int ss = 1;
            foreach (string filename in Directory.GetFiles(HEIC_Folder))
            {
                //  fileInfo = new FileInfo(filename);
                // fileInfo.Name
                if (filename.Split(".").Last().ToUpper() == gbox1)
                {
                    listBox1.Items.Add(filename);
                    transform(filename);
                    label6.Text = ss++.ToString();
                }

            }

        }
        public void transform(string filename)
        {
            FileInfo info = new FileInfo(filename);
            using (MagickImage image = new MagickImage(info.FullName))
            {
                // Save frame as jpg
                image.Write(JPEG_folder + @"\" + info.Name.Split(".")[0] + gbox2);
                //   image.Write(info.FullName.Split(@"\").Last() + gbox2);

                listBox2.Items.Add(JPEG_folder + @"\" + info.Name.Split(".")[0] + gbox2);
            }
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gbox1 = "HEIC";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gbox1 = "PNG";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gbox1 = "JPG";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            gbox1 = "JPEG";
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            gbox2 = ".JPG";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            gbox2 = ".HEIC";

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            gbox2 = ".PNG";

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            gbox2 = ".JPEG";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            ProcessStartInfo pi = new ProcessStartInfo(listBox1.SelectedItem.ToString())
            {
                Arguments = Path.GetFileName(listBox1.SelectedItem.ToString()),
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Normal,
                Verb = "OPEN"
            };
            Process proc = new Process
            {
                StartInfo = pi
            };
            proc.Start();
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProcessStartInfo pi = new ProcessStartInfo(listBox1.SelectedItem.ToString())
            {
                Arguments = Path.GetFileName(listBox1.SelectedItem.ToString()),
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Normal,
                Verb = "OPEN"
            };
            Process proc = new Process
            {
                StartInfo = pi
            };
            proc.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {        
             Environment.Exit(0);Application.Exit();
        }
    }
}
