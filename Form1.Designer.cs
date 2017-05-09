namespace BubbleSortDataSetsandAlgorithms
{
    partial class Form1
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
            this.Numbers = new System.Windows.Forms.ListBox();
            this.oneHundred = new System.Windows.Forms.RadioButton();
            this.Thousand = new System.Windows.Forms.RadioButton();
            this.tenThousand = new System.Windows.Forms.RadioButton();
            this.oneHundredThousand = new System.Windows.Forms.RadioButton();
            this.sortButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bubbleSort = new System.Windows.Forms.CheckBox();
            this.selectionSort = new System.Windows.Forms.CheckBox();
            this.insertionSort = new System.Windows.Forms.CheckBox();
            this.mergeSort = new System.Windows.Forms.CheckBox();
            this.quickSort = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Numbers
            // 
            this.Numbers.FormattingEnabled = true;
            this.Numbers.ItemHeight = 16;
            this.Numbers.Location = new System.Drawing.Point(285, 12);
            this.Numbers.MultiColumn = true;
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(182, 500);
            this.Numbers.TabIndex = 0;
            // 
            // oneHundred
            // 
            this.oneHundred.AutoSize = true;
            this.oneHundred.Location = new System.Drawing.Point(12, 29);
            this.oneHundred.Name = "oneHundred";
            this.oneHundred.Size = new System.Drawing.Size(86, 21);
            this.oneHundred.TabIndex = 1;
            this.oneHundred.TabStop = true;
            this.oneHundred.Text = "Max: 100";
            this.oneHundred.UseVisualStyleBackColor = true;
            this.oneHundred.CheckedChanged += new System.EventHandler(this.oneHundred_CheckedChanged);
            // 
            // Thousand
            // 
            this.Thousand.AutoSize = true;
            this.Thousand.Location = new System.Drawing.Point(12, 56);
            this.Thousand.Name = "Thousand";
            this.Thousand.Size = new System.Drawing.Size(94, 21);
            this.Thousand.TabIndex = 2;
            this.Thousand.TabStop = true;
            this.Thousand.Text = "Max: 1000";
            this.Thousand.UseVisualStyleBackColor = true;
            this.Thousand.CheckedChanged += new System.EventHandler(this.Thousand_CheckedChanged);
            // 
            // tenThousand
            // 
            this.tenThousand.AutoSize = true;
            this.tenThousand.Location = new System.Drawing.Point(12, 83);
            this.tenThousand.Name = "tenThousand";
            this.tenThousand.Size = new System.Drawing.Size(106, 21);
            this.tenThousand.TabIndex = 3;
            this.tenThousand.TabStop = true;
            this.tenThousand.Text = "Max: 10,000";
            this.tenThousand.UseVisualStyleBackColor = true;
            this.tenThousand.CheckedChanged += new System.EventHandler(this.tenThousand_CheckedChanged);
            // 
            // oneHundredThousand
            // 
            this.oneHundredThousand.AutoSize = true;
            this.oneHundredThousand.Location = new System.Drawing.Point(12, 110);
            this.oneHundredThousand.Name = "oneHundredThousand";
            this.oneHundredThousand.Size = new System.Drawing.Size(114, 21);
            this.oneHundredThousand.TabIndex = 4;
            this.oneHundredThousand.TabStop = true;
            this.oneHundredThousand.Text = "Max: 100,000";
            this.oneHundredThousand.UseVisualStyleBackColor = true;
            this.oneHundredThousand.CheckedChanged += new System.EventHandler(this.oneHundredThousand_CheckedChanged);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(15, 470);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(87, 42);
            this.sortButton.TabIndex = 5;
            this.sortButton.Text = "Sort!";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Time Elapsed:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 352);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 22);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Num of Swaps:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 380);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 22);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "# of Algorithm Loops:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "Save to .txt File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 42);
            this.button3.TabIndex = 13;
            this.button3.Text = "Load from .txt File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Algorithms:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Number of Integers:";
            // 
            // bubbleSort
            // 
            this.bubbleSort.AutoSize = true;
            this.bubbleSort.Location = new System.Drawing.Point(6, 168);
            this.bubbleSort.Name = "bubbleSort";
            this.bubbleSort.Size = new System.Drawing.Size(104, 21);
            this.bubbleSort.TabIndex = 18;
            this.bubbleSort.Text = "Bubble Sort";
            this.bubbleSort.UseVisualStyleBackColor = true;
            // 
            // selectionSort
            // 
            this.selectionSort.AutoSize = true;
            this.selectionSort.Location = new System.Drawing.Point(6, 195);
            this.selectionSort.Name = "selectionSort";
            this.selectionSort.Size = new System.Drawing.Size(118, 21);
            this.selectionSort.TabIndex = 19;
            this.selectionSort.Text = "Selection Sort";
            this.selectionSort.UseVisualStyleBackColor = true;
            // 
            // insertionSort
            // 
            this.insertionSort.AutoSize = true;
            this.insertionSort.Location = new System.Drawing.Point(6, 222);
            this.insertionSort.Name = "insertionSort";
            this.insertionSort.Size = new System.Drawing.Size(114, 21);
            this.insertionSort.TabIndex = 20;
            this.insertionSort.Text = "Insertion Sort";
            this.insertionSort.UseVisualStyleBackColor = true;
            // 
            // mergeSort
            // 
            this.mergeSort.AutoSize = true;
            this.mergeSort.Location = new System.Drawing.Point(6, 249);
            this.mergeSort.Name = "mergeSort";
            this.mergeSort.Size = new System.Drawing.Size(100, 21);
            this.mergeSort.TabIndex = 21;
            this.mergeSort.Text = "Merge Sort";
            this.mergeSort.UseVisualStyleBackColor = true;
            // 
            // quickSort
            // 
            this.quickSort.AutoSize = true;
            this.quickSort.Location = new System.Drawing.Point(6, 276);
            this.quickSort.Name = "quickSort";
            this.quickSort.Size = new System.Drawing.Size(96, 21);
            this.quickSort.TabIndex = 22;
            this.quickSort.Text = "Quick Sort";
            this.quickSort.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "# of Shifts:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 408);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(106, 22);
            this.textBox4.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "# of Inserts:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(97, 434);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(106, 22);
            this.textBox5.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 527);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quickSort);
            this.Controls.Add(this.mergeSort);
            this.Controls.Add(this.insertionSort);
            this.Controls.Add(this.selectionSort);
            this.Controls.Add(this.bubbleSort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.oneHundredThousand);
            this.Controls.Add(this.tenThousand);
            this.Controls.Add(this.Thousand);
            this.Controls.Add(this.oneHundred);
            this.Controls.Add(this.Numbers);
            this.Name = "Form1";
            this.Text = "Number Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Numbers;
        private System.Windows.Forms.RadioButton oneHundred;
        private System.Windows.Forms.RadioButton Thousand;
        private System.Windows.Forms.RadioButton tenThousand;
        private System.Windows.Forms.RadioButton oneHundredThousand;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox bubbleSort;
        private System.Windows.Forms.CheckBox selectionSort;
        private System.Windows.Forms.CheckBox insertionSort;
        private System.Windows.Forms.CheckBox mergeSort;
        private System.Windows.Forms.CheckBox quickSort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
    }
}

