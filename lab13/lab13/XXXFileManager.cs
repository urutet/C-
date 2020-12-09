using System;
using System.IO;
using System.IO.Compression;
namespace lab13
{
    public static class YINFileManager
    {
        public static void FileManagerActions(string disk)
        {
            if (Directory.Exists(disk))
            {
                var diskInf = new DirectoryInfo(disk);
                Console.WriteLine($"Directories in disk {disk}");
                foreach (var dir in diskInf.GetDirectories())
                {
                    Console.WriteLine(dir);
                }
                Console.WriteLine();
                
                Console.WriteLine($"Files in disk {disk}");
                foreach (var files in diskInf.GetFiles())
                {
                    Console.WriteLine(files);
                }
                Console.WriteLine();

                if (!Directory.Exists(@$"{disk}YINInspect") && !File.Exists(@$"{disk}YINInspect/YINdirinfo.txt"))
                {
                    Directory.CreateDirectory(@$"{disk}YINInspect");
                    //File.Create($@"{disk}YINInspect/YINdirinfo.txt");
                    using (StreamWriter sw = new StreamWriter(@$"{disk}YINInspect/YINdirinfo.txt"))
                    {
                        foreach (var dir in diskInf.GetDirectories())
                        {
                            sw.WriteLine(dir);
                        }
                        foreach (var files in diskInf.GetFiles())
                        {
                            sw.WriteLine(files);
                        }
                        sw.Close();
                    }

                    File.Copy(@$"{disk}YINInspect/YINdirinfo.txt", @$"{disk}YINInspect/YINdirinfoCopy.txt");
                    File.Delete(@$"{disk}YINInspect/YINdirinfo.txt");

                    //xxxfilemanager B
                    Directory.CreateDirectory(@$"{disk}YINfiles");
                    var dirInfo = new DirectoryInfo($@"{disk}txts");
                    var yinDirInfo = new DirectoryInfo(@$"{disk}/YINfiles");
                    
                    foreach(var txt in dirInfo.GetFiles("*.txt", SearchOption.AllDirectories))
                    {
                        File.Copy(txt.FullName, @$"{disk}YINfiles/{txt.Name}");
                    }

                    //xxxfilemanager C
                    yinDirInfo.MoveTo(@$"{disk}YINInspect/YINfiles");
                    ZipFile.CreateFromDirectory(@$"{disk}YINInspect/YINfiles", @$"{disk}YINInspect/YINfiles.zip");
                    ZipFile.ExtractToDirectory(@$"{disk}YINInspect/YINfiles.zip", @$"{disk}YINInspect/ExtractedFiles");

                }
                else
                {
                    Directory.Delete(@$"{disk}YINInspect", true);
                    Directory.CreateDirectory($@"{disk}YINInspect");
                    using (StreamWriter sw = new StreamWriter(@$"{disk}YINInspect/YINdirinfo.txt"))
                    {
                        foreach (var dir in diskInf.GetDirectories())
                        {
                            sw.WriteLine(dir);
                        }
                        foreach (var files in diskInf.GetFiles())
                        {
                            sw.WriteLine(files);
                        }
                        sw.Close();  
                    }
                    File.Copy(@$"{disk}YINInspect/YINdirinfo.txt", @$"{disk}YINInspect/YINdirinfoCopy.txt");
                    File.Delete(@$"{disk}YINInspect/YINdirinfo.txt");

                    //xxxfilemanager B    
                    Directory.CreateDirectory(@$"{disk}YINfiles");
                    var dirInfo = new DirectoryInfo($@"{disk}txts");
                    var yinDirInfo = new DirectoryInfo(@$"{disk}/YINfiles");

                    foreach (var txt in dirInfo.GetFiles("*.txt", SearchOption.AllDirectories))
                    {
                        File.Copy(txt.FullName, @$"{disk}YINfiles/{txt.Name}");
                    }

                    yinDirInfo.MoveTo(@$"{disk}YINInspect/YINfiles");
                    ZipFile.CreateFromDirectory(@$"{disk}YINInspect/YINfiles", @$"{disk}YINInspect/YINfiles.zip");
                    ZipFile.ExtractToDirectory(@$"{disk}YINInspect/YINfiles.zip", @$"{disk}YINInspect/ExtractedFiles");
                }
            }
        }
    }
}
