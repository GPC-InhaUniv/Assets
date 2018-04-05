using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DoubleLinkedList
    {
        public Node Front = new Node();
        public Node Back = new Node();

        public int Size
        {
            get
            {
                int size = 0;
                Node node = Front.Next;
                while(node != Back)
                {
                    size++;
                    node = node.Next;
                }

                return size;
            }
        }

        public bool IsEmpty()
        {
            if(Front.Next == Back)
            {
                return true;
            }
            return false;
        }

        public DoubleLinkedList()
        {
            Front.Next = Back;
            Back.Previous = Front;
        }

        public void PushBack(string elem)
        {
            Node node;
            if (IsEmpty())
            {
                node = new Node(elem);
                Front.Next = node;
                Back.Previous = node;
                node.Previous = Front;
                node.Next = Back;
                return;
            }
            node = new Node(elem);
            Back.Previous.Next = node;
            node.Previous = Back.Previous;
            Back.Previous = node;
            node.Next = Back;
        }

        public void PushFront(string elem)
        {
            Node node;
            if (IsEmpty())
            {
                node = new Node(elem);
                Front.Next = node;
                Back.Previous = node;
                node.Previous = Front;
                node.Next = Back;
                return;
            }
            node = new Node(elem);
            Front.Next.Previous = node;
            node.Next = Front.Next;
            Front.Next = node;
            node.Previous = Front;
        }
        
        public void Push(string elem, string targerElem)
        {
            Node node = new Node(elem);
            Node currentNode = Front.Next;

            while(!(currentNode.Elem.Equals(targerElem)))
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next.Previous = node;
            node.Next = currentNode.Next;
            currentNode.Next = node;
            node.Previous = currentNode;
        }

        public void Push(string elem, int index)
        {
            Node node = new Node(elem);
            Node currentNode = Front.Next;
            int count = 0;

            while(count != index - 1)
            {
                currentNode = currentNode.Next;
                count++;
            }

            currentNode.Next.Previous = node;
            node.Next = currentNode.Next;
            currentNode.Next = node;
            node.Previous = currentNode;
        }

        public void Pop(string targetElem)
        {
            Node currentNode = Front.Next;

            while (!(currentNode.Elem.Equals(targetElem)))
            {
                currentNode = currentNode.Next;
                
            }

            if(currentNode != Back)
            {
                currentNode.Previous.Next = currentNode.Next;
                currentNode.Next.Previous = currentNode.Previous;
            }
        }

        public void Pop(int index)
        {
            Node currentNode = Front.Next;
            int count = 0;

            while (count != index)
            {
                currentNode = currentNode.Next;
                count++;
            }

            currentNode.Previous.Next = currentNode.Next;
            currentNode.Next.Previous = currentNode.Previous;
        }
        
        public void ShowAll()
        {
            Node node = Front.Next;
            while(node != Back)
            {
                Console.WriteLine(node.Elem);
                node = node.Next;
            }
        }
    }
}
