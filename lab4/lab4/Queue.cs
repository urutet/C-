using System;
namespace lab4
{
    public class Queue
    {
        int[] arr;
        const int defaultNum = 1;
        static int numOfObjects;
        int numberOfElements;
        public int this[int i]
        {
            get
            {
                return arr[i];
            }
        }

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

        public class Date
        {
            static DateTime date;
            private int day;
            private int month;
            private int year;

            public Date()
            {
                day = date.Day;
                month = date.Month;
                year = date.Year;
            }

            public void dateOfCreation()
            {
                Console.WriteLine($"Object created on {date.Day}.{date.Month}.{date.Year}");
            }

        }   
    }

    public static class StatisticOperation
    {
        /*public static int Sum(Queue obj)
        {
            int sum = 0;
            for (int i = 0; i < obj.arr.Length; i++)
            {
                sum += obj.arr[i];
            }
            return sum;
        }

        public static int MinMaxDiff(Queue obj)
        {
            int min = 99;
            int max = 0;
            for (int i = 0; i < obj.arr.Length; i++)
            {
                if (obj.arr[i] >= max)
                {
                    max = obj.arr[i];
                }

                if (obj.arr[i] <= min)
                {
                    min = obj.arr[i];
                }
            }
            return max - min;
        }

        public static int NumOfElements(Queue obj)
        {
            return obj.arr.Length;
        }

        //static int FirstPointIndex() -----> в массиве 0? не очень понял задание

        static int FirstPointIndex(Queue obj)
        {
            return 0;
        }*/


        public static int LastItem(this int[] arr)
        {
            return arr[arr.Length];
        }

        public static int WordsCount(this string str)
        {
            int words = 0;
            string[] result;
            result = str.Split(" ");

            foreach(string s in result)
            {
                words += 1;
            }

            return words;
        }
    }
}
