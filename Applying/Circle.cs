using GeometryCalculate.Interfaces;

namespace Applying
{
    public class Circle : ICircular
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;   
        }
    }
}
