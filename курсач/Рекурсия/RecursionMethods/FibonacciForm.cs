using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryRecursionMethods;
 
namespace RecursionMethods
{ 
    public partial class FibonacciForm : Form
    {
        public FibonacciForm()
        {
            InitializeComponent();
        } 

        Fibonachi FibObj = new Fibonachi();

        private void buttonRec_Click(object sender, EventArgs e)
        {
            int n;

            if (Int32.TryParse(textBoxRec_Number.Text, out n))
            { 
                if (n > 0)
                    textBoxRec_Result.Text = FibObj.FibRec(n).ToString();
                else
                {
                    textBoxRec_Result.Text = "Ошибка.Введите положительное число";
                }
            }     
            else    
            {  
                textBoxRec_Result.Text = "Ошибка.Введите число";  
            }  
             
        }  
            
        private void buttonLoop_Click(object sender, EventArgs e)
        { 
            int n;
             
            if (Int32.TryParse(textBoxLoop_Number.Text, out n)) 
            {
                if (n > 0) 
                    textBoxLoop_Result.Text =FibObj.FibLoop(n).ToString();
                else
                {
                    textBoxLoop_Result.Text = "Ошибка.Введите положительное число";
                } 
            }
            else  
            {
                textBoxLoop_Result.Text = "Ошибка.Введите число";
            }
        }

    } 
}     
     