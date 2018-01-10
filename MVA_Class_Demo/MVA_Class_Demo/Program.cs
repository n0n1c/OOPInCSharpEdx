using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine();
            myMachine._location = "Kitchen";
            myMachine._make = "DM1000";

            Console.WriteLine(myMachine._location);
            myMachine.MakeCappuccino();
        }
    }
}
