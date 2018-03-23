using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList1
{
    public class Node
    {
        public Node next;
        public Object data;
    }
    public class LinkedList
    {
        private Node head;
        
        public void PrintNode()
        {
            Node current = head; //current == 흐름
            while(current !=null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }

        }
        public void AddFirst(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        public void AddLast(Object data)
        {
            if (head is null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;
                Node current = head;

                while (current.next != null)
                { current = current.next; }

                current.next = toAdd;
            }
        }

    }
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Add First: ");
            LinkedList list1 = new LinkedList();
            list1.AddFirst("1");
            list1.AddFirst("22");
            list1.AddFirst("333");
            list1.AddFirst("4444");
            list1.PrintNode();

            Console.WriteLine();

            Console.WriteLine("Add Last: ");
            LinkedList list2 = new LinkedList();
            list2.AddLast("1");
            list2.AddLast("22");
            list2.AddLast("333");
            list2.AddLast("4444");
            list2.PrintNode();

            Console.ReadLine();
        }
    }
}
