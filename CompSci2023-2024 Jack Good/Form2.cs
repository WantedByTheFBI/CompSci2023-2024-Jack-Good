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
                        shapes[i] = new Circles(random.Next(0,100));
                        break;
                    case 1:
                        shapes[i] = new Trapezoids(random.Next(0, 100), random.Next(0, 100), random.Next(0, 100));
                        break;
                    case 2:
                        shapes[i] = new Rectangle(random.Next(0, 100), random.Next(0, 100));
                        break;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Shapes blue in shapes) 
            {
                //kys
            }
        }
    }
}
