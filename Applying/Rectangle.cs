using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryCalculate.Interfaces;

namespace Applying
{
    public class Rectangle : IRectangular
    {
        public double SideA { get; set; }

        public double SideB { get; set; }
    }
}
