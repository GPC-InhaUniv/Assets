using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList();
            doubleLinkedList.PushBack("오우야");
            doubleLinkedList.PushBack("왓더뻑");
            doubleLinkedList.PushFront("훡유");
            doubleLinkedList.Push("뭔 개소리야?", "오우야");
            doubleLinkedList.Push("구와아아아악", 3);

            Node node = doubleLinkedList.Front.Next;
            
            while(node != doubleLinkedList.Back)
            {
                Console.WriteLine(node.Elem);
                node = node.Next;
            }

            Console.WriteLine(doubleLinkedList.Size);
            Console.WriteLine();

            doubleLinkedList.Pop("오우야");
            doubleLinkedList.Pop(2);

            node = doubleLinkedList.Front.Next;

            while (node != doubleLinkedList.Back)
            {
                Console.WriteLine(node.Elem);
                node = node.Next;
            }
            
            Console.WriteLine(doubleLinkedList.Size);
            Console.WriteLine();

        }
    }
}
