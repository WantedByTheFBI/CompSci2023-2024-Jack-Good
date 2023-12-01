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
    [Serializable]
    public abstract class Shapes : IComparable
    {
        // properties 
        public abstract double Area { get; }
        public abstract string[] RequiredLabels { get; set; } // Form1: determines which labels need to be visible on for a given shape
        public abstract string[] RequiredTextboxes { get; set; } // Form1: determines which textboxes need to be turned on
        public abstract string[] DimensionNames { get; set; }
        // Form 1: Used to rename the labels with the dimension names required for that shape
        // Form 2: Used for conveying a given randomshapeslist dimensions to the user

        // methods 
        public override string ToString(){ //Returns the Shape's child class name, ie: redcircle.ToString(); will return "Circle"
            return GetType().Name;}
        public int CompareTo(object obj){

            Shapes otherShape = obj as Shapes;  // cast the passed object reference into type Shape 

            return this.Area.CompareTo(otherShape.Area); // use native .NET comparison to compare Areas of this shape to passed otherShape 

        }
        public abstract double[] Dimensions(); //returns a list the contains each of the randomshapeslist dimensions, overwritten for each shape
        public string Describe() //returns a string that conveys the type of shape & it's dimensions
        {
            string shapedescription = "";
            shapedescription += this.ToString();
            double[] mydimensions = Dimensions();
            for (int i = 0; i<this.DimensionNames.Length; i++)
            {
                shapedescription += " " + DimensionNames[i] + ": " + mydimensions[i];
            }
            shapedescription += " Area: " + mydimensions.Last(); 
            return shapedescription;
        }
        public abstract void Draw(Panel panel, Point point);
    }
    [Serializable]
    public class Circles : Shapes
    {
        //constructors
        public Circles() //Form1 Relic, defines necessary controls to make visible and what to change the text off
        {
            this.RequiredLabels = new string[] { "DimensionOneLabel" };
            this.RequiredTextboxes = new string[] { "FirstDimensionTextbox" };
            this.DimensionNames = new string[] { "Radius" };
        }

        public Circles(double radius) : this()
        {
            this.Radius = radius;
        }
        public override string[] RequiredLabels { get; set; }
        public override string[] RequiredTextboxes { get; set; }
        public override string[] DimensionNames { get; set; }
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
        public override void Draw(Panel panel, Point point)
        {
            Graphics graphic = panel.CreateGraphics();  //Necessary for drawing the randomshapeslist
            Pen pen = new Pen(Color.Black, 2);
            graphic.DrawEllipse(pen, point.X-(int)this.Radius/2, point.Y-(int)this.Radius/2,(float)this.Radius, (float)this.Radius); //To keep the randomshapeslist centered on mouse click, it subtracts half the radii from x and y
        }
    }
    [Serializable]
    public class Trapezoids : Shapes 
    {
        //constructors
        public Trapezoids() //defines control related data for Form 1
        {
            this.RequiredLabels = new string[] { "DimensionOneLabel", "DimensionTwoLabel", "DimensionThreeLabel" };
            this.RequiredTextboxes = new string[] { "FirstDimensionTextbox", "SecondDimensionTextbox", "ThirdDimensionTextbox" };
            this.DimensionNames = new string[] { "Base_1", "Base_2", "Height" };
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
        public override string[] DimensionNames { get; set; }
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
        public override void Draw(Panel panel, Point point)
        {
            throw new NotImplementedException(); //since this shape isn't being drawn, but it is a part of the parent class,
                                                 //it just excepts it rather than bricking when this gets called
        }
    }
    [Serializable]
    public class Ellipse : Shapes
    {
        //constructors
        public Ellipse() //Form 1 related control data
        {
            this.RequiredLabels = new string[] { "DimensionOneLabel", "DimensionTwoLabel" };
            this.RequiredTextboxes = new string[] { "FirstDimensionTextbox", "SecondDimensionTextbox" };
            this.DimensionNames = new string[] { "Major_Radius", "Minor_Radius" };
        }
        public Ellipse(double major_radius, double minor_radius) : this()
        {
            this.Major_Radius = major_radius;
            this.Minor_Radius = minor_radius;
        }
        //properties
        public override string[] RequiredLabels { get; set; }
        public override string[] RequiredTextboxes { get; set; }
        public override string[] DimensionNames { get; set; }
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
        public override void Draw(Panel panel, Point point)//same as circle
        {
            Graphics graphic = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);
            graphic.DrawEllipse(pen, point.X-(int)this.Major_Radius / 2, point.Y-(int)this.Minor_Radius / 2, (float)this.Major_Radius, (float)this.Minor_Radius);
        }
    }
    [Serializable]
    public class Rectangles : Shapes
    {
        //constructors
        public Rectangles()
        {
            this.RequiredLabels = new string[] { "DimensionOneLabel", "DimensionTwoLabel" };
            this.RequiredTextboxes = new string[] { "FirstDimensionTextbox", "SecondDimensionTextbox" };
            this.DimensionNames = new string[] { "Length", "Height" };
        }

        public Rectangles(double length, double height) : this()
        {
            this.Length = length;
            this.Height = height;
        }
        //properties
        public override string[] RequiredLabels { get; set; }
        public override string[] RequiredTextboxes { get; set; }
        public override string[] DimensionNames { get; set; }
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
        public override void Draw(Panel panel, Point point)
        {
            Graphics graphic = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);
            graphic.DrawRectangle(pen, point.X-(int)this.Length/2, point.Y-(int)this.Height/2, (float)this.Length, (float)this.Height);
        }
    }
}