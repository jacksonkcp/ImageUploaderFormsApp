using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        private async void uploadBtn_Click(object sender, EventArgs e)
        {
            if (imageDisplay.Image == null)
            {
                MessageBox.Show("Browse for an image first!");
                return;
            }

            using (var form = new MultipartFormDataContent())
            {
                var fileContent = new ByteArrayContent(ImageToByteArray(imageDisplay.Image));
                fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");

                form.Add(fileContent, "file", "image.jpg");

                using(HttpClient httpClient = new HttpClient())
                {
                    var response = await httpClient.PostAsync("https://localhost:7035/Upload/image", form);
                    var responseString = await response.Content.ReadAsStringAsync();
                    uploadStatusBox.Text = responseString; // Display URL or status
                }


            }

            //uploadStatusBox.Text = "Success!";
            //uploadStatusBox.BackColor = Color.LightGreen;
        }

        private void viewWebPageBtn_Click(object sender, EventArgs e)
        {
            // URL of the webpage you want to open
            string url = "https://localhost:7035/index.html";

            try
            {
                // Open the URL in the default web browser
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
