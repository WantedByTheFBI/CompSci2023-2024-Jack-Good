namespace CompSci2023_2024_Jack_Good
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ArrayOfShapeListBox = new System.Windows.Forms.ListBox();
            this.GenerateShapes = new System.Windows.Forms.Button();
            this.BadCodeButton = new System.Windows.Forms.Button();
            this.GoodCodeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save_Shapes_Button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SeralizeShapes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ArrayOfShapeListBox
            // 
            this.ArrayOfShapeListBox.FormattingEnabled = true;
            this.ArrayOfShapeListBox.ItemHeight = 20;
            this.ArrayOfShapeListBox.Location = new System.Drawing.Point(12, 78);
            this.ArrayOfShapeListBox.Name = "ArrayOfShapeListBox";
            this.ArrayOfShapeListBox.Size = new System.Drawing.Size(519, 424);
            this.ArrayOfShapeListBox.TabIndex = 0;
            this.ArrayOfShapeListBox.SelectedIndexChanged += new System.EventHandler(this.ArrayOfShapes_SelectedIndexChanged);
            // 
            // GenerateShapes
            // 
            this.GenerateShapes.Location = new System.Drawing.Point(12, 12);
            this.GenerateShapes.Name = "GenerateShapes";
            this.GenerateShapes.Size = new System.Drawing.Size(169, 29);
            this.GenerateShapes.TabIndex = 1;
            this.GenerateShapes.Text = "Generate Shapes";
            this.GenerateShapes.UseVisualStyleBackColor = true;
            this.GenerateShapes.Click += new System.EventHandler(this.GenerateShapes_Click);
            // 
            // BadCodeButton
            // 
            this.BadCodeButton.Location = new System.Drawing.Point(187, 12);
            this.BadCodeButton.Name = "BadCodeButton";
            this.BadCodeButton.Size = new System.Drawing.Size(169, 29);
            this.BadCodeButton.TabIndex = 2;
            this.BadCodeButton.Text = "Bad Code";
            this.BadCodeButton.UseVisualStyleBackColor = true;
            this.BadCodeButton.Click += new System.EventHandler(this.BadCodeClick);
            // 
            // GoodCodeButton
            // 
            this.GoodCodeButton.Location = new System.Drawing.Point(362, 12);
            this.GoodCodeButton.Name = "GoodCodeButton";
            this.GoodCodeButton.Size = new System.Drawing.Size(169, 29);
            this.GoodCodeButton.TabIndex = 3;
            this.GoodCodeButton.Text = "Good Code";
            this.GoodCodeButton.UseVisualStyleBackColor = true;
            this.GoodCodeButton.Click += new System.EventHandler(this.GoodCodeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(557, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 490);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Save_Shapes_Button
            // 
            this.Save_Shapes_Button.Location = new System.Drawing.Point(12, 47);
            this.Save_Shapes_Button.Name = "Save_Shapes_Button";
            this.Save_Shapes_Button.Size = new System.Drawing.Size(169, 29);
            this.Save_Shapes_Button.TabIndex = 5;
            this.Save_Shapes_Button.Text = "Save Shapes";
            this.Save_Shapes_Button.UseVisualStyleBackColor = true;
            this.Save_Shapes_Button.Click += new System.EventHandler(this.Save_Shapes_Button_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // SeralizeShapes
            // 
            this.SeralizeShapes.Location = new System.Drawing.Point(187, 47);
            this.SeralizeShapes.Name = "SeralizeShapes";
            this.SeralizeShapes.Size = new System.Drawing.Size(169, 29);
            this.SeralizeShapes.TabIndex = 6;
            this.SeralizeShapes.Text = "Serialize Shapes";
            this.SeralizeShapes.UseVisualStyleBackColor = true;
            this.SeralizeShapes.Click += new System.EventHandler(this.SeralizeShapes_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 514);
            this.Controls.Add(this.SeralizeShapes);
            this.Controls.Add(this.Save_Shapes_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GoodCodeButton);
            this.Controls.Add(this.BadCodeButton);
            this.Controls.Add(this.GenerateShapes);
            this.Controls.Add(this.ArrayOfShapeListBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox ArrayOfShapeListBox;
        private Button GenerateShapes;
        private Button BadCodeButton;
        private Button GoodCodeButton;
        private Panel panel1;
        private Button Save_Shapes_Button;
        private SaveFileDialog saveFileDialog1;
        private Button SeralizeShapes;
    }
}