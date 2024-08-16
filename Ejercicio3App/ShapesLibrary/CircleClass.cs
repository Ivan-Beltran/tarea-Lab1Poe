using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Circles
    {
        public double radius { get; set; }
        public double pi { get; set; } = Math.PI;

        public Circles(double radius)
        {
            this.radius = radius;
            this.pi = pi;
        }

        public double CalcArea()
        {
            return pi * Math.Pow(radius, 2);
        }
        public double CalcPerimeter()
        {
            return 2 * pi * radius;
        }
    }
}
