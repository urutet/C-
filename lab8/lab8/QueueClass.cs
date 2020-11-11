using System;
namespace lab8
{
    public interface IQueue<T>
    {
        public void Add(T obj);
        public void Remove(T obj);
        public void ShowQueue(Queue<T> queue);
    }
    public class Queue<T> : IQueue<T>
    {
        T[] arr;
        const int defaultNum = 1;
        static int numOfObjects;
        int numberOfElements;
        public int NumberOfElements { get => numberOfElements; }
        public T this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }

        public Queue()
        {
            numOfObjects++;
        }

        public bool IsQueueEmpty
        {
            get
            {
                return numberOfElements == 0;
            }
        }

        public void Add(T obj)
        {
            if (arr == null)
            {
                arr = new T[defaultNum];
                arr[numberOfElements] = obj;
                numberOfElements++;
            }
            else
            {
                Array.Resize<T>(ref arr, arr.Length + 1);
                arr[numberOfElements] = obj;
                numberOfElements++;
            }
        }

        public void Remove(T obj)
        {
            if (arr.Length == 0)
            {
                throw new System.InvalidOperationException("Unable to pop. Queue is empty.");
            }
            else
            {
                Array.Copy(arr, 1, arr, 0, arr.Length - 1);
                Array.Resize<T>(ref arr, arr.Length - 1);
            }
        }

        public void ShowQueue(Queue<T> obj)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static Queue<T> operator +(Queue<T> obj, T numberToAdd)
        {
            if (obj.arr == null)
            {
                obj.arr = new T[defaultNum];
                obj.arr[obj.numberOfElements] = numberToAdd;
                obj.numberOfElements++;
            }
            else
            {
                Array.Resize<T>(ref obj.arr, obj.arr.Length + 1);
                obj.arr[obj.numberOfElements] = numberToAdd;
                obj.numberOfElements++;
            }
            return obj;
        }

        public static Queue<T> operator --(Queue<T> obj)
        {
            if (obj.arr.Length == 0)
            {
                throw new System.InvalidOperationException("Unable to pop. Queue is empty.");
            }
            else
            {
                Array.Copy(obj.arr, 1, obj.arr, 0, obj.arr.Length - 1);
                Array.Resize<T>(ref obj.arr, obj.arr.Length - 1);
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

        public static Queue<T> operator <(Queue<T> obj1, Queue<T> obj2)
        {
            int i = obj1.arr.Length;
            Array.Resize<T>(ref obj1.arr, obj1.arr.Length + obj2.arr.Length);
            Array.Copy(obj2.arr, 0, obj1.arr, i, obj2.arr.Length);
            Array.Sort(obj1.arr);
            Array.Reverse(obj1.arr);
            return obj1;
        }

        public static Queue<T> operator >(Queue<T> obj1, Queue<T> obj2)
        {
            int i = obj1.arr.Length;
            Array.Resize<T>(ref obj1.arr, obj1.arr.Length + obj2.arr.Length);
            Array.Copy(obj2.arr, 0, obj1.arr, i, obj2.arr.Length);
            Array.Sort(obj1.arr);
            return obj1;
        }

        public static implicit operator int(Queue<T> obj)
        {
            return obj.arr.Length;
        }

        public class Owner
        {
            string id;
            public string ID { get => id; }
            string organizationName; //ne zabyt' proinitsializirovat
            public string OrganizationName { get => organizationName; }

            public Owner(string ident, string oName)
            {
                id = ident;
                organizationName = oName;
            }
        }

        public class Date
        {
            static DateTime date;
            private int day;
            private int month;
            private int year;

            public Date()
            {
                date = DateTime.Now;
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
}
