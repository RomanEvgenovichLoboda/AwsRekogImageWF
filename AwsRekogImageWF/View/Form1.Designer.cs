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
            btnUpdateList = new Button();
            SuspendLayout();
            // 
            // uploadButton
            // 
            uploadButton.Location = new Point(282, 87);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(94, 57);
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
            listBoxFiles.Size = new Size(249, 184);
            listBoxFiles.TabIndex = 1;
            // 
            // btnAnalize
            // 
            btnAnalize.Location = new Point(282, 52);
            btnAnalize.Name = "btnAnalize";
            btnAnalize.Size = new Size(94, 29);
            btnAnalize.TabIndex = 3;
            btnAnalize.Text = "Analize";
            btnAnalize.UseVisualStyleBackColor = true;
            btnAnalize.Click += btnAnalize_Click;
            // 
            // btnDell
            // 
            btnDell.Location = new Point(282, 150);
            btnDell.Name = "btnDell";
            btnDell.Size = new Size(94, 57);
            btnDell.TabIndex = 4;
            btnDell.Text = "Remuve Image";
            btnDell.UseVisualStyleBackColor = true;
            btnDell.Click += btnDell_Click;
            // 
            // btnUpdateList
            // 
            btnUpdateList.Location = new Point(282, 12);
            btnUpdateList.Name = "btnUpdateList";
            btnUpdateList.Size = new Size(94, 29);
            btnUpdateList.TabIndex = 5;
            btnUpdateList.Text = "Show Files";
            btnUpdateList.UseVisualStyleBackColor = true;
            btnUpdateList.Click += ShowFiles;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 219);
            Controls.Add(btnUpdateList);
            Controls.Add(btnDell);
            Controls.Add(btnAnalize);
            Controls.Add(listBoxFiles);
            Controls.Add(uploadButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "AWSBucket";
            ResumeLayout(false);
        }

        #endregion

        private Button uploadButton;
        private ListBox listBoxFiles;
        private Button btnAnalize;
        private Button btnDell;
        private Button btnUpdateList;
    }
}