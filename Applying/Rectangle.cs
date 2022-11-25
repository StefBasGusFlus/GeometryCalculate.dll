using GeometryCalculate.Interfaces;

namespace Applying
{
    public class Rectangle : IRectangular
    {
        public double SideA { get; }

        public double SideB { get; }

        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }
    }
}
