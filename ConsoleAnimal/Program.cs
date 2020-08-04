using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class Program
    {
        static void Main(string[] args)
        {

            int j = 0;

            string[] MyArray = { "Zebra", "Ant", "Owl", "Lion" };
            Console.WriteLine("------------------------For Loop-----------------------------");
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }
            Console.WriteLine("---------------For Each------------------------"); 
            foreach (var i in MyArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------------------do while loop------------------------");
            do
            {

                Console.WriteLine(MyArray[j]);
                j++;

            }

            while (j < MyArray.Length);
            
            Console.WriteLine("-----------------------While loop---------------------------------------");

            while (j < MyArray.Length)
            {
                Console.WriteLine(MyArray[j]);
                j++;
            }

            Console.WriteLine("-----------------------Sorted Array--------------------------------");
            Array.Sort(MyArray);
            foreach (var i in MyArray)
            {
                Console.WriteLine(i);
            }

            string[] Animals = { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            string[] Places = { "Africa", "New Zealand", "Jamaica", "India" };

            Console.WriteLine("-----------------------Sorted Array Animals--------------------------------");
            Array.Sort(Animals);
            foreach (var i in Animals)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------Sorted Array Places--------------------------------");
            Array.Sort(Places);
            foreach (var i in Places)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }
     }
}

