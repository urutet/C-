using System;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab8/lab8.txt";
            Queue<int> intQueue = new Queue<int>();
            intQueue.Add(14);
            intQueue.Add(4124);
            intQueue.Add(12);
            intQueue.Add(24);
            intQueue.Add(256);
            intQueue.Add(128);
            intQueue.Remove();
            Console.WriteLine("intQueue: ");
            intQueue.QueuePrint();
            Console.WriteLine("\n----------------------\n");
            intQueue.ToFile(filePath);

            Queue<double> doubleQueue = new Queue<double>();
            doubleQueue.Add(2.33);
            doubleQueue.Add(55.1);
            doubleQueue.Add(46.12);
            doubleQueue.Add(4.21);
            doubleQueue.Add(3.14);
            Console.WriteLine("doubleQueue: ");
            doubleQueue.QueuePrint();
            Console.WriteLine("\n----------------------\n");
            doubleQueue.ToFile(filePath);

            Queue<bool> boolQueue = new Queue<bool>();
            boolQueue.Add(true);
            boolQueue.Add(false);
            boolQueue.Add(true);
            boolQueue.Add(false);
            boolQueue.Add(true);
            Console.WriteLine("boolQueue: ");
            boolQueue.QueuePrint();
            Console.WriteLine("\n----------------------\n");
            doubleQueue.ToFile(filePath);

            Queue<UserStruct> userStructQueue = new Queue<UserStruct>();
            UserStruct userStruct1 = new UserStruct(12, 32.12, true);
            UserStruct userStruct2 = new UserStruct(32, 4.12, true);
            UserStruct userStruct3 = new UserStruct(412, 33.12, false);
            UserStruct userStruct4 = new UserStruct(524, 332.1, true);
            UserStruct userStruct5 = new UserStruct(24, 3.14, false);
            userStructQueue.Add(userStruct1);
            userStructQueue.Add(userStruct2);
            userStructQueue.Add(userStruct3);
            userStructQueue.Add(userStruct4);
            userStructQueue.Add(userStruct5);
            Console.WriteLine("userStructQueue: ");
            userStructQueue.QueuePrint();
            Console.WriteLine("\n----------------------\n");
            userStructQueue.ToFile(filePath);

        }
    }
}
