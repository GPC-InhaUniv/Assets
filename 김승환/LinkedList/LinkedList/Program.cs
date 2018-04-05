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
            
            doubleLinkedList.ShowAll();

            Console.WriteLine(doubleLinkedList.Size);
            Console.WriteLine();

            doubleLinkedList.Pop("오우야");
            doubleLinkedList.Pop(2);
            
            doubleLinkedList.ShowAll();

            Console.WriteLine(doubleLinkedList.Size);
            Console.WriteLine();

            SingleLinkedList singleLinkedList = new SingleLinkedList();
            singleLinkedList.PushBack("닭둘기");
            singleLinkedList.PushBack("구구");

            singleLinkedList.ShowAll();
            Console.WriteLine(singleLinkedList.Size);
            Console.WriteLine();
        }
    }
}
