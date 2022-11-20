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
            Triangle tr = new Triangle();
            tr.SideA = 5;
            tr.SideB = 3;
            tr.SideC = 4;
            double expected = 6;

            //act
            double result = Square.Find(tr);

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TriangleSquare_ERRORreturned()
        {
            Triangle tr = new Triangle();
            tr.SideA = 5;
            tr.SideB = 5;
            tr.SideC = 3;

            var exception = Assert.Throws<ArgumentException>(() => Square.Find(tr));
            Assert.Equal("The triangle is not arbitrary", exception.Message);
        } 

        [Fact]
        public void RectangleSquare_FIFTEENreturned()
        {
            Rectangle rect = new Rectangle();
            rect.SideA = 5;
            rect.SideB = 3;

            double expected = 15;

            double result = Square.Find(rect);

            Assert.Equal(expected, result);
        }

        
    }
}
