using Solutions.SOLID.OCP.Model;

namespace Solutions.SOLID.OCP.Service
{
    internal class CalculateSquare
    {
        public Square? Square { get; set; }
        private double SquareArea()
        {
            if (Square == null)
            {
                throw new InvalidOperationException("Square property is not set.");
            }
            return Math.Pow(Square.GetSide(), 2);
        }
        public double Area()
        {
            return SquareArea();
        }
    }
}
