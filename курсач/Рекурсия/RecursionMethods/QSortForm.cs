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
    public partial class QSortForm : Form
    {
        public QSortForm()
        {
            InitializeComponent();
        }

         
        private void buttonQuick_Click(object sender, EventArgs e)
        { 

            List<int> a = new List<int>();//Список целочисленных значений

            string[] txt = textBoxQuick_NotSort.Text.Split(' ');//Деление введенного пользователем текста на части символом ' '(Пробел)

            for (int i = 0; i < txt.Count(); i++)//Пробегаемся по всем кусочкам 
            {
                try // Пробуем Добавить в список цифру, конвертированную в int 
                {
                    a.Add(Convert.ToInt32(txt[i]));
                }      
                catch {    
                    MessageBox.Show("Введите последовательность чисел для сортировки!", "Ошибка" , MessageBoxButtons.OK,MessageBoxIcon.Error);
                }  
            }  

            ClassLibraryRecursionMethods.Sorts.Quicksort(a, 0, a.Count - 1); //Быстрая сортировка

            textBoxQuick_Sort.Text = "";//Очищаем TextBox2

            for (int i = 0; i < a.Count(); i++)//Добавляем все элементы списка во второй TextBox
                textBoxQuick_Sort.Text += a[i] + " ";



        }

         
         
    } 
}
 