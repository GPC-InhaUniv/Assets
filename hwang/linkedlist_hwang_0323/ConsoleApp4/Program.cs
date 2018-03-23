using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Node
    {
        public int Key;
        public Node Next;
    }
    



    class Program
    {

        //링크드리스트 초기화//
        Node listHead;
        Node listTail;
        public void InitiateLink()
        {
            listHead = new Node();
            listTail = new Node();
            listHead.Next = listTail;
            listTail.Next = listTail;
        }


        //노드 삽입//
        public int InsertNode(int key)
        {
            Node tempNode;
            if((tempNode = new Node())== null)
            {
                Console.WriteLine("메모리 부족");
                return -1;
            }
            try
            {
                tempNode.Key = key;
                tempNode.Next = listHead;
                listHead = tempNode;
                return key;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        //노드 삭제//
        public int DeleteNode()
        {
            Node tempNode;
            int i;

            if (listHead == listTail)
            {
                Console.WriteLine("삭제할 메모리가 없습니다.");
                return -1;
            }
            try
            {
                tempNode = listHead.Next;
                i = tempNode.Key;
                listHead.Next = tempNode.Next;

                return i;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            
            
        }

        //출력 //
        public void PrintNode()
        {
            Node tempNode;
            tempNode = listHead.Next;
            while(tempNode != listTail)
            {
                Console.WriteLine("{0}", tempNode.Key);
                tempNode = tempNode.Next;
            }
        }



        static void Main(string[] args)
        {
            Program program = new Program();

            program.InitiateLink();
            program.InsertNode(1);
            program.InsertNode(1);
            program.InsertNode(3);
            program.InsertNode(5);


            //program.DeleteNode();
            program.PrintNode();




            Console.ReadKey();
        }
    }




}
