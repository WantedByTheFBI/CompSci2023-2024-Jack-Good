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
            this.BubbleSortListBox = new System.Windows.Forms.ListBox();
            this.QuickSortButton = new System.Windows.Forms.Button();
            this.NetSort = new System.Windows.Forms.Button();
            this.BubbleSortTimer = new System.Windows.Forms.Label();
            this.QuickSortListBox = new System.Windows.Forms.ListBox();
            this.NETSortListBox = new System.Windows.Forms.ListBox();
            this.QuickSortTimer = new System.Windows.Forms.Label();
            this.NetSortTimer = new System.Windows.Forms.Label();
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
            // BubbleSortListBox
            // 
            this.BubbleSortListBox.FormattingEnabled = true;
            this.BubbleSortListBox.ItemHeight = 20;
            this.BubbleSortListBox.Location = new System.Drawing.Point(153, 40);
            this.BubbleSortListBox.Name = "BubbleSortListBox";
            this.BubbleSortListBox.Size = new System.Drawing.Size(245, 404);
            this.BubbleSortListBox.TabIndex = 2;
            // 
            // QuickSortButton
            // 
            this.QuickSortButton.Location = new System.Drawing.Point(404, 5);
            this.QuickSortButton.Name = "QuickSortButton";
            this.QuickSortButton.Size = new System.Drawing.Size(118, 29);
            this.QuickSortButton.TabIndex = 3;
            this.QuickSortButton.Text = "Quick Sort";
            this.QuickSortButton.UseVisualStyleBackColor = true;
            this.QuickSortButton.Click += new System.EventHandler(this.QuickSortButton_Click);
            // 
            // NetSort
            // 
            this.NetSort.Location = new System.Drawing.Point(655, 5);
            this.NetSort.Name = "NetSort";
            this.NetSort.Size = new System.Drawing.Size(118, 29);
            this.NetSort.TabIndex = 4;
            this.NetSort.Text = ".NETSort";
            this.NetSort.UseVisualStyleBackColor = true;
            this.NetSort.Click += new System.EventHandler(this.NetSort_Click);
            // 
            // BubbleSortTimer
            // 
            this.BubbleSortTimer.AutoSize = true;
            this.BubbleSortTimer.Location = new System.Drawing.Point(277, 9);
            this.BubbleSortTimer.Name = "BubbleSortTimer";
            this.BubbleSortTimer.Size = new System.Drawing.Size(45, 20);
            this.BubbleSortTimer.TabIndex = 5;
            this.BubbleSortTimer.Text = "Time:";
            // 
            // QuickSortListBox
            // 
            this.QuickSortListBox.FormattingEnabled = true;
            this.QuickSortListBox.ItemHeight = 20;
            this.QuickSortListBox.Location = new System.Drawing.Point(404, 40);
            this.QuickSortListBox.Name = "QuickSortListBox";
            this.QuickSortListBox.Size = new System.Drawing.Size(245, 404);
            this.QuickSortListBox.TabIndex = 6;
            // 
            // NETSortListBox
            // 
            this.NETSortListBox.FormattingEnabled = true;
            this.NETSortListBox.ItemHeight = 20;
            this.NETSortListBox.Location = new System.Drawing.Point(655, 40);
            this.NETSortListBox.Name = "NETSortListBox";
            this.NETSortListBox.Size = new System.Drawing.Size(245, 404);
            this.NETSortListBox.TabIndex = 7;
            // 
            // QuickSortTimer
            // 
            this.QuickSortTimer.AutoSize = true;
            this.QuickSortTimer.Location = new System.Drawing.Point(528, 9);
            this.QuickSortTimer.Name = "QuickSortTimer";
            this.QuickSortTimer.Size = new System.Drawing.Size(45, 20);
            this.QuickSortTimer.TabIndex = 8;
            this.QuickSortTimer.Text = "Time:";
            // 
            // NetSortTimer
            // 
            this.NetSortTimer.AutoSize = true;
            this.NetSortTimer.Location = new System.Drawing.Point(779, 9);
            this.NetSortTimer.Name = "NetSortTimer";
            this.NetSortTimer.Size = new System.Drawing.Size(45, 20);
            this.NetSortTimer.TabIndex = 9;
            this.NetSortTimer.Text = "Time:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 450);
            this.Controls.Add(this.NetSortTimer);
            this.Controls.Add(this.QuickSortTimer);
            this.Controls.Add(this.NETSortListBox);
            this.Controls.Add(this.QuickSortListBox);
            this.Controls.Add(this.BubbleSortTimer);
            this.Controls.Add(this.NetSort);
            this.Controls.Add(this.QuickSortButton);
            this.Controls.Add(this.BubbleSortListBox);
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
        private ListBox BubbleSortListBox;
        private Button QuickSortButton;
        private Button NetSort;
        private Label BubbleSortTimer;
        private ListBox QuickSortListBox;
        private ListBox NETSortListBox;
        private Label QuickSortTimer;
        private Label NetSortTimer;
    }
}