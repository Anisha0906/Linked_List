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
            list = new Linkedlist();
            list.AppendNode(70);
            list.AppendNode(30);
            list.AppendNode(56);
            list = new Linkedlist();
            list.Add(56);
            list.Add(70);
            list.InsertAtParticularPosition(2, 30);
            Console.WriteLine("First element popped out of the Linked List- " + list.RemoveFirstNode().data);
            list.Display();
            Console.WriteLine("Last element popped out of the Linked List- " + list.RemoveLastNode().data);
            list.Display();
            Console.ReadLine();
        }
    }
}
