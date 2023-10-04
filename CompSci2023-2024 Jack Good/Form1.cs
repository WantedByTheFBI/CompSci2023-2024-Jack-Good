namespace CompSci2023_2024_Jack_Good
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circles x = new Circles();
            x.Radius = Convert.ToDouble(Userinput.Text);
            DisplayShapeArea.Text = Convert.ToString(x.Area);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayShapeArea_Click(object sender, EventArgs e)
        {

        }
    }
}