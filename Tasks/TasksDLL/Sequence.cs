using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDLL
{
   public class Sequence
    {

        private List<int> Sequencearr { get;  set; }//Создаем лист
        //Заносим данные из строки в лист с помощью лямбда выражения
        public Sequence(string s)
        {
            try
            {
                Sequencearr = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToList();
            }
            catch (Exception) { }
        }

        //Метод для получение последовательности
        private void GetSequence()
        {  
            //Проходим по листу
            for (int i = 0; i < Sequencearr.Count; i++)
            {
                //Начинаем с второго элемента
                if (i != 0 && i != Sequencearr.Count - 1)
                {
                    //Условия для удаление элемента из последовательности,
                    //если элемент расположен между двумя большими числами мы его удаляем
                    if (Sequencearr[i - 1] > Sequencearr[i] && Sequencearr[i + 1] > Sequencearr[i])
                    {
                        Sequencearr.RemoveAt(i);
                        i--;//тк количестов элементов в листе уменьшилось

                    }
                   
                }
            }
        }
        //Печатаем 
        public void PrintSequence()
        {
            GetSequence();
            string stroka=string.Empty;
            foreach (var item in Sequencearr)
            {
                
                stroka += item + " ";
               
            }
            Console.WriteLine(stroka);
            Console.ReadKey();
        }


    }
}
