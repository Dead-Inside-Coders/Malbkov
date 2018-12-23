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
    public partial class Zero : Form
    { 
        public Zero()
        {
            InitializeComponent();
        }
          

        void Calculate(TextBox TextBoxInput1, TextBox TextBoxInput2, TextBox TextBoxOutput, Func<int, int, long> Func)
        {
            try
            {
                int n = Int32.Parse(TextBoxInput1.Text); 
                int k = Int32.Parse(TextBoxInput2.Text); 

                TextBoxOutput.Text = Convert.ToString(Func(n, k));

                if (n < 0 || n > 10)
                    throw new Exception("Число n должно быть от 1 до 9");
                if (k < 0 || k > 16)
                    throw new Exception("Число k должно быть от 1 до 15");
            }  
            catch(FormatException)
            { 
                TextBoxOutput.Text = "Неверный ввод данных";
            }
            catch(Exception ex) 
            {
                TextBoxOutput.Text = "Ошибка: " + ex.Message;
            }

        }     
      
             
        private void buttonTask1_Click(object sender, EventArgs e)
        { 
            Calculate(textBoxN1,textBoxK1,textBoxR1, ZeroLib.Not_2Zero); 
        }   
              

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            Calculate(textBoxN3, textBoxK3, textBoxR3, ZeroLib.No_Zero_end);
        }
    } 
} 
   