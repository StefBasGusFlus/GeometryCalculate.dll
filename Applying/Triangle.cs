using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryCalculate.Interfaces;

namespace Applying
{
    public class Triangle : ITriangular
    {
        public double SideA { get; set; }

        public double SideB { get; set; }

        public double SideC { get; set; }
    }
}
