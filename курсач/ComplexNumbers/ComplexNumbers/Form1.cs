using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryComplexNumbers; 
 
namespace ComplexNumbers
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        } 
         
       public string selectedState = ""; 
         
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = comboBox.SelectedItem.ToString();
        }
        
       

        void Calculate()
        {
            double realZ1, imagZ1, realZ2, imagZ2;

            try
            { 
                realZ1 = double.Parse(reZ1.Text);
                imagZ1 = double.Parse(imZ1.Text);
                realZ2 = double.Parse(reZ2.Text);  
                imagZ2 = double.Parse(imZ2.Text);

                Complex z1 = new Complex(realZ1, imagZ1);
                Complex z2 = new Complex(realZ2, imagZ2); 
                 
                if (selectedState == "")
                {
                    throw new Exception("Выберите операцию из выпадающего меню");
                }

                switch (selectedState)
                {
                    case "+":
                        Complex z3 = z1 + z2;
                        listBox.Items.Add(z3.Print());
                        break;
                    case "-":
                        z3 = z1 - z2;
                        listBox.Items.Add(z3.Print());
                        break;
                    case "*": 
                        z3 = z1 * z2;
                        listBox.Items.Add(z3.Print());
                        break;
                    case "/":
                        if (z2.re == 0.0 || z2.im == 0.0)
                            throw new DivideByZeroException("На ноль делить нельзя, введите другое значение z2 и попробуйте еще раз.");   
                        z3 = z1 / z2;   
                        listBox.Items.Add(z3.Print());
                        break;
                } 
            }  
            catch (FormatException)  
            { 
                MessageBox.Show("В поля ввода можно вводить числа либо дроби! Исправьте введенную информацию и попробуйте еще раз.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
            catch(Exception ex)     
            {  
                MessageBox.Show(ex.Message , "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
              
        }      

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Calculate();     
        }  
    } 
}  
  