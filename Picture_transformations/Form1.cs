
using ImageMagick;
using System.Diagnostics;
using System.Globalization;
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
        OpenFileDialog openFileDialog;
        FileInfo fileInfo;

        string sourceFolder;
        string saveFolder;
        string cBox1 = "ALL";
        string cBox2 = ".AAI";

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();
            if (openFileDialog.FileNames != null)
            {


                foreach (var item in openFileDialog.FileNames)
                {
                    listBox1.Items.Add(item);
                }
                saveFolder = new FileInfo(listBox1.Items[0].ToString()).DirectoryName;
                label4.Text= saveFolder;
                label3.Text = listBox1.Items.Count.ToString();
            }
            /*   folderBrowserDialog = new FolderBrowserDialog();
               folderBrowserDialog.ShowDialog();
               sourceFolder = folderBrowserDialog.SelectedPath;
               label2.Text = sourceFolder;*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("ALL");
            comboBox1.SelectedIndex = 0;

            StreamReader sr = new StreamReader("ext.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                comboBox1.Items.Add(line);
                comboBox2.Items.Add(line);
                line = sr.ReadLine();

            }

            comboBox2.SelectedIndex = 0;
            listBox1.HorizontalScrollbar = true;
            listBox2.HorizontalScrollbar = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();

            saveFolder = folderBrowserDialog.SelectedPath==""?saveFolder:folderBrowserDialog.SelectedPath;
            label4.Text = saveFolder;


        }

        Thread thread;
        private void button3_Click(object sender, EventArgs e)
        {
            threadstart();

        }

        private void threadstart()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            thread = new Thread(thread1);
            thread.Start();
        }

        public void thread1()
        {
           
            foreach (string filename in listBox1.Items)
            {
                if (cBox1 == "ALL")
                    transform(filename);


                if (filename.Split(".").Last().ToUpper(new CultureInfo("en-US", false)) == cBox1.ToUpper(new CultureInfo("en-US", false)))
                {
                    transform(filename);                   
                }

            }

        }
        int numberOfConverted = 1;
        public void transform(string filename)
        {
            try
            {
                FileInfo info = new FileInfo(filename);
                using (MagickImage image = new MagickImage(info.FullName))
                {
                    // Save frame as          
                    image.Write(saveFolder + @"\" + info.Name.Split(".")[0] + cBox2);
                    listBox2.Items.Add(saveFolder + @"\" + info.Name.Split(".")[0] + cBox2);
                    label6.Text = numberOfConverted.ToString();
                    numberOfConverted++;
                }
            }
            catch
            {

            }

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
            Environment.Exit(0);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBox1 = comboBox1.SelectedItem.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBox2 = "." + comboBox2.SelectedItem.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
