using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum VehType
    {
        Car,
        Truck,
        Bus


    };
    public enum FuelType
    {
        Diesel,
        Petrol,
        CNG
    };

   public class Vehicle
    {
        string name;
        public string  Name
        {
            get { return name; }
            set { name = value; }
        }

        public  string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public  int  NoOfWheels;
        public int NOOFWHEELS
        {
            get { return NoOfWheels; }
            set { NoOfWheels = value; }
        }
        public string make;
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public VehType vehType;

        public VehType vtype
        {
            get { return vehType; }
            set
            {
                vehType = value;
            }
        }
        public FuelType fuelType;
        public FuelType ftype
        {
            get { return fuelType; }
            set
            {
                fuelType = value;
            }
        }

        public void Start()
        {
            Console.WriteLine("{0}  {1} has started ",name, vehType);

        }
        public void Stop()
        {
            Console.WriteLine("{0}  {1} has stopped ", name, vehType);
        }
        public Vehicle(VehType _vehtype,FuelType _fueltype,string _name,string _color,int _NoofWheels,string _make )
        { 
            vehType = _vehtype;
            fuelType=_fueltype;
            name = _name;
            color = _color;
            NoOfWheels = _NoofWheels;
            make = _make;
                
                
        }
        public Vehicle(string _name,string _color,VehType _vehtype,int _NoofWheels)
        {
            name = _name;
            color = _color;
            vehType = _vehtype;
            NoOfWheels = _NoofWheels;
            this.fuelType = FuelType.Petrol;
           
        }
        public Vehicle(string _name,string _color)
        {
            name = _name;
            color = _color;
            this.vehType = VehType.Car;
            this.NoOfWheels = 4;
            this.fuelType = FuelType.Petrol;

        }

        




    }
    public class Class1
    {
    }
}
