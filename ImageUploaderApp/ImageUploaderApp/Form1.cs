using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageUploaderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var filePath = openFileDialog.FileName;
                        var fileContent = new ByteArrayContent(System.IO.File.ReadAllBytes(filePath));
                        fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
                        Image image = Image.FromFile(filePath);

                        imageDisplay.Image = image;
                        imageDisplay.SizeMode = PictureBoxSizeMode.CenterImage;
                        locationBox.Text = filePath;

                        // Adjust the PictureBox size to match the image size
                        imageDisplay.Width = image.Width;
                        imageDisplay.Height = image.Height;

                        //// Resize the form based on the image size plus any padding (e.g., 20 pixels for margin)
                        this.ClientSize = new Size(Math.Max(image.Width,panel1.Width), image.Height + panel1.Height + 20);

                    }
                }
            }
            catch (Exception ex) {
                uploadStatusBox.Text = $"Failed: {ex}";
            }

        }
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            //using (var form = new MultipartFormDataContent())
            //{
            //    form.Add(fileContent, "file", "image.jpg");

            //var response = await _httpClient.PostAsync("http://localhost:5000/upload", form);
            //var responseString = await response.Content.ReadAsStringAsync();
            //    uploadStatusBox.Text = responseString; // Display URL or status
            //}

            uploadStatusBox.Text = "Success!";
            uploadStatusBox.BackColor = Color.LightGreen;
        }

        private void viewWebPageBtn_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void locationBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uploadStatusBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imageDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
