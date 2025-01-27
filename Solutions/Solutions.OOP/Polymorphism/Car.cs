using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.OOP.Polymorphism
{
    internal class Car : Vehicle
    {
        private int NumberOfDoors { get; set; }
        private int NumberOfWheels { get; set; }

        public Car(string brand, string model, int year, int numberOfDoors, int numberOfWheels) : base(brand, model, year)
        {
            NumberOfDoors = numberOfDoors;
            NumberOfWheels = numberOfWheels;
        }

        public override void Start()
        {
            Console.WriteLine("Car started");
        }

        public override void Stop()
        {
            Console.WriteLine("Car stopped");
        }
    }
}
