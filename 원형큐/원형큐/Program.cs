using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 원형큐
{
    class Program
    {
        static int MAX = 10;
        class CircleQueue
        {
            public int Data = 1;
            public int Front = 0;
            public int Rear = 0;
            public int[] Queue = new int[MAX];
            public void PutDataInQueue()
            {
                for (int i = 0; i < MAX; i++)
                {
                    if ((Rear + 1) % MAX == Front % MAX)
                    {
                        Console.WriteLine("큐의 메모리가 꽉찼습니다!");
                        Rear = (Rear + 1) % MAX;
                    }
                    else
                    {
                        Rear = (Rear + 1) % MAX;
                        Queue[Rear] = Data;
                        Data++;
                    }
                }
            }
            public void DeleteDataInQueue()
            {
                Queue[Front] = Data;
                Queue[Front + 1] = 0;
                Front = (Front + 1) % MAX;
                Data++;
            }
            public void ShowQueue()
            {
                for (int i = 0; i < MAX; i++)
                {
                    Console.WriteLine("현재 큐[" + i + "]의 데이터는 : " + Queue[i]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            CircleQueue circlequeue = new CircleQueue();
            circlequeue.PutDataInQueue();
            circlequeue.ShowQueue();
            circlequeue.DeleteDataInQueue();
            circlequeue.ShowQueue();
            circlequeue.DeleteDataInQueue();
            circlequeue.ShowQueue();
        }
    }
}