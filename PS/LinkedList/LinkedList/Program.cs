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
            LinkedList ll = new LinkedList();

            Node A = new Node();
            A.data = "A";
            
            Node B = new Node();
            B.data = "B";

            Node C = new Node();
            C.data = "C";

            ll.AddNode(A);
            ll.AddNode(B);
            ll.AddNode(C);
            
            ll.printNodes();
        }

    }

    public class Node

    {
        public Object data
        {
            get; set;
        }

        public Node Next
        {
            get; set;
        }

    }

    public class LinkedList
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

