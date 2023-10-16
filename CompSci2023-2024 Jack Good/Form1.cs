using System.Xml.Linq;

namespace CompSci2023_2024_Jack_Good
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void VisibilitySetter(string name) 
        {
            this.Controls.(name, true)[0].Visible = true; 
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
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Selecteditem = listBox1.SelectedItem.ToString();
            SecondDimensionInput.Visible = false;
            ThirdDimensionInput.Visible = false;
            Dimension2.Visible = false;
            Dimension3.Visible = false;

            switch (Selecteditem)
            {
                case "Circle":
                    Circles circle = new Circles();
                    foreach (string name in circle.UIControls)
                    {
                        this.Controls.Find(name, true)[0].Visible = true;
                        
                    }
                    foreach (string[] labelrename  in circle.UINames)
                    {
                        this.Controls.Find(labelrename[0], true)[0].Text= labelrename[1];
                    }
                    break;

                case "Trapezoid":
                    Trapezoids trapezoid = new Trapezoids();
                    foreach (string name in trapezoid.UIControls)
                    {
                        this.Controls.Find(name, true)[0].Visible = true;

                    }
                    foreach (string[] labelrename in trapezoid.UINames)
                    {
                        this.Controls.Find(labelrename[0], true)[0].Text = labelrename[1];
                    }
                    break;

                case "Elipse":
                    Elipse elipse = new Elipse();
                    foreach (string name in elipse.UIControls)
                    {
                        this.Controls.Find(name, true)[0].Visible = true;

                    }
                    foreach (string[] labelrename in elipse.UINames)
                    {
                        this.Controls.Find(labelrename[0], true)[0].Text = labelrename[1];
                    }
                    break;

                case "Rectangle":
                    Rectangle rectangle = new Rectangle();
                    foreach (string name in rectangle.UIControls)
                    {
                        this.Controls.Find(name, true)[0].Visible = true;

                    }
                    foreach (string[] labelrename in rectangle.UINames)
                    {
                        this.Controls.Find(labelrename[0], true)[0].Text = labelrename[1];
                    }
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