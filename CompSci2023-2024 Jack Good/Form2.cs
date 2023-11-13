using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

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
                string TemporaryString = ""; //this string lives to add the dimensions to the listbox
                TemporaryString += NamelessShape.ToString();
                switch (NamelessShape.ToString()) // checks the type of the shape and then points it to do x code if it's y type.
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

        private void GoodCodeButton_Click(object sender, EventArgs e) //OOP, has each shape call it's own describe function
        {
            ArrayOfShapeListBox.Items.Clear();
            foreach (Shapes NamelessShape in shapes)
            {
                ArrayOfShapeListBox.Items.Add(NamelessShape.Describe());
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MouseEventArgs args = (MouseEventArgs)e; //casts the triggering click as a mouseevent so we can grab the x and y values
            point.X = args.Location.X;
            point.Y = args.Location.Y;
            if(ArrayOfShapeListBox.SelectedIndex != -1) //prevents crashing when no items are in the list
                //next step is the case where no items are selected
            {
                shapes[ArrayOfShapeListBox.SelectedIndex].Draw(panel1, point); //has the selected item call it's listbox
            }
            
        }

        private void Save_Shapes_Button_Click(object sender, EventArgs e)
        {
            string fileName = null;

            // configure the SaveAs dialog 

            saveFileDialog1.Title = "Save shapes";

            saveFileDialog1.DefaultExt = "shape";  // we'll make up our own file extension 

            saveFileDialog1.Filter = "shape files (*.shapes)|*.shape|All files (*.*)|*.*";

            // show dialog 

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)  // if the user didnt cancel 

            {

                fileName = saveFileDialog1.FileName; // get path & filename from SaveAs dialog 



                FileStream stream = new FileStream(fileName, FileMode.Create);  // create file and open stream to it 

                StreamWriter writer = new StreamWriter(stream);  // create writer that uses stream 



                foreach (Shapes shape in shapes)

                {

                    writer.WriteLine(shape.Describe());  // write shape's description string to file 

                }

                writer.Close();  // close writer (commits data to stream) 

                stream.Close();  // close stream when you are done (dont leave files open!) 



                MessageBox.Show("Saved!");  // inform user save has completed 

            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void SeralizeShapes_Click(object sender, EventArgs e)
        {
            string fileName = null;

            // configure the SaveAs dialog 

            saveFileDialog1.Title = "Save shapes";

            saveFileDialog1.DefaultExt = "shape";  // we'll make up our own file extension 

            saveFileDialog1.Filter = "shape files (*.shapes)|*.shape|All files (*.*)|*.*";

            // show dialog 

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)  // if the user didnt cancel 
            {
                fileName = saveFileDialog1.FileName; // get path & filename from SaveAs dialog  

                FileStream stream = new FileStream(fileName, FileMode.Create);  // create file and open stream to it 

                XmlSerializer ser = new XmlSerializer(typeof(Shapes[]), new Type[] { typeof(Circles), typeof(Rectangles), typeof(Ellipse) });

                ser.Serialize(stream, shapes);

                stream.Close();  // close stream when you are done (dont leave files open!) 

                MessageBox.Show("Saved!");  // inform user save has completed 
            }
        }
    }
}
