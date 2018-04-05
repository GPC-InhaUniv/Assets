using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueue
{
    
    class Program
    {
        static void Main(string[] args)
        {
            CircularQueue<int> ccQueue = new CircularQueue<int>(9);

            ccQueue.PushBack(1);
            ccQueue.PushBack(2);
            ccQueue.PushBack(4);
            ccQueue.PushBack(5);
            ccQueue.PushBack(8);
            ccQueue.PushBack(5);
            ccQueue.PushBack(3);
            ccQueue.PushBack(4);
            ccQueue.PushBack(5);

            Console.WriteLine(ccQueue.IsFull);

            ccQueue.PopHeader();
            ccQueue.PopHeader();
            ccQueue.PopHeader();

            Console.WriteLine(ccQueue.Header);
            Console.WriteLine(ccQueue.HeaderData);
            Console.WriteLine(ccQueue.Trailer);
            Console.WriteLine(ccQueue.TrailerData);
            Console.WriteLine(ccQueue.IsFull);
            Console.WriteLine(ccQueue.IsEmpty);

            int a = 1;
            double b = a;
            Console.WriteLine(b);
        }
    }
}
