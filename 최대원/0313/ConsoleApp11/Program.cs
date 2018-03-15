using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //원형 큐의 크기보다 1이 더 큰 크기의 배열 선언
            //남은 한개의 공간은 큐의 포화 여부를 판별하기 위해 쓴다.
            int QueueSize = 10;
            int[] RoundQueue = new int[QueueSize+1];
            //front == rear인 경우 큐가 비어있음
            int front = 0, rear = 0;


           string Num = "";
            //내용 실행
            Console.WriteLine(" 큐에 넣을 수 입력(1~10)");
            Num = Console.ReadLine();
            SetQueue(int.Parse(Num));
            Console.WriteLine(" 삭제 할 큐의 수 입력(1~10)");
            Num = Console.ReadLine();
            DelQueue(int.Parse(Num));
            Console.WriteLine(" 큐에 넣을 수 입력(1~10)");
            Num = Console.ReadLine();
            SetQueue(int.Parse(Num));
            Console.WriteLine(" 삭제 할 큐의 수 입력(1~10)");
            Num = Console.ReadLine();
            DelQueue(int.Parse(Num));


            //이하 메소드
            void SetQueue(int num)
            {
                //값 넣기
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("{0}번 자리에 {1} 넣기",front + i ,i);
                    Enqueue(i);
                }
                ShowQueue();
            }
            
            void DelQueue(int num)
            {
                //값 빼기
                for (int i = 0; i < QueueSize - num + 1; i++)
                {
                    Dequeue();
                }
                ShowQueue();
            }

            //큐에 값을 넣는 함수
            void Enqueue(int inputnum)
            {

                //rear의 바로 뒷부분이 front인 경우
                if((rear + 1) == front)
                {
                    Console.WriteLine("이런! 큐가 꽉 찼습니다.");
                }
                else
                {
                    if (rear == QueueSize + 1)
                    {
                        rear = 0;
                    }
                    RoundQueue[rear] = inputnum;
                    rear++;
                }
            }

            //큐에 값을 빼는 함수
            void Dequeue()
            {
                //앞과 뒤가 같은 경우 1577
                if(front == rear)
                {
                    Console.WriteLine("큐가 비어 있습니다.");
                }
                else
                {   
                    if(front < QueueSize + 1) { front = 0; }
                    RoundQueue[front] = 0;
                    Console.WriteLine("큐의 {0}번자리 삭제 성공.", front);
                    front++;
                }
            }

            //큐의 상태를 보여주는 함수
            void ShowQueue()
            {
                Console.WriteLine("======================================");
                for (int i = 0; i < QueueSize + 1; i++)
                {
                    Console.Write("{0}번째 자리 데이터 : {1}", i, RoundQueue[i]);
                    if (i == front)
                    {
                        Console.WriteLine(" + Front");
                    }
                    else if (i == rear - 1)
                    {
                        Console.WriteLine(" + Rear");
                    }
                    else Console.WriteLine(" ");
                }
                Console.WriteLine("======================================");
            }
            Console.ReadKey();
        }
    }
}
