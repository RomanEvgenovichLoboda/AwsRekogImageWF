namespace AwsRekogImageWF
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
            uploadButton = new Button();
            listBoxFiles = new ListBox();
            btnAnalize = new Button();
            btnDell = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // uploadButton
            // 
            uploadButton.Location = new Point(406, 12);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(115, 53);
            uploadButton.TabIndex = 0;
            uploadButton.Text = "Upload Image";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadButton_Click;
            // 
            // listBoxFiles
            // 
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.ItemHeight = 20;
            listBoxFiles.Location = new Point(12, 12);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(377, 164);
            listBoxFiles.TabIndex = 1;
            listBoxFiles.DoubleClick += listBoxFiles_DoubleClick;
            // 
            // btnAnalize
            // 
            btnAnalize.Location = new Point(406, 132);
            btnAnalize.Name = "btnAnalize";
            btnAnalize.Size = new Size(115, 52);
            btnAnalize.TabIndex = 3;
            btnAnalize.Text = "Analize";
            btnAnalize.UseVisualStyleBackColor = true;
            btnAnalize.Click += btnAnalize_Click;
            // 
            // btnDell
            // 
            btnDell.Location = new Point(406, 71);
            btnDell.Name = "btnDell";
            btnDell.Size = new Size(115, 55);
            btnDell.TabIndex = 4;
            btnDell.Text = "Remuve Image";
            btnDell.UseVisualStyleBackColor = true;
            btnDell.Click += btnDell_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(12, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 362);
            panel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 579);
            Controls.Add(panel1);
            Controls.Add(btnDell);
            Controls.Add(btnAnalize);
            Controls.Add(listBoxFiles);
            Controls.Add(uploadButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "AWSBucket";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button uploadButton;
        private ListBox listBoxFiles;
        private Button btnAnalize;
        private Button btnDell;
        public Panel panel1;
    }
}