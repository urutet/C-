using System;

namespace lab3
{
    public class Stack
    {
        int numberOfItems;
        readonly int defaultNum = 20;
        public float[] arr;

        public Stack()
        {
            arr = new float[defaultNum];
        }

        public Stack(int numOfElements)
        {
            arr = new float[numOfElements];
        }

        public int ArrayLength()
        {
            return arr.Length;
        }

        public bool IsStackEmpty
        {
            get
            {
                return numberOfItems == 0;
            }
        }

        public void Push(float numberToAdd)
        {
            if(arr.Length == numberOfItems)
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                arr[numberOfItems++] = numberToAdd;
            }
        }

        public float Pop()
        {
            if(IsStackEmpty)
            {
                throw new System.InvalidOperationException("Unable to pop. Stack is empty.");
            }
            else
            {
                float fl = arr[--numberOfItems];
                arr[numberOfItems] = 0;
                return fl;
            }
        }

        public float this[int j]
        {
            get
            {
                return arr[j];
            }

            set
            {
                arr[j] = value;
            }
        }

        public bool HasNegativeItems()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    return true;
                }
            }

            return false;
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

                if (stackArr[i][0] >= maxTopValue)
                {
                    maxTopValue = stackArr[i][0];
                    maxValueArrayNumber = i;
                }

                if (stackArr[i][0] <= minTopValue)
                {
                    minTopValue = stackArr[i][0];
                    minValueArrayNumber = i;
                }
            }

            Console.WriteLine($"Stack {maxValueArrayNumber + 1} has the maximum top number among all stacks equal to {maxTopValue}.");
            Console.WriteLine($"Stack {minValueArrayNumber + 1} has the minimum top number among all equal to {minTopValue}.");

        }
    }
}
