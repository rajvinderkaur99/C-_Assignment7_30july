using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class LinklistDemo
    {
        static void Main()
        {
            int[] num = { 4, 5, 7, 3, 9 };
            LinkedList<int> l = new LinkedList<int>(num);
            Console.WriteLine("The linkedlist values:");
            foreach (var i in l)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("List after adding 2");
            l.AddFirst(2);
            l.RemoveFirst();
            foreach (var i in l)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("after first element deleted");
            l.RemoveFirst();
            foreach (var i in l)
            {
                Console.WriteLine(i);
            }
           var newNode= l.AddLast(18);
            Console.WriteLine("add 18 in last");
            foreach (var i in l)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Add After");
            l.AddAfter(newNode, 40);
            foreach (var i in l)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Add before");
            l.AddBefore(newNode, 30);
            foreach (var i in l)
            {
                Console.WriteLine(i);
            }
            l.Remove(7);
            Console.WriteLine("LinkedList after removing a node...");
            foreach (var n in l)
            {
                Console.WriteLine(n);
            }
            l.RemoveFirst();
            Console.WriteLine("LinkedList after removing first node...");
            foreach (var n in l)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Is number 18 (node) in the list?: " + l.Contains(18));

            Console.WriteLine("find operation");

            //Console.WriteLine("Is number 30 (node) in the list?: " + l.Find(18));

           

            IEnumerator idee =  l.GetEnumerator();
            while(idee.MoveNext())
            {
                Console.WriteLine(idee.Current);
            }

            LinkedListNode<int> temp = l.Find(56);

            Console.WriteLine(temp.Value);

        }
    }
}
