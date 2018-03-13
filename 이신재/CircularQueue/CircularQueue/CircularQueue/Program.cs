using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircularQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueBody queue = new QueueBody(5);

            queue.InputNumber(1);
            queue.InputNumber(2);
            queue.InputNumber(3);
            queue.InputNumber(4);
            queue.InputNumber(5);
            queue.InputNumber(6);
           

            queue.DeleteNumber();
            queue.DeleteNumber();

            queue.InputNumber(7);
            queue.InputNumber(8);
            queue.WriteResult();
        }
    }
}
