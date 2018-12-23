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
    public partial class TowerOfHanoi : Form
    { 
        public TowerOfHanoi()
        {
            InitializeComponent();
        }

        public static string ListElement(char a,char b)
        {
            return "Переложить диск из " + Convert.ToString(a) + " в " + Convert.ToString(b);
            
        }  
           
        void HanoiSolution(int k, char a, char b, char c)
        {

                if (k > 1) HanoiSolution(k - 1, a, c, b);
                listBoxHanoi.Items.Add(ListElement(a, b));
                if (k > 1) HanoiSolution(k - 1, c, b, a);

        }  

        void Calculate()
        {
            try
            {
                int count = Int32.Parse(textBoxCountDisk.Text);

                HanoiSolution(count, 'A', 'B', 'C');

                if (count < 0)
                    throw new Exception("Количество дисков должно быть положительным");
            } 
            catch(FormatException) 
            { 
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                listBoxHanoi.Items.Add("Ошибка: "+ex.Message);
            }

            }

        private void buttonHanoi_Click(object sender, EventArgs e)
        {
            Calculate();    
        }
        
    } 
      
}
 