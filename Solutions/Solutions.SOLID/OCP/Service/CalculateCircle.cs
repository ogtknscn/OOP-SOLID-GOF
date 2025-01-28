using Solutions.SOLID.OCP.Model;

namespace Solutions.SOLID.OCP.Service
{
    internal class CalculateCircle : Shape
    {
        public Circle? Circle { get; set; }
        private double CircleArea()
        {
            if (Circle == null)
            {
                throw new InvalidOperationException("Circle property is not set.");
            }

            return Math.PI * Math.Pow(Circle.GetRadius(), 2);
        }

        public override double Area()
        {
            return CircleArea();
        }

    }
}
