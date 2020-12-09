using System;
using System.IO;
namespace lab13
{
    public static class YINDiskInfo
    {

        public static void ShowDiskInfo()
        {
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
    }
}
