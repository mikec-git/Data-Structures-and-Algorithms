using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDS
{
    // This class represents a node in the linked list
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node()
        {
            next = null;
        }

        public Node(T data, Node<T> next)
        {
            this.data = data;
            this.next = next;
        }
    }
}
