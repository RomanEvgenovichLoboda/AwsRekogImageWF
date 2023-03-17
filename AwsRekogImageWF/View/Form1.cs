using AwsRekogImageWF.Controller;

namespace AwsRekogImageWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowFiles(object sender, EventArgs e)
        {
            listBoxFiles.Items.Clear();
            listBoxFiles.Items.AddRange(AmazonClientController.GetFilesNames());
        }

        private async void uploadButton_Click(object sender, EventArgs e)
        {
            AmazonClientController.UploadFile();
            await Task.Run(() => ShowFiles(sender, e));
        }

        private void btnAnalize_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex < 0) MessageBox.Show("Choose File From List!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                AmazonClientController.DetectFaces(listBoxFiles.SelectedItem.ToString());
                ShowFiles(sender, e);
            }
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex < 0) MessageBox.Show("Choose File From List!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                AmazonClientController.RemuveFile(listBoxFiles.SelectedItem.ToString());
                ShowFiles(sender, e);
            }
        }
    }
}