using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    public class Person
    {
        public int age
        {
            get;
            set;
        }

        public string fname
        {
            get;
            set;
        }
            public string lname
        {
            get;
            set;
        }
       public string city
        {
            get;
            set;
        }
        public Person()
        {

        }
        public Person(int _age,string _fanme,string _lname,string _city)
        {
            age = _age;
            fname = _fanme;
            lname = _lname;
            city = _city;
                

        }
        public void Display()
        {
           
            Console.WriteLine("Name :{0} ", fname  + lname);
            Console.WriteLine("Age :{0}",age);
            Console.WriteLine("City :{0}",city);
        }
    }
    class Assignment2
    {
        static void Main()
        {
            List<Person> li = new List<Person>()
            {
                
                new Person(){ age=22, fname="Rosy",lname="Kaur",city="Kolkata"},
                new Person(){ age=12, fname="Bill",lname="Gates",city="Pune"},
                new Person(){ age=15, fname="Sweety",lname="Kaur",city="kharagpur"},
                new Person(){ age=40, fname="anjali",lname="Sharma",city="Ranchi"},
                new Person(){ age=45, fname="john",lname="singh",city="Pune"}

            };
            Console.WriteLine("Details of the 5 Person:");
            foreach (var p in li)
            {
                p.Display();

            }

            //ICollection col = Person(12, "Rosy", "Kaur", "Kolkata");
            //li.AddRange((IEnumerable<Person>)col);
            //foreach (var i in li)
            //{
            //    Console.WriteLine(i);
            //}

        }

       
    }
}
