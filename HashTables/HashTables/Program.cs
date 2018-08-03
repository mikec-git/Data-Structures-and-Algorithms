using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class Program
    {
        static Hashtable userInfoHash;

        static void Main(string[] args)
        {
            userInfoHash = new Hashtable();

            //Adding
            for (int i = 0; i < 10; i++)
            {
                userInfoHash.Add(i, "User " + i);
            }

            //Removing
            if (userInfoHash.ContainsKey(0))
            {
                userInfoHash.Remove(0);
            }
        }
    }
}
