namespace AwsRekogImageWF.View
{
    partial class AWSForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbBuckets = new System.Windows.Forms.ListBox();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.btnGetBucket = new System.Windows.Forms.Button();
            this.btnGetList = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBuckets
            // 
            this.lbBuckets.FormattingEnabled = true;
            this.lbBuckets.ItemHeight = 20;
            this.lbBuckets.Location = new System.Drawing.Point(21, 41);
            this.lbBuckets.Name = "lbBuckets";
            this.lbBuckets.Size = new System.Drawing.Size(266, 284);
            this.lbBuckets.TabIndex = 0;
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 20;
            this.lbFiles.Location = new System.Drawing.Point(333, 41);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(303, 284);
            this.lbFiles.TabIndex = 1;
            // 
            // btnGetBucket
            // 
            this.btnGetBucket.Location = new System.Drawing.Point(105, 331);
            this.btnGetBucket.Name = "btnGetBucket";
            this.btnGetBucket.Size = new System.Drawing.Size(94, 29);
            this.btnGetBucket.TabIndex = 2;
            this.btnGetBucket.Text = "Get Buckets";
            this.btnGetBucket.UseVisualStyleBackColor = true;
            this.btnGetBucket.Click += new System.EventHandler(this.btnGetBucket_Click);
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(418, 331);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(94, 29);
            this.btnGetList.TabIndex = 3;
            this.btnGetList.Text = "Get Files";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(49, 409);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(94, 29);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload File";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(163, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete File";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AWSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnGetList);
            this.Controls.Add(this.btnGetBucket);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.lbBuckets);
            this.Name = "AWSForm";
            this.Text = "AWSForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbBuckets;
        private ListBox lbFiles;
        private Button btnGetBucket;
        private Button btnGetList;
        private Button btnUpload;
        private Button btnDelete;
    }
}