using System;
namespace lab3
{
    public class Stack
    {
        int numberOfItems;
        const int defaultNum = 10;
        float[] arr;
        static int numOfObjects = 0;
        readonly int hash;

        public Stack()
        {
            arr = new float[defaultNum];
            hash = GetHashCode();
            numOfObjects++;
        }

        public Stack(int numOfElements)
        {
            arr = new float[numOfElements];
            hash = GetHashCode();
            numOfObjects++;
        }

        static Stack()
        {
            Console.WriteLine("First object created");
        }

        //private Stack() { }

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
            if (arr.Length == numberOfItems)
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
            if (IsStackEmpty)
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
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    return true;
                }
            }

            return false;
        }

        static void stackInfo()
        {
            Console.WriteLine($"Number of objects {numOfObjects}");

        }

        /*public void Sum(ref float[] arr, out float sum)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"Sum equals to {sum}");
        }*/

        public virtual bool Equals(float obj)
        {
            if (arr[0] == obj)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            int a = arr.Length;
            float b = arr[0];
            return (int)(a % b + 1241748124712489124/25);
        }


    }
}
