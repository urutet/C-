using System;
using System.Diagnostics;
using System.Threading;
using System.IO;
namespace lab15
{
    class Program
    {
        static string objlocker = "null";
        static Mutex mutex = new Mutex(false);

        public static void Time(object state)
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }

        public static bool isSimple(int N)
        {
            for (int i = 2; i <= (int)(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }

        public static void allSimpleToN()
        {
            Console.WriteLine("Enter N");
            int N = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < N; i++)
            {
                if(Program.isSimple(i) == true)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    continue;
                }
            }
        }
        public static void Even(int n)
        {
            lock (objlocker)
            {
                for (int i = 2; i < n; i += 2)
                {
                    Console.Write(i + " ");
                    using (StreamWriter sw = new StreamWriter("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab15/num.txt"))
                    {
                        sw.Write(i + " ");
                    }
                }
            }
        }

        public static void Uneven(int n)
        {
            lock (objlocker)
            {
                for (int i = 1; i < n; i += 2)
                {
                    Console.Write(i + " ");
                    using (StreamWriter sw = new StreamWriter("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab15/num.txt"))
                    {
                        sw.Write(i + " ");
                    }
                }
            }
        }

        public static void Even(int n, bool sync)
        {
            for (int i = 2; i < n; i+=2)
                {
                mutex.WaitOne();
                        Console.Write(i + " ");
                        using(StreamWriter sw = new StreamWriter("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab15/num.txt"))
                        {
                            sw.Write(i + " ");
                        }
                mutex.ReleaseMutex();
                }
        }

        public static void Uneven(int n, bool sync)
        {
            for (int i = 1; i < n; i+=2)
                {
                mutex.WaitOne();
                        Console.Write(i + " ");
                        using (StreamWriter sw = new StreamWriter("/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab15/num.txt"))
                        {
                            sw.Write(i + " ");
                        }
                mutex.ReleaseMutex();
                }
        }

        static void Main(string[] args)
        {
            Process[] allProcesses = Process.GetProcesses();
            foreach(var p in allProcesses)
            {
                try
                {
                    Console.WriteLine(@$"˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜
PID: {p.Id}
Process Name: {p.ProcessName}
Start time: {p.StartTime}
Priority: {p.PriorityClass}
˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜");
                }
                catch
                {
                    continue;
                }
            }

            /*AppDomain appDomain = AppDomain.CurrentDomain;
            Console.WriteLine(@$"˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜
Name: {appDomain.FriendlyName}
All assemblies: {appDomain.GetAssemblies()}
˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜");
            AppDomain newDomain = AppDomain.CreateDomain("MyDomain");           //App Domains are not supported
            newDomain.Load("Assembly name");
            Console.WriteLine(newDomain.FriendlyName);
            AppDomain.Unload(newDomain);*/

            Thread thread1 = new Thread(allSimpleToN);
            thread1.Start();
            thread1.Join();
            Console.WriteLine();

            Console.WriteLine("Enter n");
            int n = Convert.ToInt32(Console.ReadLine());
            Thread thread2 = new Thread(() => Even(n));
            Thread thread3 = new Thread(() => Uneven(n));
            thread2.Priority = ThreadPriority.Highest;
            thread2.Start();
            thread3.Start();
            thread2.Join();
            thread3.Join();

            Console.WriteLine();
            Thread thread4 = new Thread(() => Even(n, false));
            Thread thread5 = new Thread(() => Uneven(n, true));
            thread5.Start();
            thread4.Start();
            thread5.Join();
            thread4.Join();
            Console.WriteLine();

            Timer timer = new Timer(new TimerCallback(Time), null, 0, 1000);
            Thread.Sleep(5000);
        }
    }
}
