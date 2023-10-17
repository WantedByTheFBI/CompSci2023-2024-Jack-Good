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
        public string[] LabelControls { get; set; }
        public string[] TextBoxControls { get; set; }
        public string[] LabelDimensionNames { get; set; }
        public string[][] LabelTextToggles { get; set; }
        //methods
        public void FillLabelTextToggles()
        {
            for (int i = 0; i < this.LabelControls.Length; i++)
            {
                string[] LabelControlNameCombo = { this.LabelControls[i], this.LabelDimensionNames[i] };
                this.LabelTextToggles.Append(LabelControlNameCombo);
            }
        }
        

    // switch case is just brought into the shape class


}
    public class Circles : Shapes
    {
        //constructor
        public Circles()
        {
            this.LabelControls = new string[] { "DimensionOneLabel" };
            this.TextBoxControls = new string[] { "DimensionOneTextbox" };
            this.LabelDimensionNames = new string[] { "Radius" };
            this.LabelTextToggles = new string[][] { };
            FillLabelTextToggles();
        }
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
            this.LabelControls = new string[] { "DimensionOneLabel", "DimensionTwoLabel", "DimensionThreeLabel" };
            this.TextBoxControls = new string[] { "DimensionOneTextbox", "SecondDimensionTextbox", "DimensionThreeTextbox" };
            this.LabelDimensionNames = new string[] { "Base 1", "Base 2", "Height" };
            this.LabelTextToggles = new string[][] { };
            FillLabelTextToggles();
        }
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
            this.LabelControls = new string[] { "DimensionOneLabel", "DimensionTwoLabel" };
            this.TextBoxControls = new string[] { "DimensionOneTextbox", "SecondDimensionTextbox" };
            this.LabelDimensionNames = new string[] { "Major Radius", "Minor Radius" };
            this.LabelTextToggles = new string[][] { };
            FillLabelTextToggles();
        }
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
            this.LabelControls = new string[] { "DimensionOneLabel", "DimensionTwoLabel" };
            this.TextBoxControls = new string[] { "DimensionOneTextbox", "SecondDimensionTextbox" };
            this.LabelDimensionNames = new string[] { "Length", "Height" };
            this.LabelTextToggles = new string[][] { };
            FillLabelTextToggles();
        }
        public double Base { get; set; }
        public double Height { get; set; }
        //methods
        public double Area
        {
            get { return (Base * Height); }
        }
    }
}