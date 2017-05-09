using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace BubbleSortDataSetsandAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] array;
        int smallMaxSize = 101;
        int mediumMaxSize = 1001;
        int largeMaxSize = 10001;
        int extraLargeMaxSize = 100001;

        private static int swapCount = 0;
        private static int sortAlgorithmCount = 0;
        private static int shiftCount = 0;
        private static int insertCount = 0;

        Stopwatch stopWatch = new Stopwatch();

        #region Sort Button Click
        private void sortButton_Click(object sender, EventArgs e)//Bubblesort Code
        {
            #region Check multiple boxes
            int numberChecked = 0;
            CheckBox[] array = new CheckBox[] { bubbleSort, selectionSort, insertionSort, mergeSort, quickSort };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Checked)
                    numberChecked++;
            }

            if (numberChecked > 1)
            {
                MessageBox.Show("You have checked " + numberChecked.ToString() + " checkBoxes. One one is allowed.");
            }
            #endregion//Checks if multiple boxes are checked

            if (bubbleSort.Checked == true)//If Bubble Sort is Checked, run Bubble Sort Algorithm
            {
                if (oneHundred.Checked == true)
                {
                    bubbleSortAlgorithm(smallMaxSize);
                }

                if (Thousand.Checked == true)
                {
                    bubbleSortAlgorithm(mediumMaxSize);
                }

                if (tenThousand.Checked == true)
                {
                    bubbleSortAlgorithm(largeMaxSize);
                }

                if (oneHundredThousand.Checked == true)
                {
                    bubbleSortAlgorithm(extraLargeMaxSize);
                }
            }
            if (selectionSort.Checked == true)//if Selection Sort is checked, run Selection Sort Algorithm
            {
                if (oneHundred.Checked == true)
                {
                    selectionSortAlgorithm(smallMaxSize);
                }

                if (Thousand.Checked == true)
                {
                    selectionSortAlgorithm(mediumMaxSize);
                }

                if (tenThousand.Checked == true)
                {
                    selectionSortAlgorithm(largeMaxSize);
                }

                if (oneHundredThousand.Checked == true)
                {
                    selectionSortAlgorithm(extraLargeMaxSize);
                }
            }
            if (insertionSort.Checked == true) //If insertion sort is checked
            {
                if (oneHundred.Checked == true)
                {
                    insertionSortAlgorithm(smallMaxSize);
                }

                if (Thousand.Checked == true)
                {
                    insertionSortAlgorithm(mediumMaxSize);
                }

                if (tenThousand.Checked == true)
                {
                    insertionSortAlgorithm(largeMaxSize);
                }

                if (oneHundredThousand.Checked == true)
                {
                    insertionSortAlgorithm(extraLargeMaxSize);
                }
            }
            if (mergeSort.Checked == true)
            {
                if(oneHundred.Checked == true)
                {
                    mergeSortAlgorithm(smallMaxSize);
                }
                if (Thousand.Checked == true)
                {
                    mergeSortAlgorithm(mediumMaxSize);
                }
                if (tenThousand.Checked == true)
                {
                    mergeSortAlgorithm(largeMaxSize);
                }
                if (oneHundredThousand.Checked == true)
                {
                    mergeSortAlgorithm(extraLargeMaxSize);
                }
            }
            if (quickSort.Checked == true) //If quick sort is checked
            {
                if (oneHundred.Checked == true)
                {
                    quickSortAlgorithm(smallMaxSize);
                }

                if (Thousand.Checked == true)
                {
                    quickSortAlgorithm(mediumMaxSize);
                }

                if (tenThousand.Checked == true)
                {
                    quickSortAlgorithm(largeMaxSize);
                }

                if (oneHundredThousand.Checked == true)
                {
                    quickSortAlgorithm(extraLargeMaxSize);
                }
            }
            textBox1.Text = stopWatch.Elapsed.ToString();
            textBox2.Text = swapCount.ToString();
            textBox3.Text = sortAlgorithmCount.ToString();
            textBox4.Text = shiftCount.ToString();
            textBox5.Text = insertCount.ToString();
        }
        #endregion

        #region Swap Numbers
        private void swap(int one, int two)//Swaps larger number for smaller number
        {
            swapCount++;
            int temp = array[one];
            array[one] = array[two];
            array[two] = temp;
        }
        #endregion

        #region Algorithms
        #region Bubble Sort Algorithm
        private void bubbleSortAlgorithm(int Size)
        {
            int Out;
            int In;

            for (Out = Size - 1; Out > 1; Out--)
            {
                stopWatch.Start();
                sortAlgorithmCount++;
                for (In = 0; In < Out; In++)
                {
                    if (array[In] > array[In + 1])
                    {
                        swap(In, In + 1);
                    }
                }
            }
            Numbers.Items.Clear();
            for (int i = 0; i < Size; i++)
            {
                Numbers.Items.Add(array[i]);
            }
        }
        #endregion

        #region Selection Sort Algorithm
        private void selectionSortAlgorithm(int Size)
        {
            int Out;
            int In;
            int min;

            for (Out = 0; Out < Size - 1; Out++)//Outer loop
            {
                stopWatch.Start();
                sortAlgorithmCount++;
                min = Out;//minimum
                for (In = Out + 1; In < Size; In++)//Inner loop
                {
                    if (array[In] < array[min])//If min is greater, min changes.
                    {
                        min = In;
                    }
                }
                swap(Out, min);//Swap Out for new min
            }
            Numbers.Items.Clear();
            for(int i = 0; i < Size; i++)//Sort items
            {
                Numbers.Items.Add(array[i]);
            }
        }
        #endregion

        #region Insertion Sort Algorithm
        public void insertionSortAlgorithm(int Size)
        {
            int In;
            int Out;

            for (Out = 1; Out < Size; Out++) //Out is equal to dividing line
            {
                stopWatch.Start();
                sortAlgorithmCount++;
                int temp = array[Out]; //Removes marked item
                In = Out; //Starts shift at out
                while(In>0 && array[In-1] >= temp) //Until one number is smaller
                {
                    array[In] = array[In - 1]; //Shift item right
                    shiftCount++;
                    --In; //Go left one position
                }
                insertCount++;
                array[In] = temp;//Insert marked number
            }
            Numbers.Items.Clear();
            for (int i = 0; i < Size; i++)//Sort items
            {
                Numbers.Items.Add(array[i]);
            }
        }
        #endregion

        #region Merge Sort Algorithm
        public void mergeSortAlgorithm(int Size)
        {
            mergingSort(array, 0, Size - 1, Size);
            Numbers.Items.Clear();
            for (int i = 0; i < Size; i++)//Sort items
            {
                Numbers.Items.Add(array[i]);
            }
        }

        public static void Merge(int[] numbers, int left, int mid, int right, int Size)
        {
            int[] temp = new int[Size];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }

            while (left <= eol)
                temp[pos++] = numbers[left++];

            while (mid <= right)
                temp[pos++] = numbers[mid++];

            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        public void mergingSort(int[] numbers, int left, int right, int Size)
        {
            int mid;
            stopWatch.Start();
            sortAlgorithmCount++;
            if (right > left)
            {
                mid = (right + left) / 2;
                mergingSort(numbers, left, mid, Size);
                mergingSort(numbers, (mid + 1), right, Size);
 
                Merge(numbers, left, (mid + 1), right, Size);
            }
        }
        #endregion

        #region Quick Sort Algorithm
        public void quickSortAlgorithm(int Size)
        {
            quicksort(array, 0, Size - 1);
            Numbers.Items.Clear();
            for (int i = 0; i < Size; i++)//Sort items
            {
                Numbers.Items.Add(array[i]);
            }
        }
        private void quicksort(int[] numbers, int left, int right)
        {
            int pivot_loc = 0; //initial pivot location

            if(left < right)
            {
                stopWatch.Start();
                pivot_loc = Partition(numbers, left, right);
                quicksort(numbers, left, pivot_loc - 1);
                quicksort(numbers, pivot_loc + 1, right);
            }
        }
        public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[right];
            int i = left - 1;

            for(int j = left; j < right; j++)
            {
                if(numbers[j] <= pivot)
                {
                    i++;
                    quickSwap(numbers, i, j);
                }
            }
            quickSwap(numbers, i + 1, right);
            return i + 1;
        }
        private void quickSwap(int[] array, int a, int b)
        {
            swapCount++;
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        #endregion
        #endregion

        #region Generating Numbers
        #region Number Generator
        private void randNumGenerator(int Size)
        {
            Numbers.Items.Clear();
            array = Enumerable.Range(0, Size).ToArray();

            Shuffle(array);

            foreach (int value in array)
            {
                Numbers.Items.Add(value);
            }
        }
        #endregion

        #region Shuffle Algorithm
        static Random numGenerator = new Random();
        static void Shuffle(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int r = numGenerator.Next(0, i);
                int temp = array[r];
                array[r] = array[i];
                array[i] = temp;
            }
        }
        #endregion
        #endregion

        #region Radio Buttons
        #region Small Max: 100
        private void oneHundred_CheckedChanged(object sender, EventArgs e)//Max 100 button
        {
            randNumGenerator(smallMaxSize);
        }

        #endregion

        #region Medium Max: 1000
        private void Thousand_CheckedChanged(object sender, EventArgs e)//Max 1000 Button
        {
            randNumGenerator(mediumMaxSize);
        }
        #endregion

        #region Large Max: 10000
        private void tenThousand_CheckedChanged(object sender, EventArgs e)//Max 10000 Button
        {
            randNumGenerator(largeMaxSize);
        }
        #endregion

        #region Extra Large Max: 100000
        private void oneHundredThousand_CheckedChanged(object sender, EventArgs e)//Max 100000 Button
        {
            randNumGenerator(extraLargeMaxSize);
        }
        #endregion
        #endregion

        #region Open and Save
        #region Open File Button
        private void button3_Click(object sender, EventArgs e) //Open from File Button
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Numbers.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string numbers;
                    while ((numbers = r.ReadLine()) != null)
                    {
                        Numbers.Items.Add(numbers);

                    }
                }
            }
        }
        #endregion

        #region Save to File Button
        private void button2_Click(object sender, EventArgs e) //Save to File Button
        {
            if (Numbers.Items.Count > 1)
            {
                using (System.IO.TextWriter TW = new System.IO.StreamWriter("numbers.txt"))
                {
                    foreach (var item in Numbers.Items)
                    {
                        TW.WriteLine(item);
                    }
                }

                Process.Start("numbers.txt");
            }
        }
        #endregion
        #endregion
    }
}
