using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDLL
{
    public class CoinExchange
    {

        public static int Cnt; //количество номиналов 

        public static int[] Values = new int[Cnt + 1]; //значения номиналов

        public int Sum; //сумма , которую необходимо выдать 

        public CoinExchange(int count, int[] values, int sum)
        {
            Cnt = count;
            Values = values;
            Sum = sum;
        }

        public void SortValues()
        {

            for (int j = 0; j < Cnt + 1; j++)
            {
                for (int i = 0; i < Cnt - 1; i++)
                {
                    if (Values[i] > Values[i + 1])
                    {
                        int temp = Values[i];
                        Values[i] = Values[i + 1];
                        Values[i + 1] = temp;
                    }
                }
            }
        }

        public void MinBillsLoop()
        {
            int[] bills = new int[Cnt + 1]; //количество купюр определенного номинала
            int currentBill;

            for (int i = 0; i <= Cnt - 1; i++)
            {
                currentBill = Sum / (Values[Cnt - i]);
                bills[i + 1] = currentBill;
                Sum = Sum % Values[Cnt - i];
            }
            string str_msg = "0";

            int minBills = 0;

            for (int i = 0; i < Cnt + 1; i++)
            {

                if (bills[i] != 0)
                {
                    str_msg = "";
                    str_msg = str_msg + bills[i] + " купюр " + " с номиналом " + Values[Cnt - i + 1] + " | ";
                    minBills += bills[i];
                }
            }

            if (Sum == 0)
            {
                Console.WriteLine("Выдача: " + str_msg);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Всего купюр: " + minBills);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Выдано: " + str_msg + ". Запрошенная сумма не может быть выдана полностью или сумма меньше номинала, осталось " + Sum);
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
