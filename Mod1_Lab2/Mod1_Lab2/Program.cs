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
            var car1 = new Car();

            car1.Color = "White";
            car1.Year = 2010;
            car1.Mileage = 11000;

            var car2 = new Car("Red", 2008);

            int carCount = Car.CountCars();

            Console.WriteLine($"There are {carCount} cars on inventory right now.");
        }
    }

    //Declaring the Car() Class
    //This class 3 properties: Color, Year, Mileage
    public class Car
    {
        //Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        //Creates integer variable called "instances" and assigns value to 0
        private static int _instances = 0;

        //Adding a Constructor
        //This constructor instantiates a Car() object while only having the car's color and year information available
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            //Evey time the constuctors runs, increment "instances"
            _instances++;
        }

        //Adding another Constructor
        //This constructor instantiates a Car() object while only having the car's year and mileage information available
        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            //Evey time the constuctors runs, increment "instances"
            _instances++;
        }


        public Car()
        {
            //Everytime the constructor runs, increments "intances"
            _instances++;
        }

        //Declare static member
        public static int CountCars()
        {
            return _instances;
        }
    }


}
