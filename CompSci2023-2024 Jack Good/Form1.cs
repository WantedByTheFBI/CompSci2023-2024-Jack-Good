namespace CompSci2023_2024_Jack_Good
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AlterInputControls(Shapes shape)
        {
            foreach (string name in shape.LabelControls)
            {
                this.Controls.Find(name, true)[0].Visible = true;
            }
            foreach (string[] labelrename in shape.LabelTextToggles)
            {
                this.Controls.Find(labelrename[0], true)[0].Text = labelrename[1];
            }
        }
        private void TextboxVisibilityToggle(Shapes shape)
        {
            foreach (string name in shape.TextBoxControls)
            {
                this.Controls.Find(name, true)[0].Visible = true;
            }
        }
        private void Setter_Click(object sender, EventArgs e)
        {
            string Selecteditem = ShapeHandlerListBox.SelectedItem.ToString();
            switch (Selecteditem)
            {
                case "Circle":
                    Circles temporarycircle = new Circles();
                    temporarycircle.Radius = Convert.ToDouble(DimensionOneTextbox.Text);
                    DisplayShapeArea.Text = Convert.ToString(temporarycircle.Area);
                    break;

                case "Trapezoid":
                    Trapezoids temporarytrapezoid = new Trapezoids();
                    temporarytrapezoid.Base1 = Convert.ToDouble(DimensionOneTextbox.Text);
                    temporarytrapezoid.Base2 = Convert.ToDouble(SecondDimensionTextbox.Text);
                    temporarytrapezoid.Height = Convert.ToDouble(DimensionThreeTextbox.Text);
                    DisplayShapeArea.Text = Convert.ToString(temporarytrapezoid.Area);
                    break;

                case "Ellipse":
                    Ellipse temporaryelipse = new Ellipse();
                    temporaryelipse.MajorRadius = Convert.ToDouble(DimensionOneTextbox.Text);
                    temporaryelipse.MinorRadius = Convert.ToDouble(SecondDimensionTextbox.Text);
                    DisplayShapeArea.Text = Convert.ToString(temporaryelipse.Area);
                    break;

                case "Rectangle":
                    Rectangle temporaryrectangle = new Rectangle();
                    temporaryrectangle.Base = Convert.ToDouble(DimensionOneTextbox.Text);
                    temporaryrectangle.Height = Convert.ToDouble(SecondDimensionTextbox.Text);
                    DisplayShapeArea.Text = Convert.ToString(temporaryrectangle.Area);
                    break;
            }
        }
        private void ShapeHandlerIndexChanged(object sender, EventArgs e)
        {
            string Selecteditem = ShapeHandlerListBox.SelectedItem.ToString();
            SecondDimensionTextbox.Visible = false;
            DimensionThreeTextbox.Visible = false;
            DimensionTwoLabel.Visible = false;
            DimensionThreeLabel.Visible = false;

            switch (Selecteditem)
            {
                case "Circle":
                    Circles circle = new Circles();
                    AlterInputControls(circle);
                    TextboxVisibilityToggle(circle);
                    break;

                case "Trapezoid":
                    Trapezoids trapezoid = new Trapezoids();
                    AlterInputControls(trapezoid);
                    TextboxVisibilityToggle(trapezoid);
                    break;

                case "Ellipse":
                    Ellipse ellipse = new Ellipse();
                    AlterInputControls(ellipse);
                    TextboxVisibilityToggle(ellipse);
                    break;

                case "Rectangle":
                    Rectangle rectangle = new Rectangle();
                    AlterInputControls(rectangle);
                    TextboxVisibilityToggle(rectangle);
                    break;


            }
        }
    }
}