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
        static void SubjectsCount()
        {
            Console.WriteLine("Введите предметы: ");
            string input = Console.ReadLine();
            string[] arr = input.Split(' ',',');
            Abbr abbr = new Abbr(arr);
            abbr.PrintSubjects();

        }

        static void CollatzProblem()
        {
            Console.WriteLine("Введите cтепень n числа 2^n-1 ");
            double n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите M");
            double M = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(Collatz.IsExistK(n, M)));
            Console.ReadKey(); 
        }
                  
        static void Sequence()
        {
            Console.WriteLine("Введите последовательность через пробел:");
            string s = Console.ReadLine();
            Sequence dad = new Sequence(s);
            dad.PrintSequence();
        }
        static void Main(string[] args) 
        {
            //FindTriangle.Find();  
            //CollatzProblem();
            // SubjectsCount();
            Sequence();




            
        }
        
       
    }
}
                                        