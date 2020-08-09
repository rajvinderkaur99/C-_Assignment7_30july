using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace ConSystemCollectionSpecialized
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("********************************String Collection*******************************************");
            StringCollection s1 = new StringCollection();
            s1.Add("rosy");
            s1.Add("sweety");
            s1.Add("anjali");
            s1.Add("kavya");
            Console.WriteLine("Elements in string collection");
            foreach (var i in s1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("count of string{0}", s1.Count);
            var a1 = new string[s1.Count];
            Console.WriteLine("copying the string list to array a1");

            s1.CopyTo(a1, 0);
            foreach (var i in a1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("using Ienumerator");
            StringEnumerator ie = s1.GetEnumerator();
            while(ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }
            Console.WriteLine("insterting a string");
            s1.Insert(2, "swagata");
            foreach (var i in s1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*******************************************String Dictionary***********************************************");
            StringDictionary s2 = new StringDictionary();
            s2.Add("one", "first");
            s2.Add("two", "second");
            s2.Add("three", "third");
            foreach  (DictionaryEntry ide in s2)

            {
                Console.WriteLine("{0}={1}",ide.Key,ide.Value);
            }
            DictionaryEntry[] a2 = new
                DictionaryEntry[s2.Count];
            Console.WriteLine("copying the string list to array a1");
            s2.CopyTo(a2, 0);
            foreach (DictionaryEntry ide in a2)

            {
                Console.WriteLine("{0}={1}", ide.Key, ide.Value);
            }
            Console.WriteLine("using Ienumerator");
            StringEnumerator id = s1.GetEnumerator();
            DictionaryEntry de;

            while (id.MoveNext())
            {
                //de = (DictionaryEntry)id.Current;
       
                Console.WriteLine("{0}:{1}", de.Key,de.Value);
            }
            Console.WriteLine("Removing two");
            s2.Remove("two");

            foreach (DictionaryEntry ide in s2)

            {
                Console.WriteLine("{0}={1}", ide.Key, ide.Value);
            }

           
            
           











        }



    }
}
