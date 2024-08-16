using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionLibrary
{
    public class ConversionClase
    {
       public double value { get; set; }

        public ConversionClase(double value)
        {
         this.value = value;
        }
        public double MtsToKm()
        {
            return value / 1000;
        }
        public double KmToMts()
        {
            return value * 1000;
        }

    }
}
