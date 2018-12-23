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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuickSort_Click(object sender, EventArgs e)
        {
            QSortForm Form = new QSortForm(); 
            Form.Show(); 

        }   

        private void buttonFibonachi_Click(object sender, EventArgs e)
        {
            FibonacciForm Form = new FibonacciForm();
            Form.Show();
        }  

        private void buttonMergeSort_Click(object sender, EventArgs e)
        {
            MergeSortForm Form = new MergeSortForm();
            Form.Show();
        }

        private void buttonStairs_Click(object sender, EventArgs e)
        {
            StairsForm Form = new StairsForm();
            Form.Show();
        } 

        private void buttonChairs_Click(object sender, EventArgs e)
        {
            Chairs Form = new Chairs();
            Form.Show();
        }

        private void buttonHanoi_Click(object sender, EventArgs e)
        {
            TowerOfHanoi Form = new TowerOfHanoi();
            Form.Show();
        }

        private void buttonHappyTicket_Click(object sender, EventArgs e)
        {
            HappyTicket Form = new HappyTicket();
            Form.Show();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            Zero Form = new Zero();
            Form.Show();
        }
    } 
}    
     