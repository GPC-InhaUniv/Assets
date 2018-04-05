using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateLinkedList
{
    public class Node
    {
        public Node Next;
        public Object Data;
    }

    public class LinkedList
    {
        private Node head;

        public void PrintAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();

            toAdd.Data = data;
            toAdd.Next = head;

            head = toAdd;
        }

        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();

                head.Data = data;
                head.Next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.Data = data;

                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = toAdd;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add First:");
            LinkedList myList1 = new LinkedList();

            myList1.AddFirst("Hello");
            myList1.AddFirst("Magical");
            myList1.AddFirst("World");
            myList1.PrintAllNodes();

            Console.WriteLine();

            Console.WriteLine("Add Last:");
            LinkedList myList2 = new LinkedList();

            myList2.AddLast("Hello");
            myList2.AddLast("Magical");
            myList2.AddLast("World");
            myList2.PrintAllNodes();

            Console.ReadLine();
        }
    }
}
