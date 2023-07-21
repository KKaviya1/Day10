
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListNode
{
    public class Linkedlist
    {
        public Node head;
        public Linkedlist()
        {
            head = null;
        }
        public void Printlist()
        {
            Node temp = new Node();
            temp = this.head;
            if (temp != null)
            {
                Console.WriteLine("The List Contains");
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                    if (temp == this.head)
                    { break; }
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("The linked List is empty");
            }
        }
    }
}

