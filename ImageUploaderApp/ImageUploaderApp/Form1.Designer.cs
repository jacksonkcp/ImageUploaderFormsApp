﻿namespace ImageUploaderApp
{
    partial class Form1
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
            this.imageDisplay = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uploadStatusBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.browseBtn = new System.Windows.Forms.Button();
            this.viewWebpageBtn = new System.Windows.Forms.Button();
            this.locationBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageDisplay
            // 
            this.imageDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.imageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageDisplay.Location = new System.Drawing.Point(0, 0);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(634, 281);
            this.imageDisplay.TabIndex = 1;
            this.imageDisplay.TabStop = false;
            this.imageDisplay.Click += new System.EventHandler(this.imageDisplay_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.locationBox);
            this.panel1.Controls.Add(this.browseBtn);
            this.panel1.Controls.Add(this.viewWebpageBtn);
            this.panel1.Controls.Add(this.uploadStatusBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.uploadButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 163);
            this.panel1.TabIndex = 9;
            // 
            // uploadStatusBox
            // 
            this.uploadStatusBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadStatusBox.Location = new System.Drawing.Point(145, 119);
            this.uploadStatusBox.Name = "uploadStatusBox";
            this.uploadStatusBox.Size = new System.Drawing.Size(329, 20);
            this.uploadStatusBox.TabIndex = 4;
            this.uploadStatusBox.TextChanged += new System.EventHandler(this.uploadStatusBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Upload Status";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadButton.Location = new System.Drawing.Point(521, 68);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(91, 23);
            this.uploadButton.TabIndex = 3;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Image Location";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.browseBtn.Location = new System.Drawing.Point(521, 28);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(91, 23);
            this.browseBtn.TabIndex = 0;
            this.browseBtn.Text = "Browse..";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // viewWebpageBtn
            // 
            this.viewWebpageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewWebpageBtn.Location = new System.Drawing.Point(521, 119);
            this.viewWebpageBtn.Name = "viewWebpageBtn";
            this.viewWebpageBtn.Size = new System.Drawing.Size(91, 23);
            this.viewWebpageBtn.TabIndex = 7;
            this.viewWebpageBtn.Text = "View Webpage";
            this.viewWebpageBtn.UseVisualStyleBackColor = true;
            this.viewWebpageBtn.Click += new System.EventHandler(this.viewWebPageBtn_Click);
            // 
            // locationBox
            // 
            this.locationBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationBox.Location = new System.Drawing.Point(145, 30);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(329, 20);
            this.locationBox.TabIndex = 2;
            this.locationBox.TextChanged += new System.EventHandler(this.locationBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imageDisplay);
            this.MinimumSize = new System.Drawing.Size(650, 489);
            this.Name = "Form1";
            this.Text = "Upload Image";
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imageDisplay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button viewWebpageBtn;
        private System.Windows.Forms.TextBox uploadStatusBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uploadButton;
    }
}

