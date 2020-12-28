using System;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Disk info: ");
            YINDiskInfo.ShowDiskInfo();
            Console.WriteLine("File info: ");
            YINDiskInfo.ShowFileInfo("/Volumes/BOOTCAMP/BELSTU/2 Курс/Компьютерные сети/Лабораторные работы/1 семестр/Лабораторная работа 1/Звездно-кольцевая.net");
            Console.WriteLine("Directory info: ");
            YINDiskInfo.ShowDirInfo("/Volumes/BOOTCAMP/BELSTU/2 Курс/Компьютерные сети/Лабораторные работы/1 семестр/Лабораторная работа 1/");
            YINFileManager.FileManagerActions("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab13/");
            YINLog.FindByDay("12");
            YINLog.FindInRange(DateTime.Now.AddMinutes(-5), DateTime.Now);
            YINLog.FindByKeyword("Disk");
            YINLog.deleteInfo();
        }
    }
}
