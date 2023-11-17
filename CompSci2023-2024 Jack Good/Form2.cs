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
using System.Xml;
using System.Xml.Schema;

namespace CompSci2023_2024_Jack_Good
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // properties that work best at this level of visibility
        Shapes[] randomshapeslist = new Shapes[10];
        Shapes[] loadedshapeslist = new Shapes[10];
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
                        randomshapeslist[i] = new Circles(random.Next(1,100));
                        break;
                    case 1:
                        randomshapeslist[i] = new Ellipse(random.Next(1, 100), random.Next(1, 100));
                        break;
                    case 2:
                        randomshapeslist[i] = new Rectangles(random.Next(1, 100), random.Next(1, 100));
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
            foreach (Shapes NamelessShape in randomshapeslist) 
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
            ArrayOfShapeListBox.Items.Clear(); //clears the items in this listbox
            foreach (Shapes NamelessShape in randomshapeslist)
            {
                ArrayOfShapeListBox.Items.Add(NamelessShape.Describe());
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MouseEventArgs args = (MouseEventArgs)e; //casts the triggering click as a mouseevent so we can grab the x and y values
            point.X = args.Location.X;
            point.Y = args.Location.Y;
            if (ArrayOfShapeListBox.Visible == true & ArrayOfShapeListBox.SelectedIndex != -1) //checks that the random shapes list is the one being used  
                // prevents crashing when no items are selected                                                                             
            {
                randomshapeslist[ArrayOfShapeListBox.SelectedIndex].Draw(panel1, point); //has the selected item call it's listbox
            }
            else if (ListLoadedShapes.SelectedIndex != -1)  //if the other list isn't being used, and something is selected on this list, draw that item
            {
                loadedshapeslist[ListLoadedShapes.SelectedIndex].Draw(panel1, point);
            }            
        }

        private void Save_Shapes_Button_Click(object sender, EventArgs e)
        {
            string fileName = null;

            // configure the SaveAs dialog 

            saveFileDialog1.Title = "Save randomshapeslist";

            saveFileDialog1.DefaultExt = "shape";  // we'll make up our own file extension 

            saveFileDialog1.Filter = "shape files (*.randomshapeslist)|*.shape|All files (*.*)|*.*";

            // show dialog 

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)  // if the user didnt cancel 

            {

                fileName = saveFileDialog1.FileName; // get path & filename from SaveAs dialog 



                FileStream stream = new FileStream(fileName, FileMode.Create);  // create file and open stream to it 

                StreamWriter writer = new StreamWriter(stream);  // create writer that uses stream 



                foreach (Shapes shape in randomshapeslist)

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

            saveFileDialog1.Title = "Save randomshapeslist";

            saveFileDialog1.DefaultExt = "shape";  // we'll make up our own file extension 

            saveFileDialog1.Filter = "shape files (*.randomshapeslist)|*.shape|All files (*.*)|*.*";

            // show dialog 

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)  // if the user didnt cancel 
            {
                fileName = saveFileDialog1.FileName; // get path & filename from SaveAs dialog  

                FileStream stream = new FileStream(fileName, FileMode.Create);  // create file and open stream to it 

                XmlSerializer ser = new XmlSerializer(typeof(Shapes[]), new Type[] { typeof(Circles), typeof(Rectangles), typeof(Ellipse) });

                ser.Serialize(stream, randomshapeslist);

                stream.Close();  // close stream when you are done (dont leave files open!) 

                MessageBox.Show("Saved!");  // inform user save has completed 
            }
        }

        private void LoadedToggle_Click(object sender, EventArgs e)
        {
            LoadedListToggle.Visible = false; // makes the loaded list button and random list invisible, as both are no longer necessary
            RandomListToggle.Visible = true;  // while making the loaded list and random button visible, so they can select loaded shapes
            ListLoadedShapes.Visible = true;  //and then swich back to the other list
            ArrayOfShapeListBox.Visible = false;
        }

        private void RandomListToggle_Click(object sender, EventArgs e)
        {
            LoadedListToggle.Visible = true;  //does the opposite of above loadedtoggle
            RandomListToggle.Visible = false;
            ListLoadedShapes.Visible = false;
            ArrayOfShapeListBox.Visible = true;
        }

        private void Load_Shapes_Button_Click(object sender, EventArgs e)
        {

            // configure the SaveAs dialog

            openFileDialog1.Title = "Open Shapes";
            openFileDialog1.DefaultExt = "shape";  // only look for the shape file extension 
            openFileDialog1.Filter = "shape files (*.randomshapeslist)|*.shape|All files (*.*)|*.*";
            // show dialog 

            if (openFileDialog1.ShowDialog() == DialogResult.OK)  // if the user didnt cancel 
            {
                FileStream stream = new FileStream(openFileDialog1.FileName, FileMode.Open);  // create file and open stream to it 

                XmlSerializer ser = new XmlSerializer(typeof(Shapes[]), new Type[] { typeof(Circles), typeof(Rectangles), typeof(Ellipse) });

                    //The following is unfinished code meant to handle any extraneous data from other programs "Shapes" Files
                //ser.UnknownNode += new XmlNodeEventHandler(Serializer_UnknownNode);
                //ser.UnknownAttribute += new XmlAttributeEventHandler(Serializer_UnknownAttribute);

                loadedshapeslist = (Shapes[])ser.Deserialize(stream); //casts the deserialized data as a list of shapes

                stream.Close();  // close stream when you are done (dont leave files open!)

                foreach (Shapes NamelessShape in loadedshapeslist)
                {
                    ListLoadedShapes.Items.Add(NamelessShape.Describe());
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
