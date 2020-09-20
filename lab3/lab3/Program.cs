using System;

namespace lab3
{
    public class Stack
    {
        int numberOfItems;
        const int defaultNum = 20;
        float[] arr;
        float value;

        public Stack()
        {
            arr = new float[defaultNum];
        }

        public Stack(int numOfElements)
        {
            arr = new float[numOfElements];
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


    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
