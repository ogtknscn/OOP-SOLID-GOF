using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.SOLID.OCP.Model
{
    internal class Square
    {
        private double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }
        public double GetSide()
        {
            return Side;
        }
    }
}
