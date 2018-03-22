using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractice_pan
{
    class Program
    {
       

        static void Main(string[] args)
        {

            int data;
            int Answer;
            Node node = new Node();

            Console.WriteLine("연결 리스트 만들기 프로그램 - 김판주");
            node.InitLink();//리스트 초기화

            Console.WriteLine(" ");
            Console.WriteLine("값을 입력해주세요.");
            data = int.Parse(Console.ReadLine());
            node.InsertNode(data);
            Console.WriteLine("값을 입력해주세요.");
            data = int.Parse(Console.ReadLine());
            node.InsertNode(data);
            Console.WriteLine("값을 입력해주세요.");
            data = int.Parse(Console.ReadLine());
            node.InsertNode(data);
            Console.WriteLine("값을 입력해주세요.");
            data = int.Parse(Console.ReadLine());
            node.InsertNode(data);
            Console.WriteLine("값을 입력해주세요.");
            data = int.Parse(Console.ReadLine());
            node.InsertNode(data);
            Console.WriteLine(" ");

            Console.WriteLine("노드를 출력합니다.");
            node.PrintNode();

            Console.WriteLine(" ---------------------- ");
            Console.WriteLine(" 노드를 삭제하시겠습니까? \n YES - 1, NO - 2");
            Answer = int.Parse(Console.ReadLine());
            switch (Answer)
            {
                case 1:
                    Console.WriteLine(" ");
                    Console.WriteLine("노드를 삭제했습니다.");
                    Console.WriteLine(" ");
                    node.DeleteNode();
                    Console.WriteLine("재출력합니다.");
                    node.PrintNode();
                    break;
                case 2:
                    Console.WriteLine(" ");
                    Console.WriteLine("노드를 삭제하지 않았습니다.");
                    Console.WriteLine(" ");
                    Console.WriteLine("재출력합니다.");
                    node.PrintNode();
                    break;
                default: break;
            }
        }     
    }
    class Node
    {
        public int nKey;
        public Node next;

        Node head;
        Node tail;

        public void InitLink() //연결리스트 초기화
        {
            head = new Node(); //node의 시작
            tail = new Node(); //node의 끝
            head.next = tail;
            tail.next = tail; //링크의 끝 링크는 끝을 가르킴
        }
        public int InsertNode(int nKey) // 노드 삽입
        {
            Node tempNode;
            if ((tempNode = new Node()) == null)
            {
                Console.WriteLine("경고 : 메모리 부족");
                return -1;
            }
            try
            {
                tempNode.nKey = nKey;
                tempNode.next = head.next;
                head.next = tempNode;
                return nKey;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int DeleteNode() //노드 삭제
        {
            Node tempNode;
            int i;
            if (head.next == tail)
            {
                Console.WriteLine("경고 : 삭제할 메모리가 없습니다.");
                return -1;
            }
            try
            {
                tempNode = head.next;
                i = tempNode.nKey;
                head.next = tempNode.next;

                return i;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
        public void PrintNode()
        {
            Node tempNode;
            tempNode = head.next;
            while (tempNode != tail)
            {
                Console.WriteLine("{0}", tempNode.nKey);
                tempNode = tempNode.next;
            }
        }
    }
}
