namespace CompSci2023_2024_Jack_Good
{
    partial class Form3
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
            this.Generate100Shapesbutton = new System.Windows.Forms.Button();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.QuickSortButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Generate100Shapesbutton
            // 
            this.Generate100Shapesbutton.Location = new System.Drawing.Point(12, 5);
            this.Generate100Shapesbutton.Name = "Generate100Shapesbutton";
            this.Generate100Shapesbutton.Size = new System.Drawing.Size(135, 29);
            this.Generate100Shapesbutton.TabIndex = 0;
            this.Generate100Shapesbutton.Text = "Generate Shapes";
            this.Generate100Shapesbutton.UseVisualStyleBackColor = true;
            this.Generate100Shapesbutton.Click += new System.EventHandler(this.Generate100Shapesbutton_Click);
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.Location = new System.Drawing.Point(153, 5);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(118, 29);
            this.BubbleSortButton.TabIndex = 1;
            this.BubbleSortButton.Text = "Bubble Sort";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.BubbleSortButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(289, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 404);
            this.listBox1.TabIndex = 2;
            // 
            // QuickSortButton
            // 
            this.QuickSortButton.Location = new System.Drawing.Point(12, 40);
            this.QuickSortButton.Name = "QuickSortButton";
            this.QuickSortButton.Size = new System.Drawing.Size(135, 29);
            this.QuickSortButton.TabIndex = 3;
            this.QuickSortButton.Text = "Quick Sort";
            this.QuickSortButton.UseVisualStyleBackColor = true;
            this.QuickSortButton.Click += new System.EventHandler(this.QuickSortButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuickSortButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BubbleSortButton);
            this.Controls.Add(this.Generate100Shapesbutton);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Generate100Shapesbutton;
        private Button BubbleSortButton;
        private ListBox listBox1;
        private Button QuickSortButton;
        private Label label1;
    }
}