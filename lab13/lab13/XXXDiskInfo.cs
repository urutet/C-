using System;
using System.IO;
using System.Reflection;
namespace lab13
{
    public static class YINDiskInfo
    {

        public static void ShowDiskInfo()
        {
            YINLog.Add(Convert.ToString(MethodBase.GetCurrentMethod()));
            foreach (var d in DriveInfo.GetDrives())
            {
                Console.WriteLine($@"
˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜
Volume label: {d.VolumeLabel}
Drive name: {d.Name}
Drive file system: {d.DriveFormat}
Total space: {d.TotalSize}
Free space: {d.TotalFreeSpace}
˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜
");
            }
        }

        public static void ShowFileInfo(string path)
        {
            YINLog.Add(Convert.ToString(MethodBase.GetCurrentMethod()));
            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine($@"
˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜
Full path: {fileInfo.DirectoryName}
File name: {fileInfo.Name}
File size: {fileInfo.Length}
File extension: {fileInfo.Extension}
Creation date: {fileInfo.CreationTime}
Last changes date: {fileInfo.LastWriteTime}
˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜");
        }

        public static void ShowDirInfo(string path)
        {
            YINLog.Add(Convert.ToString(MethodBase.GetCurrentMethod()));
            var dirInfo = new DirectoryInfo(path);
            Console.WriteLine($@"
˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜
Number of files: {dirInfo.GetFiles().Length}
Creation date: {dirInfo.CreationTime}
Number of subdirectories: {dirInfo.GetDirectories().Length}
Parent directory: {dirInfo.Parent}
˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜
");
        }
    }
}
