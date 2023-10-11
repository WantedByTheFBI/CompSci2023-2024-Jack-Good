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
            this.FirstDimensionInput = new System.Windows.Forms.TextBox();
            this.Setter = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DisplayShapeArea = new System.Windows.Forms.Label();
            this.AreaTitleLabel = new System.Windows.Forms.Label();
            this.Dimension1 = new System.Windows.Forms.Label();
            this.Dimension2 = new System.Windows.Forms.Label();
            this.SecondDimensionInput = new System.Windows.Forms.TextBox();
            this.Dimension3 = new System.Windows.Forms.Label();
            this.ThirdDimensionInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FirstDimensionInput
            // 
            this.FirstDimensionInput.Location = new System.Drawing.Point(12, 181);
            this.FirstDimensionInput.Name = "FirstDimensionInput";
            this.FirstDimensionInput.Size = new System.Drawing.Size(125, 27);
            this.FirstDimensionInput.TabIndex = 0;
            this.FirstDimensionInput.Visible = false;
            this.FirstDimensionInput.TextChanged += new System.EventHandler(this.FirstDimesionInputTextChanged);
            // 
            // Setter
            // 
            this.Setter.Location = new System.Drawing.Point(25, 228);
            this.Setter.Name = "Setter";
            this.Setter.Size = new System.Drawing.Size(92, 35);
            this.Setter.TabIndex = 2;
            this.Setter.Text = "Set";
            this.Setter.UseVisualStyleBackColor = true;
            this.Setter.Click += new System.EventHandler(this.Setter_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Circle",
            "Trapezoid",
            "Elipse",
            "Rectangle"});
            this.listBox1.Location = new System.Drawing.Point(12, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 104);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DisplayShapeArea
            // 
            this.DisplayShapeArea.AutoSize = true;
            this.DisplayShapeArea.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.DisplayShapeArea.Location = new System.Drawing.Point(520, 181);
            this.DisplayShapeArea.Name = "DisplayShapeArea";
            this.DisplayShapeArea.Size = new System.Drawing.Size(215, 20);
            this.DisplayShapeArea.TabIndex = 1;
            this.DisplayShapeArea.Text = "[Waiting for shape dimensions]";
            this.DisplayShapeArea.Click += new System.EventHandler(this.DisplayShapeArea_Click);
            // 
            // AreaTitleLabel
            // 
            this.AreaTitleLabel.AutoSize = true;
            this.AreaTitleLabel.Location = new System.Drawing.Point(609, 142);
            this.AreaTitleLabel.Name = "AreaTitleLabel";
            this.AreaTitleLabel.Size = new System.Drawing.Size(43, 20);
            this.AreaTitleLabel.TabIndex = 4;
            this.AreaTitleLabel.Text = "Area:";
            this.AreaTitleLabel.UseMnemonic = false;
            // 
            // Dimension1
            // 
            this.Dimension1.AutoSize = true;
            this.Dimension1.Location = new System.Drawing.Point(25, 158);
            this.Dimension1.Name = "Dimension1";
            this.Dimension1.Size = new System.Drawing.Size(92, 20);
            this.Dimension1.TabIndex = 5;
            this.Dimension1.Text = "Dimension 1";
            this.Dimension1.Visible = false;
            // 
            // Dimension2
            // 
            this.Dimension2.AutoSize = true;
            this.Dimension2.Location = new System.Drawing.Point(180, 158);
            this.Dimension2.Name = "Dimension2";
            this.Dimension2.Size = new System.Drawing.Size(92, 20);
            this.Dimension2.TabIndex = 7;
            this.Dimension2.Text = "Dimension 2";
            this.Dimension2.Visible = false;
            this.Dimension2.Click += new System.EventHandler(this.SecondDimensionInput_Click);
            // 
            // SecondDimensionInput
            // 
            this.SecondDimensionInput.Location = new System.Drawing.Point(160, 181);
            this.SecondDimensionInput.Name = "SecondDimensionInput";
            this.SecondDimensionInput.Size = new System.Drawing.Size(125, 27);
            this.SecondDimensionInput.TabIndex = 6;
            this.SecondDimensionInput.Visible = false;
            // 
            // Dimension3
            // 
            this.Dimension3.AutoSize = true;
            this.Dimension3.Location = new System.Drawing.Point(328, 158);
            this.Dimension3.Name = "Dimension3";
            this.Dimension3.Size = new System.Drawing.Size(88, 20);
            this.Dimension3.TabIndex = 9;
            this.Dimension3.Text = "Dimension3";
            this.Dimension3.Visible = false;
            // 
            // ThirdDimensionInput
            // 
            this.ThirdDimensionInput.Location = new System.Drawing.Point(309, 181);
            this.ThirdDimensionInput.Name = "ThirdDimensionInput";
            this.ThirdDimensionInput.Size = new System.Drawing.Size(125, 27);
            this.ThirdDimensionInput.TabIndex = 8;
            this.ThirdDimensionInput.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dimension3);
            this.Controls.Add(this.ThirdDimensionInput);
            this.Controls.Add(this.Dimension2);
            this.Controls.Add(this.SecondDimensionInput);
            this.Controls.Add(this.Dimension1);
            this.Controls.Add(this.AreaTitleLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Setter);
            this.Controls.Add(this.DisplayShapeArea);
            this.Controls.Add(this.FirstDimensionInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FirstDimensionInput;
        private Button Setter;
        private ListBox listBox1;
        
        // This was a textbox in the assignment, however I initially made this a label since I'm used to it
        // and can make the same end result without retracing all my steps

        private Label DisplayShapeArea;
        private Label AreaTitleLabel;
        private Label Dimension1;
        private Label Dimension2;
        private TextBox SecondDimensionInput;
        private Label Dimension3;
        private TextBox ThirdDimensionInput;
    }
}