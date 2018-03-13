using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularQ circularQ = new CircularQ(5);
            circularQ.EnQueue(5);
            circularQ.EnQueue(10);
            circularQ.EnQueue(15);
            circularQ.EnQueue(20);
            circularQ.EnQueue(25);
            Console.WriteLine("Items are : ");
            circularQ.PrintQueue();

            circularQ.DeQueue();
            circularQ.DeQueue();
            circularQ.DeQueue();

            circularQ.EnQueue(55);
            circularQ.EnQueue(75);
            circularQ.EnQueue(95);


            Console.WriteLine("Items are : ");
            circularQ.PrintQueue();

            Console.ReadKey();
        }
    }
}
