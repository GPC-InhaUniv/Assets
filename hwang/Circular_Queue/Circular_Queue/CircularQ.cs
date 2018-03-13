using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Queue

{
    class CircularQ
    {
        private int []element;
        private int front;
        private int rear;
        private int max;
        private int count;


        //Constructor//
        public CircularQ(int size)
        {
            element = new int[size];
            front = 0;
            rear = -1;
            max = size;
            count = 0;
        }
        //EnQueue//
        public void EnQueue(int item)
        {
            if(count == max)
            {
                Console.WriteLine("Queue OverFlow");
                return;
            }
            else
            {
                rear = (rear + 1) % max;
                element[rear] = item;
                count++;
            }
        }
        //DeQueue//
        public void DeQueue()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("Deleted element is :" + element[front]);

                front = (front + 1) % max;

                count--;
            }

        }

        public void PrintQueue()
        {
            int i = 0;
            int j = 0;

            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for(i = front; j < count;)
                {
                    Console.WriteLine("Item [" + (i + 1) + "]:" + element[i]);

                    i = (i + 1) % max;
                    j++;
                }
            }
        }

    }
}
