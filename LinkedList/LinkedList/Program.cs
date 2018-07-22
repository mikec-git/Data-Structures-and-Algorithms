using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDS
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> link = new LinkedList<int>();
            link.AddLast(1);
            link.AddLast(2);

            link.AddFirst(0);

            link.AddLast(3);
            link.AddLast(4);
            link.AddLast(5);


            link.Remove(4);

            link.ReadAll();

            Console.WriteLine("\n" + link.Count);

            link.Clear();

            Console.ReadKey();
        }
    }
}
