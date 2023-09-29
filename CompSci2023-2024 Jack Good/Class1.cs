using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompSci2023_2024_Jack_Good
{
    internal class Shapes
    {
    }

    public class Circles
    {
        // constructors
        public double Radius { get; set; }
        public double Area
        {
            get { return (Math.PI * Math.Pow(this.Radius, 2D)); }
            }


    }
}
