using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CircularQueue
    {
        private int[] ele;
        private int front; //앞
        private int rear; //뒤
        private int max; //최대
        private int count;

        public CircularQueue(int size)
        {
            ele = new int[size];
            front = 0; //앞
            rear = -1; //뒤
            max = size;
            count = 0;
        }

        public void insert(int item)
        {
            if (count == max)
            {
                Console.WriteLine("Queue가 꽉 찼습니다.");
                return;
            }
            else
            {
                rear = (rear + 1) % max;
                ele[rear] = item;

                count++;
            }
        }

        public void delete()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue가 비어있습니다.");
            }
            else
            {
                Console.WriteLine("삭제된 요소 : " + ele[front]);

                front = (front + 1) % max;

                count--;
            }
        }

        public void printQueue()
        {
            int i = 0;
            int j = 0;

            if (count == 0)
            {
                Console.WriteLine("Queue가 비어있습니다.");
                return;
            }
            else
            {
                for (i = front; j < count;)
                {
                    Console.WriteLine("원형큐[" + (i + 1) + "]: " + ele[i]);

                    i = (i + 1) % max;
                    j++;
                }
            }
        }
    }

    internal class Program2
    {
        private static void Main()
        {
            CircularQueue Q = new CircularQueue(5);

            Q.insert(10);
            Q.insert(20);
            Q.insert(30);
            Q.insert(40);
            Q.insert(50);

            Console.WriteLine("원형큐 : ");
            Q.printQueue();

            Q.delete();
            Q.delete();

            Q.insert(60);
            Q.insert(70);

            Console.WriteLine("원형큐 : ");
            Q.printQueue();

            Console.ReadKey();
        }
    }
}