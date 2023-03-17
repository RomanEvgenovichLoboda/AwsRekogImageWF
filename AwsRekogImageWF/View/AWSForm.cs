using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwsRekogImageWF.View
{
    public partial class AWSForm : Form
    {
        //string accessKey = "AKIA344VMXIHI53J3UPT";
        //string secretKey = "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";
        public AWSForm()
        {
            InitializeComponent();
        }

        private void btnGetBucket_Click(object sender, EventArgs e)
        {
            //using (var client = Amazon.AWSClientFactory.CreateAmazonS3Client(accessKey, secretKey, Amazon.RegionEndpoint.EUCentral1))
            //{
            //    var list = client.ListBuckets();

            //    foreach (var bucket in list.Buckets)
            //    {
            //        lbBuckets.Items.Add(bucket.BucketName);
            //    }
            //}
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            //using (var client = Amazon.AWSClientFactory.CreateAmazonS3Client(accessKey, secretKey))
            //{
            //    if (lbBuckets.SelectedIndex < 0)
            //        return;

            //    var list = client.ListObjects(
            //        new ListObjectsRequest()
            //        {
            //            BucketName = lbBuckets.SelectedItem.ToString()
            //        });

            //    foreach (var file in list.S3Objects)
            //    {
            //        lbFiles.Items.Add(file.Key);
            //    }
            //}
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //var dlg = new OpenFileDialog();

            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //    var stream = new FileStream(dlg.FileName, FileMode.Open);

            //    using (var client = Amazon.AWSClientFactory.CreateAmazonS3Client(accessKey, secretKey))
            //    {
            //        var request = new PutObjectRequest();

            //        if (lbBuckets.SelectedIndex < 0)
            //            return;

            //        request
            //            .WithBucketName(lbBuckets.SelectedItem.ToString())
            //            .WithCannedACL(S3CannedACL.PublicRead)
            //            .WithKey(Path.GetFileName(dlg.FileName))
            //            .InputStream = stream;

            //        client.PutObject(request);
            //    }
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //using (var client = Amazon.AWSClientFactory.CreateAmazonS3Client(accessKey, secretKey))
            //{
            //    if (lbFiles.SelectedIndex < 0)
            //        return;

            //    new DeleteObjectRequest()
            //        .WithBucketName(lbBuckets.SelectedItem.ToString())
            //        .WithKey(lbFiles.SelectedItem.ToString());
            //}
        }
    }
}
