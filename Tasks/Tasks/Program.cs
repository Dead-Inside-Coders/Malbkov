using System;
using TasksDLL;

namespace Tasks
{
    class Program 
    {  
        static void CoinExchange()
        {
            Console.WriteLine("*Coin Exchange*");
            Console.WriteLine("Введите количество номиналов:");

            try
            {
                int count = int.Parse(Convert.ToString(Console.ReadLine()));

                if (count < 1)
                    throw new Exception("Количество номиналов должно быть положительным");


                Console.WriteLine("Введите значения номиналов:");

                int[] values = new int[count + 1];
                 
                for (int i = 1; i < count + 1; i++)
                {
                    Console.Write(i + ".");
                    values[i] = int.Parse(Convert.ToString(Console.ReadLine()));
                    if (values[i] < 1)
                        throw new Exception("Значение номиналов должно быть положительным");
                }

                Console.WriteLine("Введите сумму , которую необходимо выдать:");

                int sum = int.Parse(Convert.ToString(Console.ReadLine()));

                if (sum < 1)
                    throw new Exception("Сумма должна быть положительной");
                 
                Array.Sort(values);
                CoinExchange FirstOp = new CoinExchange(count, values, sum);
                FirstOp.MinBillsLoop();

            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: неверный ввод данных.");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка:" + ex.Message);
                Console.ResetColor();
            }

            Console.ReadKey();
             
        }
         
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
            double n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите M");
            double M = int.Parse(Console.ReadLine());

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
            CollatzProblem();
            // SubjectsCount();
            //Sequence();
            //CoinExchange();
  
        }
        
       
    }
}
                                        