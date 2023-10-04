using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompSci2023_2024_Jack_Good
{

    public class Circles
    {
        public double Radius { get; set; }
        public double Area
        {
            get { return (Math.PI * Math.Pow(this.Radius, 2D)); }
            }


    }

    public class Trapezoids
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }

        public double Area
        {
            get { return ((Base1 + Base2) / 2 * Height); }
        }
    }

    public class Elipse
}

