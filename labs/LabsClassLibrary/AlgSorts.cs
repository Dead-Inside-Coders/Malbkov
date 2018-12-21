using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsClassLibrary
{
        public class Cases
        {
            public static void Case1()
            {
                Console.WriteLine("Введите элементы массива через пробел:");
                string array = Console.ReadLine();

                List<int> arrayElements = new List<int>();//Список целочисленных значений

                string[] txt = array.Split(' ');//Деление введенного пользователем текста на части символом ' '(Пробел)

                for (int i = 0; i < txt.Count(); i++)//Пробегаемся по всем кусочкам 
                {
                    try // Пробуем Добавить в список цифру, конвертированную в int  
                    {
                        arrayElements.Add(Convert.ToInt32(txt[i]));
                    }
                    catch
                    {
                        Console.WriteLine("Введите последовательность чисел для сортировки!");
                        Case1();
                    }
                }

                Sorts.BubbleSort(arrayElements); //Быстрая сортировка
                Console.WriteLine("Отсортированный массив:");
                for (int i = 0; i < arrayElements.Count(); i++)
                    Console.Write(arrayElements[i] + " ");

            }
            public static void Case2()
            {
                Console.WriteLine("Введите элементы массива через пробел:");
                string array = Console.ReadLine();

                string[] txt = array.Split(' ');

                int[] numbers = new int[txt.Length];

                for (int i = 0; i < txt.Length; i++)
                {

                    try
                    {
                        numbers[i] = Convert.ToInt32(txt[i]);
                    }
                    catch
                    {
                        Console.WriteLine("Введите последовательность чисел для сортировки!");
                        Case2();
                    }
                }

                int[] result = Sorts.Mergesort(numbers);

                Console.WriteLine("Отсортированный массив:");

                for (int i = 0; i < result.Length; i++)
                    Console.Write(result[i] + " ");

            }
            public static void Case3()
            {
                List<int> arrayElements = new List<int>();//Список целочисленных значений

                Console.WriteLine("Введите элементы массива через пробел:");
                string array = Console.ReadLine();

                string[] txt = array.Split(' ');//Деление введенного пользователем текста на части символом ' '(Пробел)

                for (int i = 0; i < txt.Count(); i++)//Пробегаемся по всем кусочкам 
                {
                    try // Пробуем Добавить в список цифру, конвертированную в int 
                    {
                        arrayElements.Add(Convert.ToInt32(txt[i]));
                    }
                    catch
                    {
                        Console.WriteLine("Введите последовательность чисел для сортировки!");
                    }
                }

                Sorts.Quicksort(arrayElements, 0, arrayElements.Count - 1); //Быстрая сортировка

                Console.WriteLine("Отсортированный массив: ");
                for (int i = 0; i < arrayElements.Count(); i++)//Добавляем все элементы списка во второй TextBox
                    Console.Write(arrayElements[i] + " ");

            }
            public static void Case4()
            {
                Console.WriteLine("Введите элементы массива через пробел:");
                string array = Console.ReadLine();

                string[] txt = array.Split(' ');

                int[] numbers = new int[txt.Length];

                for (int i = 0; i < txt.Length; i++)
                {
                    try
                    {
                        numbers[i] = Convert.ToInt32(txt[i]);
                    }
                    catch
                    {
                        Console.WriteLine("Введите последовательность чисел для сортировки!");
                        Case2();
                    }
                }

                Sorts.SelectionSort(numbers);

                Console.WriteLine("Отсортированный массив:");

                for (int i = 0; i < numbers.Length; i++)
                    Console.Write(numbers[i] + " ");
            }
        }
          
        public class Sorts
        {
            /// <summary>
            ////Сортировка пузырьком 
            /// </summary>
            /// <param name="A">Массив для сортировки</param>
            public static void BubbleSort(List<int> A)
            {
                for (int i = 0; i < A.Count; i++)
                {
                    for (int j = 0; j < A.Count - i - 1; j++)
                    {
                        if (A[j] > A[j + 1])
                        {
                            int temp = A[j];
                            A[j] = A[j + 1];
                            A[j + 1] = temp;
                        }
                    }
                }
            }


            /// <summary>
            ////Сортировка массива слиянием
            /// </summary>
            /// <param name="massive"></param>
            /// <returns></returns>
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
            ////Сортировка выбором 
            /// </summary>
            /// <param name="arr"></param>
            public static void SelectionSort(int[] arr)
            {
                int min, temp;
                int length = arr.Length;

                for (int i = 0; i < length - 1; i++)
                {
                    min = i;

                    for (int j = i + 1; j < length; j++)
                    {
                        if (arr[j] < arr[min])
                        {
                            min = j;
                        }
                    }

                    if (min != i)
                    {
                        temp = arr[i];
                        arr[i] = arr[min];
                        arr[min] = temp;
                    }
                }

            }
    }
}
  