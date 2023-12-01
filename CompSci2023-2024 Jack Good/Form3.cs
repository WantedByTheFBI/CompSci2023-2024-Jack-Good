using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            if (GettingSorted.Length == 2){ //Quick return for any lists of length 2, skips extra for loops
                if (GettingSorted[0].Area < GettingSorted[1].Area){
                    Shapes tempshape = GettingSorted[0];
                    GettingSorted[0] = GettingSorted[1];
                    GettingSorted[1] = tempshape;}
                return (GettingSorted);}
            
            Shapes pivot1 = GettingSorted[0];
            for(int i = 1; i < GettingSorted.Length; i++){ //everything above the pivot point
                if (pivot1.Area > GettingSorted[i].Area){
                    Shapes tempshape2 = GettingSorted[i];
                    for(int x = i; x > Array.IndexOf(GettingSorted, pivot1); x+= -1) { //goes back from the shape with the larger area and 
                        Shapes tempshape = GettingSorted[x];                           //individually switches each shape inbetween it and the pivot point
                        GettingSorted[x] = GettingSorted[x-1];
                        GettingSorted[x-1] = tempshape;}}}

            // recursive calls

            //quicksort above the pivot point
            if (GettingSorted.Length - Array.IndexOf(GettingSorted, pivot1) > 2) { 
                //if the pivot point is more than 2 lower than the length of the list
                //since if it's 2, the only value above it is higher, and it it's 1, it's the highest
                Shapes[] templist = QuickSort(GettingSorted[(Array.IndexOf(GettingSorted, pivot1)+1)..GettingSorted.Length]); //from everything above the pivot point to the end of the list
                foreach(Shapes shapes in templist) {
                    GettingSorted[Array.IndexOf(GettingSorted, pivot1)+1 + Array.IndexOf(templist, shapes)] = shapes;}} //adds the quicksorted list to everything above the pivot point
            
            
            //quicksort below the pivot point
            if(Array.IndexOf(GettingSorted, pivot1) > 1) { //if the pivot point has more than 1 value lower than it
               Shapes[] templist = QuickSort(GettingSorted[0..(Array.IndexOf(GettingSorted, pivot1) - 1)]); //start of the list to the value right below the pivot point
                foreach (Shapes shapes in templist){
                    GettingSorted[Array.IndexOf(templist, shapes)] = shapes;}}
            return (GettingSorted);}

        public Shapes[] BubbleSort(Shapes[] GettingSorted) {
            for (int i = 0; i < 100; i++) {  //for every item from 1 to 100,
                for (int b = 0; b < 100 - i - 1; b++) { //for every item above I
                    if (GettingSorted[b].Area > GettingSorted[b + 1].Area) { //switches b and i if b is greater
                        Shapes temp = GettingSorted[b];
                        GettingSorted[b] = GettingSorted[b + 1];
                        GettingSorted[(b + 1)] = temp;}}}
            return(GettingSorted);}
        private void Generate100Shapesbutton_Click(object sender, EventArgs e)
        {
            Random MakeShape = new Random();
            for (int i = 0; i < 100; i++)
            {   
                switch(MakeShape.Next(0,3))
                {
                    case 0:
                        HundredShapes[i] = new Circles(MakeShape.Next(1, 25));
                        break;
                    case 1:
                        HundredShapes[i] = new Ellipse(MakeShape.Next(1, 100), MakeShape.Next(1, 25));
                        break;
                    case 2:
                        HundredShapes[i] = new Rectangles(MakeShape.Next(1, 100), MakeShape.Next(1, 25));
                        break;
                }
            }
        }

        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //clears the items in this listbox
            foreach (Shapes NamelessShape in BubbleSort(HundredShapes)){ //adds all the shapes
                string ShapeArea = "";
                ShapeArea += NamelessShape.ToString();
                ShapeArea += " with Area: " + NamelessShape.Area;
                listBox1.Items.Add(ShapeArea);}
        }
        private void QuickSortButton_Click(object sender, EventArgs e){
            listBox1.Items.Clear();
            foreach (Shapes NamelessShape in QuickSort(HundredShapes))
            {
                string ShapeArea = "";
                ShapeArea += NamelessShape.ToString();
                ShapeArea += " with Area: " + NamelessShape.Area;
                listBox1.Items.Add(ShapeArea);}
        }

        private void NetSort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
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
