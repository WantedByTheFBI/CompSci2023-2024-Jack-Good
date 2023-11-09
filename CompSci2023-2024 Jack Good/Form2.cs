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
        // properties that work best at this level of visibility
        Shapes[] shapes = new Shapes[10];
        Point point = new Point();

        //form2 methods
        private void GenerateShapes_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 10 ; i++) //will run through this for loop 10 times
            {
                switch(random.Next(0, 3)) //pseudorandomly decides whether it will be a circle, ellipse or rectangle
                {
                    case 0:
                        shapes[i] = new Circles(random.Next(1,100));
                        break;
                    case 1:
                        shapes[i] = new Ellipse(random.Next(1, 100), random.Next(1, 100));
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
            ArrayOfShapeListBox.Items.Clear();
            foreach (Shapes NamelessShape in shapes) 
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

                    case ("Ellipse"):
                        Ellipse Ellipse = (Ellipse)NamelessShape; // casts the shape to a Ellipse so that the system knows it's not just a shape
                        TemporaryString += " Base1: " + (Ellipse).Major_Radius.ToString();
                        TemporaryString += " Base2: " + (Ellipse).Minor_Radius.ToString();
                        TemporaryString += " Area: " + (Ellipse).Area.ToString();
                        break;
                }
                ArrayOfShapeListBox.Items.Add(TemporaryString);
            }
        }

        private void GoodCodeButton_Click(object sender, EventArgs e)
        {
            ArrayOfShapeListBox.Items.Clear();
            foreach (Shapes NamelessShape in shapes)
            {
                ArrayOfShapeListBox.Items.Add(NamelessShape.Describe());
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MouseEventArgs args = (MouseEventArgs)e;
            point.X = args.Location.X;
            point.Y = args.Location.Y;
            shapes[ArrayOfShapeListBox.SelectedIndex].Draw(panel1, point);
        }
    }
}
