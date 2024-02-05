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
            label2 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            button3 = new Button();
            label6 = new Label();
            listBox2 = new ListBox();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton10 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            label7 = new Label();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(7, 84);
            button1.Name = "button1";
            button1.Size = new Size(157, 23);
            button1.TabIndex = 1;
            button1.Text = "SEÇ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Location = new Point(6, 110);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 2;
            label2.Text = " ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 288);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(360, 64);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 110);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 6;
            label4.Text = " ";
            // 
            // button2
            // 
            button2.Location = new Point(6, 84);
            button2.Name = "button2";
            button2.Size = new Size(158, 23);
            button2.TabIndex = 7;
            button2.Text = "SEÇ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 270);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 8;
            label5.Text = "Bulunan Dosyalar";
            // 
            // button3
            // 
            button3.Location = new Point(12, 221);
            button3.Name = "button3";
            button3.Size = new Size(105, 34);
            button3.TabIndex = 9;
            button3.Text = "Bul ve Dönüştür";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 355);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 10;
            label6.Text = "0";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(12, 393);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(360, 64);
            listBox2.TabIndex = 11;
            listBox2.MouseDoubleClick += listBox2_MouseDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(170, 199);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resimlerin Bulunduğu Klasör";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(116, 34);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(48, 19);
            radioButton4.TabIndex = 6;
            radioButton4.Text = "jpeg";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(116, 59);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(42, 19);
            radioButton3.TabIndex = 5;
            radioButton3.Text = "jpg";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(7, 59);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(46, 19);
            radioButton2.TabIndex = 4;
            radioButton2.Text = "png";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(6, 34);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(47, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "heic";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton10);
            groupBox2.Controls.Add(radioButton9);
            groupBox2.Controls.Add(radioButton8);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(202, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(170, 199);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dönüştürülen resimlerin kaydedileceği klasör";
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Checked = true;
            radioButton10.Location = new Point(97, 34);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(48, 19);
            radioButton10.TabIndex = 3;
            radioButton10.TabStop = true;
            radioButton10.Text = "jpeg";
            radioButton10.UseVisualStyleBackColor = true;
            radioButton10.CheckedChanged += radioButton10_CheckedChanged;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(97, 59);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(42, 19);
            radioButton9.TabIndex = 2;
            radioButton9.Text = "jpg";
            radioButton9.UseVisualStyleBackColor = true;
            radioButton9.CheckedChanged += radioButton9_CheckedChanged;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(11, 59);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(46, 19);
            radioButton8.TabIndex = 1;
            radioButton8.Text = "png";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += radioButton8_CheckedChanged;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(10, 34);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(47, 19);
            radioButton7.TabIndex = 0;
            radioButton7.Text = "heic";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 375);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 14;
            label7.Text = "Dönüştürülenler";
            // 
            // button4
            // 
            button4.Location = new Point(267, 221);
            button4.Name = "button4";
            button4.Size = new Size(105, 34);
            button4.TabIndex = 15;
            button4.Text = "ÇIKIŞ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 484);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listBox2);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resim Çevirici";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label2;
        private ListBox listBox1;
        private Label label4;
        private Button button2;
        private Label label5;
        private Button button3;
        private Label label6;
        private ListBox listBox2;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton10;
        private Label label7;
        private Button button4;
    }
}
