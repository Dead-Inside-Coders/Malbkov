using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TasksDLL
{
    public class Abbr
    {
        private string[] subjects;//массив предметов

        private Dictionary<string, int> dict = new Dictionary<string, int>(); //Создаем словарь предмет + частота повторения

        //Конструктор
        public Abbr(string[] arr)
        {
            subjects = arr;
        }
        
        private Dictionary<string, int> GetDictionary()
        {
            Array.Sort(subjects);//Сортируем предметы
            int count = 1;

            //Проходим циклом по предметам
            for (int i = 0; i < subjects.Length; i++)
            {
               //Если не последний элемент
                if (i != subjects.Length - 1)
                {
                    //Смотрим на вхождение в сторку первых двух элементов из отсортированого массива "предметов"
                    if (subjects[i + 1].IndexOf(subjects[i]) == 0)
                        count++;

                    //Добавляем в словарь последний похожий элемент
                    else
                    {
                        dict.Add(subjects[i], count);
                        count = 1;
                    }
                }
                else
                    dict.Add(subjects[i], count);
            }
            return dict;

        }

        //Печатаем элементы из словаря 
        public void PrintSubjects()
        {
            
           var dickT = GetDictionary();
            foreach (var item in dickT)
            {
                Console.WriteLine("Кол-во предметов  " + $"\"{item.Key}\""  + " - " + item.Value );
            }
            Console.ReadKey();
        }




    }
}
