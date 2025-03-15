
using ImageMagick;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace ImageConverterTool
{
    public partial class ImageConverterTool : Form
    {
        public ImageConverterTool()
        {
            InitializeComponent();

        }

        FolderBrowserDialog folderBrowserDialog;
        OpenFileDialog openFileDialog;
        FileInfo fileInfo;

        string sourceFolder;
        string saveFolder;
        string cBox1 = "All Extensions";
        string cBox2 = ".AAI";
        string folderFilter = "Supported Files|*.aai;*.apng;*.art;*.arw;*.avi;*.avif;*.avs;*.bayer;*.bpg;*.bmp;*.bmp2;*.bmp3;" +
                    "*.brf;*.cals;*.cin;*.cip;*.cmyk;*.cmyka;*.cr2;*.crw;*.cube;*.cur;*.cut;*.dcm;*.dcr;*.dcx;*.dds;*.debug;*.dib;*.djvu;" +
                    "*.dmr;*.dng;*.dot;*.dpx;*.emf;*.epdf;*.epi;*.eps;*.eps2;*.eps3;*.epsf;*.epsi;*.ept;*.exr;*.farbfeld;*.fax;*.fits;*.fl32;" +
                    "*.flif;*.fpx;*.ftxt;*.gif;*.gplt;*.gray;*.graya;*.hdr;*.heic;*.hpgl;*.hrz;*.html;*.ico;*.info;*.isobrl;*.isobrl6;*.jbig;" +
                    "*.jng;*.jp2;*.jpt;*.j2c;*.j2k;*.jpeg;*.jpg;*.jxr;*.json;*.jxl;*.kernel;*.man;*.mat;*.miff;*.mono;*.mng;*.m2v;*.mpeg;*.mpc;" +
                    "*.mpo;*.mpr;*.mrw;*.msl;*.mtv;*.mvg;*.nef;*.orf;*.ora;*.otb;*.p7;*.palm;*.pam;*.clipboard;*.pbm;*.pcd;*.pcds;*.pcl;*.pcx;" +
                    "*.pdb;*.pdf;*.pef;*.pes;*.pfa;*.pfb;*.pfm;*.pgm;*.phm;*.picon;*.pict;*.pix;*.png;*.png8;*.png00;*.png24;*.png32;*.png48;" +
                    "*.png64;*.pnm;*.pocketmod;*.ppm;*.ps;*.ps2;*.ps3;*.psb;*.psd;*.ptif;*.pwp;*.qoi;*.rad;*.raf;*.raw;*.rgb;*.rgb565;*.rgba;" +
                    "*.rgf;*.rla;*.rle;*.sct;*.sfw;*.sgi;*.shtml;*.sid;*.mrsid;*.sparse-color;*.strimg;*.sun;*.svg;*.text;*.tga;*.tiff;*.tim;" +
                    "*.ttf;*.txt;*.ubrl;*.ubrl6;*.uhdr;*.uil;*.uyvy;*.vicar;*.video;*.viff;*.wbmp;*.wdp;*.webp;*.wmf;*.wpg;*.x;*.xbm;*.xcf;*.xpm;" +
                    "*.xwd;*.x3f;*.yaml;*.ycbcr;*.ycbcra;*.yuv;*.ashlar;*.canvas;*.caption;*.clip;*.clipboard;*.fractal;*.gradient;*.hald;" +
                    "*.histogram;*.inline;*.label;*.map;*.mask;*.matte;*.null;*.pango;*.plasma;*.preview;*.print;*.scan;*.radial_gradient;" +
                    "*.scanx;*.screenshot;*.stegano;*.tile;*.unique;*.vid;*.win;*.x;*.xc";
        private void selectImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                // sourceListBox.Items.Clear();
                openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = folderFilter;
                openFileDialog.ShowDialog();
                if (openFileDialog.FileNames != null)
                {


                    foreach (var item in openFileDialog.FileNames)
                    {
                        sourceListBox.Items.Add(item);
                    }
                    saveFolder = new FileInfo(sourceListBox.Items[0].ToString()).DirectoryName;
                    targetPathlbl.Text = saveFolder;
                    label3.Text = sourceListBox.Items.Count.ToString();
                }
                /*   folderBrowserDialog = new FolderBrowserDialog();
                   folderBrowserDialog.ShowDialog();
                   sourceFolder = folderBrowserDialog.SelectedPath;
                   label2.Text = sourceFolder;*/
            }
            catch { }
        }

        private void ImageConverterTool_Load(object sender, EventArgs e)
        {
            sourceExtensionCbox.Items.Add("All Extensions");
            clearSelectExtCBox.Items.Add("Clear Whole List");
            sourceExtensionCbox.SelectedIndex = 0;
            clearSelectExtCBox.SelectedIndex = 0;
            if (!File.Exists("ext.txt"))
            {
                // Dosya adý ve oluþturulacaðý yer
                string dosyaYolu = "ext.txt";

                // Dosyaya yazýlacak içerik
                string[] dosyaFormatlari = {
            "JPEG", "JPG", "PNG", "PDF", "HEIC", "GIF", "BMP", "WEBP", "AAI", "APNG", "ART",
            "ARW", "AVI", "AVIF", "AVS", "BAYER", "BPG", "BMP", "BMP2", "BMP3", "BRF", "CALS",
            "CIN", "CIP", "CMYK", "CMYKA", "CR2", "CRW", "CUBE", "CUR", "CUT", "DCM", "DCR",
            "DCX", "DDS", "DEBUG", "DIB", "DJVU", "DMR", "DNG", "DOT", "DPX", "EMF", "EPDF",
            "EPI", "EPS", "EPS2", "EPS3", "EPSF", "EPSI", "EPT", "EXR", "FARBFELD", "FAX",
            "FITS", "FL32", "FLIF", "FPX", "FTXT", "GPLT", "GRAY", "GRAYA", "HDR", "HPGL",
            "HRZ", "HTML", "ICO", "INFO", "ISOBRL", "ISOBRL6", "JBIG", "JNG", "JP2", "JPT",
            "J2C", "J2K", "JXR", "JSON", "JXL", "KERNEL", "MAN", "MAT", "MIFF", "MONO", "MNG",
            "M2V", "MPEG", "MPC", "MPO", "MPR", "MRW", "MSL", "MTV", "MVG", "NEF", "ORF", "ORA",
            "OTB", "P7", "PALM", "PAM", "CLIPBOARD", "PBM", "PCD", "PCDS", "PCL", "PCX", "PDB",
            "PEF", "PES", "PFA", "PFB", "PFM", "PGM", "PHM", "PICON", "PICT", "PIX", "PNG8",
            "PNG00", "PNG24", "PNG32", "PNG48", "PNG64", "PNM", "POCKETMOD", "PPM", "PS", "PS2",
            "PS3", "PSB", "PSD", "PTIF", "PWP", "QOI", "RAD", "RAF", "RAW", "RGB", "RGB565",
            "RGBA", "RGF", "RLA", "RLE", "SCT", "SFW", "SGI", "SHTML", "SID", "MrSID",
            "SPARSE-COLOR", "STRIMG", "SUN", "SVG", "TEXT", "TGA", "TIFF", "TIM", "TTF", "TXT",
            "UBRL", "UBRL6", "UHDR", "UIL", "UYVY", "VICAR", "VIDEO", "VIFF", "WBMP", "WDP",
            "WMF", "WPG", "X", "XBM", "XCF", "XPM", "XWD", "X3F", "YAML", "YCbCr", "YCbCrA",
            "YUV", "ASHLAR", "CANVAS", "CAPTION", "CLIP", "CLIPBOARD", "FRACTAL", "GRADIENT",
            "HALD", "HISTOGRAM", "INLINE", "LABEL", "MAP", "MASK", "MATTE", "NULL", "PANGO",
            "PLASMA", "PREVIEW", "PRINT", "SCAN", "RADIAL_GRADIENT", "SCANX", "SCREENSHOT",
            "STEGANO", "TILE", "UNIQUE", "VID", "WIN", "X", "XC"
        };

                try
                {
                    // Ýçeriði dosyaya satýr satýr yaz
                    File.WriteAllLines(dosyaYolu, dosyaFormatlari);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluþtu: " + ex.Message);
                }
            }
            StreamReader sr = new StreamReader("ext.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                sourceExtensionCbox.Items.Add(line);
                targetExtensionCbox.Items.Add(line);
                clearSelectExtCBox.Items.Add(line);
                line = sr.ReadLine();

            }

            targetExtensionCbox.SelectedIndex = 0;
            sourceListBox.HorizontalScrollbar = true;
            targetListBox.HorizontalScrollbar = true;

        }

        private void selectSavePathButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();

            saveFolder = folderBrowserDialog.SelectedPath == "" ? saveFolder : folderBrowserDialog.SelectedPath;
            targetPathlbl.Text = saveFolder;


        }

        Thread thread;
        private void convertButton_Click(object sender, EventArgs e)
        {
            if (saveFolder != null)
            {
                threadstart();
                label5.Text = "";
            }
            else { MessageBox.Show("Select the folder to save the converted images"); }
        }

        private void threadstart()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            thread = new Thread(thread1);
            thread.Start();
        }

        public void thread1()
        {

            foreach (string filename in sourceListBox.Items)
            {
                if (cBox1 == "All Extensions")
                    transform(filename);

                else
                {
                    if (filename.Split(".").Last().ToLower(new CultureInfo("en-US", false)) == cBox1.ToLower(new CultureInfo("en-US", false)))
                        transform(filename);
                }

            }
            label5.Text = "Conversion completed";

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
                    image.Write(saveFolder + @"\" + info.Name.Split(".")[0] + cBox2.ToLower(new CultureInfo("en-US", false)));
                    targetListBox.Items.Add(saveFolder + @"\" + info.Name.Split(".")[0] + cBox2.ToLower(new CultureInfo("en-US", false)));
                    label6.Text = numberOfConverted.ToString();
                    numberOfConverted++;
                }

            }
            catch (Exception e)
            {
                targetListBox.Items.Add("This file cannot be converted to the selected extension.");
            }

        }

        private void sourceListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            ProcessStartInfo pi = new ProcessStartInfo(sourceListBox.SelectedItem.ToString())
            {
                Arguments = Path.GetFileName(sourceListBox.SelectedItem.ToString()),
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

        private void targetListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProcessStartInfo pi = new ProcessStartInfo(targetListBox.SelectedItem.ToString())
            {
                Arguments = Path.GetFileName(targetListBox.SelectedItem.ToString()),
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

        private void ImageConverterTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);

        }

        private void ImageConverterTool_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); Application.Exit();
        }

        private void sourceExtensionCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBox1 = sourceExtensionCbox.SelectedItem.ToString();

        }

        private void targetExtensionCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBox2 = "." + targetExtensionCbox.SelectedItem.ToString();
        }

        private void sourceListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void sourceListBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) sourceListBox.Items.Add(file);
        }



        private void sourceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            if (clearSelectExtCBox.SelectedIndex == 0)
                sourceListBox.Items.Clear();
            else
            {
                if (sourceListBox.Items.Count != 0)
                {
                    int listboxItemIndex = 0;
                    List<int> removeIndex = new List<int> { };
                    foreach (string file in sourceListBox.Items)
                    {
                        if (file.Split('.').Last().ToLower(new CultureInfo("en-US", false)) == clearSelectExtCBox.Text.ToLower(new CultureInfo("en-US", false)))
                        {
                            removeIndex.Add(listboxItemIndex);

                        }
                        listboxItemIndex++;
                    }
                    removeIndex.Reverse();
                    foreach (int index in removeIndex)
                    {
                        sourceListBox.Items.RemoveAt(index);
                    }
                }
            }
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if (Directory.Exists(dialog.SelectedPath))
            {
                string[] extensions = {
    ".jpeg", ".jpg", ".png", ".pdf", ".heic", ".gif", ".bmp", ".webp", ".aai", ".apng", ".art",
    ".arw", ".avi", ".avif", ".avs", ".bayer", ".bpg", ".bmp", ".bmp2", ".bmp3", ".brf", ".cals",
    ".cin", ".cip", ".cmyk", ".cmyka", ".cr2", ".crw", ".cube", ".cur", ".cut", ".dcm", ".dcr",
    ".dcx", ".dds", ".debug", ".dib", ".djvu", ".dmr", ".dng", ".dot", ".dpx", ".emf", ".epdf",
    ".epi", ".eps", ".eps2", ".eps3", ".epsf", ".epsi", ".ept", ".exr", ".farbfeld", ".fax",
    ".fits", ".fl32", ".flif", ".fpx", ".ftxt", ".gplt", ".gray", ".graya", ".hdr", ".hpgl",
    ".hrz", ".html", ".ico", ".info", ".isobrl", ".isobrl6", ".jbig", ".jng", ".jp2", ".jpt",
    ".j2c", ".j2k", ".jxr", ".json", ".jxl", ".kernel", ".man", ".mat", ".miff", ".mono", ".mng",
    ".m2v", ".mpeg", ".mpc", ".mpo", ".mpr", ".mrw", ".msl", ".mtv", ".mvg", ".nef", ".orf", ".ora",
    ".otb", ".p7", ".palm", ".pam", ".clipboard", ".pbm", ".pcd", ".pcds", ".pcl", ".pcx", ".pdb",
    ".pef", ".pes", ".pfa", ".pfb", ".pfm", ".pgm", ".phm", ".picon", ".pict", ".pix", ".png8",
    ".png00", ".png24", ".png32", ".png48", ".png64", ".pnm", ".pocketmod", ".ppm", ".ps", ".ps2",
    ".ps3", ".psb", ".psd", ".ptif", ".pwp", ".qoi", ".rad", ".raf", ".raw", ".rgb", ".rgb565",
    ".rgba", ".rgf", ".rla", ".rle", ".sct", ".sfw", ".sgi", ".shtml", ".sid", ".mrsid",
    ".sparse-color", ".strimg", ".sun", ".svg", ".text", ".tga", ".tiff", ".tim", ".ttf", ".txt",
    ".ubrl", ".ubrl6", ".uhdr", ".uil", ".uyvy", ".vicar", ".video", ".viff", ".wbmp", ".wdp",
    ".wmf", ".wpg", ".x", ".xbm", ".xcf", ".xpm", ".xwd", ".x3f", ".yaml", ".ycbcr", ".ycbcra",
    ".yuv", ".ashlar", ".canvas", ".caption", ".clip", ".clipboard", ".fractal", ".gradient",
    ".hald", ".histogram", ".inline", ".label", ".map", ".mask", ".matte", ".null", ".pango",
    ".plasma", ".preview", ".print", ".scan", ".radial_gradient", ".scanx", ".screenshot",
    ".stegano", ".tile", ".unique", ".vid", ".win", ".x", ".xc"
};
                var files = Directory.GetFiles(dialog.SelectedPath, "*.*", SearchOption.AllDirectories).Where(file => extensions.Contains(Path.GetExtension(file).ToLower())).ToList();


                foreach (string file in files)
                {
                    sourceListBox.Items.Add(file);
                }
            }
            else
            {
                Console.WriteLine("Belirtilen klasör bulunamadý!");
            }
        }
    }
}