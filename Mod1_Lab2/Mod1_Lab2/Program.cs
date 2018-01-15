using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating an object of a Car() Class by using Type Inference called car1
            var car1 = new Car();
            //Using dot notation to call members on car1
            car1.Color = "White";
            car1.Year = 2010;
            car1.Mileage = 11000;

            var car2 = new Car("Red", 2008);

            //Access static members
            int carCount = Car.CountCars();

            //Output to the console window
            Console.WriteLine($"There are {carCount} cars on inventory right now.");
        }
    }
}
