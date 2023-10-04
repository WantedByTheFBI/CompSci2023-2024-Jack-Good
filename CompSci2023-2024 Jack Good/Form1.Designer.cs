namespace CompSci2023_2024_Jack_Good
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Userinput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DisplayShapeArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Userinput
            // 
            this.Userinput.Location = new System.Drawing.Point(12, 23);
            this.Userinput.Name = "Userinput";
            this.Userinput.Size = new System.Drawing.Size(125, 27);
            this.Userinput.TabIndex = 0;
            this.Userinput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Circles",
            "Trapezoid",
            "Elipse",
            "Rectangle"});
            this.listBox1.Location = new System.Drawing.Point(76, 151);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 104);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DisplayShapeArea
            // 
            this.DisplayShapeArea.AutoSize = true;
            this.DisplayShapeArea.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.DisplayShapeArea.Location = new System.Drawing.Point(169, 82);
            this.DisplayShapeArea.Name = "DisplayShapeArea";
            this.DisplayShapeArea.Size = new System.Drawing.Size(215, 20);
            this.DisplayShapeArea.TabIndex = 1;
            this.DisplayShapeArea.Text = "[Waiting for shape dimensions]";
            this.DisplayShapeArea.Click += new System.EventHandler(this.DisplayShapeArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DisplayShapeArea);
            this.Controls.Add(this.Userinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Userinput;
        private Button button1;
        private ListBox listBox1;
        
        // This was a textbox in the assignment, however I initially made this a label since I'm used to it
        // and can make the same end result without retracing all my steps

        private Label DisplayShapeArea;
    }
}