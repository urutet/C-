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
            queue1.QueuePrint();
        }
    }
}
