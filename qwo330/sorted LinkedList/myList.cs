using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public int Data;
        public Node Next;
        public Node Prev;
    }

    class myList
    {
        private Node head = new Node();
        private Node tail = new Node();
        private int count = 0;

        public myList()
        {
            head = new Node();
            tail = new Node();
            head.Next = tail;
            tail.Prev = head;
        }

        public void Add(int data)
        {
            Node temp = new Node();
            temp.Data = data;

            Node ptr = Compare(data);
            temp.Next = ptr.Next;
            ptr.Next.Prev = temp;
            temp.Prev = ptr;
            ptr.Next = temp;
            
            Console.WriteLine("\n" + data.ToString() + "을 추가하였습니다.\n");
            count++;
        }

        public bool Remove(int data)
        {
            Node ptr = Find(data);
            if (ptr != null)
            {
                ptr.Prev.Next = ptr.Next;
                ptr.Next.Prev = ptr.Prev;

                ptr = null;
                count--;
                Console.WriteLine("\n" + data.ToString() + "을 삭제하였습니다.\n");
                return true;
            }
            Console.WriteLine("\n해당 값이 리스트에 존재하지 않습니다.\n");
            return false;
        }

        public Node Find(int findValue)
        {
            for (Node i = head.Next, j = tail.Prev; i.Data <= j.Data && i != tail && j != head; i = i.Next, j = j.Prev)
            {
                if (i.Data == findValue) return i;
                else if (j.Data == findValue) return j;
            }
            return null;
        }

        public Node Compare(int data) // 다음에 올 노드의 값 미리 탐색
        {
           
            for (Node i = head, j = tail; i.Data <= j.Data && i != tail && j != head; i = i.Next, j = j.Prev)
            {
                if (i.Next.Data >= data) return i;
                else if (j.Prev.Data <= data) return j.Prev;
            }
            return null;
        }

        public void PrintList()
        {
            for (Node i = head.Next; i != tail; i = i.Next)
            {
                Console.Write(i.Data + " ");
            }
            Console.WriteLine();
        }

        public int Count()
        {
            return count;
        }
    }
}
