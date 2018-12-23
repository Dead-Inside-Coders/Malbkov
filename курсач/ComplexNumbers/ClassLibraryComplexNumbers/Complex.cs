using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryComplexNumbers 
{
    public class Complex 
    {
        public double re, im; //действительная и мнимая часть

        public Complex()
        { }

        /// <summary> 
        /// Конструктор класса  
        /// </summary>
        /// <param name="r"></param> 
        /// <param name="i"></param> 
        public Complex(double r, double i)
        {
            re = r;
            im = i;
        }

        /// <summary>
        /// Метод сложения 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public Complex Plus(Complex a)
        {
            return new Complex(re + a.re, im + a.im);
        }

        /// <summary>
        /// Оператор сложения
        /// </summary>
        /// <param name="r1"></param> 
        /// <param name="r2"></param>
        /// <returns></returns>
        public static Complex operator +(Complex r1, Complex r2)
        {
            return (r1.Plus(r2));
        }

        /// <summary> 
        /// Метод вычитания
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public Complex Minus(Complex a)
        {
            return new Complex(re - a.re, im - a.im);
        }

        /// <summary>
        /// Оператор вычитания
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public static Complex operator -(Complex r1, Complex r2)
        {
            return (r1.Minus(r2));
        }

        /// <summary>
        /// Метод умножения
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public Complex Multiply(Complex a)
        {
            return new Complex(re * a.re - im * a.im, re * a.im + im * a.re);
        }

        /// <summary>
        /// Оператор умножения
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public static Complex operator *(Complex r1, Complex r2)
        {
            return (r1.Multiply(r2));
        }

        /// <summary>
        /// Метод деления 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public Complex Divide(Complex a)
        {
            Complex temp = new Complex();

            double r = a.re * a.re + a.im * a.im;
            if (r == 0)
                throw new DivideByZeroException("На ноль делить нельзя, введите другое значение z2 и попробуйте еще раз.");
            temp.re = (re * a.re + im * a.im) / r;
            temp.im = (im * a.re - re * a.im) / r;

            return temp;
        }

        /// <summary>
        /// Оператор деления
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public static Complex operator /(Complex r1, Complex r2)
        {
            return (r1.Divide(r2));
        }

        /// <summary>
        /// Модуль комплексного числа
        /// </summary>
        /// <returns></returns> 
        double Abs()
        {
            return Math.Sqrt(re * re + im * im);
        }

        public string Print()
        {

            if (im < 0)
            {
                return "" + re + im + "i";
            }
            if (im == 0)
            {
                return "" + re;
            }

            return re + "+" + im + "i";
        }

    }

}
 