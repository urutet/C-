using System;

namespace lab3
{
    partial class Stack
    {
        public void Ping()
        {
            Console.WriteLine("Pinging");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack[] stackArr = new Stack[5];
            Random randNum = new Random();
            float maxTopValue = float.MinValue;
            float minTopValue = float.MaxValue;
            int maxValueArrayNumber = 0;
            int minValueArrayNumber = 0;

            //anonimous type
            var anonimous = new { Name = "Elijah" };

            for (int s = 0; s < 5; s++)
            {
                stackArr[s] = new Stack();
            }

            for (int i = 0; i < stackArr.Length; i++)
            {
                for (int j = 0; j < stackArr[i].ArrayLength(); j++)
                {
                    stackArr[i].Push((float)randNum.NextDouble() * randNum.Next(int.MinValue, int.MaxValue));
                }
            }

            for (int i = 0; i < stackArr.Length; i++)
            {
                if(stackArr[i].HasNegativeItems())
                {
                    Console.WriteLine($"Stack {i + 1} has negative numbers in it.");
                }

                if (stackArr[i][stackArr.Length] >= maxTopValue)
                {
                    maxTopValue = stackArr[i][0];
                    maxValueArrayNumber = i;
                }

                if (stackArr[i][stackArr.Length] <= minTopValue)
                {
                    minTopValue = stackArr[i][0];
                    minValueArrayNumber = i;
                }
            }

            Console.WriteLine($"Stack {maxValueArrayNumber + 1} has the maximum top number among all stacks equal to {maxTopValue}.");
            Console.WriteLine($"Stack {minValueArrayNumber + 1} has the minimum top number among all equal to {minTopValue}.");

            Console.WriteLine($"Type: {anonimous.GetType()}");
            Console.WriteLine(anonimous.Name);
        }
    }
}
