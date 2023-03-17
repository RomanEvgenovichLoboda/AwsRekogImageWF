using Amazon.S3.Model;
using Amazon.S3;
using AwsRekogImageWF.Model;
using Amazon.Rekognition.Model;

namespace AwsRekogImageWF.Controller
{
    public static class AmazonClientController
    {
        public static async void UploadFile()
        {
            using (OpenFileDialog openfiledialog = new OpenFileDialog())
            {
                openfiledialog.InitialDirectory = "c:\\";
                openfiledialog.Filter = "image files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png";
                openfiledialog.FilterIndex = 2;
                openfiledialog.RestoreDirectory = true;

                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openfiledialog.FileName;
                    try
                    {
                        var putRequest = new PutObjectRequest
                        {
                            BucketName = AmazonClient.bucketName,
                            Key = Path.GetFileName(filePath),
                            FilePath = filePath,
                            ContentType = "text/plain"
                        };

                        putRequest.Metadata.Add("x-amz-meta-title", "someTitle");
                        PutObjectResponse response2 = await AmazonClient.client.PutObjectAsync(putRequest);
                        MessageBox.Show("Uploaded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (AmazonS3Exception ex)
                    {
                        MessageBox.Show($"Error encountered ***. Message:'{ex.Message}' when writing an object","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unknown encountered on server. Message:'{ex.Message}' when writing an object", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public static string[] GetFilesNames() => AmazonClient.client.ListObjectsAsync(AmazonClient.bucketName).Result.S3Objects.Select(item => item.Key).ToArray();

        public static void RemuveFile(string file)
        {
            try
            {
                AmazonClient.client.DeleteObjectAsync(AmazonClient.bucketName, file);
                MessageBox.Show("Remuved!", "Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public static void DetectFaces(string file)
        {
            DetectFacesRequest detectFacesRequest = new DetectFacesRequest()
            {
                Image = new Amazon.Rekognition.Model.Image()
                {
                    S3Object = new Amazon.Rekognition.Model.S3Object()
                    {
                        Name = file,
                        Bucket = AmazonClient.bucketName
                    }
                },
                Attributes = new List<string>() { "ALL" }
            };
            try
            {
                DetectFacesResponse detectFacesResponse = AmazonClient.rekognitionClient.DetectFacesAsync(detectFacesRequest).GetAwaiter().GetResult();
                string info = "";
                foreach (var item in detectFacesResponse.FaceDetails)
                {
                    if (item != null) info += "Age = " + item.AgeRange.Low + " - " + item.AgeRange.High + " / " + "  Genger = " + item.Gender.Value.Value + "\n";
                }
                MessageBox.Show(info, "Analize",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
