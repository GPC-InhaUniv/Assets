using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            do
            {
                Console.Write("Queue 사이즈는? : ");
                size = int.Parse(Console.ReadLine());
                //int.TryParse(Console.ReadLine(), out size);
            } while (size < 3 || size > 10);

            CircleQueue queue = new CircleQueue(size);
            int i = 1, select;
            queue.show();

            while (true)
            {
                Console.Write("1 : Push, 2 : Pop  >>> ");
                //select = int.Parse(Console.ReadLine());
                int.TryParse(Console.ReadLine(), out select);

                if (select == 1)
                {
                    if (!queue.push(i)) i++;
                }

                else if (select == 2)
                    queue.pop();
            }
        }
    }

    class CircleQueue
    {
        private int size;
        private int front; // pop 되는 위치
        private int rear; // push 되는 위치
        private int[] arr;

        public CircleQueue(int size)
        {
            this.size = size;
            front = 0;
            rear = front;
            arr = new int[size + 1];
        }

        public bool push(int data)
        {
            if (isFull())
            {
                Console.WriteLine("        full 입니다.");
                show();
                return true;
            }

            arr[rear++] = data;
            Console.WriteLine("        Push : " + data);
            show();
            return false;
        }

        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("        empty 입니다.");
                show();
                return -1;
            }

            int data;
            data = arr[front++];
            Console.WriteLine("        Pop : " + data);

            show();
            return data;
        }

        public bool isFull() // 큐가 꽉 찼는지 확인
        {
            if (front < rear) return (rear - front) == size - 1;
            return rear + 1 == front;
        }

        public bool isEmpty() // 큐가 비었는지 확인
        {
            if (front == rear) return true;
            return false;
        }

        public bool isNull(int i) // 해당 위치의 데이터가 존재하는지 확인
        {
            i %= size;
            if (front < rear)   return !(front <= i && i < rear);
            else if (rear < front)  return !(front <= i || i < rear);
            return true;
        }

        public void show()
        {
            front %= size; // 원형으로
            rear %= size; // 원형으로
            Console.WriteLine("=================================");
            for (int i = 0; i < size; i++)
            {
                if (isNull(i))
                {
                    Console.Write("[   ]");
                }
                else Console.Write("[{0,3:G}]", arr[i]);
            }
            /* 포인터 표시용 for문 */
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                if (i == front) Console.Write("{0,3:G}", "f");
                else Console.Write("     ");
            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                if (i == rear) Console.Write("{0,3:G}", "r");
                else Console.Write("     ");
            }
            Console.WriteLine("\n=================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }

}