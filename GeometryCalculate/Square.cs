using System;
using GeometryCalculate.Interfaces;

namespace GeometryCalculate
{
    public static class Square
    {
        public static double Find(ITriangular figure)
        {
            if (figure.SideA == figure.SideB || figure.SideB == figure.SideC || figure.SideC == figure.SideA)
                throw new ArgumentException("The triangle is not arbitrary");

            double p = (figure.SideA + figure.SideB + figure.SideC) / 2;

            double result = Math.Sqrt(p * (p - figure.SideA) * (p - figure.SideB) * (p - figure.SideC));

            return result;
        }

        public static double Find(ITriangularIsosceles figure)
        {
            double result = (figure.LegA * figure.LegB) / 2;

            return result;
        }

        public static double Find(IRegularTriangular figure)
        {
            double result = Math.Pow(figure.RightSide, 2) * Math.Sqrt(3) / 4;

            return result;
        }

        public static double Find(IRectangular figure)
        {
            double result = figure.SideA * figure.SideB;

            return result;
        }

        public static double Find(ICircular figure)
        {
            double result = Math.PI * Math.Pow(figure.Radius, 2);

            return result;
        }
    }
}
