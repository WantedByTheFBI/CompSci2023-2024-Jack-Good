using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic;

namespace CompSci2023_2024_Jack_Good
{
    public abstract class Shapes
    {

        // properties 

        public abstract double Area { get; }
        public abstract string[] RequiredLabels { get; set; }
        public abstract string[] RequiredTextboxes { get; set; }
        public abstract string[] LabelDimensionNames { get; set; }

        // methods 
        public override string ToString()
        {
            return GetType().Name;
        }
        public abstract double[] Dimensions();
        public string Describe()
        {
            string shapedescription = "";
            shapedescription += this.ToString();
            double[] mydimensions = Dimensions();
            for (int i = 0; i<this.LabelDimensionNames.Length; i++)
            {
                shapedescription += " " + LabelDimensionNames[i] + ": " + mydimensions[i];
            }
            shapedescription += " Area: " + mydimensions.Last(); 
            return shapedescription;
        }
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

        public Circles(double radius) : this()
        {
            this.Radius = radius;
        }
        public override string[] RequiredLabels { get; set; }
        public override string[] RequiredTextboxes { get; set; }
        public override string[] LabelDimensionNames { get; set; }
        //properties
        public double Radius { get; set; }
        //methods
        public override double Area
        {
            get { return (Math.PI * Math.Pow(this.Radius, 2D)); }
        }
        public override double[] Dimensions()
        {
            double[] mydimensions = new double[2];
            mydimensions[0] = this.Radius;
            mydimensions[1] = this.Area;
            return mydimensions;
        }
    }

    public class Trapezoids : Shapes 
    {
        //constructors
        public Trapezoids()
        {
            this.RequiredLabels = new string[] { "DimensionOneLabel", "DimensionTwoLabel", "DimensionThreeLabel" };
            this.RequiredTextboxes = new string[] { "FirstDimensionTextbox", "SecondDimensionTextbox", "ThirdDimensionTextbox" };
            this.LabelDimensionNames = new string[] { "Base_1", "Base_2", "Height" };
        }
        public Trapezoids(double base1, double base2, double height) : this()
        {
            this.Base_1 = base1;
            this.Base_2 = base2;
            this.Height = height;
        }
        //properties
        public override string[] RequiredLabels { get; set; }
        public override string[] RequiredTextboxes { get; set; }
        public override string[] LabelDimensionNames { get; set; }
        public double Base_1 { get; set; }
        public double Base_2 { get; set; }
        public double Height { get; set; }
        //methods
        public override double Area
        {
            get { return ((Base_1 + Base_2) / 2 * Height); }
        }
        public override double[] Dimensions()
        {
            double[] mydimensions = new double[4];
            mydimensions[0] = this.Base_1;
            mydimensions[1] = this.Base_2;
            mydimensions[2] = this.Height;
            mydimensions[3] = this.Area;
            return mydimensions;
        }
    }

    public class Ellipse : Shapes
    {
        //constructors
        public Ellipse()
        {
            this.RequiredLabels = new string[] { "DimensionOneLabel", "DimensionTwoLabel" };
            this.RequiredTextboxes = new string[] { "FirstDimensionTextbox", "SecondDimensionTextbox" };
            this.LabelDimensionNames = new string[] { "Major_Radius", "Minor_Radius" };
        }
        //properties
        public override string[] RequiredLabels { get; set; }
        public override string[] RequiredTextboxes { get; set; }
        public override string[] LabelDimensionNames { get; set; }
        public double Major_Radius { get; set;}
        public double Minor_Radius { get; set;}
        //methods
        public override double Area
        {
            get { return (Major_Radius * Minor_Radius * Math.PI); }
        }
        public override double[] Dimensions()
        {
            double[] mydimensions = new double[3];
            mydimensions[0] = this.Major_Radius;
            mydimensions[1] = this.Minor_Radius;
            mydimensions[2] = this.Area;
            return mydimensions;
        }
    }
    public class Rectangles : Shapes
    {
        //constructors
        public Rectangles()
        {
            this.RequiredLabels = new string[] { "DimensionOneLabel", "DimensionTwoLabel" };
            this.RequiredTextboxes = new string[] { "FirstDimensionTextbox", "SecondDimensionTextbox" };
            this.LabelDimensionNames = new string[] { "Length", "Height" };
        }

        public Rectangles(double length, double height) : this()
        {
            this.Length = length;
            this.Height = height;
        }
        //properties
        public override string[] RequiredLabels { get; set; }
        public override string[] RequiredTextboxes { get; set; }
        public override string[] LabelDimensionNames { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        //methods
        public override double Area
        {
            get { return (Length * Height); }
        }
        public override double[] Dimensions()
        {
            double[] mydimensions = new double[3];
            mydimensions[0] = this.Length;
            mydimensions[1] = this.Height;
            mydimensions[2] = this.Area;
            return mydimensions;
        }
    }
}