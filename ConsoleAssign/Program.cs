using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssign
{
    interface IVolume
    {

        double Volume { get; }
       

    }
    interface IArea
    {
        double SurfaceArea();

       
    }
    interface ISolid:IVolume,IArea
    {
        
    }

 public abstract class Solid: ISolid
{
        const double pi = 3.142;
        double radius;
        public double Radius

        {
            get { return radius; }
            set { radius = value; }
        }

       
        public abstract double SurfaceArea();
        public abstract double Volume { get; }

        
        public Solid(double _radius)
        {
            radius = _radius;
        }
      
    }
    class Cylinder:Solid
    {
        const double pi = 3.142;
        public double height;
        public Cylinder(double _height, double _radius) : base(_radius)
        {
            height = _height;
        }

        public override double Volume
        {
            get
            {
                Console.WriteLine("Volume of Cylinder");
                return pi * Radius * Radius * height;
               
            }
        }

        public override double SurfaceArea()
        {
            var sa = 2 * pi * Radius * (Radius + height);
            return sa;
        }
    }
    class Sphere: Solid
    {
        public double height;
        const double pi = 3.142;


        public Sphere(double _height, double _radius) : base(_radius)
        {
            height = _height;
        }

        public override double Volume
        {
            get
            {
                Console.WriteLine("Volume of Sphere");
                return (4 / 3) * pi * Radius * Radius * Radius;
               
            }
        }
        public override double SurfaceArea()
        {
            var sa = 4 * pi * Radius * Radius;
            return sa;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Cylinder c = new Cylinder(7, 8);

            Console.WriteLine( "Surface Area of Cylinder{0} ",c.SurfaceArea());
            Console.WriteLine(c.Volume);

            Console.WriteLine("--------------------------------------------------------------");
            Sphere s = new Sphere(5,6);
            Console.WriteLine("Surface Area of Sphere {0}", s.SurfaceArea());
            Console.WriteLine(s.Volume);

            Console.Read();

        }
    }
}
