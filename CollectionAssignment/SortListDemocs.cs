using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class SortListDemocs
    {
        static void Main()
        {
            SortedList<int, int> sort = new SortedList<int, int>();
            sort.Add(1, 11);
            sort.Add(2, 14);
            sort.Add(3, 16);
            sort.Add(4, 13);
            sort.Add(5, 17);
            sort.Add(6, 12);
            foreach (KeyValuePair<int,int>ie in sort)
            {
                Console.WriteLine(ie.Key+":" + ie.Value);
            }

           if(!sort.ContainsKey(8))
            {
                sort.Add(8, 20);
                Console.WriteLine("Value added for key = : {0}",
                    sort[8]);

            }
            IDictionaryEnumerator ide = (IDictionaryEnumerator)sort.GetEnumerator();
            while(ide.MoveNext())
            {
                Console.WriteLine(ide.Key + ":" + ide.Value);
            }

        }
    }
}
