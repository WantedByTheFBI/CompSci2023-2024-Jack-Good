namespace CompSci2023_2024_Jack_Good
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ModifyDimensionLabels(Shapes shape)
        {
            foreach (string name in shape.RequiredLabels)
            {
                this.Controls.Find(name, true)[0].Visible = true;
            }
            for (int i = 0; i < shape.RequiredLabels.Length; i++)
            {
                this.Controls.Find(shape.RequiredLabels[i], true)[0].Text = shape.LabelDimensionNames[i];
            }
        }
        private void TextboxVisibilityToggle(Shapes shape)
        {
            foreach (string name in shape.RequiredTextboxes)
            {
                this.Controls.Find(name, true)[0].Visible = true;
                this.Controls.Find(name, true)[0].ResetText();
            }
        }
        private void Setter_Click(object sender, EventArgs e)
        {
            string Selecteditem = ShapeHandlerListBox.SelectedItem.ToString();
            if (FirstDimensionTextbox.Text == "" || SecondDimensionTextbox.Text == "" || ThirdDimensionTextbox.Text == "")
            {
                pictureBox1.Visible = true;
                //Thread.Sleep(300);
                // pictureBox1.Visible = false;
                return;
            }
            switch (Selecteditem)
            {
                case "Circle":
                    Circles temporarycircle = new Circles();
                    temporarycircle.Radius = Convert.ToDouble(FirstDimensionTextbox.Text);
                    AreaDisplayLabel.Text = Convert.ToString(temporarycircle.Area);
                    break;

                case "Trapezoid":
                    Trapezoids temporarytrapezoid = new Trapezoids();
                    temporarytrapezoid.Base1 = Convert.ToDouble(FirstDimensionTextbox.Text);
                    temporarytrapezoid.Base2 = Convert.ToDouble(SecondDimensionTextbox.Text);
                    temporarytrapezoid.Height = Convert.ToDouble(ThirdDimensionTextbox.Text);
                    AreaDisplayLabel.Text = Convert.ToString(temporarytrapezoid.Area);
                    break;

                case "Ellipse":
                    Ellipse temporaryelipse = new Ellipse();
                    temporaryelipse.MajorRadius = Convert.ToDouble(FirstDimensionTextbox.Text);
                    temporaryelipse.MinorRadius = Convert.ToDouble(SecondDimensionTextbox.Text);
                    AreaDisplayLabel.Text = Convert.ToString(temporaryelipse.Area);
                    break;

                case "Rectangle":
                    Rectangle temporaryrectangle = new Rectangle();
                    temporaryrectangle.Base = Convert.ToDouble(FirstDimensionTextbox.Text);
                    temporaryrectangle.Height = Convert.ToDouble(SecondDimensionTextbox.Text);
                    AreaDisplayLabel.Text = Convert.ToString(temporaryrectangle.Area);
                    break;
            }
        }
        private void ShapeHandlerIndexChanged(object sender, EventArgs e)
        {
            string Selecteditem = ShapeHandlerListBox.SelectedItem.ToString();
            SecondDimensionTextbox.Visible = false;
            ThirdDimensionTextbox.Visible = false;
            DimensionTwoLabel.Visible = false;
            DimensionThreeLabel.Visible = false;

            switch (Selecteditem)
            {
                case "Circle":
                    Circles circle = new Circles();
                    ModifyDimensionLabels(circle);
                    TextboxVisibilityToggle(circle);
                    break;

                case "Trapezoid":
                    Trapezoids trapezoid = new Trapezoids();
                    ModifyDimensionLabels(trapezoid);
                    TextboxVisibilityToggle(trapezoid);
                    break;

                case "Ellipse":
                    Ellipse ellipse = new Ellipse();
                    ModifyDimensionLabels(ellipse);
                    TextboxVisibilityToggle(ellipse);
                    break;

                case "Rectangle":
                    Rectangle rectangle = new Rectangle();
                    ModifyDimensionLabels(rectangle);
                    TextboxVisibilityToggle(rectangle);
                    break;


            }
        }
    }
}