using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
namespace lab16
{
    class Program
    {
        static public void Producer(int id, BlockingCollection<int> warehouse)
        {
            var rand = new Random();
            var sleepTime = rand.Next(0, 3000);
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(sleepTime);
                warehouse.Add(i + 10 * id);
                Console.WriteLine($"Producer {id} produced goods {i + 10 * id}");
            }

        }

        static public void Consumer(int id, BlockingCollection<int> warehouse)
        {
            var rand = new Random();
            var sleepTime = rand.Next(0, 7000);
            Thread.Sleep(sleepTime);
            if (warehouse.Count == 0)
            {
                Console.WriteLine($"Consumer {id} has left unhappy");
                return;
            }
            foreach (var item in warehouse)
            {
                int _item = item;
                if (warehouse.TryTake(out _item))
                {
                    Console.WriteLine($"Consumer {id} bought goods {item}");
                }
            }
        }

        static public async Task<double> AsyncSinh(double num)
        {
            Task<double> sin = new Task<double>(() => Math.Sin(num));
            sin.Start();
            var sinResult = await sin;
            double sinh = Math.Sinh(sinResult);
            return sinh;

        }
            static List<uint> SieveEratosthenes(uint n)
        {
            var numbers = new List<uint>();
            for (var i = 2u; i < n; i++)
            {
                numbers.Add(i);
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 2u; j < n; j++)
                {
                    numbers.Remove(numbers[i] * j);
                }
            }

            return numbers;
        }

        static void Print(string str)
        {
            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {
            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            Task task1 = new Task(() => SieveEratosthenes(2000));
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            task1.Start();
            Console.WriteLine($"TaskID {task1.Id} {task1.Status}");
            Task.WaitAll(task1);
            stopwatch.Stop();
            if (task1.IsCompleted)
            {
                Console.WriteLine($"TaskID {task1.Id} {task1.Status}");
                Console.WriteLine($"TaskID {task1.Id} finished in {stopwatch.ElapsedMilliseconds} ms");
            }
            stopwatch.Restart();
            SieveEratosthenes(2000);
            stopwatch.Stop();
            Console.WriteLine($"Finished in {stopwatch.ElapsedMilliseconds} ms");

            Task task2 = new Task(() => SieveEratosthenes(20000), cancellationToken.Token);
            task2.Start();
            Console.WriteLine($"TaskID {task2.Id} {task2.Status}");
            cancellationToken.Cancel();
            Console.WriteLine($"TaskID {task2.Id} {task2.Status}");

            Task task3 = Task.Run(() => Print("What the ...?"));
            Task task4 = task3.ContinueWith(t => Print("Are we playing"));
            Task task5 = task4.ContinueWith(t => Print("Periodic reverbations of our gaseous medium!"));
            Task task6 = task5.ContinueWith(t => Print("Yes, I like sequences and repetitions"));

            Task<double> task7 = new Task<double>(() => Math.Cos(1.2));
            task7.Start();
            var awaiter = task7.GetAwaiter();
            awaiter.OnCompleted(() => { double res = awaiter.GetResult();  Console.WriteLine(res); });

            List<List<int>> list = new List<List<int>>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(new List<int>());
            }
            Random random = new Random();
            stopwatch.Restart();
            Parallel.For(1, 1000000, (z) =>
            {
                  for(int i = 0; i < 10; i++)
                {
                    list[i].Add(random.Next());
                }
            });
            stopwatch.Stop();
            
            Console.WriteLine($"Time elapsed (parallel) {stopwatch.ElapsedMilliseconds} ms");
            list.Clear();
            for (int j = 0; j < 10; j++)
            {
                list.Add(new List<int>());
            }
            int r = 1;
            stopwatch.Restart();
            for(int i = 0; i < 1000000; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    list[j].Add(random.Next());
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed {stopwatch.ElapsedMilliseconds} ms");

            Parallel.Invoke(
                () =>
                {
                    Console.WriteLine($"Tread={Thread.CurrentThread.ManagedThreadId}");
                },
                () =>
                {
                    Console.WriteLine($"Thread={Thread.CurrentThread.ManagedThreadId}");
                },
                () =>
                {
                    Console.WriteLine($"Thread={Thread.CurrentThread.ManagedThreadId}");
                });

            var warehouse = new BlockingCollection<int>();

            for (int i = 0; i < 5; i++)
            {
                new Thread(() => Producer(i, warehouse)).Start();
                Thread.Sleep(10);
            }
            for (int i = 0; i < 10; i++)
            {
                new Thread(() => Consumer(i, warehouse)).Start();
                Thread.Sleep(10);
            }

            Console.WriteLine($"Sinh(1)={AsyncSinh(1).Result}");
        }
    }
}
