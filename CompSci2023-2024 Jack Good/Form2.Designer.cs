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
            this.ListLoadedShapes = new System.Windows.Forms.ListBox();
            this.Load_Shapes_Button = new System.Windows.Forms.Button();
            this.RandomListToggle = new System.Windows.Forms.Button();
            this.LoadedListToggle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ArrayOfShapeListBox
            // 
            this.ArrayOfShapeListBox.FormattingEnabled = true;
            this.ArrayOfShapeListBox.ItemHeight = 15;
            this.ArrayOfShapeListBox.Location = new System.Drawing.Point(12, 91);
            this.ArrayOfShapeListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArrayOfShapeListBox.Name = "ArrayOfShapeListBox";
            this.ArrayOfShapeListBox.Size = new System.Drawing.Size(455, 289);
            this.ArrayOfShapeListBox.TabIndex = 0;
            this.ArrayOfShapeListBox.SelectedIndexChanged += new System.EventHandler(this.ArrayOfShapes_SelectedIndexChanged);
            // 
            // GenerateShapes
            // 
            this.GenerateShapes.Location = new System.Drawing.Point(10, 9);
            this.GenerateShapes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateShapes.Name = "GenerateShapes";
            this.GenerateShapes.Size = new System.Drawing.Size(148, 22);
            this.GenerateShapes.TabIndex = 1;
            this.GenerateShapes.Text = "Generate Shapes";
            this.GenerateShapes.UseVisualStyleBackColor = true;
            this.GenerateShapes.Click += new System.EventHandler(this.GenerateShapes_Click);
            // 
            // BadCodeButton
            // 
            this.BadCodeButton.Location = new System.Drawing.Point(164, 9);
            this.BadCodeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BadCodeButton.Name = "BadCodeButton";
            this.BadCodeButton.Size = new System.Drawing.Size(148, 22);
            this.BadCodeButton.TabIndex = 2;
            this.BadCodeButton.Text = "Bad Code";
            this.BadCodeButton.UseVisualStyleBackColor = true;
            this.BadCodeButton.Click += new System.EventHandler(this.BadCodeClick);
            // 
            // GoodCodeButton
            // 
            this.GoodCodeButton.Location = new System.Drawing.Point(317, 9);
            this.GoodCodeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoodCodeButton.Name = "GoodCodeButton";
            this.GoodCodeButton.Size = new System.Drawing.Size(148, 22);
            this.GoodCodeButton.TabIndex = 3;
            this.GoodCodeButton.Text = "Good Code";
            this.GoodCodeButton.UseVisualStyleBackColor = true;
            this.GoodCodeButton.Click += new System.EventHandler(this.GoodCodeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(487, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 368);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Save_Shapes_Button
            // 
            this.Save_Shapes_Button.Location = new System.Drawing.Point(10, 35);
            this.Save_Shapes_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save_Shapes_Button.Name = "Save_Shapes_Button";
            this.Save_Shapes_Button.Size = new System.Drawing.Size(148, 22);
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
            this.SeralizeShapes.Location = new System.Drawing.Point(164, 35);
            this.SeralizeShapes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeralizeShapes.Name = "SeralizeShapes";
            this.SeralizeShapes.Size = new System.Drawing.Size(148, 22);
            this.SeralizeShapes.TabIndex = 6;
            this.SeralizeShapes.Text = "Serialize Shapes";
            this.SeralizeShapes.UseVisualStyleBackColor = true;
            this.SeralizeShapes.Click += new System.EventHandler(this.SeralizeShapes_Click);
            // 
            // ListLoadedShapes
            // 
            this.ListLoadedShapes.FormattingEnabled = true;
            this.ListLoadedShapes.ItemHeight = 15;
            this.ListLoadedShapes.Location = new System.Drawing.Point(12, 91);
            this.ListLoadedShapes.Name = "ListLoadedShapes";
            this.ListLoadedShapes.Size = new System.Drawing.Size(455, 289);
            this.ListLoadedShapes.TabIndex = 7;
            this.ListLoadedShapes.Visible = false;
            // 
            // Load_Shapes_Button
            // 
            this.Load_Shapes_Button.Location = new System.Drawing.Point(318, 34);
            this.Load_Shapes_Button.Name = "Load_Shapes_Button";
            this.Load_Shapes_Button.Size = new System.Drawing.Size(147, 23);
            this.Load_Shapes_Button.TabIndex = 8;
            this.Load_Shapes_Button.Text = "Load_Shapes";
            this.Load_Shapes_Button.UseVisualStyleBackColor = true;
            this.Load_Shapes_Button.Click += new System.EventHandler(this.Load_Shapes_Button_Click);
            // 
            // RandomListToggle
            // 
            this.RandomListToggle.Location = new System.Drawing.Point(10, 62);
            this.RandomListToggle.Name = "RandomListToggle";
            this.RandomListToggle.Size = new System.Drawing.Size(75, 23);
            this.RandomListToggle.TabIndex = 9;
            this.RandomListToggle.Text = "Random";
            this.RandomListToggle.UseVisualStyleBackColor = true;
            this.RandomListToggle.Visible = false;
            this.RandomListToggle.Click += new System.EventHandler(this.RandomListToggle_Click);
            // 
            // LoadedListToggle
            // 
            this.LoadedListToggle.BackColor = System.Drawing.Color.Transparent;
            this.LoadedListToggle.Location = new System.Drawing.Point(83, 62);
            this.LoadedListToggle.Name = "LoadedListToggle";
            this.LoadedListToggle.Size = new System.Drawing.Size(75, 23);
            this.LoadedListToggle.TabIndex = 10;
            this.LoadedListToggle.Text = "Loaded";
            this.LoadedListToggle.UseVisualStyleBackColor = false;
            this.LoadedListToggle.Click += new System.EventHandler(this.LoadedToggle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 396);
            this.Controls.Add(this.LoadedListToggle);
            this.Controls.Add(this.RandomListToggle);
            this.Controls.Add(this.Load_Shapes_Button);
            this.Controls.Add(this.ListLoadedShapes);
            this.Controls.Add(this.SeralizeShapes);
            this.Controls.Add(this.Save_Shapes_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GoodCodeButton);
            this.Controls.Add(this.BadCodeButton);
            this.Controls.Add(this.GenerateShapes);
            this.Controls.Add(this.ArrayOfShapeListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private ListBox ListLoadedShapes;
        private Button Load_Shapes_Button;
        private Button RandomListToggle;
        private Button LoadedListToggle;
        private OpenFileDialog openFileDialog1;
    }
}