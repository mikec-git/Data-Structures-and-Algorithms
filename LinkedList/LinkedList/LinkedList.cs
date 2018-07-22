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
        private Node<T> head;
        private Node<T> tail;

        public LinkedList()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public bool Empty () => Count == 0;

        public int Count { get; private set; }

        public void Add(int index, T data)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index: " + index);
            else if (index > Count)
                index = Count;

            Node<T> current = head;

            if (Empty() || index == 0)
                head = new Node<T>(data, head);
            else
            {
                // 0    1    2    3   4
                // A -> B -> C -> D
                for (int i = 0; i < index - 1; i++)
                    current = current.next;

                current.next = new Node<T>(data, current.next);
            }

            Count++;
        }

        public void AddLast(T data)
        {
            Node<T> newItem = new Node<T>(data, null);

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

            Count++;
        }

        public void AddFirst(T data)
        {
            Node<T> newItem = new Node<T>(data, null);

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

            Count++;
        }

        public void Remove(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index: " + index);
            else if (index > Count)
                index = Count;

            if (Empty())
                return;

            Node<T> current = head;

            if (index == 0)
                head = current.next;
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.next;

                current.next = current.next.next;
            }
            Count--;
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

        public void Clear()
        {
            Console.Write("\nType \"CLEAR\" to clear the list or \"BACK\" to return: ");
            
            while (true)
            {
                string clearCheck = Console.ReadLine();

                if (clearCheck == "CLEAR")
                {
                    head = null;
                    tail = null;
                    Count = 0;
                }
                else if (clearCheck == "BACK")
                    return;
                else
                    Console.WriteLine("Incorrect input, try again.");
            }
        }
    }
}
