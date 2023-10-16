using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompSci2023_2024_Jack_Good
{
    public abstract class Shapes
    {
        public Shapes(Form1 form)
        {

        }
        public abstract string[] LabelControls { get; }
        public abstract string[] TextBoxControls { get; }
        public abstract string[] LabelDimensionNames { get; }

        // switch case is just brought into the shape class
        void AlterInputControls()
        {
            foreach (string name in this.LabelControls)
            {
                this.Controls.Find(name, true)[0].Visible = true;

            }
            foreach (string labelrename in this.LabelDimensionNames)
            {
                string namereplace = LabelDimensionNames[public int GetLowerBound(string labelrename[0]);]
                Form1.Controls.Find(labelrename[0], true)[0].Text = ;
            }
            break;
        }
    }
    public class Circles : Shapes
    {
        //constructor
        public Circles(Form1 form) : base(form)
        {

        }
        public override string[] LabelControls { get; } = { "Dimension1" };

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