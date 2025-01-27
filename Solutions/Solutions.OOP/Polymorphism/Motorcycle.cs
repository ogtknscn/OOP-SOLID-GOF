using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.OOP.Polymorphism
{
    internal class Motorcycle : Vehicle
    {
        private int NumberOfWheels { get; set; }
        public Motorcycle(string brand, string model, int year, int numberOfWheels) : base(brand, model, year)
        {
            NumberOfWheels = numberOfWheels;
        }

        public override void Start()
        {
            Console.WriteLine("Motorcycle started");
        }

        public override void Stop()
        {
            Console.WriteLine("Motorcycle stopped");
        }
    }
}
