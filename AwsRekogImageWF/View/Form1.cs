using AwsRekogImageWF.Controller;
using static System.Net.Mime.MediaTypeNames;

namespace AwsRekogImageWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowFiles();
        }

        private void ShowFiles()
        {
            listBoxFiles.Items.Clear();
            listBoxFiles.Items.AddRange(AmazonClientController.GetFilesNames());
        }

        private async void uploadButton_Click(object sender, EventArgs e)
        {
            AmazonClientController.UploadFile();
            await Task.Run(() => ShowFiles());
        }

        private void btnAnalize_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex < 0) MessageBox.Show("Choose File From List!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                AmazonClientController.ShowFaces(listBoxFiles.SelectedItem.ToString());
                //AmazonClientController.DetectFaces(listBoxFiles.SelectedItem.ToString());
                //ShowFiles();
            }
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex < 0) MessageBox.Show("Choose File From List!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                AmazonClientController.RemuveFile(listBoxFiles.SelectedItem.ToString());
                ShowFiles();
            }
        }

        private void listBoxFiles_DoubleClick(object sender, EventArgs e)
        {
            AmazonClientController.ShowFaces(listBoxFiles.SelectedItem.ToString());
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Directory.Delete($"{Directory.GetCurrentDirectory}" + "/Image/");
            var list = Directory.EnumerateFiles($"{Directory.GetCurrentDirectory}" + "/Image/");
            foreach (var file in list)
            {
                try
                {
                    File.Delete(file);
                }
                catch { }

            }
        }
    }
}