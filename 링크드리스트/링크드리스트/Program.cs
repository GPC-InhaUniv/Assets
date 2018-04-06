using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 링크드리스트
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            Node A = new Node();
            A.data = "A";

            Node B = new Node();
            B.data = "B";

            Node C = new Node();
            C.data = "C";
            ll.AddNode(A);
            ll.AddNode(B);
            ll.AddNode(C);

            ll.printNodes();
        }
    }
}
