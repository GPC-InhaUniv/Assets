using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SingleLinkedList
    {
        public Node Front = new Node();
        public Node Back = new Node();

        public int Size
        {
            get
            {
                int size = 0;
                Node node = Front.Next;
                while (node != Back)
                {
                    size++;
                    node = node.Next;
                }

                return size;
            }
        }

        public bool IsEmpty()
        {
            if (Front.Next == Back)
            {
                return true;
            }
            return false;
        }

        public SingleLinkedList()
        {
            Front.Next = Back;
        }

        public void PushBack(string elem)
        {
            Node node = new Node(elem);
            Node currentNode = Front;

            if (IsEmpty())
            {
                Front.Next = node;
                node.Next = Back;
                return;
            }

            while(currentNode.Next != Back)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = node;
            node.Next = Back;
            
        }

        public void PushFront(string elem)
        {
            Node node = new Node();
            node.Next = Front.Next;
            Front.Next = node;
        }

        public void Push(string elem, string targerElem)
        {
            Node node = new Node(elem);
            Node currentNode = Front.Next;

            while (!(currentNode.Elem.Equals(targerElem)))
            {
                currentNode = currentNode.Next;
            }
            
            node.Next = currentNode.Next;
            currentNode.Next = node;

        }

        public void Push(string elem, int index)
        {
            Node node = new Node(elem);
            Node currentNode = Front.Next;
            int count = 0;

            while (count != index - 1)
            {
                currentNode = currentNode.Next;
                count++;
            }
            
            node.Next = currentNode.Next;
            currentNode.Next = node;
        }

        public void Pop(string targetElem)
        {
            Node currentNode = Front.Next;

            while (!(currentNode.Next.Elem.Equals(targetElem)))
            {
                currentNode = currentNode.Next;

            }

            currentNode.Next = currentNode.Next.Next;
        }

        public void Pop(int index)
        {
            Node currentNode = Front.Next;
            int count = 0;

            while (count != index - 1)
            {
                currentNode = currentNode.Next;
                count++;
            }

            currentNode.Next = currentNode.Next.Next;
        }

        public void ShowAll()
        {
            Node node = Front.Next;
            while (node != Back)
            {
                Console.WriteLine(node.Elem);
                node = node.Next;
            }
        }
    }
}
