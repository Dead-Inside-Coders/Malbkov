using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
 
namespace LabsClassLibrary
{
    public class Search
    {  
        /// <summary>     
        ///  Определяет индекс первого вхождения отдельного символа или подстроки в строке:
        /// </summary>
        /// <param name="S">Входная строка</param> 
        /// <param name="Value">Входная подстрока</param> 
        /// <returns>Индекс вхождения</returns> 
        public int IndexEnter(string S, string Value)
        {
            int Index;
            int N = S.Length;
            int M = Value.Length;
            string str = null; 
            for (int i = 0; i < N; i++)
            {
                if (S[i] == Value[0])
                {
                    Index = i;
                    str = null;
                    for (int k = i; k < M + i && k < N; k++)
                    {
                        str = str + S[k];
                    }
                    if (str == Value)
                    {
                        return Index;
                    }
                }
            }
            return -1; 
        }

        /// <summary>
        /// Хеш-функция для алгоритма Рабина-Карпа
        /// </summary>
        /// <param name="x"></param> 
        /// <returns></returns> 
        private static int Hash(string x)
        {
            int p = 31; //Простое число
            int rez = 0; //Результат вычисления
            for (int i = 0; i < x.Length; i++)
            {
                rez += (int)Math.Pow(p, x.Length - 1 - i) * (int)(x[i]);//Подсчет хеш-функции
            }
            return rez;
        }

        /// <summary>
        /// Функция поиска алгоритмом Рабина-Карпа 
        /// </summary>
        /// <param name="x">Строка</param> 
        /// <param name="s">Подстрока</param>
        /// <returns>Номера всех вхождений образца в строку</returns>
        public string Rabina(string x, string s)
        {
            string nom = ""; //Номера всех вхождений образца в строку
            if (x.Length > s.Length) return nom; //Если искомая строка больше исходной – возврат пустого поиска
            int xhash = Hash(x); //Вычисление хеш-функции искомой строки
            int shash = Hash(s.Substring(0, x.Length)); //Вычисление хеш-функции первого слова длины образца в строке S
            bool flag;
            int j;
            for (int i = 0; i < s.Length - x.Length; i++)
            {
                if (xhash == shash)//Если значения хеш-функций совпадают
                {
                    flag = true;
                    j = 0;
                    while ((flag == true) && (j < x.Length))
                    {
                        if (x[j] != s[i + j]) flag = false;
                        j++;
                    }
                    if (flag == true) //Если искомая строка совпала с частью исходной
                        nom = nom + Convert.ToString(i) + ", "; //Добавление номера вхождения
                }
                else //Иначе вычисление нового значения хеш-функции
                    shash = (shash - (int)Math.Pow(31, x.Length - 1) * (int)(s[i])) * 31 + (int)(s[i + x.Length]);
            }
            if (nom != "") //Если вхождение найдено
            {
                nom = nom.Substring(0, nom.Length - 2); //Удаление запятой и пробела
            }
            else { nom = "-1"; }
            return nom; //Возвращение результата поиска
        }
         
        /// <summary> 
        /// Алгоритм Кнута-Морриса-Пратта
        /// </summary>
        /// <param name="s"></param>  
        /// <returns></returns>
        private static int[] GetPrefix(string s)
        { 
            int[] result = new int[s.Length];
            result[0] = 0;
            int index = 0;

            for (int i = 1; i < s.Length; i++)
            {
                while (index >= 0 && s[index] != s[i]) { index--; }
                index++;
                result[i] = index;
            }

            return result;
        }

        public int FindSubstring(string pattern, string text)
        {
            int res = -1;
            int[] pf = GetPrefix(pattern);
            int index = 0;

            for (int i = 0; i < text.Length; i++)
            {
                while (index > 0 && pattern[index] != text[i]) { index = pf[index - 1]; }
                if (pattern[index] == text[i]) index++;
                if (index == pattern.Length)
                {
                    return res = i - index + 1;
                }
            }

            return res; 
        }

        /// <summary>
        /// Поиск основы слова 
        /// </summary>
        /// <param name="text"></param> 
        /// <returns></returns>
        public static string Stemming(string text)
        {
            List<string> ending = new List<string> { "ly", "ed", "ing" };
            List<string> prefix = new List<string> { "re", "de", "un", "dis", "non", "il", "pre" };

            for (int i = 0; i < ending.Count; i++)
            { 
                int index = text.IndexOf(ending[i]);   
                 
                if (index != -1 && index >= (text.Count() - 3))
                    text = text.Remove(index);
            } 
            for (int i = 0; i < prefix.Count; i++)   
            {  
                int index = text.IndexOf(prefix[i]);
                   
                if (index == 0)
                    text = text.Remove(0, prefix[i].Length);
            }
            return text; 
        }     
             
    }    

    public class StrCases
    {
        public static Search Algoritm = new Search(); //Объект класса Algoritms  

        public static void Case1()
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine("Введите подстроку:");
            string substr = Console.ReadLine();

            int index = Algoritm.IndexEnter(str, substr);

            Console.WriteLine("Индекс вхождения подстроки в строку: " + index);
            Console.ReadLine();
        }

        public static void Case2()
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine("Введите подстроку:");
            string substr = Console.ReadLine();

            string indexs = Algoritm.Rabina(substr, str);

            Console.WriteLine("Номера вхождения подстроки в строку: " + indexs);
            Console.ReadLine();

        }

        public static void Case3()
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine("Введите подстроку:");
            string substr = Console.ReadLine();

            int index = Algoritm.FindSubstring(substr, str);

            Console.WriteLine("Индекс вхождения подстроки в строку: " + index);
            Console.ReadLine();
        }

        public static void Case4()
        {
            Console.WriteLine("Нахождение основы слова:");
            Console.WriteLine("Введите слово: ");
            string input = Console.ReadLine();
            string output = string.Empty;
            try  
            {  
                output = Search.Stemming(input);
            } 
            catch(Exception)
            { }
            Console.WriteLine("Результат: ");
            Console.WriteLine(output);
        }   
    }  

   

}
