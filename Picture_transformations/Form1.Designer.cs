namespace Picture_transformations
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            listBox2 = new ListBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 11);
            button1.Name = "button1";
            button1.Size = new Size(372, 23);
            button1.TabIndex = 1;
            button1.Text = "Select Images";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(372, 244);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // button2
            // 
            button2.Location = new Point(12, 382);
            button2.Name = "button2";
            button2.Size = new Size(373, 23);
            button2.TabIndex = 7;
            button2.Text = "Select the folder to save the converted images";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 428);
            button3.Name = "button3";
            button3.Size = new Size(151, 23);
            button3.TabIndex = 9;
            button3.Text = "Bul ve Dönüştür";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 472);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 10;
            label6.Text = "0";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(13, 490);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(372, 124);
            listBox2.TabIndex = 11;
            listBox2.MouseDoubleClick += listBox2_MouseDoubleClick;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(11, 353);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(227, 353);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(158, 23);
            comboBox2.TabIndex = 9;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(293, 472);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 14;
            label7.Text = "Dönüştürülenler";
            // 
            // button4
            // 
            button4.Location = new Point(227, 428);
            button4.Name = "button4";
            button4.Size = new Size(158, 23);
            button4.TabIndex = 15;
            button4.Text = "ÇIKIŞ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.Location = new Point(12, 303);
            label1.Name = "label1";
            label1.Size = new Size(151, 47);
            label1.TabIndex = 9;
            label1.Text = "Select the extension to convert from the images (optional)";
            // 
            // label2
            // 
            label2.Location = new Point(234, 303);
            label2.Name = "label2";
            label2.Size = new Size(151, 47);
            label2.TabIndex = 16;
            label2.Text = "Select the image extension you want to convert(required)";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(12, 408);
            label4.Name = "label4";
            label4.Size = new Size(372, 17);
            label4.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 287);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 625);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resim Çevirici";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Label label6;
        private ListBox listBox2;
        private Label label7;
        private Button button4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}
