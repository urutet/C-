using System;
using System.Collections;
using System.Collections.Generic;
namespace lab10
{
    public class ConcertList: IList<Concert>
    {
        List<Concert> concertList;

        public Concert this[int i]
        {
            get => concertList[i];
            set => concertList[i] = value;
        }

        public int Count
        {
            get => concertList.Count;
        }

        public bool IsReadOnly
        {
            get => false;
        }

        public ConcertList()
        {
            concertList = new List<Concert>();
        }

        public void Add(Concert obj)
        {
            concertList.Add(obj);
        }

        public void RemoveAt(int i)
        {
            concertList.RemoveAt(i);
        }

        public void Insert(int i, Concert obj)
        {
            concertList.Insert(i, obj);
        }

        public int IndexOf(Concert obj)
        {
            for(int i = 0; i < concertList.Count; i++)
            {
                if(concertList[i].Equals(obj))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Clear()
        {
            concertList.Clear();
        }

        public bool Remove(Concert obj)
        {
            concertList.Remove(obj);
            return true;
        }

        public void CopyTo(Concert[] objArray, int i)
        {
            concertList.CopyTo(objArray, i);
        }

        public bool Contains(Concert obj)
        {
            return concertList.Contains(obj);
        }

        public IEnumerator<Concert> GetEnumerator()
        {
            return ((IEnumerable<Concert>)concertList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)concertList).GetEnumerator();
        }

        public void ShowList()
        {
            foreach(Concert concert in concertList)
            {
                Console.WriteLine(@$"
˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜
Name: {concert.Name}
Date: {concert.Date}
Number Of Tickets: {concert.NumberOfTickets}
˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜˜");
            }
        }
    }
}
