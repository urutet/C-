using System;
namespace lab4
{
    public class Queue
    {
        int[] arr;
        const int defaultNum = 1;
        static int numOfObjects;
        int numberOfElements;

        public Queue()
        {
            numOfObjects++;
        }

        static Queue()
        {
            Console.WriteLine("First object created");
        }

        public bool IsQueueEmpty
        {
            get
            {
                return numberOfElements == 0;
            }
        }

        public static Queue operator + (Queue obj, int numberToAdd)
        {
            if (obj.arr == null)
            {
                obj.arr = new int[defaultNum];
                obj.arr[obj.numberOfElements] = numberToAdd;
                obj.numberOfElements++;
            }
            else
            {
                Array.Resize<int>(ref obj.arr, obj.arr.Length + 1);
                obj.arr[obj.numberOfElements] = numberToAdd;
                obj.numberOfElements++;
            }
            return obj;
        }

        public static Queue operator --(Queue obj)
        {
            if (obj.arr.Length == 0)
            {
                throw new System.InvalidOperationException("Unable to pop. Queue is empty.");
            }
            else
            {
                Array.Copy(obj.arr, 1, obj.arr, 0, obj.arr.Length - 1);
                Array.Resize<int>(ref obj.arr, obj.arr.Length - 1);
                return obj;
            }
        }

        public void QueuePrint()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static Queue operator <(Queue obj1, Queue obj2)
        {
            int i = obj1.arr.Length;
            Array.Resize<int>(ref obj1.arr, obj1.arr.Length + obj2.arr.Length);
            Array.Copy(obj2.arr, 0, obj1.arr, i, obj2.arr.Length);
            Array.Sort(obj1.arr);
            Array.Reverse(obj1.arr);
            return obj1;
        }

        public static Queue operator >(Queue obj1, Queue obj2)
        {
            int i = obj1.arr.Length;
            Array.Resize<int>(ref obj1.arr, obj1.arr.Length + obj2.arr.Length);
            Array.Copy(obj2.arr, 0, obj1.arr, i, obj2.arr.Length);
            Array.Sort(obj1.arr);
            return obj1;
        }

        public static implicit operator int(Queue obj)
        {
            return obj.arr.Length;
        }

        public class Owner
        {
            string id;
            string organizationName; //ne zabyt' proinitsializirovat
        }

        
    }
}
