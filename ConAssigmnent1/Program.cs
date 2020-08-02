using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConAssigmnent1
{
    abstract class Quadrilateral
    {
        //public int length;


        abstract public int Area(int length);
    }
    class Square : Quadrilateral
    {

        public override int Area(int length)
        {
            return length * length;

        }

    }
    class Rectangle : Quadrilateral
    {
        public int length;
        public int breadth;
        public Rectangle(int _breadth)
        {
            breadth = _breadth;
        }

        public override int Area(int length)
        {
            return length * breadth;

        }

        public int area;

        public int IsSquare
        {
            get { return area; }
            set
            {
                if ((area / length) == breadth)
                {
                    area = value;
                }
                else
                {
                    Console.WriteLine("The given rectangle is a Square ");
                }

                
            }

        }
    }
        class Program
        {
            static void Main(string[] args)
            {

                Square s = new Square();
                Console.WriteLine("Area of Square:  {0}", s.Area(4));
                Rectangle r = new Rectangle(6);
          
                Console.WriteLine("Area of Rectangle:  {0}", r.Area(5));





                Console.ReadLine();
            }
        }



 }

