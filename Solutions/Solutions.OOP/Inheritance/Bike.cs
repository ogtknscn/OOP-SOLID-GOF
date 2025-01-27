using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.OOP.Inheritance
{
    internal class Bike : Vehicle
    {
        private int NumberOfWheels { get; set; }

        public Bike(string brand, string model, int year, int numberOfWheels) : base(brand, model, year)
        {
            NumberOfWheels = numberOfWheels;
        }
    }
}
