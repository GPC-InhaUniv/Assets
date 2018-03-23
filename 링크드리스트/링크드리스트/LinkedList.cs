using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 링크드리스트
{
    class LinkedList
    {
        private Node Head;

        public void AddNode(Node n)
        {
            n.Next = this.Head;
            this.Head = n;
        }

        public void printNodes()
        {
            while (Head != null)
            {
                Console.WriteLine(Head.data);
                Head = Head.Next;
            }
        }
    }
}
