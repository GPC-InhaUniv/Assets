using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Pool
{
    class ObjectPool<T> where T : new()
    {
        readonly ConcurrentBag<T> items = new ConcurrentBag<T>();
        int counter = 0;
        int MAX = 10;

        public void release(T item)
        {
            if(counter < MAX)
            {
                items.Add(item);
                counter++;
            }
            Console.WriteLine("Call release Method : " + item.ToString());
        }

        public T Get()
        {
            
            T item;
            if(items.TryTake(out item))
            {
                counter--;
                Console.WriteLine("Call Get Method : " + item.ToString());
                return item;
            }
            else
            {
                T obj = new T();
                items.Add(obj);
                counter++;
                Console.WriteLine("Call Get Method : " + obj.ToString());
                return obj;
            }
            
        }
    }
}
