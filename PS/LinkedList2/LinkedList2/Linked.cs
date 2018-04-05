using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class Linked
    {
        private int size;

        public int Count
        {
            get
            {
                return size;
            }
        }

        private Node head;
        private Node current;

        public Linked()
        {
            size = 0;
        }

        public void Add(object value)
        {
            size++;
            Node node = new Node { Content = value };

            if (head == null)
            {
                head = node;
            }
            else
            {
                current.Next = node;
            }

            current = node;
        }

        public void AddIndex(int index, object value)
        {
            if (size < index - 1) return;

            int count = 0;
            Node temp = head;

            while (temp != null)
            {
                if (count == index - 2)
                {
                    size++;

                    Node _temp = temp.Next;
                    temp.Next = new Node { Content = value, Next = _temp };

                    break;
                }
                count++;
                temp = temp.Next;
            }
        }

        public void Print()
        {
            Node temp = head;

            while (temp != null)
            {
                System.Diagnostics.Debug.WriteLine(temp.Content);

                temp = temp.Next;
            }
        }

        public bool Delete(int index)
        {
            if (index == 1)
            {
                head = null;
                current = null;
                return true;
            }
            if (index > 1 && index <= size)
            {
                Node temp = head;
                Node last = null;
                int count = 0;

                while (temp != null)
                {
                    if (count == index - 1)
                    {
                        size -= 1;
                        last.Next = temp.Next;
                        return true;
                    }
                    count++;

                    last = temp;
                    temp = temp.Next;
                }
            }
            return false;
        }        
    }

    public class Node
    {
        public object Content
        {
            get; set;
        }
        public Node Next
        {
            get; set;
        }
    }
}
