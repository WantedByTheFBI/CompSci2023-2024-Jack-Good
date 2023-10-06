namespace CompSci2023_2024_Jack_Good
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FirstDimesionInputTextChanged(object sender, EventArgs e)
        {

         
        }

        private void Setter_Click(object sender, EventArgs e)
        {
            string Selecteditem = listBox1.SelectedItem.ToString();
            switch (Selecteditem)
            {
                case "Circle":
                    Circles temporarycircle = new Circles();
                    temporarycircle.Radius = Convert.ToDouble(FirstDimensionInput.Text);
                    DisplayShapeArea.Text = Convert.ToString(temporarycircle.Area);
                    break;

                case "Trapezoid":
                    Trapezoids temporarytrapezoid = new Trapezoids();
                    temporarytrapezoid.Base1 = Convert.ToDouble(FirstDimensionInput.Text);
                    temporarytrapezoid.Base2 = Convert.ToDouble(SecondDimensionInput.Text);
                    temporarytrapezoid.Height = Convert.ToDouble(ThirdDimensionInput.Text);
                    DisplayShapeArea.Text = Convert.ToString(temporarytrapezoid.Area);
                    break;

                case "Elipse":
                    Elipse temporaryelipse = new Elipse();
                    temporaryelipse.MajorRadius = Convert.ToDouble(FirstDimensionInput.Text);
                    temporaryelipse.MinorRadius = Convert.ToDouble(SecondDimensionInput.Text);
                    DisplayShapeArea.Text = Convert.ToString(temporaryelipse.Area);
                    break;

                case "Rectangle":
                    Rectangle temporaryrectangle = new Rectangle();
                    temporaryrectangle.Base = Convert.ToDouble(FirstDimensionInput.Text);
                    temporaryrectangle.Height = Convert.ToDouble(SecondDimensionInput.Text);
                    DisplayShapeArea.Text = Convert.ToString(temporaryrectangle.Area);
                    break;
                    
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Selecteditem = listBox1.SelectedItem.ToString();
            switch(Selecteditem)
            {
                case "Circle":
                    Dimension1.Visible = true;
                    Dimension1.Text = "Radius";
                    FirstDimensionInput.Visible = true;

                    // making irrelevant boxes invisible
                    Dimension2.Visible = false;
                    Dimension3.Visible = false;
                    SecondDimensionInput.Visible = false;
                    ThirdDimensionInput.Visible = false;
                    break;

                case "Trapezoid":
                    Dimension1.Visible = true;
                    Dimension1.Text = "Base 1";
                    FirstDimensionInput.Visible = true;

                    Dimension2.Visible = true;
                    Dimension2.Text = "Base 2";
                    SecondDimensionInput.Visible = true;

                    Dimension3.Visible = true;
                    Dimension3.Text = "Height";
                    ThirdDimensionInput.Visible = true;
                    break;

                case "Elipse":
                    Dimension1.Visible = true;
                    Dimension1.Text = "Major Radius";
                    FirstDimensionInput.Visible = true;

                    Dimension2.Visible = true;
                    Dimension2.Text = "MinorRadius";
                    SecondDimensionInput.Visible = true;

                    Dimension3.Visible = false;
                    ThirdDimensionInput.Visible = false;
                
                    break;

                case "Rectangle":

                    break;


            }
        }

        private void DisplayShapeArea_Click(object sender, EventArgs e)
        {

        }

        private void SecondDimensionInput_Click(object sender, EventArgs e)
        {

        }

    }
}