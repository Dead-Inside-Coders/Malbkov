using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ClassLibraryRecursionMethods
{
    public class Fibonachi
    {
         
        /// <summary>  
        /// Функция для нахрждения числа из последователности Фибоначи
        /// </summary>
        /// <param name="n">Позиция числа Фибоначи</param>
        /// <returns>значение числа Фибоначи на дангной позиции</returns>
        public int FibRec(int n)
        {
            int result = 1;
            if (n <= 1) 
            {
                return n;
            } 
            else
            {
                return result = FibRec(n - 1) + FibLoop(n - 2);

            } 
            
        } 
         

        /// <summary>
        /// Функция для нахождения числа из последователности Фибоначи
        /// </summary>
        /// <param name="n">Позиция числа Фибоначи</param>
        /// <returns>значение числа Фибоначи на дангной позиции</returns>
        public int FibLoop(int n)
        {
            int n1 = 1;
            int n2 = 1;  
            int result = 0;
            if (n <= 1)
            {
                return n;
            }
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    result = n1 + n2;
                    n1 = n2;
                    n2 = result;

                }
                return n2;
            }    
        }

    }

    public class Sorts
    {
        /// <summary>
        ////Дополнительная функция для quicksort
        /// </summary>
        /// <param name="array">Массив для сортировки</param>
        /// <param name="start">Стартовая позиция</param>
        /// <param name="end">Конечная позиция</param>
        /// <returns>Данные для quicksort</returns>
        private static int partition(List<int> array, int start, int end)
        {
            int temp; 
            int marker = start; 
            for (int i = start; i <= end; i++)
            {
                if (array[i] < array[end])
                {
                    temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }

            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }

        /// <summary>
        /// Быстрая сортировка
        /// </summary>
        /// <param name="array">Массив для сортировки</param>
        /// <param name="start">Стартовая позиция</param>
        /// <param name="end">Конечная позиция</param> 
        public static void Quicksort(List<int> array, int start, int end)
        {
            if (start >= end)
            {
                return; 
            }
            int pivot = partition(array, start, end);
            Quicksort(array, start, pivot - 1);
            Quicksort(array, pivot + 1, end);
        } 


        /// <summary>
        ////Сортировка массива слиянием
        /// </summary>
        /// <param name="massive"></param>
        /// <returns></retЗurns> 
        public static int[] Mergesort(int[] massive)
        {
            if (massive.Length == 1)
                return massive;
            int mid_point = massive.Length / 2;
            return Merge(Mergesort(massive.Take(mid_point).ToArray()), Mergesort(massive.Skip(mid_point).ToArray()));
        } 
           
        /// <summary>
        /// Разделение и сортировка двух массивов 
        /// </summary> 
        /// <param name="mass1"></param> 
        /// <param name="mass2"></param> 
        /// <returns></returns>
        private static int[] Merge(int[] mass1, int[] mass2)
        {
            int a = 0, b = 0;
            int[] merged = new int[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                    if (mass1[a] > mass2[b] && b < mass2.Length)
                        merged[i] = mass2[b++];
                    else
                        merged[i] = mass1[a++];
                else 
                    if (b < mass2.Length) 
                    merged[i] = mass2[b++]; 
                else  
                    merged[i] = mass1[a++]; 
            } 
            return merged;  
        } 
         
    }    
      
    public static class ZeroLib 
    {  
        /// <summary>  
        /// Число n-разрядных чисел в системе с основанием k не содержащих двух нулей подряд
        /// </summary> 
        /// <param name="n">Разрядность</param>  
        /// <param name="k">Система счисления</param> 
        /// <returns></returns>  
        public static long Not_2Zero(int n, int k) 
        {      
            return Zero_end(n, k) + No_Zero_end(n, k);
        }  
               
        /// <summary>  
        /// Число n-разрядных чисел
        /// в системе с основанием k,
        /// не содержащих двух нулей подряд
        /// и заканчивающихся нулем
        /// </summary>
        /// <param name="n">Разрядность</param>
        /// <param name="k">Система счисления</param> 
        /// <returns></returns>
        public static long Zero_end(int n, int k)                                                                               
        { 
            if (n == 1) return 0; 
            return No_Zero_end(n - 1, k);   
        } 
            
        /// <summary> 
        /// Число n-разрядных чисел  
        /// в системе с основанием k, 
        /// не содержащих двух нулей подряд 
        /// и заканчивающихся цифрой, отличной от нуля 
        /// </summary>  
        /// <param name="n">Разрядность</param> 
        /// <param name="k">Система счисления</param>  
        /// <returns></returns>   
        public static long No_Zero_end(int n, int k) 
        { 
            if (n == 1) return k - 1; 
            if (n == 2) return (k - 1) * (k - 1);  
            return Not_2Zero(n - 1, k) * (k - 1); 
        }      
    } 
     
    public class Tasks  
    {
        /// <summary>
        /// Вычисление коэффициентов для функции Stairs
        /// </summary>
        /// <param name="N"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        private ulong[] Coef(int N, int K)

        {

            ulong[] res = new ulong[K];

            ulong q = 0;

            for (int i = 0; i < K; i++)

                res[i] = 1; 

            for (int j = 1; j < N - K; j++ )

{ 

                q = res[0];

                for (int i = 0; i < K - 1; i++)

                    res[i] = q + res[i + 1];

                res[K - 1] = q;

            }

            return res;

        }
         
        /// <summary>
        /// Количество возможных вариантов различных маршрутов зайца 
        /// </summary>
        /// <param name="N">Общее число ступенек</param>
        /// <param name="K">Максимальное количество ступенек, которое заяц может преодолеть заяц одним прыжоком</param>
        /// <returns></returns> 
        public ulong Stairs(int N, int K)   
        {   
            if (K == 1) return 1;
              
            ulong M = 0;

            if (N > K)

            {

                ulong[] coef = Coef(N, K);

                for (int i = 0; i < K; i++)  

                    M += coef[i] * ((ulong)1 << (K - 1 - i));

            }

            else 

                M = (ulong)1 << (N - 1);

            return M;
             
        } 

        /// <summary> 
        /// Нахождение числа способов неправильной рассадки гостей(циклом)
        /// </summary>
        /// <param name="N">Кол-во гостей</param>
        /// <returns></returns>
        public int Chairs(int N)
        {   
            int x1 = 0, x2 = 1, x = 0;  
            for (int i = 1; i < N + 1; i++)
            {
                x = (i - 1) * (x1 + x2);
                x1 = x2;
                x2 = x; 
            } 
            return x; 
        }
         
         
        /// <summary> 
        /// Нахождение числа счастливых билетов  
        /// </summary> 
        /// <param name="N">Длина билета</param>  
        /// <returns></returns>  
        public long HappyTicket(int N)   
        {  
            int n = N / 2;
            int[,] c = new int[n + 1, n * 9 + 1];  
            for (int i = 0; i <= 9; ++i) 
                c[1, i] = 1;
            for (int i = 2; i <= n; ++i)   
            {       
                for (int j = 0; j <= i * 9; ++j)
                { 
                    for (int k = 0; k <= Math.Min(j, 9); ++k)
                    {
                        c[i, j] += c[i - 1, j - k];
                    }
                }
            }
            long answer = 0;
            for (int i = 0; i <= n * 9; ++i)
                answer += c[n, i] * c[n, i];
            return answer;
        }

    }

      
}
