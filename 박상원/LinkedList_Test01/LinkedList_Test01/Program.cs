using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Node nodeA = new Node();
            Node nodeB = new Node();
            Node nodeC = new Node();

            nodeA.data = "Anode";
            nodeB.data = "Bnode";
            nodeC.data = "Cnode";

            list.AddNode(nodeA);
            list.AddNode(nodeB);
            list.AddNode(nodeC);

            list.printNodes();

            Console.ReadKey();
        }
    }
}
