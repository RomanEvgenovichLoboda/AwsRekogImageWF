using Amazon;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;
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
                    filePath = openfiledialog.FileName;

                    try
                    {
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
                        btnShow_Click(sender, e);
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

        private void btnAnalize_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex < 0) MessageBox.Show("Choose File From List!");
            else
            {
                AmazonRekognitionClient rekClient = new AmazonRekognitionClient("AKIA344VMXIHI53J3UPT", "SmGmMBv4hKZhbIhvDK57ewOnKntKFhK87RDv03L4", Amazon.RegionEndpoint.EUCentral1);
                DetectFacesRequest detectFacesRequest = new DetectFacesRequest()
                {
                    Image = new Amazon.Rekognition.Model.Image()
                    {
                        S3Object = new Amazon.Rekognition.Model.S3Object()
                        {
                            Name = listBoxFiles.SelectedItem.ToString(),
                            Bucket = bucketName
                        }
                    },
                    Attributes = new List<string>() { "ALL" }
                };
                try
                {
                    DetectFacesResponse detectFacesResponse = rekClient.DetectFacesAsync(detectFacesRequest).GetAwaiter().GetResult();
                    string info = "";
                    foreach (var item in detectFacesResponse.FaceDetails)
                    {
                        if (item != null) info += "Age = " + item.AgeRange.Low + " - " + item.AgeRange.High + " / " + "  Genger = " + item.Gender.Value.Value + "\n";
                    }
                    MessageBox.Show(info,"Analize");
                }
                catch(Exception ex) { MessageBox.Show(ex.Message, "Error"); }
            }
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex < 0) MessageBox.Show("Choose File From List!");
            else
            {
                try
                {
                    client.DeleteObjectAsync(bucketName, listBoxFiles.SelectedItem.ToString());
                    MessageBox.Show("Remuved!", "Mssage");
                    btnShow_Click(sender, e);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
                
            }
        }
    }
}