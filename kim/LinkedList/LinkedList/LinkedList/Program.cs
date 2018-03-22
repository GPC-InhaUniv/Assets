using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        
        public int data;
        public Node Next;
        public Node Prev;
        public Node(int data)
        {
            this.data = data;
        }
        
    }

    class SingleLinked
    {
      
        public Node head;
        public Node current;


        public void Add(int data)
        {
         
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
                current.Next = node;

            current = node;
        }

        public void Show()
        {
            Node temp = head;
            int i = 0;
            while (temp !=null)
            {
                i++;
                Console.WriteLine("{0}번째 데이터 : {1}",i,temp.data);
                temp = temp.Next;
            }
        }

        public void Remove()
        {
            if(head == null)
            {
                Console.WriteLine("리스트가 비었습니다");
            }
            Node temp = head;
            while(temp!=null)
            {
                if(temp.Next.Next==null)
                {
                    temp.Next = null;
                    break;
                }
            }
            
        }
    }
   
    class DoubleLinked
    {
        public Node head;
        public Node current;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.Prev = current;
                node.Next = current.Next;
                current.Next = node;
            }

            current = node;

        }

        public void Show()
        {
            Node temp = head;
            int i = 0;

            while(temp !=null)
            {
                i++;
                Console.WriteLine("{0}번째 데이터 : {1}", i, temp.data);
                temp = temp.Next;
            }
        }
        public void ReverseShow()
        {
            Node temp = current;
            int i = 0;

            while (temp != null)
            {
                i++;
                Console.WriteLine("데이터 : {0}", temp.data);
                temp = temp.Prev;
            }
        }

        public void Remove()
        {
            current.Prev.Next = null;

        }
    }

    class CircleSingleLinked
    {
        public Node head;
        public Node current;

        public void Add(int data)
        {

            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
                current.Next = node ;

            current = node;
            current.Next = head;
        }

        public void Show()
        {
            Node temp = head;
            int i = 0;
            while (i< 10)
            {
                i++;
                Console.WriteLine("{0}번째 데이터 : {1}", i, temp.data);
                temp = temp.Next;
            }
        }

       
    }

    class CircleDoubleLinked
    {
        public Node head;
        public Node current;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                
            }
            else
            {
                head.Prev = node;
                node.Next = head;
                node.Prev = current;
                current.Next = node;
                


            }
            current = node;
        

            
        }

        public void Show()
        {
            Node temp = head;
            int i = 0;

            while (i < 10)
            {
                i++;
                Console.WriteLine("{0}번째 데이터 : {1}", i, temp.data);
                temp = temp.Next;
            }
        }

        public void ReverseShow()
        {
            Node temp = current;
            int i = 0;

            while (i < 10)
            {
                i++;
                Console.WriteLine("데이터 : {0}", temp.data);
                temp = temp.Prev;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("단일 연결 리스트");
            SingleLinked link = new SingleLinked();

            link.Add(1);
            link.Add(2);
            link.Show();
            Console.WriteLine("삭제");
            link.Remove();
            link.Show();

            Console.WriteLine("이중 연결 리스트");

            DoubleLinked link2 = new DoubleLinked();

            link2.Add(1);
            link2.Add(2);
            link2.Add(3);
            link2.Show();
            link2.ReverseShow();
            Console.WriteLine("삭제");
            link2.Remove();
            link2.Show();

            Console.WriteLine("원형 단일 연결 리스트");

            CircleSingleLinked link3 = new CircleSingleLinked();

            link3.Add(1);
            link3.Add(3);
            link3.Add(10);
            link3.Show();

            Console.WriteLine("원형 이중 연결 리스트");

            CircleDoubleLinked link4 = new CircleDoubleLinked();
            link4.Add(1);
            link4.Add(2);
            link4.Add(4);
            link4.Add(10);
            link4.Add(5);
            link4.Show();
           
            Console.ReadKey();
        }
    }
}
