using System;
using System.Collections.Generic;
namespace lab10
{
    public class ObservableCollection<T>
    {
        public ObservableCollection()
        {
            observableCollectionList = new List<T>();
        }
        public delegate void EventHandler(string mes);
        public event EventHandler CollectionChange;

        List<T> observableCollectionList;

        public void Add(T obj)
        {
            observableCollectionList.Add(obj);
            CollectionChange?.Invoke("Object added to the collection");
        }

        public void Remove(T obj)
        {
            observableCollectionList.Remove(obj);
            CollectionChange?.Invoke("Object removed from the collection");

        }

        public void RemoveAt(int i)
        {
            observableCollectionList.RemoveAt(i);
            CollectionChange?.Invoke($"Object {i} removed from the collection");

        }
    }
}
