using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Test01
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
            Console.WriteLine(Head.data);
            Head = Head.Next;
        }
    }
}
