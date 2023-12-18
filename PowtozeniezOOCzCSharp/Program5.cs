using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowtozeniezOOCzCSharp
{
    class Car
    {
        public string? Name { get; set; }
        public string? DateProduction { get; set; }
    }
    class CarShop
    {
        public Car[] Cars = new Car[3];
        public Car this[string Name]
        {
            get
            {
                foreach (Car car in Cars)
                {
                    if (car.Name == Name)
                    {
                        return car;
                    }
                }
                return null;
            }
        }

        public CarShop()
        {
            Car auto1 = new Car();
            Car auto2 = new Car();
            Car auto3 = new Car();

            auto1.Name = "Ford";
            auto2.Name = "Opel";
            auto3.Name = "Toyota";

            Cars[0] = auto1;
            Cars[1] = auto2;
            Cars[2] = auto3;
        }
    }
    /*
    class Program5
    {
        static void Main(string[] args)
        {
            CarShop sklepZAutami = new CarShop();

            var Autko = sklepZAutami["Toyota"];
            Console.WriteLine(Autko.Name);
        }
    }
    */
}
