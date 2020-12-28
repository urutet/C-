using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace lab13
{
    public static class YINLog
    {
        public static string path = "/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab13/YINlog.txt";
        public static int count;
        public static void Add(string method)
        {
            File.AppendAllText(path, $"{System.DateTime.Now.ToString("dd.MM.yyyy HH.mm")} YINLog.txt: {method} \n");
            count++;
        }

        public static List<string> FindByDay(string day)
        {
            List<string> allLogs = new List<string>();
            List<string> logsByDay = new List<string>();

            allLogs = File.ReadAllText(path).Split('\n').ToList();
            if (allLogs.Count == 0)
            {
                Console.WriteLine("File was empty!");
            }

            foreach (var s in allLogs)
            {
                if(s.Length < 16)
                {
                    continue;
                }
                if (s.Substring(0, 2) == day)
                {
                    logsByDay.Add(s);
                }
            }

            Console.WriteLine($"Logs day {day}: ");
            foreach (var s in logsByDay)
            {
                Console.WriteLine(s);
            }
            return logsByDay;
        }

        public static List<string> FindInRange(DateTime start, DateTime finish)
        {
            List<string> allLogs = new List<string>();
            List<string> filteredLogs = new List<string>();
            allLogs = File.ReadAllText(path).Split('\n').ToList();
            if (allLogs.Count == 0)
            {
                Console.WriteLine("File was empty!");
            }

            foreach (var s in allLogs)
            {
                if(s.Length < 16)
                {
                    continue;
                }
                if (s.Substring(0, 16).CompareTo(start.ToString("dd.MM.yyyy HH.mm")) >= 0 && s.Substring(0, 16).CompareTo(finish.ToString("dd.MM.yyyy HH.mm")) <= 0)
                {
                    filteredLogs.Add(s);
                }
            }

            Console.WriteLine($"Logs in range {start.ToString("dd.MM.yyyy HH.mm")} - {finish.ToString("dd.MM.yyyy HH.mm")}: ");
            foreach (var s in filteredLogs)
            {
                Console.WriteLine(s);
            }
            return filteredLogs;
        }

        public static List<string> FindByKeyword(string keyword)
        {
            List<string> allLogs = new List<string>();
            List<string> filteredLogs = new List<string>();
            allLogs = File.ReadAllText(path).Split('\n').ToList();
            if (allLogs.Count == 0)
            {
                Console.WriteLine("File was empty!");
            }

            foreach (var s in allLogs)
            {
                if (s.Contains(keyword))
                {
                    filteredLogs.Add(s);
                }
            }
            Console.WriteLine($"Logs with {keyword}: ");
            foreach (var s in filteredLogs)
            {
                Console.WriteLine(s);
            }
            return filteredLogs;
        }

        public static void deleteInfo()
        {
            List<string> logs = YINLog.FindInRange(System.DateTime.Now.AddHours(-1), System.DateTime.Now);
            File.Delete(path);
            File.AppendAllLines(path, logs);
        }
    } 
}
