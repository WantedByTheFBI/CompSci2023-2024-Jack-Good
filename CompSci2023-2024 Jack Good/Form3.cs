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
        Shapes[] HundredShapes = new Shapes[1000];
        Shapes[] QuickHundredShapes = new Shapes[1000];
        public string addtolistbox(Shapes TempShape)
        {
            string NamelessShape = "";
            NamelessShape += TempShape.ToString();
            NamelessShape += " with Area: " + TempShape.Area;
            return (NamelessShape);
        }
        public void QuicksortSwap(int position1, int position2)
        {
            //holds the first positions value, replaces the first position with the second, then fills in the second
            Shapes tempshape = QuickHundredShapes[position1];
            QuickHundredShapes[position1] = QuickHundredShapes[position2];
            QuickHundredShapes[position2] = tempshape;
        }

        public void SwapAroundPivot(int FxStartingPoint, int FxEndpoint, Shapes pivotvalue)
        {
            int leftposition = FxStartingPoint; //this variable represents the place in the list currently being looked at starting from 0 ->
            int rightposition = FxEndpoint - 1; //the opposite of the above variable, starting just below the pivot and moving down
            while (true)
            {
                while (QuickHundredShapes[leftposition].Area < pivotvalue.Area) { leftposition++; } //unless the shape on the left is larger than the pivotpoint, keep moving inwards
                while (QuickHundredShapes[rightposition].Area > pivotvalue.Area & rightposition > 0) { rightposition--; } //unless our shape on the right is lower than the pivot point, move inwards
                if (leftposition >= rightposition) { break; } // breaks because we have where the pivot slots in
                else
                {
                    QuicksortSwap(leftposition, rightposition);
                    leftposition++;
                    //left is greater than the pivot and right is lower than, swap them
                }
            }
            QuicksortSwap(leftposition, FxEndpoint); //swap the midpoint of the list (just higher than the pivot value) with the pivot)
        }

        public void QuickSort(int left, int right) //base function meant to sort our list faster then bubble sort by being more efficient
                                                   //we essentially skip quite a few steps off bubble sort by dividing and conquering, allowing us to avoid going through every item in the list compared to 
                                                   // every other item in the list and drastically lower the # of lines run
        {
            if (right - left <= 0) { return; }// this means it's been past parameters so short it can't sort it any lower, so it just says "you're good"
            else
            {
                Shapes pivot = QuickHundredShapes[right]; //rightmost shape is the pivot point
                SwapAroundPivot(left, right, pivot); //move every item in the list to 3 chunks: | lower than pivot | pivot | higher than pivot |
                QuickSort(left, Array.IndexOf(QuickHundredShapes, pivot) - 1); // sort |higher than pivot|
                QuickSort(Array.IndexOf(QuickHundredShapes, pivot) + 1, right); // sort |lower than pivot|
            }
        }
        public Shapes[] BubbleSort(Shapes[] GettingSorted) {
            for (int iterations = 1; iterations < GettingSorted.Length; iterations++) { //How many times that list has been cycled through
                for (int positioninlist = 0; positioninlist < GettingSorted.Length - iterations; positioninlist++) { //cycles through the list from 0 to length-cycles
                    if (GettingSorted[positioninlist].Area > GettingSorted[positioninlist + 1].Area) { //switches a number and the number after it, if the former is greater
                    Shapes temp = GettingSorted[positioninlist];
                    GettingSorted[positioninlist] = GettingSorted[positioninlist+1];
                    GettingSorted[positioninlist+1] = temp; } } }
        return(GettingSorted);}
        private void Generate100Shapesbutton_Click(object sender, EventArgs e)
        {
            Array.Clear(HundredShapes, 0, HundredShapes.Length);
            Random MakeShape = new Random();
            int I = 0;
            while (I < HundredShapes.Length) {
                switch (MakeShape.Next(0, 3))
                {
                    case 0:
                        HundredShapes[I] = new Circles(MakeShape.Next(1, 1000));
                        I++;
                        break;
                    case 1:
                        HundredShapes[I] = new Ellipse(MakeShape.Next(1, 1000), MakeShape.Next(1, 1000));
                        I++;
                        break;
                    case 2:
                        HundredShapes[I] = new Rectangles(MakeShape.Next(1, 1000), MakeShape.Next(1, 1000));
                        I++;
                        break;
                }
            }
            OriginalShapelistbox.Items.Clear();
            foreach (Shapes NamelessShape in HundredShapes)
            {
                OriginalShapelistbox.Items.Add(addtolistbox(NamelessShape));
            }
        }
        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = (new Stopwatch()); 
            stopwatch.Start(); //starts our timer
            Shapes[] middleman = BubbleSort(HundredShapes); //makes a new list our bubblesort so we can keep the initial list
            stopwatch.Stop(); 
            BubbleSortTimer.Text = stopwatch.ElapsedMilliseconds.ToString(); //makes the related label display the time it took to bubble sort
            BubbleSortListBox.Items.Clear(); //clears the items in this listbox
            foreach (Shapes NamelessShape in middleman){ //adds all the shapes
                BubbleSortListBox.Items.Add(addtolistbox(NamelessShape));
            }
        }
        private void QuickSortButton_Click(object sender, EventArgs e)
        {
            QuickSortListBox.Items.Clear();
            QuickHundredShapes = HundredShapes;

            Stopwatch stopwatch = (new Stopwatch());
            stopwatch.Start();

            QuickSort(0, HundredShapes.Length-1);

            stopwatch.Stop();
            QuickSortTimer.Text = stopwatch.ElapsedMilliseconds.ToString();
            foreach (Shapes NamelessShape in QuickHundredShapes)
            {
                QuickSortListBox.Items.Add(addtolistbox(NamelessShape));
            }
        }
        private void NetSort_Click(object sender, EventArgs e)
        {
            Shapes[] middleman = HundredShapes;
            NETSortListBox.Items.Clear();

            Stopwatch stopwatch = (new Stopwatch());
            stopwatch.Start();

            Array.Sort(middleman);

            stopwatch.Stop();
            NetSortTimer.Text = stopwatch.ElapsedMilliseconds.ToString();
            
            foreach (Shapes NamelessShape in middleman){
                NETSortListBox.Items.Add(addtolistbox(NamelessShape));
            }
        }
    }
}
