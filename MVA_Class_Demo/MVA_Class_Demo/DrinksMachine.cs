using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVA_Class_Demo
{
    class DrinksMachine
    {
        //The following statements declare private member variables
        public string _location;
        public string _make;
        public string _model;

        //The following statements declare public methods;
        public void MakeCappuccino()
        {
            //Method logic goes here
            Console.WriteLine("The Cappuccino has been made.");
        }

        public void MakeExpresso()
        {
            //Method logic goes here
        }
    }
}
