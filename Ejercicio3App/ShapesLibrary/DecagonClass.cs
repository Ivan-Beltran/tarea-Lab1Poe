using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Decagons
    {
        public double side { get; set; }

        public Decagons(double side)
        {
            this.side = side;
        }
        public double CalcPerimeter()
        {
            return side * 10;
        }
        public double CalcArea()
        {
            return 7.6942 * Math.Pow(side, 2);
        }

    }
}
