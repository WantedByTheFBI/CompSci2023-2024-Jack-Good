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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Shapes[] HundredShapes = new Shapes[100];

        public Shapes[] QuickSort(Shapes[] GettingSorted)
        {

            return (GettingSorted);
        }
        private void Generate100Shapesbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Random MakeShape = new Random();
                switch(MakeShape.Next(0,3))
                {
                    case 0:
                        HundredShapes[i] = new Circles(MakeShape.Next(1, 25));
                        break;
                    case 1:
                        HundredShapes[i] = new Ellipse(MakeShape.Next(1, 25), MakeShape.Next(1, 25));
                        break;
                    case 2:
                        HundredShapes[i] = new Rectangles(MakeShape.Next(1, 25), MakeShape.Next(1, 25));
                        break;
                }
            }
        }

        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 100;i++)
            {
                for(int b = 0; b < 100-i-1; b++)
                {
                    if (HundredShapes[b].Area > HundredShapes[b + 1].Area)
                    {
                        Shapes temp = HundredShapes[b];
                        HundredShapes[b] = HundredShapes[b + 1];
                        HundredShapes[(b+1)] = temp;
                    }
                }
            }
            listBox1.Items.Clear(); //clears the items in this listbox
            foreach (Shapes NamelessShape in HundredShapes)
            {
                string ShapeArea = "";
                ShapeArea += NamelessShape.ToString();
                ShapeArea += " with Area: " + NamelessShape.Area;
                listBox1.Items.Add(ShapeArea);
            }
        }

        private void QuickSortButton_Click(object sender, EventArgs e)
        {
            HundredShapes = QuickSort(HundredShapes);
            foreach (Shapes NamelessShape in HundredShapes)
            {
                string ShapeArea = "";
                ShapeArea += NamelessShape.ToString();
                ShapeArea += " with Area: " + NamelessShape.Area;
                listBox1.Items.Add(ShapeArea);
            }
        }
    }
}
