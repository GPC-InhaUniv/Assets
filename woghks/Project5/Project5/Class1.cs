using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class CircularQueue
    {
        static int DEFAULT_SIZE = 16;
        int[] Q = new int[DEFAULT_SIZE];
        int front = -1;
        int rear = -1;

        public void Enqueue(int val)
        {
            if (rear + 1 % Q.Length == front)
            {
                throw new ApplicationException("Queue is full");
            }
            if (front == -1)
            {
                front = rear = 0;
            }
            else
            {
                rear = rear + 1 % Q.Length;
            }
            Q[rear] = val;
        }

        public int Dequeue()
        {
            if (front == -1)
            {
                throw new ApplicationException("Queue is empty");
            }
            int val = Q[front];

            if (front == rear)
            {
                front = rear = -1;
            }
            else
            {
                front = front + 1 % Q.Length;
            }

            return val;
           
        }
    }
}
