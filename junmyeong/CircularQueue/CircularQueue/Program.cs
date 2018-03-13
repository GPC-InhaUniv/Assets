using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("메모리의 크기를 입력하시오. : ");
            int size1 = int.Parse(Console.ReadLine());
            int[] queue = new int[size1];
            int start = 0;                   //원형 큐 인큐 시작지점을 알기위한 변수
            int end = 0;                     //원형 큐 디큐 시작지점을 알기위한 변수
            int value = 0;                   //얼마큼 더 저장할 수 있는 알리기 위한 변수
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("안에 들어갈 정수를 0을 제외한 최대 {0}개 만큼 입력해주십시오. 그만 넣으실려면 아무 값도 넣지 않고 엔터를 치시면 됩니다.", size1 - value);
                Console.WriteLine("---------------------입력------------------------");
                if (start >= size1)                        //최대 배열의 크기와 같거나 커질경우 0으로 다시 초기화
                    start = start - size1;

                for (int i = start; ; i++)
                {
                    if (i >= size1)                       //최대 배열의 크기와 같거나 커질경우 0으로 다시 초기화
                    {
                        i = 0;
                    }
                    if (queue[i] != 0)                    //배열에 이미 값이 들어가 있을 경우 끝냄.
                        break;
                    String input = Console.ReadLine();
                    if (input == "")                      //아무것도 입력 안할 시
                        break;
                    queue[i] = int.Parse(input);          //배열에 값 넣음.
                    value++;                        
                    start++;

                }

                Console.WriteLine("출력할 정수의 갯수 최대 {0}개 만큼 입력해주십시오. 출력 하고 싶지않다면 엔터를 누르십시오.", value);
                String input2 = Console.ReadLine();
                if (input2 == "")                  //엔터 누를경우 입력으로 넘어감
                    continue;
                Console.WriteLine("---------------------출력------------------------");
                int size2 = int.Parse(input2);         
                if (end >= size1)                  //최대 배열의 크기와 같거나 커질경우 0으로 다시 초기화
                    end = end - size1;
                int count = 0;                     //다 출력시 브레이크를 위한 변수
                for (int i = end; ; i++)
                {

                    if (count == size2)
                        break;
                    if (i >= size1)
                    {
                        i = 0;
                    }
                    if (queue[i] == 0)
                    {
                        Console.WriteLine("불러 올 값이 없습니다.");
                        break;
                    }

                    Console.WriteLine(queue[i]);
                    queue[i] = 0;                  //출력하고 값 초기화
                    end++;
                    value--;
                    count++;
                }

                Console.ReadKey();
            }

        }
    }
}
