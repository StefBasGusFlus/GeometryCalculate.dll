using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculate.Interfaces
{
    // произвольный треугольник
    public interface ITriangular
    {
        double SideA { get; set; }

        double SideB { get; set; }

        double SideC { get; set; }
    }
}
