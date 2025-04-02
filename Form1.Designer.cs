namespace URL_Dumper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.DumpBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.urlInput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DisplaySubdomains = new System.Windows.Forms.RichTextBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.DisplaySubdirectories = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL Dumper";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DumpBtn
            // 
            this.DumpBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DumpBtn.BackColor = System.Drawing.Color.Green;
            this.DumpBtn.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DumpBtn.ForeColor = System.Drawing.Color.White;
            this.DumpBtn.Location = new System.Drawing.Point(693, 118);
            this.DumpBtn.Name = "DumpBtn";
            this.DumpBtn.Size = new System.Drawing.Size(83, 36);
            this.DumpBtn.TabIndex = 2;
            this.DumpBtn.Text = "Dump";
            this.DumpBtn.UseVisualStyleBackColor = false;
            this.DumpBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL:";
            // 
            // urlInput
            // 
            this.urlInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.urlInput.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlInput.Location = new System.Drawing.Point(99, 78);
            this.urlInput.Multiline = false;
            this.urlInput.Name = "urlInput";
            this.urlInput.Size = new System.Drawing.Size(677, 34);
            this.urlInput.TabIndex = 4;
            this.urlInput.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loading.....";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DisplaySubdomains
            // 
            this.DisplaySubdomains.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DisplaySubdomains.BackColor = System.Drawing.Color.Black;
            this.DisplaySubdomains.DetectUrls = false;
            this.DisplaySubdomains.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold);
            this.DisplaySubdomains.ForeColor = System.Drawing.Color.Lime;
            this.DisplaySubdomains.Location = new System.Drawing.Point(17, 244);
            this.DisplaySubdomains.Name = "DisplaySubdomains";
            this.DisplaySubdomains.ReadOnly = true;
            this.DisplaySubdomains.Size = new System.Drawing.Size(759, 150);
            this.DisplaySubdomains.TabIndex = 8;
            this.DisplaySubdomains.Text = "";
            // 
            // StopBtn
            // 
            this.StopBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StopBtn.BackColor = System.Drawing.Color.Red;
            this.StopBtn.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold);
            this.StopBtn.Location = new System.Drawing.Point(604, 118);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(83, 36);
            this.StopBtn.TabIndex = 9;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // DisplaySubdirectories
            // 
            this.DisplaySubdirectories.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DisplaySubdirectories.BackColor = System.Drawing.Color.Black;
            this.DisplaySubdirectories.DetectUrls = false;
            this.DisplaySubdirectories.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold);
            this.DisplaySubdirectories.ForeColor = System.Drawing.Color.Lime;
            this.DisplaySubdirectories.Location = new System.Drawing.Point(12, 499);
            this.DisplaySubdirectories.Name = "DisplaySubdirectories";
            this.DisplaySubdirectories.ReadOnly = true;
            this.DisplaySubdirectories.Size = new System.Drawing.Size(759, 150);
            this.DisplaySubdirectories.TabIndex = 8;
            this.DisplaySubdirectories.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sub-Domains:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sub-Directories:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(16, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Loading.....";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(16, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "ETC";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(16, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "ETC";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("OCR A Extended", 15F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(340, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "By Samrat Sarkar";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::URL_Dumper.Properties.Resources.diglogo;
            this.pictureBox1.Location = new System.Drawing.Point(228, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // LoadFile
            // 
            this.LoadFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoadFile.BackColor = System.Drawing.Color.Blue;
            this.LoadFile.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold);
            this.LoadFile.Location = new System.Drawing.Point(99, 118);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(287, 36);
            this.LoadFile.TabIndex = 18;
            this.LoadFile.Text = "Load Wordlist (Optional)";
            this.LoadFile.UseVisualStyleBackColor = false;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 687);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DisplaySubdirectories);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.DisplaySubdomains);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.urlInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DumpBtn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 726);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "URL Dumper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DumpBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox urlInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox DisplaySubdomains;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.RichTextBox DisplaySubdirectories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoadFile;
    }
}

