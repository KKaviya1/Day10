using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListNode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Linkedlist linkedList = new Linkedlist();
            Node first = new Node
            {
                data = 12,
            };
            linkedList.head = first;
            first.next =linkedList.head;
            Node second = new Node
            {
                data = 20,
                next = null
            };
            first.next = second;
            second.next = linkedList.head;
            Node third = new Node
            {
                data = 30,
                next = null
            };
            second.next = third;
            third.next = linkedList.head;
            linkedList.Printlist();
            Console.ReadKey();

        }
    }
}
