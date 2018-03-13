using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static int arrsize = 10;

        static int front = 0;
        static int nextpos = 1;
        static int[] QueueArr = new int[arrsize];

        static void Main(string[] args)
        {
            Choicebutton();

            Console.ReadKey();
        }

        public static void Menu()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Enqueue ");
            Console.WriteLine("2. Dequeue ");
            Console.WriteLine("3. ShowFront");
            Console.WriteLine("4. Show Queue");
            Console.WriteLine("5. Clear");
            Console.WriteLine("----------------------");
            Console.Write("번호를 선택하세요  ==>> ");

        }

        public static void Choicebutton()
        {
            string Choice = null;
            string Data = null;
         
            
           
            for (; ; )
            {
                Menu();
                Choice = Console.ReadLine();
                switch (Choice)
                {
                    case "1":
                        Console.Write("들어갈 데이터를 입력하세요 :");
                        Data = Console.ReadLine();
                        Enqueue(Convert.ToInt32(Data));
                       
                        break;
                    case "2":
                        Dequeue();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("Front의 Data :" + getFront());
                        break;
                    case "4":
                        ShowArray();
                        break;
                    case "5":
                        Console.Clear();
                        break;
                 
                    default:
                        Console.WriteLine("잘못입력하셨습니다");
                        
                        break;
                }
            }
        }


        public static void Enqueue(int data)
        {
            if ((nextpos % arrsize) == front)
            {
                Console.WriteLine("큐가 가득 차있습니다");
            }
            else
            {
               
                QueueArr[nextpos] = data;
                nextpos = (nextpos + 1) % arrsize;
                Console.Clear();
            }
        }

        public static void Dequeue()
        {
            if (front == nextpos - 1)
            {
                Console.WriteLine("큐가 비었습니다");
            }
            else
            {
                front = (front + 1) % arrsize;
                Console.WriteLine("Dequeue된 data : " + QueueArr[front]);
                QueueArr[front] = 0;
                
            }

        }

        public static void ShowArray()
        {
            foreach (int a in QueueArr)
            {
                Console.WriteLine("Queue Data : " + a);
            }
        }

        public static int getFront()
        {
            return QueueArr[front] ;
        }

    }


}
