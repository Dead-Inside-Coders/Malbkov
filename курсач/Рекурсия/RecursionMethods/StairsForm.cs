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
    public partial class StairsForm : Form
    {
        public StairsForm()
        {
            InitializeComponent(); 
        }
          
        Tasks Task = new Tasks();
         
        void Calculate() 
        {
            try 
            {
                int N = Int32.Parse(textBox_CountStairs.Text);
                int K = Int32.Parse(textBoxMaxJump.Text);

                Tasks task = new Tasks(); 
                textBox_CountWays.Text = task.Stairs(N, K).ToString() ;  

                if (N < 0 || K < 0)
                    throw new Exception("Числа N и K должны быть положительными");

                if (K > N)
                    throw new Exception("Число K не может быть больше числа N");
            }
            catch (FormatException) 
            {
                textBox_CountWays.Text = "Ошибка: неверный ввод данных ";
            }
            catch (Exception ex) 
            {
                textBox_CountWays.Text = "Ошибка: " + ex.Message;
            }




            

        }

        private void buttonStairs_Click(object sender, EventArgs e) 
        {
            Calculate(); 
        } 
    } 
} 
