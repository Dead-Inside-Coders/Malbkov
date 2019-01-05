using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksDLL;

namespace Tasks
{
    class Program
    { 
        static void CollatzProblem()
        {
            Console.WriteLine("Введите cтепень n числа 2^n-1 ");
            double n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите M");
            double M = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(Collatz.IsExistK(n, M)));
            Console.ReadKey(); 
        }
                  
        static void Main(string[] args) 
        {
             //FindTriangle.Find();  
            CollatzProblem();
        } 
    }
}
                                        