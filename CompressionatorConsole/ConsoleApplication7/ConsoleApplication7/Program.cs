using System;
using System.IO;
using System.IO.Compression;

namespace ConsoleApplication
{
    class Program
    {
     
        static void Main(string[] args)
        {
            //initializes target paths
            string type = "zip";
            string startPath = @"C:\Users\Raf\Documents\Visual Studio 2013\Projects\ConsoleApplication7\ConsoleApplication7\temp";
            string zipPath = @"C:\Users\Raf\Documents\Visual Studio 2013\Projects\ConsoleApplication7\ConsoleApplication7\Result.zip";
            string extractPath = @"C:\Users\Raf\Documents\Visual Studio 2013\Projects\ConsoleApplication7\ConsoleApplication7\temp\Result";
            string logpath = "log.txt";
            string choice;
            bool writetolog=false;
            DirectoryInfo currentdir = new DirectoryInfo(startPath);
            StreamWriter w = File.AppendText(logpath);
            //simple folder zip compression

            //simple zip extraction

            do
            {
                Console.WriteLine("Type a command (zip cmpr, zip extr, zip scmpr, zip sextr,");
                Console.WriteLine("zip exit, zip cmprpath, zip extrpath, zip path, zip help, zip type, zip add, zip log):");
                choice = Console.ReadLine();
                Console.WriteLine("\n");
                switch (choice)
                {
                    case "zip type":
                        Console.WriteLine("Enter a type (currently the only options are zip or gzip):");
                        choice =  Console.ReadLine();
                        if (choice == "zip" || choice == "gzip")
                        {
                            type = choice;
                            if (writetolog)
                            {
                                Log("Type changed to " + type, w);
                            }
                            else
                            {
                                Console.WriteLine("Type changed to " + type);
                                Log("Type changed to " + type, w);
                            }
                                
                        }
                        else Console.WriteLine("Invalid option");
                        break;
                    case "zip log":
                        Console.WriteLine("Enter a path for a new log file:");
                        logpath= "@" + Console.ReadLine()+"log.txt";
                        w = File.AppendText(logpath);
                        Log("Log file changed to " + logpath, w);
                        Console.WriteLine("Log file changed to " + logpath);
                        Console.WriteLine("Do you want to write only to log? (y/n)");
                        choice = Console.ReadLine();
                        if (choice=="y")
                        writetolog = true;
                        break;
                    case "zip help":
                        Console.WriteLine("Type one of these commands:");
                        Console.WriteLine("compress = compresses folder at directory startPath");
                        Console.WriteLine("extract  = extracts everyting from zip file at zipPath to extractPath");
                        Console.WriteLine("specific compress = same as compress but you specify an extension for the target files");
                        Console.WriteLine("specific extract = same as extract but you specify an extension for the target files");
                        Console.WriteLine("start path = changes the current selected directory for compression");
                        Console.WriteLine("extract path = changes the target directory for extraction");
                        Console.WriteLine("zip path = changes the target zip file path (to create or select existing)");
                        Console.WriteLine("zip type = changes the algorythm for compression (default zip)");
                        Console.WriteLine("zip add = compress a single file to the zip folder by specifying its path");
                        Console.WriteLine("exit = exits program");
                        break;
                    case "zip cmpr":
                        ZipFile.CreateFromDirectory(startPath, zipPath);

                        if (writetolog)
                            Log("Compressed all files in " + startPath + " to " + zipPath, w);
                        else
                        {
                            Console.WriteLine("Compressed all files in " + startPath + " to " + zipPath);
                            Log("Compressed all files in " + startPath + " to " + zipPath, w);
                        }
                        break;

                    case "zip extr":
                        ZipFile.ExtractToDirectory(zipPath, extractPath);
                        if (writetolog)
                            Log("Extracted all files from " + zipPath + " to " + extractPath, w);
                        else
                        {
                            Console.WriteLine("Extracted all files from " + zipPath + " to " + extractPath);
                            Log("Extracted all files from " + zipPath + " to " + extractPath, w);
                        }
                        break;

                    case "zip scmpr":
                        Console.WriteLine("Specify a valid extension (example: .txt):");
                        choice = Console.ReadLine();
                        if (writetolog)
                        {
                            Log("Attempt to compress all files in: " + zipPath + " with extension " + choice, w);
                        }
                        else
                        {
                            Console.WriteLine("Attempt to compress all files in: " + zipPath + " with extension " + choice);
                            Log("Attempt to compress all files in: " + zipPath + " with extension " + choice, w);
                        }
                      

                        if (!File.Exists(zipPath))
                        {
                            System.IO.Directory.CreateDirectory(@"C:\Temporarydir");
                            ZipFile.CreateFromDirectory(@"C:\Temporarydir", zipPath);
                            System.IO.Directory.Delete(@"C:\Temporarydir");
                           
                        }
                  
                        using (FileStream zipToOpen = new FileStream(zipPath, FileMode.Open))
                        {
                            using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                            {
                                foreach (FileInfo fileToCompress in currentdir.GetFiles())
                                {
                                    if (fileToCompress.FullName.EndsWith(choice, StringComparison.OrdinalIgnoreCase))
                                    {


                                        archive.CreateEntryFromFile(fileToCompress.FullName, fileToCompress.Name);


                                    }
                                }
                            }
                            if (writetolog)
                            {
                                Log("Sucess", w);
                            }
                            else
                            {
                                Console.WriteLine("Sucess");
                                Log("Sucess", w);
                            }
                        }
                        break;

                    case "zip sextr":
                        //extracts specific files by extension
                        Console.WriteLine("Specify a valid extension (example: .txt):");
                        choice = Console.ReadLine();
                        if (writetolog)
                        {
                            Log("Attempt to extract all files in: " + zipPath + " with extension " + choice, w);
                        }
                        else
                        {
                            Console.WriteLine("Attempt to compress all files in: " + zipPath + " with extension " + choice);
                            Log("Attempt to extract all files in: " + zipPath + " with extension " + choice, w);
                        }
                        if (!File.Exists(zipPath))
                        {
                            if (writetolog)
                            {
                                Log("Error: Zip file does not exist at: " + zipPath, w);
                            }
                            else
                            {
                                Log("Error: Zip file does not exist at: " + zipPath, w);
                                Console.WriteLine("Error:Zip file does not exist: " + zipPath);
                            }
                        }
                       else
                        using (ZipArchive archive = ZipFile.OpenRead(zipPath))
                        {
                            foreach (ZipArchiveEntry entry in archive.Entries)
                            {
                                if (entry.FullName.EndsWith(choice, StringComparison.OrdinalIgnoreCase))
                                {
                                    entry.ExtractToFile(Path.Combine(extractPath, entry.FullName));
                                }
                            }
                            if (writetolog)
                            {
                                Log("Sucess", w);
                            }
                            else
                            {
                                Console.WriteLine("Sucess");
                                Log("Sucess", w);
                            }
                        }
                        break;

                    case "zip exit":
                        break;

                    case "zip cmprpath":
                        startPath = "@" + Console.ReadLine();
                        currentdir = new DirectoryInfo(startPath);
                        break;       
        
                    case "zip path":
                        zipPath = "@" + Console.ReadLine();
                        break;

                    case "zip extrpath":
                        extractPath = "@" + Console.ReadLine();
                        break;

                    case "zip add":
                        Console.Write("Enter the path of the file you wish to add to the zip folder");
                        choice = Console.ReadLine();
                        if (writetolog)
                        {
                            Log("Attempt to add: " + choice + " to " + zipPath, w);
                        }
                        else
                        {
                            Console.WriteLine("Attempt to add: " + choice + " to " + zipPath);
                            Log("Attempt to add: " + choice + " to " + zipPath, w);
                        }
                        using (FileStream zipToOpen = new FileStream(zipPath, FileMode.Open))
                        {

                            using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                            {
                               
                               archive.CreateEntryFromFile(choice, choice); ;
                              
                            }
                            if (writetolog)
                            {
                                Log("Sucess", w);
                            }
                            else
                            {
                                Console.WriteLine("Sucess");
                                Log("Sucess", w);
                            }
                        }
                        break;
                    case "zip delete":
                        Console.WriteLine("Enter file to Delete");
                        choice = Console.ReadLine();
                        if (writetolog)
                        {
                            Log("Attempt to delete: " + choice + " from " + zipPath, w);
                        }
                        else
                        {
                            Console.WriteLine("Attempt to delete: " + choice + " from " + zipPath);
                            Log("Attempt to delete: " + choice + " from " + zipPath, w);
                        }
                        using (FileStream zipToOpen = new FileStream(zipPath, FileMode.Open))
                        {
                            using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                            {
                                ZipArchiveEntry readmeEntry = archive.GetEntry(choice); 
                                if (readmeEntry != null)
                                {
                                    readmeEntry.Delete();
                                }
                                else
                                {
                                    if (writetolog)
                                    {
                                        Log("Error: No such entry in " + zipPath, w);
                                    }
                                    else
                                    {
                                        Log("Error: No such entry in " + zipPath, w);
                                        Console.WriteLine("Error: No such entry in " + zipPath);
                                    }
                                }

                            }

                            if (writetolog)
                            {
                                Log("Sucess", w);
                            }
                            else
                            {
                                Console.WriteLine("Sucess");
                                Log("Sucess", w);
                            }
                        }

                        break;

                    default:
                        Console.WriteLine("Invalid Option \n");
                        break;
                }

            } while (choice != "exit");

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
    }
}