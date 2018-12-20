using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BinarySearch_Click(object sender, EventArgs e)
        {
            BinarySearchForm f = new BinarySearchForm();
            f.Show();
        }

        private void BinarySearch_Rec_Click(object sender, EventArgs e)
        {
            BinarySearchRecForm f = new BinarySearchRecForm();
            f.Show();
        }

        private void LinearSearch_Click(object sender, EventArgs e)
        {
            LinearSearchForm f = new LinearSearchForm();
            f.Show();
        }

        private void InterpolationSearch_Click(object sender, EventArgs e)
        {
            InterpolationSearchForm f = new InterpolationSearchForm();
            f.Show();
        }
    }
}
 