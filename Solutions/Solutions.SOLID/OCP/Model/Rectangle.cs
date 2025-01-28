using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.SOLID.OCP.Model
{
    internal class Rectangle
    {
        private double Width { get; set; }
        private double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double GetWidth()
        {
            return Width;
        }
        public double GetHeight()
        {
            return Height;
        }
    }
}
