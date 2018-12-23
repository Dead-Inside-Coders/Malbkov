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
    public partial class HappyTicket : Form
    {

        public HappyTicket()
        {
            InitializeComponent(); 
        }
         
        Tasks Task = new Tasks();
         
        void Calculate(TextBox tbi,TextBox tbo )
        {
            
            if (Int32.TryParse(tbi.Text, out int result))  
            {
                if (result > 20)
                    tbo.Text = "Длина билетов: до 20"; 
                else if (result > 0 & result != 1 & result%2==0)
                    tbo.Text = Task.HappyTicket(result).ToString();
                else 
                    tbo.Text = "Ошибка. Введите нечетное положительное число , отличное от единицы ";     
            }  
            else   
            { 
                tbo.Text = "Ошибка. Введите число ";  
            }

          
        }
         
        private void buttonResult_Click(object sender, EventArgs e)
        {   
            Calculate(textBoxInput, textBoxOutput); 
        } 
    }
}  
 