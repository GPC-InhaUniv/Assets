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
    }

    class myList
    {
        private Node head = new Node();
        private int count = 0;

        public void Add(int data)
        {
            Node temp = new Node();
            temp.Data = data;
            temp.Next = head.Next;
            head.Next = temp;
            Console.WriteLine(data.ToString() + "을 추가하였습니다.\n");
            count++;
        }

        public bool Remove(int data)
        {
            Node prev = Find(data); // 지울 노드의 이전 노드
            if (prev != null)
            {
                prev.Next = prev.Next.Next;
                count--;
                Console.WriteLine(data.ToString() + "을 삭제하였습니다.\n");
                return true;
            }
            Console.WriteLine("해당 값이 리스트에 존재하지 않습니다.\n");
            return false;
        }

        public Node Find(int findValue) // 다음에 올 노드의 값 미리 탐색
        {
            for (Node i = head; i.Next != null; i = i.Next)
            {
                if (i.Next.Data == findValue) return i;
            }
            return null;
        }

        public void PrintList()
        {
            for (Node i = head.Next; i != null; i = i.Next)
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
