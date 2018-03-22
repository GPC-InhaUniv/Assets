using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0322_LinkedList_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //리스트 - 추가,제거,넥스트,주소값(랜덤)
            //연결 리스트, 링크드 리스트(linked list)는 각 노드가 데이터와 포인터를 가지고 한 줄로 연결되어 있는 방식으로 데이터를 저장하는 자료 구조이다.
            //이름에서 말하듯이 데이터를 담고 있는 노드들이 연결되어 있는데, 노드의 포인터가 다음이나 이전의 노드와의 연결을 담당하게 된다.
            //LinkedList<string> list = new LinkedList<string>();
            //list.AddLast("Apple");
            //list.AddLast("Banana");
            //list.AddLast("Lemon");

            //LinkedListNode<string> node = list.Find("Banana");
            //LinkedListNode<string> newNode = new LinkedListNode<string>("Grape");

            //// 새 Grape 노드를 Banana 노드 뒤에 추가
            //list.AddAfter(node, newNode);

            //// 리스트 출력
            //list.ToList().ForEach(p => Console.WriteLine(p));

            //// Enumerator를 이용한 리스트 출력
            //foreach (var m in list)
            //{
            //    Console.WriteLine(m);
            //}
            //Console.ReadKey();
            Random random = new Random();//임의의 주소를 만들꺼다 -사실 랜덤을 쓰는 의미는 없다
            while (true)
            {
                Console.WriteLine("1. 단순추가\n2. 삽입추가\n3. 제거");
                int select = int.Parse(Console.ReadLine());
                int location = 0;
                int AddValue;
                int RemoveValue;
                switch (select)
                {
                    case 1://추가
                        
                        Console.WriteLine("추가할 값 입력");
                        AddValue = int.Parse(Console.ReadLine());
                        List.AddData(AddValue,location);//추가해준다
                        location = location + random.Next(5);//추가할때 이 전의 추가 값에 이 location 값을 명시해준다
                        List.ReadData();//출력
                        break;

                    case 2://삽입추가
                        Console.WriteLine("삽입할 위치의 값");//해당 값과 그 다음 값 사이에 추가해주기위해 입력받는다
                        int FindValue = int.Parse(Console.ReadLine());
                        Console.WriteLine("추가할 값 입력");
                        AddValue = int.Parse(Console.ReadLine());
                        List.AddData(AddValue, location, FindValue);//삽입추가해준다
                        location = location + random.Next(5);//추가할때 이 전의 추가 값에 이 location 값을 명시해준다
                        List.ReadData();//출력
                        break;

                    case 3://제거
                        Console.WriteLine("제거할 값 입력");
                        RemoveValue = int.Parse(Console.ReadLine());
                        List.RemoveData(RemoveValue);//제거해준다 제거할때 제거하는 값의 주소를 가르키는 값을 제거하는놈 다음값으로 바꿔주고 제거한다
                        List.ReadData();//출력
                        break;

                    default:
                        break;
                }

            }

        }
    }
}
