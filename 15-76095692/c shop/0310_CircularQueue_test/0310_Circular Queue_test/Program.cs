using System;

namespace _0310_Circular_Queue_test
{
    class CircularQueue
    {

        private int[] queArray;
        private int front;
        private int rear;
        private int max;
        private int count;

        public CircularQueue(int size)
        {
            queArray = new int[size];
            front = 0;
            rear = -1;
            max = size;
            count = 0;
        }

        public void insert(int item)
        {
            if (count == max)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                rear = (rear + 1) % max;
                queArray[rear] = item;

                count++;
            }
        }

        public void delete()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("deleted element is: " + queArray[front]);

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
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (i = front; j < count;)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + queArray[i]);

                    i = (i + 1) % max;
                    j++;

                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("배열 수를 정한다");
            int size = 0;
            string qsize;
            qsize = Console.ReadLine();
            size = Convert.ToInt32(qsize);
            CircularQueue Q = new CircularQueue(size);


            Console.WriteLine("모든 배열에 값을 넣는다");
            string qinsert;
            int insert = 0;
            for (int i =0; i<size; i++)
            {
                Console.WriteLine(i+"번째 배열");
                qinsert = Console.ReadLine();
                insert = Convert.ToInt32(qinsert);
                Q.insert(insert);
            }
            Console.WriteLine("배열 내 아이템");
            Q.printQueue();


            Console.WriteLine("매뉴 \n 1.추가\n 2.제거\n 3.종료");
            string menuSelect;
            menuSelect = Console.ReadLine();
            if (menuSelect == "2")
            {
                string sdeleteNum;
                int deleteNum;
                Console.WriteLine("얼마나 삭제할껀가");
                sdeleteNum = Console.ReadLine();
                deleteNum = Convert.ToInt32(sdeleteNum);
                
                for (int i = 0;i<deleteNum ; i++)
                {
                    Q.delete();
                }
                
            }
            else if (menuSelect == "1")
            {
                string sinsertNum;
                int insertNum;
                Console.WriteLine("몇개를 추가할건가");
                sinsertNum = Console.ReadLine();
                insertNum = Convert.ToInt32(sinsertNum);
                for (int i = 0; i< insertNum;i++)
                {
                    string saddinsert;
                    int addinsert;
                    Console.WriteLine(i + "번째 배열");
                    saddinsert = Console.ReadLine();
                    addinsert = Convert.ToInt32(saddinsert);
                    Q.insert(addinsert);
                }

            }
            else
            {
                Console.WriteLine("아무키나 누르시오");
                
            }
            Q.printQueue();

            Console.ReadKey();
            //키를 받는걸 합쳐서 따로 빼놓자
        }
    }
}
