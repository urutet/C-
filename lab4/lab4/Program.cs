using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue1 = new Queue();
            Queue queue2 = new Queue();
            queue1 += 1024;
            queue1 += 64;
            queue1 += 128;
            queue2 += 512;
            queue2 += 256;
            queue2 += 128;
            queue1--;
            queue1 = queue1 < queue2;

            Console.WriteLine("Queue: ");
            queue1.QueuePrint();
            Console.WriteLine("Sum: " + StatisticOperation.Sum(queue1));
            Console.WriteLine("MinMaxDiff: " + StatisticOperation.MinMaxDiff(queue1));
            Console.WriteLine("LastItem: " + StatisticOperation.LastItem(queue1));

            Queue.Owner owner1 = new Queue.Owner("qwerty", "qwerty");
            Console.WriteLine($"Owner ID: {owner1.ID}, Organization name: {owner1.OrganizationName}");

            Queue.Date date = new Queue.Date();
            date.dateOfCreation();
        }
    }
}
