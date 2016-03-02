using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string type = "zip";
        string startPath = @"";
        string zipPath = @"";
        string extractPath = @"";
        string unzipext;
        string zipext;
        string logpath = "log.txt";
        string choice;
        string zipname;
        bool writetolog = false;
        DirectoryInfo currentdir;
        DirectoryInfo gcurrentdir;
        StreamWriter w;
        //DirectoryInfo currentdir = new DirectoryInfo(startPath);
        //StreamWriter w = File.AppendText(logpath);
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            extractPath = DecompressText.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // zipPath = ZipPathText.Text;
        }

        private void Zipbutton_Click(object sender, EventArgs e)
        {
            if (zipPath.EndsWith("\\"))
            zipPath = ZipPathText.Text + zipname;
            else
            zipPath = ZipPathText.Text + "\\" + zipname;


            if (string.IsNullOrEmpty(CompressExtText.Text))
            {
                if (string.IsNullOrEmpty(CompressText.Text))
                {
                    MessageBox.Show("Please Enter the path to a folder you wish to compress");

                }
                else if(string.IsNullOrEmpty(zipnameText.Text))
                {
                    MessageBox.Show("Please Enter the name of the output zip file");

                }
                else if(string.IsNullOrEmpty(zipnameText.Text))
                {
                    MessageBox.Show("Please Enter the path to a folder you wish the zip file to be created in");
                }
                else
                {
                    if (zipPath == startPath + zipname +".zip")
                    {
                        MessageBox.Show("Error, the zip cannot be placed in the same folder that you are zipping");
                    }
                    ZipFile.CreateFromDirectory(startPath, zipPath);
                    if (writetolog)
                        Log("Compressed all files in " + startPath + " to " + zipPath, w);
                }
                MessageBox.Show("Sucess Compressed all files!");
            }

            else
            {
                if (writetolog)
                {
                    Log("Attempt to compress all files in: " + zipPath + " with extension " + choice, w);
                }
                if (!File.Exists(zipPath))
                {
                    System.IO.Directory.CreateDirectory(@"C:\Temporarydir");
                    ZipFile.CreateFromDirectory(@"C:\Temporarydir", zipPath);
                    System.IO.Directory.Delete(@"C:\Temporarydir");

                }
                currentdir = new DirectoryInfo(startPath);
                using (FileStream zipToOpen = new FileStream(zipPath, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                    {
                        foreach (FileInfo fileToCompress in currentdir.GetFiles())
                        {
                            if (fileToCompress.FullName.EndsWith(CompressExtText.Text, StringComparison.OrdinalIgnoreCase))
                            {


                                archive.CreateEntryFromFile(fileToCompress.FullName, fileToCompress.Name);


                            }
                        }
                    }
                }
                MessageBox.Show("Sucess Compressed all files with extension " + CompressExtText.Text);
                if (writetolog)
                {
                    Log("Sucess", w);
                }
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            logpath = "@" + LogText.Text + "log.txt";
            w = File.AppendText(logpath);
            Log("Log file changed to " + logpath, w);
            choice = Console.ReadLine();
            writetolog = true;
        }

        private void ZipAddbutton_Click(object sender, EventArgs e)
        {
           
        }

        private void CompressText_TextChanged(object sender, EventArgs e)
        {
            startPath = CompressText.Text;
        }

        private void CompressExtText_TextChanged(object sender, EventArgs e)
        {
            zipext = CompressExtText.Text;
        }

        private void DecompressExtText_TextChanged(object sender, EventArgs e)
        {
            unzipext = DecompressExtText.Text;
        }

        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
        }

        private void UnZipbutton_Click(object sender, EventArgs e)
        {
            if (zipPath.EndsWith("\\"))
                zipPath = ZipPathText.Text + zipname;
            else
                zipPath = ZipPathText.Text + "\\" + zipname;


            if (string.IsNullOrEmpty(DecompressText.Text))
            {
                MessageBox.Show("Please Enter a path to extract the zip!");
            }

            else 
            {
                if (string.IsNullOrEmpty(DecompressExtText.Text))
                {
                    using (ZipArchive archive = ZipFile.OpenRead(zipPath))
                    {
                        foreach (ZipArchiveEntry file in archive.Entries)
                        {
                            string completeFileName = Path.Combine(DecompressText.Text, file.FullName);
                            if (file.Name == "")
                            {// Assuming Empty for Directory
                                Directory.CreateDirectory(Path.GetDirectoryName(completeFileName));
                                continue;
                            }
                            file.ExtractToFile(completeFileName, true);
                        }
                 }
                
                    if (writetolog)
                        Log("Extracted all files from " + zipPath + " to " + extractPath, w);
                    MessageBox.Show("Success!");
                }
                else
                {
                    if (writetolog)
                    {
                        Log("Attempt to extract all files in: " + zipPath + " with extension " + choice, w);
                    }

                    if (!File.Exists(zipPath))
                    {
                        if (writetolog)
                        {
                            Log("Error: Zip file does not exist at: " + zipPath, w);
                            MessageBox.Show("There is no such zip file!");
                        }

                    }
                    else
                        using (ZipArchive archive = ZipFile.OpenRead(zipPath))
                        {
                            System.IO.Directory.CreateDirectory(extractPath);
                            foreach (ZipArchiveEntry entry in archive.Entries)
                            {
                                if (entry.FullName.EndsWith(DecompressExtText.Text, StringComparison.OrdinalIgnoreCase))
                                {
                                    if(!File.Exists(Path.Combine(extractPath, entry.Name)))
                                    entry.ExtractToFile(Path.Combine(extractPath, entry.Name));
                                }
                            }
                            if (writetolog)
                            {
                                Log("Success", w);
                            }
                            MessageBox.Show("Success!");
                        }
                }
            }

             
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            zipname = zipnameText.Text +".zip";
        }

        private void GZipPathText_TextChanged(object sender, EventArgs e)
        {

        }

        private void GZipbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GZipCompressText.Text))
            {
                MessageBox.Show("Cant start without a path to the folder you wish to compress!");
            }
            if (string.IsNullOrEmpty(GZipPathText.Text))
            {
                MessageBox.Show("Please Enter the path of the output zip file");
            }
           
            else
            {
                gcurrentdir = new DirectoryInfo(GZipCompressText.Text);

                foreach (FileInfo fileToCompress in gcurrentdir.GetFiles())
                {
                     using (FileStream originalFileStream = fileToCompress.OpenRead())
                     {
                         if ((File.GetAttributes(fileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden && fileToCompress.Extension != GZipCompressExt.Text)
                         {
                              using (FileStream CompressedFileStream = File.Create(fileToCompress.FullName + ".gz"))
                              {
                                  using (GZipStream compressionStream = new GZipStream(CompressedFileStream, CompressionMode.Compress))
                                  {
                                      originalFileStream.CopyTo(compressionStream);
                                  }
                              }
                         }

                     }
                }
            }
               
        }

        private void GZipDecompressText_TextChanged(object sender, EventArgs e)
        {
            gcurrentdir = new DirectoryInfo(GZipDecompressText.Text);
            foreach (FileInfo fileToDecompress in gcurrentdir.GetFiles("*.gz"))
            {
                using (FileStream originalFileStream = fileToDecompress.OpenRead())
                {
                    string currentFileName = fileToDecompress.FullName;
                    string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                    using (FileStream decompressedFileStream = File.Create(newFileName))
                    {
                        using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                        {
                            decompressionStream.CopyTo(decompressedFileStream);
                            Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
                        }
                    }
                }
               
            }
           
            
        }

    }
   
}

