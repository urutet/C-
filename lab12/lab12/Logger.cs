using System;
using System.Collections.Generic;
using System.IO;
namespace lab12
{
    public class Logger
    {
        List<string> log;
        public string this[int i]
        {
            get => log[i];
        }

        public Logger()
        {
            log = new List<string>();
        }

        public void AddException(Exception e)
        {
            log.Add($@"-------------------
{DateTime.Now.ToString("MM/dd/yyyy HH:mm")}
|INFO:

|Type: {e.GetType()}

|Source: {e.Source}

|TargetSite: {e.TargetSite}

|Message: {e.Message}

|Data: {e.Data}
-------------------

");
        }

        public void LogToFile(string filePath)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                foreach(string str in log)
                {
                    writer.WriteLine(str);
                }
                writer.Close();
            }
        }

        public void LogToConsole()
        {
            foreach (string str in log)
            {
                Console.WriteLine(str);
            }
        }
    }
}
