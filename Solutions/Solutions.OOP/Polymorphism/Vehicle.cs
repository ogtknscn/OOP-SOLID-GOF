using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.OOP.Polymorphism
{
    internal class Vehicle
    {
        private string Brand { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public virtual void Start()
        {
            Console.WriteLine("Vehicle started");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle stopped");
        }
    }
}
