using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();

            car1.Color = "White";
            car1.Year = 2010;
            car1.Mileage = 11000;

            Console.WriteLine("The car is painted {0}, was built in {1}, and has {2} miles on it.", car1.Color, car1.Year, car1.Mileage);
        }
    }

    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
    }
}
