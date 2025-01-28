namespace Solutions.SOLID.OCP.Model
{
    internal class Circle(double radius)
    {
        private double Radius { get; set; } = radius;

        public double GetRadius()
        {
            return Radius;
        }
    }
}
