using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConStringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            
            Console.WriteLine("Enter First String");
           str1= Console.ReadLine();
            Console.WriteLine("Enter Second String");
            str2 = Console.ReadLine();

            int option;
            Console.WriteLine("Enter Option");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Concatenate Strings");
                  
                   string str3= string.Concat( str1, str2);
                    Console.WriteLine(str3);
                    break;
                case 2:
                    Console.WriteLine("Length of Two String");
                   var s= str1.Length;
                    var s1 = str2.Length;
                    Console.WriteLine("{0},{1}", s, s1);
                    break;
                case 3:
                    Console.WriteLine("SubString");
                   var s2= str1.Substring(2);
                    var s3=str2.Substring(3);
                    Console.WriteLine("{0},{1}", s2, s3);

                    break;
                case 4:
                    Console.WriteLine("Replace");
                  var s4=  str1.Replace( 'o','p');
                   var s5= str2.Replace('i','l');
                    Console.WriteLine(s4);
                    Console.WriteLine(s5);

                    break;
                case 5:
                    Console.WriteLine("Upper Case");
                    var s6 = str1.ToUpper();
                    var s7 = str2.ToUpper(); Console.WriteLine(s6);
                    Console.WriteLine(s7);
                    break;
                case 6:
                    Console.WriteLine("Lower Case");
                    var s8 = str1.ToLower();
                    var s9 = str2.ToLower(); Console.WriteLine(s8);
                    Console.WriteLine(s9);
                    break;
                case 7:
                    Console.WriteLine("Trim");
                    Console.WriteLine( str1.Trim());
                    Console.WriteLine(str2.Trim());
                    break;
                    case 8:
                    Console.WriteLine("Split");
                    var res = str1.Split(new char[] { ' ', 'o' });
                    var res1 = str2.Split(new char[] { ' ', 'a' });
                    foreach (var r in res)
                    {
                        Console.WriteLine(r);
                    }
                    foreach (var r1 in res1)
                    {
                        Console.WriteLine(r1);
                    }
                    break;
                default:
                    Console.WriteLine("Make a Choice Again");
                    break;

                   
                    

            }
        }
    }
}
