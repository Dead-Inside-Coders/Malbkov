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
        private string[] subjects;

        private Dictionary<string, int> dict = new Dictionary<string, int>(); 

        public Abbr(string[] arr)
        {
            subjects = arr;
        }
        
        private Dictionary<string, int> GetDictionary()
        {
            Array.Sort(subjects);
            int count = 1;

            for (int i = 0; i < subjects.Length; i++)
            {
                if (i != subjects.Length - 1)
                {
                    string s1 = subjects[i];
                    string s2 = subjects[i + 1];

                    if (s2.IndexOf(s1) == 0)
                        count++;

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
