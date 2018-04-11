using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;


namespace ObjectPoolExample
{
    
    public class ObjectPool<T> where T : new()
    {
        private readonly ConcurrentBag<T> items = new ConcurrentBag<T>();
        private int counter = 0;
        private int MAX = 10;
        public void Release(T item)
        {
            if (counter < MAX)
            {
                items.Add(item);
                counter++;
            }
        }
        public T Get()
        {
            T item;
            if (items.TryTake(out item))
            {
                counter-- ;
                return item;
            }
            else
            {
                T obj = new T();
                items.Add(obj);
                counter++;
                return obj;
            }
        }
    }
    
    
    static void Main(string[] args)
    {
        ObjectPool<MyClass> objPool = new ObjectPool<MyClass>();
        MyClass obj = objPool.Get();
        objPool.Release(obj);
        Console.Read();
    }
}