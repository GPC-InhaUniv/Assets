using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    class Node<T>
    {
        public T value;
        public Node<T> next;
        public Node<T> prev;

        public Node()
        {
            next = null;
            prev = null;
            value = default(T);
        }
        
       
        
            
    }
}
