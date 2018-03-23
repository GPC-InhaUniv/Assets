using System;
using System.Collections.Generic;
using System.Collections;

namespace ex_LinkedLIST
{
    public class GenericCollection
    {
        public static void Main()
        {
            // 새 LinkedList생성 및 초기화.
            LinkedList<String> ll = new LinkedList<String>();
            ll.AddLast("red");
            ll.AddLast("orange");
            ll.AddLast("yellow");
            ll.AddLast("orange");

            // 링크된 목록의 내용 표시.
            if (ll.Count > 0)
            {
                Console.WriteLine("The item in the list is {0}.", ll.First.Value);
                Console.WriteLine("The item in the list is {0}.", ll.Last.Value);

                Console.WriteLine("The LinkedList contains:");
                foreach (String s in ll)
                    Console.WriteLine("   {0}", s);
            }
            else
            {
                Console.WriteLine("The LinkedList is empty.");
            }

        }
    }
}

