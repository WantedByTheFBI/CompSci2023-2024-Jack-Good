using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompSci2023_2024_Jack_Good
{
    public class Shapes
    {
        //properties
        public string[] RequiredLabels { get; set; }
        public string[] RequiredTextboxes { get; set; }
        public string[] LabelDimensionNames { get; set; }
        public string[][] LabelTextToggles { get; set; }
}
    public class Circles : Shapes
    {
        //constructor
        public Circles()
        {
            this.RequiredLabels = new string[] { "DimensionOneLabel" };
            this.RequiredTextboxes = new string[] { "FirstDimensionTextbox" };
            this.LabelDimensionNames = new string[] { "Radius" };
        }
        //properties
        public double Radius { get; set; }
        //methods
        public double Area
        {
            get { return (Math.PI * Math.Pow(this.Radius, 2D)); }
        }
    }

    public class Trapezoids : Shapes 
    {
        //constructors
        public Trapezoids()
        {
            this.RequiredLabels = new string[] { "DimensionOneLabel", "DimensionTwoLabel", "DimensionThreeLabel" };
            this.RequiredTextboxes = new string[] { "FirstDimensionTextbox", "SecondDimensionTextbox", "ThirdDimensionTextbox" };
            this.LabelDimensionNames = new string[] { "Base 1", "Base 2", "Height" };
        }
        //properties
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }
        //methods
        public double Area
        {
            get { return ((Base1 + Base2) / 2 * Height); }
        }
    }

    public class Ellipse : Shapes
    {
        //constructors
        public Ellipse()
        {
            this.RequiredLabels = new string[] { "DimensionOneLabel", "DimensionTwoLabel" };
            this.RequiredTextboxes = new string[] { "FirstDimensionTextbox", "SecondDimensionTextbox" };
            this.LabelDimensionNames = new string[] { "Major Radius", "Minor Radius" };
        }
        //properties
        public double MajorRadius { get; set;}
        public double MinorRadius { get; set;}
        //methods
        public double Area
        {
            get { return (MajorRadius * MinorRadius * Math.PI); }
        }
    }
    public class Rectangle : Shapes
    {
        //constructors
        public Rectangle()
        {
            this.RequiredLabels = new string[] { "DimensionOneLabel", "DimensionTwoLabel" };
            this.RequiredTextboxes = new string[] { "FirstDimensionTextbox", "SecondDimensionTextbox" };
            this.LabelDimensionNames = new string[] { "Length", "Height" };
        }
        //properties
        public double Base { get; set; }
        public double Height { get; set; }
        //methods
        public double Area
        {
            get { return (Base * Height); }
        }
    }
}