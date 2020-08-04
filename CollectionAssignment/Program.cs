using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(11);
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(15);
            list.Add(16);
            Console.WriteLine("Elements in the List");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("count of the list {0}", list.Count);
           // Console.WriteLine("Copying elements to Array a1");
           // Array arr = new Object[list.Count];
           
           //list.CopyTo((int[])arr);
           // foreach (var i in arr)
           // {
           //     Console.WriteLine(i);
           // }

           int a= list.FindIndex(x => x.Equals(12));
            Console.WriteLine("finding 2nd index {0}:",a);

            int Res = list.Find(x => x.Equals(14));
            Console.WriteLine("finding 14 in the list {0}", Res);
            
            List<int> findAll = list.FindAll(x => x != 11);
            Console.WriteLine("result of findall  11");
            foreach (var i in findAll)
            {
                Console.WriteLine(i);
            }

            int Res1 = list.FindLast(x => x.Equals(13));
            Console.WriteLine("finding last 13 in the list {0}", Res1);

            int Res2 = list.FindLastIndex(x => x.Equals(13));
            Console.WriteLine("finding last Index 13 in the list {0}", Res2);



            Console.WriteLine("------------------------------------------------------");
            ICollection col = new int[] { 5, 6, 7, 8, 9 };
            list.AddRange((IEnumerable<int>)col);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine( "list after sorting");
            list.Sort();
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }


        }
    }
}
