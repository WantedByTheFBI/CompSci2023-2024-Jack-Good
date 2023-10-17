using System;
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

        // switch case is just brought into the shape class
        
        
    }
    public class Circles : Shapes
    {
        //constructor
        public Circles()
        {
            this.LabelControls = new string[] { "Dimension1" };
            this.TextBoxControls = new string[] { "FirstDimensionInput" };
            this.LabelDimensionNames = new string[] { "Radius" };
            this.LabelTextToggles = new string[][] { };
            foreach (string label in LabelControls)
            {
                string[] LabelControlNameCombo = { label, LabelDimensionNames[LabelControls.GetLowerBound(string label)] };
                this.LabelTextToggles.Append(LabelControlNameCombo);
            }
              

        }
        // label controls should inherit and be filled in with which labels get turned on
        // etc with textbox controls
        // then label names is inherited and filled with the names of the dimensions it needs
        public double Radius { get; set; }
        public double Area
        {
            get { return (Math.PI * Math.Pow(this.Radius, 2D)); }
        }
    }

    public class Trapezoids
    {
        //constructors
        public Trapezoids()
        {
            this.UIControls = new string[] { "FirstDimensionInput", "Dimension1", "SecondDimensionInput", "Dimension2", "ThirdDimensionInput", "Dimension3"};
            this.Base1LabelsName = new string[] { "Dimension1", "Base 1" };
            this.Base2LabelsName = new string[] { "Dimension2", "Base 2" };
            this.HeightLabelsName = new string[] { "Dimension3", "Height"};
            this.UINames = new string[][] { this.Base1LabelsName,this.Base2LabelsName,this.HeightLabelsName};
        }
        public string[] UIControls { get; private set; }
        public string[] Base1LabelsName { get; private set; }
        public string[] Base2LabelsName { get; private set; }
        public string[] HeightLabelsName { get; private set; }
        public string[][] UINames { get; private set; }
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }

        public double Area
        {
            get { return ((Base1 + Base2) / 2 * Height); }
        }
    }

    public class Elipse
    {
        //constructors
        public Elipse()
        {
            this.UIControls = new string[] { "FirstDimensionInput", "Dimension1", "SecondDimensionInput", "Dimension2" };
            this.MajorRadiusLabelsName = new string[] { "Dimension1", "Major Radius" };
            this.MinorRadiusLabelsName = new string[] { "Dimension2", "Minor Radius" };
            this.UINames = new string[][] { this.MajorRadiusLabelsName, this.MinorRadiusLabelsName };
        }
        public string[] UIControls { get; private set; }
        public string[] MajorRadiusLabelsName { get; private set; }
        public string[] MinorRadiusLabelsName { get; private set; }
        public string[][] UINames { get; private set; }
        public double MajorRadius { get; set;}
        public double MinorRadius { get; set;}
        
        public double Area
        {
            get { return (MajorRadius * MinorRadius * Math.PI); }
        }
    }
    public class Rectangle
    {
        public Rectangle()
        {
            this.UIControls = new string[] { "FirstDimensionInput", "Dimension1", "SecondDimensionInput", "Dimension2" };
            this.LengthLabelsName = new string[] { "Dimension1", "Length" };
            this.HeightLabelsName = new string[] { "Dimension2", "Height" };
            this.UINames = new string[][] { this.LengthLabelsName, this.HeightLabelsName };
        }
        public string[] UIControls { get; private set; }
        public string[] LengthLabelsName { get; private set; }
        public string[] HeightLabelsName { get; private set; }
        public string[][] UINames { get; private set; }
        public double Base { get; set; }
        public double Height { get; set; }

        public double Area
        {
            get { return (Base * Height); }
        }
    }
}