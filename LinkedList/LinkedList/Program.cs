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
            link.AddLast(3);
            link.AddLast(4);
            link.AddFirst(0);

            link.Add(0, 55);
            link.Add(-1, 55);

            link.ReadAll();

            Console.ReadKey();
        }
    }
}
