using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDS
{
    // This class will have the logic to connect the node objects to create linked list structure
    public class LinkedList<T>
    {
        // Start of the linked list chain
        Node<T> head = null;
        Node<T> tail = null;

        public void AddLast(T data)
        {
            Node<T> newItem = new Node<T>();
            newItem.data = data;

            if (head == null)
            {
                // Step 1: First Item
                // head --> newItem
                // tail --> newItem
                
                // If this is the first item added to the linked list, make a new Node object and assign it to the Node head object. 
                // Also assign the next node as null since it is the first node, so there will not be a next node yet.

                head = newItem;
                tail = newItem;
            }

            else
            {
                // Step 2: Second item
                // Current tail's next node points to newItem.
                // Current tail is set to newItem.

                // O(1) performance
                tail.next = newItem;
                tail = newItem;
            }
        }

        public void AddFirst(T data)
        {
            Node<T> newItem = new Node<T>();
            newItem.data = data;

            // This is now the first item so the current head becomes the next item
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                newItem.next = head;
                head = newItem;
            }
        }

        public void RemoveNode(int nodeNumber)
        {

        }

        public void ReadAll()
        {
            Node<T> current = head;

            // Loop until we get to the last node.
            // Display the data inside it.
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }

            // Display last node data.
            Console.WriteLine(current.data);
        }
    }
}
