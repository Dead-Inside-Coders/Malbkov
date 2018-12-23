using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursionMethods
{
    public partial class MergeSortForm : Form
    {
        public MergeSortForm()
        {
            InitializeComponent();
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            string[] txt = textBoxMerge_NotSort.Text.Split(' ');

            int[] numbers = new int[txt.Length]; 
             
            for (int i = 0; i < txt.Length; i++)
            { 

                try 
                {
                    numbers[i] = Convert.ToInt32(txt[i]);
                }
                catch {
                    MessageBox.Show("Введите последовательность чисел для сортировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                } 
            } 

            int [] result = ClassLibraryRecursionMethods.Sorts.Mergesort(numbers);

            textBoxMerge_Sort.Text = "";  

            for (int i = 0; i < result.Length; i++) 
                textBoxMerge_Sort.Text += result[i] + " "; 



        }
    }
}
