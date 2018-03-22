using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<string> linked = new LinkedList<string>(); //linked list 생성

            linked.AddLast("one"); 
            linked.AddLast("two");
            linked.AddLast("three"); //linked list에 3개의 요소 추가

            LinkedListNode<string> node = linked.Find("one"); 
            linked.AddAfter(node, "inserted"); //첫번째 node인 one 뒤에 inserted 삽입.

            foreach (var value in linked) //linked list 루프 실행
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
