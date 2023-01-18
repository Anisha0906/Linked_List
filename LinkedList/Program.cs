using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
     class Program
    {
        static void Main(string[] args)
        {
            Linkedlist list = new Linkedlist();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.ReadLine();
        }
    }
}
