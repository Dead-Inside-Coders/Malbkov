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
    public partial class Chairs : Form
    { 
        public Chairs()
        {
            InitializeComponent(); 
        }

        Tasks Task = new Tasks();

        void Calculate()
        {
            try
            {
                int input = Int32.Parse(textBoxChairs_Guests.Text);

                if (input < 0)
                {
                    throw new Exception("Количество гостей должно быть больше 0");
                } 

                textBoxChairs_Ways.Text = Task.Chairs(input).ToString();

            } 
            catch(FormatException)
            {
                textBoxChairs_Ways.Text = "Ошибка: неверный ввод данных";
            } 
            catch(Exception ex)
            {
                textBoxChairs_Ways.Text = "Ошибка: " + ex.Message;
            }
           

            

        }

        private void buttonChairs_Click(object sender, EventArgs e)
        {
            Calculate();             
        }

    }
} 
