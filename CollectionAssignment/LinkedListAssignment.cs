using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class LinkedListAssignment
    {
        static void Main()
        {
            string[] str = {"quick","fox","the","lazy"};
            LinkedList<string> list = new LinkedList<string>(str);
            //list.AddFirst("the");
            LinkedListNode<string> temp = list.Find("quick");
            LinkedListNode<string> temp1 = list.Find("fox");
           
            list.AddFirst("the");
            list.AddAfter(temp,"brown");
            var newNode=list.AddAfter(temp1, "jumps");
            list.AddAfter(newNode, "over");
            list.AddLast("fox");

            
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}
