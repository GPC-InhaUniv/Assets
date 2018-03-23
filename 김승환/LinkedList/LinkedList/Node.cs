using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public Node Previous;
        public Node Next;

        private string elem;
        public string Elem
        {
            get => elem;
        }

        public Node()
        {

        }

        public Node(string elem)
        {
            this.elem = elem;
        }
    }
}
