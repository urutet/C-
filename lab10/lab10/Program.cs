using System;
using System.Collections.Generic;
namespace lab10
{
    class Program
    {
        static void ObservableCollectionHandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            //1ST TASK
            ConcertList concerts = new ConcertList();

            Concert concert1 = new Concert("AAA", "AA.AA.AA", 10);
            Concert concert2 = new Concert("BBB", "BB.BB.BB", 20);
            Concert concert3 = new Concert("CCC", "CC.CC.CC", 30);
            concerts.Add(concert1);
            concerts.Add(concert2);
            concerts.Add(concert3);

            concerts.ShowList();

            concerts.RemoveAt(concerts.Count-1);

            concerts.ShowList();

            //2ND TASK
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "qwerty");
            dictionary.Add(2, "azerty");
            dictionary.Add(3, "qwertz");
            dictionary.Add(4, "colemak");
            dictionary.Add(5, "maltron");

            Console.WriteLine("Enter n (1-5): ");
            int n = Console.Read();

            dictionary.Remove(n);

            dictionary.Add(6, "colemak");

            foreach(KeyValuePair<int, string> pair in dictionary)
            {
                Console.WriteLine(@$"˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜
{pair.Key} {pair.Value}
˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜");
            }

            List<string> list = new List<string>();
            list.Add("qwerty");
            list.Add("azerty");
            list.Add("qwertz");
            list.Add("colemak");
            list.Add("maltron");

            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            bool container = list.Contains(str);
            if(container)
            {
                Console.WriteLine("Item was found");
            }
            else
            {
                Console.WriteLine("Item wasn't found");
            }

            //3RD TASK
            ObservableCollection<Concert> collection = new ObservableCollection<Concert>();
            collection.CollectionChange += ObservableCollectionHandler;
            collection.Add(concert1);
            collection.Add(concert2);
            collection.Add(concert3);

            collection.Remove(concert3);
        }
    }
}
