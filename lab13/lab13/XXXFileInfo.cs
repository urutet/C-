using System;
using System.IO;
namespace lab13
{
    public static class YINFileInfo
    {
        public static void ShowFileInfo(string path)
        {
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
    }
}
