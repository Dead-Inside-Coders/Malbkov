using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{  
    public static class Algoritms  
    {   
        /// <summary> 
        // создание массива из случайных чисел
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int[] ArrayGenerate(int length)
        {
            Random rnd = new Random(Environment.TickCount);
            int[] a = new int[length]; 
            for (int i = 0; i < length-1; i++)
            {
                a[i] = rnd.Next(1, 100);
            }
            return a;
        }  
         
        /// <summary>
        // Сортировка массива    
        /// </summary>
        /// <param name="Elements"></param>
        private static void Sort(int[] Elements) 
        {
            for (int i = 0; i < Elements.Length; i++)
            {
                for (int j = 0; j < Elements.Length - 1; j++)
                {
                    if (Elements[j] > Elements[j + 1])
                    { 
                        int temp = Elements[j];
                        Elements[j] = Elements[j + 1];
                        Elements[j + 1] = temp;
                    }
                } 
            }
        }
         
        /// <summary>
        // Есть ли смысл начинать поиск
        /// </summary>
        /// <returns></returns>
        private static bool SearchCheck(int[] Elements , int Element)
        { 
            // Если массив пустой или искомый элемент меньше первого или больше последнего
            if (Elements.Length == 0 || Element < Elements[0] || Element > Elements[Elements.Length - 1]) 
            return false;

            return true;  
        }   
        /// <summary>
        /// Двоичный поиск
        /// </summary>
        /// <param name="Elements"></param>
        /// <param name="Element"></param>
        /// <returns></returns>
        public static int? BinarySearch (int[] Elements, int Element) 
        {
            Sort(Elements);
              
            if( SearchCheck(Elements, Element) )
            {
                int left  = 0;   
                int right = Elements.Length; 

                while (left < right) //пока слева и справа от середины есть элементы
                {
                    int mid = (left + right) / 2; //определяем середину

                    if (Element <= Elements[mid]) //если элемент меньше или равен элементу в середине
                        right = mid; //перемещаем правую границу
                    else
                        left = mid + 1; //иначе левую

                } 
                // Теперь последний элемент может указывать на искомый элемент массива.
                if (Elements[right] == Element)
                    return right; 

                else  
                    return null; 

            }
            else
            {
                return null;
            }

        }  
        /// <summary>
        /// Рекурсивный двоичный поиск
        /// </summary>
        /// <param name="Elements"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="Element"></param>
        /// <returns></returns>
        public static int? BinarySearchRec(int[]Elements , int left , int right , int Element)
        {
            Sort(Elements);

            if (SearchCheck(Elements, Element))
            {
                if (left < right) //пока слева и справа от середины есть элементы 
                {
                    int mid = (left + right) / 2; //определяем середину 

                    if (Elements[right] == Element) //ели элемент найден, возвращаем его
                        return right; 
                    else if (Element <= Elements[mid]) //если элемент меньше или равен элементу в середине
                        BinarySearchRec(Elements, left, mid-1, Element);//перемещаем правую границу
                    else
                        BinarySearchRec(Elements, mid + 1, right, Element);//иначе левую
                }  
                else 
                    return null; 
            }
             
            return null;
        }
         /// <summary>
         /// Линейный поиск
         /// </summary>
         /// <param name="Elements"></param>
         /// <param name="Element"></param>
         /// <returns></returns>
        public static int? LinearSearch(int[] Elements , int Element)
        {
            if (SearchCheck(Elements, Element))
            {
                for (int i = 0; i < Elements.Length; i++)
                {
                    if (Elements[i] == Element)
                        return i;
                }
                return null;
               
            } 
            else 
                return null;
        }
        /// <summary>
        /// Интерполяционный поик
        /// </summary>
        /// <param name="a"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int? InterpolationSearch(int[] a, int key)
        { 
            Sort(a); 
            if (SearchCheck(a, key))
            {
                int left = 0;// левая граница поиска (будем считать, что элементы массива нумеруются с нуля) 
                int right = a.Length - 1;// правая граница поиска 

                while ( (a[left]<key) & (key < a[right]) )
            {
                int mid = left + (key - a[left]) * (right - left) / (a[right] - a[left]); // индекс элемента, с которым будем проводить сравнение
                if (a[mid] < key)
                    left = mid + 1;
                else if (a[mid] > key)
                    right = mid - 1;
                else
                    return mid;
            }
            if (a[left] == key)
                return left;
            else if (a[right] == key)
                return right;
            else
                return null;
            } 
            else
                return null;

        }
         
          
         
    } 
       
}
