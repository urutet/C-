using System;
using System.IO;
namespace lab13
{
    public class YINDirInfo
    {
        public static void ShowDirInfo(string path)
        {
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
