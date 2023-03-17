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
            this.uploadButton = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAnalize = new System.Windows.Forms.Button();
            this.btnDell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(282, 82);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(94, 57);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "Upload Image";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 20;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 12);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(249, 184);
            this.listBoxFiles.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(282, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(94, 29);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show Files";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAnalize
            // 
            this.btnAnalize.Location = new System.Drawing.Point(282, 47);
            this.btnAnalize.Name = "btnAnalize";
            this.btnAnalize.Size = new System.Drawing.Size(94, 29);
            this.btnAnalize.TabIndex = 3;
            this.btnAnalize.Text = "Analize";
            this.btnAnalize.UseVisualStyleBackColor = true;
            this.btnAnalize.Click += new System.EventHandler(this.btnAnalize_Click);
            // 
            // btnDell
            // 
            this.btnDell.Location = new System.Drawing.Point(282, 145);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(94, 57);
            this.btnDell.TabIndex = 4;
            this.btnDell.Text = "Remuve Image";
            this.btnDell.UseVisualStyleBackColor = true;
            this.btnDell.Click += new System.EventHandler(this.btnDell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 240);
            this.Controls.Add(this.btnDell);
            this.Controls.Add(this.btnAnalize);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.uploadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "AWSBucket";
            this.ResumeLayout(false);

        }

        #endregion

        private Button uploadButton;
        private ListBox listBoxFiles;
        private Button btnShow;
        private Button btnAnalize;
        private Button btnDell;
    }
}