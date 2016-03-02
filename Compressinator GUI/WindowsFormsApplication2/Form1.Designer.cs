namespace WindowsFormsApplication2
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
            this.Zipbutton = new System.Windows.Forms.Button();
            this.UnZipbutton = new System.Windows.Forms.Button();
            this.ZipPathText = new System.Windows.Forms.TextBox();
            this.DecompressText = new System.Windows.Forms.TextBox();
            this.LogText = new System.Windows.Forms.TextBox();
            this.LogButton = new System.Windows.Forms.Button();
            this.CompressExtText = new System.Windows.Forms.TextBox();
            this.DecompressExtText = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CompressText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GZipCompressText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GZipCompressExt = new System.Windows.Forms.TextBox();
            this.GZipDecompressText = new System.Windows.Forms.TextBox();
            this.GZipPathText = new System.Windows.Forms.TextBox();
            this.UnGZipbutton = new System.Windows.Forms.Button();
            this.GZipbutton = new System.Windows.Forms.Button();
            this.zipnameText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Zipbutton
            // 
            this.Zipbutton.Location = new System.Drawing.Point(68, 85);
            this.Zipbutton.Name = "Zipbutton";
            this.Zipbutton.Size = new System.Drawing.Size(75, 23);
            this.Zipbutton.TabIndex = 0;
            this.Zipbutton.Text = "Zip";
            this.Zipbutton.UseVisualStyleBackColor = true;
            this.Zipbutton.Click += new System.EventHandler(this.Zipbutton_Click);
            // 
            // UnZipbutton
            // 
            this.UnZipbutton.Location = new System.Drawing.Point(68, 130);
            this.UnZipbutton.Name = "UnZipbutton";
            this.UnZipbutton.Size = new System.Drawing.Size(75, 23);
            this.UnZipbutton.TabIndex = 1;
            this.UnZipbutton.Text = "UnZip";
            this.UnZipbutton.UseVisualStyleBackColor = true;
            this.UnZipbutton.Click += new System.EventHandler(this.UnZipbutton_Click);
            // 
            // ZipPathText
            // 
            this.ZipPathText.Location = new System.Drawing.Point(149, 35);
            this.ZipPathText.Name = "ZipPathText";
            this.ZipPathText.Size = new System.Drawing.Size(459, 20);
            this.ZipPathText.TabIndex = 2;
            this.ZipPathText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DecompressText
            // 
            this.DecompressText.Location = new System.Drawing.Point(152, 130);
            this.DecompressText.Name = "DecompressText";
            this.DecompressText.Size = new System.Drawing.Size(459, 20);
            this.DecompressText.TabIndex = 3;
            this.DecompressText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LogText
            // 
            this.LogText.Location = new System.Drawing.Point(93, 455);
            this.LogText.Name = "LogText";
            this.LogText.Size = new System.Drawing.Size(459, 20);
            this.LogText.TabIndex = 8;
            this.LogText.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // LogButton
            // 
            this.LogButton.Location = new System.Drawing.Point(12, 455);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(75, 23);
            this.LogButton.TabIndex = 9;
            this.LogButton.Text = "LogFile";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // CompressExtText
            // 
            this.CompressExtText.Location = new System.Drawing.Point(617, 87);
            this.CompressExtText.Name = "CompressExtText";
            this.CompressExtText.Size = new System.Drawing.Size(109, 20);
            this.CompressExtText.TabIndex = 10;
            this.CompressExtText.TextChanged += new System.EventHandler(this.CompressExtText_TextChanged);
            // 
            // DecompressExtText
            // 
            this.DecompressExtText.Location = new System.Drawing.Point(617, 130);
            this.DecompressExtText.Name = "DecompressExtText";
            this.DecompressExtText.Size = new System.Drawing.Size(109, 20);
            this.DecompressExtText.TabIndex = 11;
            this.DecompressExtText.TextChanged += new System.EventHandler(this.DecompressExtText_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Extension";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Uncompressed Folder";
            // 
            // CompressText
            // 
            this.CompressText.Location = new System.Drawing.Point(149, 87);
            this.CompressText.Name = "CompressText";
            this.CompressText.Size = new System.Drawing.Size(459, 20);
            this.CompressText.TabIndex = 20;
            this.CompressText.TextChanged += new System.EventHandler(this.CompressText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Extension";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Path to Zip Folder (This is where the zip folder will be created)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Path to GZip Folder (This is where the zip folder will be created)";
            // 
            // GZipCompressText
            // 
            this.GZipCompressText.Location = new System.Drawing.Point(149, 298);
            this.GZipCompressText.Name = "GZipCompressText";
            this.GZipCompressText.Size = new System.Drawing.Size(459, 20);
            this.GZipCompressText.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Extract Folder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(614, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Extension";
            // 
            // GZipCompressExt
            // 
            this.GZipCompressExt.Location = new System.Drawing.Point(617, 298);
            this.GZipCompressExt.Name = "GZipCompressExt";
            this.GZipCompressExt.Size = new System.Drawing.Size(109, 20);
            this.GZipCompressExt.TabIndex = 29;
            // 
            // GZipDecompressText
            // 
            this.GZipDecompressText.Location = new System.Drawing.Point(152, 341);
            this.GZipDecompressText.Name = "GZipDecompressText";
            this.GZipDecompressText.Size = new System.Drawing.Size(459, 20);
            this.GZipDecompressText.TabIndex = 28;
            this.GZipDecompressText.TextChanged += new System.EventHandler(this.GZipDecompressText_TextChanged);
            // 
            // GZipPathText
            // 
            this.GZipPathText.Location = new System.Drawing.Point(149, 246);
            this.GZipPathText.Name = "GZipPathText";
            this.GZipPathText.Size = new System.Drawing.Size(459, 20);
            this.GZipPathText.TabIndex = 27;
            this.GZipPathText.TextChanged += new System.EventHandler(this.GZipPathText_TextChanged);
            // 
            // UnGZipbutton
            // 
            this.UnGZipbutton.Location = new System.Drawing.Point(68, 341);
            this.UnGZipbutton.Name = "UnGZipbutton";
            this.UnGZipbutton.Size = new System.Drawing.Size(75, 23);
            this.UnGZipbutton.TabIndex = 26;
            this.UnGZipbutton.Text = "UnGZip";
            this.UnGZipbutton.UseVisualStyleBackColor = true;
            // 
            // GZipbutton
            // 
            this.GZipbutton.Location = new System.Drawing.Point(68, 296);
            this.GZipbutton.Name = "GZipbutton";
            this.GZipbutton.Size = new System.Drawing.Size(75, 23);
            this.GZipbutton.TabIndex = 25;
            this.GZipbutton.Text = "GZip";
            this.GZipbutton.UseVisualStyleBackColor = true;
            this.GZipbutton.Click += new System.EventHandler(this.GZipbutton_Click);
            // 
            // zipnameText
            // 
            this.zipnameText.Location = new System.Drawing.Point(614, 35);
            this.zipnameText.Name = "zipnameText";
            this.zipnameText.Size = new System.Drawing.Size(109, 20);
            this.zipnameText.TabIndex = 38;
            this.zipnameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(614, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Zip file name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Uncompressed Folder";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Extract Folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 504);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.zipnameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GZipCompressText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GZipCompressExt);
            this.Controls.Add(this.GZipDecompressText);
            this.Controls.Add(this.GZipPathText);
            this.Controls.Add(this.UnGZipbutton);
            this.Controls.Add(this.GZipbutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CompressText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecompressExtText);
            this.Controls.Add(this.CompressExtText);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.LogText);
            this.Controls.Add(this.DecompressText);
            this.Controls.Add(this.ZipPathText);
            this.Controls.Add(this.UnZipbutton);
            this.Controls.Add(this.Zipbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Zipbutton;
        private System.Windows.Forms.Button UnZipbutton;
        private System.Windows.Forms.TextBox ZipPathText;
        private System.Windows.Forms.TextBox DecompressText;
        private System.Windows.Forms.TextBox LogText;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.TextBox CompressExtText;
        private System.Windows.Forms.TextBox DecompressExtText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CompressText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GZipCompressText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox GZipCompressExt;
        private System.Windows.Forms.TextBox GZipDecompressText;
        private System.Windows.Forms.TextBox GZipPathText;
        private System.Windows.Forms.Button UnGZipbutton;
        private System.Windows.Forms.Button GZipbutton;
        private System.Windows.Forms.TextBox zipnameText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
    }
}

