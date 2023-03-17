using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
namespace AwsRekogImageWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            client = new AmazonS3Client("AKIA344VMXIHI53J3UPT", "SmGmMBv4hKZhbIhvDK57ewOnKntKFhK87RDv03L4",Amazon.RegionEndpoint.EUCentral1);
        }
        private const string bucketName = "reml2bucket";
        private string filePath;
        private static IAmazonS3 client;
        private async void uploadButton_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            using (OpenFileDialog openfiledialog = new OpenFileDialog())
            {
                openfiledialog.InitialDirectory = "c:\\";
                openfiledialog.Filter = "image files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png";
                openfiledialog.FilterIndex = 2;
                openfiledialog.RestoreDirectory = true;

                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    //get the path of specified file
                    filePath = openfiledialog.FileName;

                    try
                    {
                        
                        // 2. Put the object-set ContentType and add metadata.
                        var putRequest2 = new PutObjectRequest
                        {
                            BucketName = bucketName,
                            Key = Path.GetFileName(filePath),
                            FilePath = filePath,
                            ContentType = "text/plain"
                        };

                        putRequest2.Metadata.Add("x-amz-meta-title", "someTitle");
                        PutObjectResponse response2 = await client.PutObjectAsync(putRequest2);
                        MessageBox.Show("Uploaded!");
                    }
                    catch (AmazonS3Exception ex)
                    {
                        MessageBox.Show($"Error encountered ***. Message:'{ex.Message}' when writing an object");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unknown encountered on server. Message:'{ex.Message}' when writing an object");
                    }
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listBoxFiles.Items.Clear();
            listBoxFiles.Items.AddRange(client.ListObjectsAsync(bucketName).Result.S3Objects.Select(item=>item.Key).ToArray());
        }
    }
}