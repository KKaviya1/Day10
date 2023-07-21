
using doublylinkedlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linkedlist linkedList = new Linkedlist();
            linkedList.Printlist();
            linkedList.InsertAtEnd(50);
            Console.WriteLine("after inserting item 50");
            linkedList.Printlist();
            linkedList.InsertAtEnd(67);
            Console.WriteLine("after inserting item 67");
            linkedList.Printlist();
            Console.ReadKey();










            //Linkedlist linkedList = new Linkedlist();
            //Node first = new Node
            //{
            //    data = 12,
            //    next = null,
            //    prev = null
            //};
            //linkedList.head = first;
            //Node second = new Node
            //{
            //    data = 20,
            //    next = null
            //};
            //first.next = second;
            //second.prev = first;
            //Node third = new Node
            //{
            //    data = 30,
            //    next = null
            //};
            //second.next = third;
            //third.prev = second;
            //linkedList.Printlist();
            //Console.ReadKey();

        }
    }
}
