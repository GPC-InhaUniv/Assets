using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    class Linked
    {
        private int size;
        public int Count { get { return size; } }
        
        Node Head;
        Node Tail;

        public Linked()
        {
            Head = null;
            Tail = null;
            size = 0;
        }
        
        public void NodeAdd(object data)
        {
            if(Head == null)
            {
                Head = new Node();
                Tail = new Node();
                Head.Key = data;
                Tail.Key = null;
                Head.NextNode = Tail;
                size++;
                size++;
            }

            else
            {
                Node TempNode = new Node();
                TempNode.Key = data;
                TempNode.NextNode = Head.NextNode;
                Head.NextNode = TempNode;
                Head.NextNode.Key = TempNode.Key;
                size++;
            }
        }

        public string NodeDel(object data)
        {
            string text = "";
            Node TempNode = null;
            object TempKey = 0;
            if(Head == Tail)
            {
                text += "링크 리스트가 비어 있습니다!" + Environment.NewLine;
                return text;
            }
            else
            {
                TempNode = Head.NextNode;
                TempKey = Head.NextNode.Key;
                if (TempNode.NextNode == Tail)
                {
                    Head.NextNode = Tail;
                    Head.NextNode.Key = null;
                }
                else
                {
                    Head.NextNode = TempNode.NextNode;
                    Head.NextNode.Key = TempNode.NextNode.Key;
                }
                size--;
                text += "링크 리스트 삭제 완료!" + Environment.NewLine;
                return text;
            }
        }

        

        public string NodeView()
        {
            string text = "";
            Node TempNode = null;
            for (int i = 0; i < Count; i++)
            {
                if (i == 0)
                {
                    TempNode = Head;
                    text += "Key = " + TempNode.Key + Environment.NewLine;
                    TempNode = TempNode.NextNode;
                }
                else if (i < Count)
                {
                    if(TempNode.Key == null) { text += "Key = null" + Environment.NewLine; }
                    else text += "Key = " + TempNode.Key + Environment.NewLine;
                    TempNode = TempNode.NextNode;
                }
                else text += "출력 완료!" + Environment.NewLine;
            }
            return text;
        }
    }
}
