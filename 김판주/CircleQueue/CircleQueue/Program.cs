using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleaQueue
{
    class Program
    {

        static void Main()
        {



            CulQueue culQueue = new CulQueue();

            int i;

            Console.Write("\n 5,4,7,8,2,1");


            culQueue.EnQueue(5);
            culQueue.EnQueue(4);
            culQueue.EnQueue(7);
            culQueue.EnQueue(8);
            culQueue.EnQueue(2);
            culQueue.EnQueue(1);
            culQueue.PrintQueue();

            Console.Write("\n Get");

            i = culQueue.DeQueue();

            culQueue.PrintQueue();

            Console.Write("\n Get");

            i = culQueue.DeQueue();

            culQueue.PrintQueue();

            Console.Write("\n Get");

            i = culQueue.DeQueue();

            culQueue.PrintQueue();

            Console.Write("\n Get");

            i = culQueue.DeQueue();

            culQueue.PrintQueue();

            Console.Write("\n Get");

            i = culQueue.DeQueue();

            culQueue.PrintQueue();

            Console.Write("\n Get");

            i = culQueue.DeQueue();

            culQueue.PrintQueue();

            Console.Write("\n Get");

            i = culQueue.DeQueue();

            culQueue.PrintQueue();



        }


        public class CulQueue
        {
            int front;
            int rear;

            static int maxSize = 7;
            int[] queueArray = new int[maxSize];

            public Boolean IsEmpty()
            {
                return front == rear;
            }

            public Boolean IsFull()
            {
                return (rear + 1) % maxSize == front;
            }

            public void CircularQueue(int maxSize)
            {
                this.front = 0;
                this.rear = 0;
                this.queueArray = new int[maxSize];
            }

            public int EnQueue(int k)
            {
                if (IsFull())
                {
                    Console.WriteLine("큐가 포화상태입니다.");
                }
                queueArray[rear] = k;

                rear++;
                rear = rear % maxSize;

                return k;
            }

            public int DeQueue()
            {
                int i;

                if (IsEmpty())
                {
                    Console.WriteLine("큐가 비어있음.");
                }
                i = queueArray[front];
                front++;
                front = front % maxSize;
                return i;
            }

            public void PrintQueue()
            {
                int i;
                Console.Write("\n Queue contents : Front ----> Rear\n");

                for (i = front; i != rear; i = ++i % maxSize)
                {

                    Console.Write(queueArray[i]);

                }
            }
        }

    }
}