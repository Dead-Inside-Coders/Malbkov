using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDLL
{
    public static class Collatz
    {
        private static double Nto1(double N)
        {
            double count = 0;

            while (N != 1)
            {
                if (N % 2 == 0)
                {
                    N = N / 2;
                }
                else
                {
                    N = 3 * N + 1;
                } 

                count++;
            }
            return count;
        }

        public static bool IsExistK(double n, double M)
        {

            double N = Math.Pow(2, n - 1);

            for (double i = N + 1; i <= N + M; i++)
            {
                double countsteps = Nto1(i);
                if (countsteps < N)
                {
                    return true;
                }
            }

            return false;
        }
    }




    
}
