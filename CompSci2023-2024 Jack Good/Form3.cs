using System.CodeDom.Compiler;
using System.Diagnostics;

namespace CompSci2023_2024_Jack_Good
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Shapes[] HundredShapes = new Shapes[50];
        int[] QuickHundredShapes = new int[50] { 19, 35, 33, 21, 28, 36, 8, 11, 30, 3, 10, 5, 39, 12, 37, 2, 32, 13, 26, 48, 42, 7, 18, 49, 22, 23, 47, 44, 40, 9, 14, 15, 1, 24, 38, 25, 50, 31, 43, 6, 4, 41, 16, 46, 34, 45, 17, 27, 20, 29 };       
        public string addtolistbox(Shapes TempShape)
        {
            string NamelessShape = "";
            NamelessShape += TempShape.ToString();
            NamelessShape += " with Area: " + TempShape.Area;
            return (NamelessShape);
        }
        public void QuicksortSwap(int position1, int position2)
        {
            int tempshape = QuickHundredShapes[position1];
            QuickHundredShapes[position1]= QuickHundredShapes[position2];
            QuickHundredShapes[position2]= tempshape;
        }

        public void QuickSortSwapAroundPivot(int left, int right, int pivot)
        {
            int leftposition = left;
            int rightposition = right - 1;
            while (true)
            {
                while (QuickHundredShapes[leftposition] < pivot) { leftposition++; }
                while (QuickHundredShapes[rightposition] > pivot & rightposition >0) { rightposition--; }
                if (leftposition >= rightposition) { break; }
                else
                {
                    QuicksortSwap(leftposition, rightposition);   
                }
            }
            QuicksortSwap(leftposition, right);
        }

        public void QuickSort(int left, int right)
        {
            if (right - left <= 0) { return; }
            else
            {
                int pivot = QuickHundredShapes[right];
                QuickSortSwapAroundPivot(left, right, pivot);
                QuickSort(left, Array.IndexOf(QuickHundredShapes, pivot)-1);
                QuickSort(Array.IndexOf(QuickHundredShapes, pivot) + 1, right);
            }
        }

        public Shapes[] BubbleSort(Shapes[] GettingSorted) {
            for (int i = 0; i < 1000; i++) {  //for every item from 1 to 100,
                for (int b = 0; b < 1000 - i - 1; b++) { //for every item above I
                    if (GettingSorted[b].Area > GettingSorted[b + 1].Area) { //switches b and i if b is greater
                        Shapes temp = GettingSorted[b];
                        GettingSorted[b] = GettingSorted[b + 1];
                        GettingSorted[(b + 1)] = temp;}}}
            return(GettingSorted);}
        private void Generate100Shapesbutton_Click(object sender, EventArgs e)
        {
            Random MakeShape = new Random();
            for (int i = 0; i < 50; i++)
            {   
                switch(MakeShape.Next(0,3))
                {
                    case 0:
                        HundredShapes[i] = new Circles(MakeShape.Next(1, 100));
                        break;
                    case 1:
                        HundredShapes[i] = new Ellipse(MakeShape.Next(1, 100), MakeShape.Next(1, 100));
                        break;
                    case 2:
                        HundredShapes[i] = new Rectangles(MakeShape.Next(1, 100), MakeShape.Next(1, 100));
                        break;
                }
            }
        }

        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = (new Stopwatch());

            stopwatch.Start();
            Shapes[] middleman = BubbleSort(HundredShapes);
            stopwatch.Stop();
            BubbleSortTimer.Text = stopwatch.ElapsedMilliseconds.ToString();
            BubbleSortListBox.Items.Clear(); //clears the items in this listbox
            foreach (Shapes NamelessShape in middleman){ //adds all the shapes
                BubbleSortListBox.Items.Add(addtolistbox(NamelessShape));
            }
        }
        private void QuickSortButton_Click(object sender, EventArgs e){
            QuickSortListBox.Items.Clear();
            //QuickHundredShapes = HundredShapes;
            //Stopwatch stopwatch = (new Stopwatch());
            //stopwatch.Start();
            //stopwatch.Stop();
            //QuickSortTimer.Text = stopwatch.ElapsedMilliseconds.ToString();
            QuickSort(0, 49);
            NETSortListBox.Items.Clear();
            foreach (int NamelessShape in QuickHundredShapes)
            {
                QuickSortListBox.Items.Add(NamelessShape);
            }
        }
        private void NetSort_Click(object sender, EventArgs e)
        {
            Shapes[] middleman = HundredShapes;
            Stopwatch stopwatch = (new Stopwatch());
            stopwatch.Start();
            Array.Sort(middleman);
            stopwatch.Stop();
            NetSortTimer.Text = stopwatch.ElapsedMilliseconds.ToString();
            NETSortListBox.Items.Clear();
            foreach (Shapes NamelessShape in middleman){
                NETSortListBox.Items.Add(addtolistbox(NamelessShape));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
