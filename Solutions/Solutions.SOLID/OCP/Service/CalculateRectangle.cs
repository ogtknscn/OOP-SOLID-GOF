using Solutions.SOLID.OCP.Model;

namespace Solutions.SOLID.OCP.Service
{
    internal class CalculateRectangle : Shape
    {
        public Rectangle? Rectangle { get; set; }
        private double RectangleArea()
        {
            if (Rectangle == null)
            {
                throw new InvalidOperationException("Rectangle property is not set.");
            }
            return Rectangle.GetWidth() * Rectangle.GetHeight();
        }
        public override double Area()
        {
            RectangleArea();
        }
    }
}
