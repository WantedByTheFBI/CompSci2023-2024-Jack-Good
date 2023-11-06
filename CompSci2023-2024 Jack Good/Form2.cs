using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompSci2023_2024_Jack_Good
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Shapes[] shapes = new Shapes[10];

        private void GenerateShapes_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 10 ; i++)
            {
                switch(random.Next(0, 3))
                {
                    case 0:
                        shapes[i] = new Circles(random.Next(1,100));
                        break;
                    case 1:
                        shapes[i] = new Trapezoids(random.Next(1, 100), random.Next(1, 100), random.Next(1, 100));
                        break;
                    case 2:
                        shapes[i] = new Rectangles(random.Next(1, 100), random.Next(1, 100));
                        break;
                }
            }
        }

        private void ArrayOfShapes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BadCodeClick(object sender, EventArgs e)
        {
            foreach(Shapes NamelessShape in shapes) 
            {
                string TemporaryString = "";
                TemporaryString += NamelessShape.ToString();
                switch (NamelessShape.ToString())
                {
                    case ("Circles"):
                        Circles Circle = (Circles)NamelessShape; // casts the shape to a circle so that the system knows it's not just a shape
                        TemporaryString += " Radius: " + (Circle).Radius.ToString(); 
                        TemporaryString += " Area: " + (Circle).Area.ToString();
                        break;
                    case ("Rectangles"):
                        Rectangles Rectangle = (Rectangles)NamelessShape; // casts the shape to a rectangle so that the system knows it's not just a shape
                        TemporaryString += " Length: " + (Rectangle).Length.ToString();
                        TemporaryString += " Height: " + (Rectangle).Height.ToString();
                        TemporaryString += " Area: " + (Rectangle).Area.ToString();
                        break;

                    case ("Trapezoids"):
                        Trapezoids Trapezoid = (Trapezoids)NamelessShape; // casts the shape to a Trapezoid so that the system knows it's not just a shape
                        TemporaryString += " Base1: " + (Trapezoid).Base_1.ToString();
                        TemporaryString += " Base2: " + (Trapezoid).Base_2.ToString();
                        TemporaryString += " Height: " + (Trapezoid).Height.ToString();
                        TemporaryString += " Area: " + (Trapezoid).Area.ToString();
                        break;
                }
                ArrayOfShapeListBox.Items.Add(TemporaryString);
            }
        }

        private void GoodCodeButton_Click(object sender, EventArgs e)
        {
            foreach (Shapes NamelessShape in shapes)
            {
                ArrayOfShapeListBox.Items.Add(NamelessShape.Describe());
            }
        }
    }
}
