namespace ImageConverterTool
{
    partial class ImageConverterTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageConverterTool));
            selectImageButton = new Button();
            sourceListBox = new ListBox();
            selectSavePathButton = new Button();
            convertButton = new Button();
            label6 = new Label();
            targetListBox = new ListBox();
            sourceExtensionCbox = new ComboBox();
            targetExtensionCbox = new ComboBox();
            exitButton = new Button();
            label1 = new Label();
            label2 = new Label();
            targetPathlbl = new Label();
            label3 = new Label();
            label5 = new Label();
            clearButton = new Button();
            selectFolderButton = new Button();
            clearSelectExtCBox = new ComboBox();
            SuspendLayout();
            // 
            // selectImageButton
            // 
            selectImageButton.Location = new Point(12, 11);
            selectImageButton.Name = "selectImageButton";
            selectImageButton.Size = new Size(202, 23);
            selectImageButton.TabIndex = 1;
            selectImageButton.Text = "Select Images or Drag and Drop";
            selectImageButton.UseVisualStyleBackColor = true;
            selectImageButton.Click += selectImageButton_Click;
            // 
            // sourceListBox
            // 
            sourceListBox.AllowDrop = true;
            sourceListBox.FormattingEnabled = true;
            sourceListBox.ItemHeight = 15;
            sourceListBox.Location = new Point(12, 40);
            sourceListBox.Name = "sourceListBox";
            sourceListBox.Size = new Size(372, 244);
            sourceListBox.TabIndex = 3;
            sourceListBox.SelectedIndexChanged += sourceListBox_SelectedIndexChanged;
            sourceListBox.DragDrop += sourceListBox_DragDrop;
            sourceListBox.DragEnter += sourceListBox_DragEnter;
            sourceListBox.MouseDoubleClick += sourceListBox_MouseDoubleClick;
            // 
            // selectSavePathButton
            // 
            selectSavePathButton.Location = new Point(12, 382);
            selectSavePathButton.Name = "selectSavePathButton";
            selectSavePathButton.Size = new Size(373, 23);
            selectSavePathButton.TabIndex = 7;
            selectSavePathButton.Text = "Select the folder to save the converted images";
            selectSavePathButton.UseVisualStyleBackColor = true;
            selectSavePathButton.Click += selectSavePathButton_Click;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(12, 428);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(151, 23);
            convertButton.TabIndex = 9;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
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
            // targetListBox
            // 
            targetListBox.FormattingEnabled = true;
            targetListBox.ItemHeight = 15;
            targetListBox.Location = new Point(13, 490);
            targetListBox.Name = "targetListBox";
            targetListBox.Size = new Size(372, 124);
            targetListBox.TabIndex = 11;
            targetListBox.MouseDoubleClick += targetListBox_MouseDoubleClick;
            // 
            // sourceExtensionCbox
            // 
            sourceExtensionCbox.DropDownStyle = ComboBoxStyle.DropDownList;
            sourceExtensionCbox.FormattingEnabled = true;
            sourceExtensionCbox.Location = new Point(11, 353);
            sourceExtensionCbox.Name = "sourceExtensionCbox";
            sourceExtensionCbox.Size = new Size(152, 23);
            sourceExtensionCbox.TabIndex = 8;
            sourceExtensionCbox.SelectedIndexChanged += sourceExtensionCbox_SelectedIndexChanged;
            // 
            // targetExtensionCbox
            // 
            targetExtensionCbox.DropDownStyle = ComboBoxStyle.DropDownList;
            targetExtensionCbox.FormattingEnabled = true;
            targetExtensionCbox.Location = new Point(227, 353);
            targetExtensionCbox.Name = "targetExtensionCbox";
            targetExtensionCbox.Size = new Size(158, 23);
            targetExtensionCbox.TabIndex = 9;
            targetExtensionCbox.SelectedIndexChanged += targetExtensionCbox_SelectedIndexChanged;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(227, 428);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(158, 23);
            exitButton.TabIndex = 15;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
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
            // targetPathlbl
            // 
            targetPathlbl.Location = new Point(12, 408);
            targetPathlbl.Name = "targetPathlbl";
            targetPathlbl.Size = new Size(372, 17);
            targetPathlbl.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 287);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 617);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 20;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(359, 11);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(26, 23);
            clearButton.TabIndex = 21;
            clearButton.Text = "\U0001f9f9";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // selectFolderButton
            // 
            selectFolderButton.Location = new Point(220, 12);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.Size = new Size(26, 23);
            selectFolderButton.TabIndex = 22;
            selectFolderButton.Text = "📁";
            selectFolderButton.UseVisualStyleBackColor = true;
            selectFolderButton.Click += selectFolderButton_Click;
            // 
            // clearSelectExtCBox
            // 
            clearSelectExtCBox.FormattingEnabled = true;
            clearSelectExtCBox.Location = new Point(252, 11);
            clearSelectExtCBox.Name = "clearSelectExtCBox";
            clearSelectExtCBox.Size = new Size(101, 23);
            clearSelectExtCBox.TabIndex = 23;
            // 
            // ImageConverterTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 634);
            Controls.Add(clearSelectExtCBox);
            Controls.Add(selectFolderButton);
            Controls.Add(clearButton);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(targetPathlbl);
            Controls.Add(label2);
            Controls.Add(targetExtensionCbox);
            Controls.Add(selectSavePathButton);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(sourceExtensionCbox);
            Controls.Add(selectImageButton);
            Controls.Add(targetListBox);
            Controls.Add(label6);
            Controls.Add(convertButton);
            Controls.Add(sourceListBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ImageConverterTool";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Converter Tool";
            FormClosing += ImageConverterTool_FormClosing;
            FormClosed += ImageConverterTool_FormClosed;
            Load += ImageConverterTool_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button selectImageButton;
        private ListBox sourceListBox;
        private Button selectSavePathButton;
        private Button convertButton;
        private Label label6;
        private ListBox targetListBox;
        private Button exitButton;
        private ComboBox sourceExtensionCbox;
        private ComboBox targetExtensionCbox;
        private Label label1;
        private Label label2;
        private Label targetPathlbl;
        private Label label3;
        private Label label5;
        private Button clearButton;
        private Button selectFolderButton;
        private ComboBox clearSelectExtCBox;
    }
}
