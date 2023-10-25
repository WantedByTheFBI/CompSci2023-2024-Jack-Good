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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FirstDimensionTextbox = new System.Windows.Forms.TextBox();
            this.Setter = new System.Windows.Forms.Button();
            this.ShapeHandlerListBox = new System.Windows.Forms.ListBox();
            this.AreaDisplayLabel = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.DimensionOneLabel = new System.Windows.Forms.Label();
            this.DimensionTwoLabel = new System.Windows.Forms.Label();
            this.SecondDimensionTextbox = new System.Windows.Forms.TextBox();
            this.DimensionThreeLabel = new System.Windows.Forms.Label();
            this.ThirdDimensionTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstDimensionTextbox
            // 
            this.FirstDimensionTextbox.Location = new System.Drawing.Point(12, 181);
            this.FirstDimensionTextbox.Name = "FirstDimensionTextbox";
            this.FirstDimensionTextbox.Size = new System.Drawing.Size(125, 27);
            this.FirstDimensionTextbox.TabIndex = 0;
            this.FirstDimensionTextbox.Visible = false;
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
            // ShapeHandlerListBox
            // 
            this.ShapeHandlerListBox.FormattingEnabled = true;
            this.ShapeHandlerListBox.ItemHeight = 20;
            this.ShapeHandlerListBox.Items.AddRange(new object[] {
            "Circle",
            "Trapezoid",
            "Ellipse",
            "Rectangle"});
            this.ShapeHandlerListBox.Location = new System.Drawing.Point(12, 19);
            this.ShapeHandlerListBox.Name = "ShapeHandlerListBox";
            this.ShapeHandlerListBox.Size = new System.Drawing.Size(150, 104);
            this.ShapeHandlerListBox.TabIndex = 3;
            this.ShapeHandlerListBox.SelectedIndexChanged += new System.EventHandler(this.ShapeHandlerIndexChanged);
            // 
            // AreaDisplayLabel
            // 
            this.AreaDisplayLabel.AutoSize = true;
            this.AreaDisplayLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.AreaDisplayLabel.Location = new System.Drawing.Point(520, 181);
            this.AreaDisplayLabel.Name = "AreaDisplayLabel";
            this.AreaDisplayLabel.Size = new System.Drawing.Size(215, 20);
            this.AreaDisplayLabel.TabIndex = 1;
            this.AreaDisplayLabel.Text = "[Waiting for shape dimensions]";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Font = new System.Drawing.Font("Sonic Cut Thru Heavy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AreaLabel.Location = new System.Drawing.Point(591, 158);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(56, 19);
            this.AreaLabel.TabIndex = 4;
            this.AreaLabel.Text = "Area:";
            this.AreaLabel.UseMnemonic = false;
            // 
            // DimensionOneLabel
            // 
            this.DimensionOneLabel.AutoSize = true;
            this.DimensionOneLabel.Location = new System.Drawing.Point(25, 158);
            this.DimensionOneLabel.Name = "DimensionOneLabel";
            this.DimensionOneLabel.Size = new System.Drawing.Size(92, 20);
            this.DimensionOneLabel.TabIndex = 5;
            this.DimensionOneLabel.Text = "Dimension 1";
            this.DimensionOneLabel.Visible = false;
            // 
            // DimensionTwoLabel
            // 
            this.DimensionTwoLabel.AutoSize = true;
            this.DimensionTwoLabel.Location = new System.Drawing.Point(180, 158);
            this.DimensionTwoLabel.Name = "DimensionTwoLabel";
            this.DimensionTwoLabel.Size = new System.Drawing.Size(92, 20);
            this.DimensionTwoLabel.TabIndex = 7;
            this.DimensionTwoLabel.Text = "Dimension 2";
            this.DimensionTwoLabel.Visible = false;
            // 
            // SecondDimensionTextbox
            // 
            this.SecondDimensionTextbox.Location = new System.Drawing.Point(160, 181);
            this.SecondDimensionTextbox.Name = "SecondDimensionTextbox";
            this.SecondDimensionTextbox.Size = new System.Drawing.Size(125, 27);
            this.SecondDimensionTextbox.TabIndex = 6;
            this.SecondDimensionTextbox.Visible = false;
            // 
            // DimensionThreeLabel
            // 
            this.DimensionThreeLabel.AutoSize = true;
            this.DimensionThreeLabel.Location = new System.Drawing.Point(328, 158);
            this.DimensionThreeLabel.Name = "DimensionThreeLabel";
            this.DimensionThreeLabel.Size = new System.Drawing.Size(92, 20);
            this.DimensionThreeLabel.TabIndex = 9;
            this.DimensionThreeLabel.Text = "Dimension 3";
            this.DimensionThreeLabel.Visible = false;
            // 
            // ThirdDimensionTextbox
            // 
            this.ThirdDimensionTextbox.Location = new System.Drawing.Point(309, 181);
            this.ThirdDimensionTextbox.Name = "ThirdDimensionTextbox";
            this.ThirdDimensionTextbox.Size = new System.Drawing.Size(125, 27);
            this.ThirdDimensionTextbox.TabIndex = 8;
            this.ThirdDimensionTextbox.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(241, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 394);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DimensionThreeLabel);
            this.Controls.Add(this.ThirdDimensionTextbox);
            this.Controls.Add(this.DimensionTwoLabel);
            this.Controls.Add(this.SecondDimensionTextbox);
            this.Controls.Add(this.DimensionOneLabel);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.ShapeHandlerListBox);
            this.Controls.Add(this.Setter);
            this.Controls.Add(this.AreaDisplayLabel);
            this.Controls.Add(this.FirstDimensionTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FirstDimensionTextbox;
        private Button Setter;
        private ListBox ShapeHandlerListBox;
        private Label AreaDisplayLabel;
        private Label AreaLabel;
        private Label DimensionOneLabel;
        private Label DimensionTwoLabel;
        private TextBox SecondDimensionTextbox;
        private Label DimensionThreeLabel;
        private TextBox ThirdDimensionTextbox;
        private PictureBox pictureBox1;
    }
}