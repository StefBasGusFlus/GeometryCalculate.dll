using System;
using Xunit;
using Applying;

namespace GeometryCalculate.Tests
{
    public class GeometryCalcTest
    {
        [Fact]
        public void TriangleSquare_SIXreturned()
        {
            // arrange
            Triangle tr = new Triangle(5, 3, 4);
            double expected = 6;

            //act
            double result = Square.Find(tr);

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TriangleSquare_ERRORreturned()
        {
            Triangle tr = new Triangle(5, 5, 3);

            var exception = Assert.Throws<ArgumentException>(() => Square.Find(tr));
            Assert.Equal("The triangle is not arbitrary", exception.Message);
        } 

        [Fact]
        public void RectangleSquare_FIFTEENreturned()
        {
            Rectangle rect = new Rectangle(5, 3);

            double expected = 15;

            double result = Square.Find(rect);

            Assert.Equal(expected, result);
        }
    }
}
