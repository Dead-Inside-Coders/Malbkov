using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabsClassLibrary;

namespace ConsoleAppTest 
{
    public class Lab3
    {
        public string Name { get; } = "Алгоритмы работы со строками";

        public void Menu() 
        {
            Console.WriteLine("Введите алгоритм:");
            Console.WriteLine("1.Поиск подстроки в тексте");
            Console.WriteLine("2.Алгоритм Рабина");
            Console.WriteLine("3.Алгоритм Кнута-Морриса-Пратта");
            Console.WriteLine("4.Стемминг");
           
            string input = Console.ReadLine(); 

            int choose = 0;  

            if (int.TryParse(input, out choose))
            {
                switch (choose)
                {
                    case 1: 
                        StrCases.Case1();
                        break; 
                    case 2:
                        StrCases.Case2();
                        break;
                    case 3:
                        StrCases.Case3();
                        break; 
                    case 4:
                        StrCases.Case4();
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некоректный ввод");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            Console.ReadKey();
        }

    } 

    public class Lab4
    {
        public string Name { get; } = "Алгоритмы поиска";

        public void Menu() 
        {
            int[] arr;

            int Len = 10; 

            arr = ArraySearch.ArrayGenerate(Len);

            Array.Sort(arr); 
              
            Console.WriteLine("Массив: ");
            for (int i = 0; i < Len; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

            Console.WriteLine("Введите элемент, который хотите найти: ");

            string inputElem = Console.ReadLine();

            if (int.TryParse(inputElem, out int Elem))
            { 

                Console.WriteLine("Выберите алгоритм: ");
                Console.WriteLine("1. Двоичный поиск");
                Console.WriteLine("2. Рекурсивный двоичный поиск");
                Console.WriteLine("3. Линейный поиск");
                Console.WriteLine("4. Интерполяционный поиск");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        int? ans1 = ArraySearch.BinarySearch(arr, Elem);
                        Console.WriteLine("Позиция: " + ans1);
                        break;
                    case "2":
                        int? ans2 = ArraySearch.BinarySearchRec(arr, 0, arr.Length - 1, Elem);
                        Console.WriteLine("Позиция: " + ans2);
                        break;
                    case "3":
                        int? ans3 = ArraySearch.LinearSearch(arr, Elem);
                        Console.WriteLine("Позиция: " + ans3);
                        break;
                    case "4":
                        int? ans4 = ArraySearch.InterpolationSearch(arr, Elem);
                        Console.WriteLine("Позиция: " + ans4);
                        break;
                    default:
                        Menu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }


            Console.ReadKey();
        }
    }
     
     
    public class Lab5
    {
        public string Name { get; } = "Алгоритмы сортировки";

        public void Menu()
        {
            Console.WriteLine("Алгоритмы сортировки:");
            Console.WriteLine("---------------------");
            Console.WriteLine("Устойчивая сортировка:");
            Console.WriteLine("1.Пузырьковая");
            Console.WriteLine("2.Слиянием");
            Console.WriteLine("Неустойчивая сортировка:");
            Console.WriteLine("3.Быстрая сортировка");
            Console.WriteLine("4.Сортировка выбором");

            string input = Console.ReadLine();
            int choose;

            if (Int32.TryParse(input, out choose))
            {
                switch (choose)
                {
                    case 1:
                        Cases.Case1();
                        break;

                    case 2:
                        Cases.Case2();
                        break;

                    case 3:
                        Cases.Case3();
                        break;

                    case 4:
                        Cases.Case4();
                        break;
                    default:
                        Console.WriteLine("Введите число от 1 до 4");
                        Menu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введите число от 1 до 4");
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            Console.ReadLine();  
        }
    }

    public class Lab6
    {
        public string Name { get; } = "Стек";

        public void Menu()
        {
            Stack stack = new Stack(); 

            stack.Push("Kate");
            stack.Push("Tom");
            stack.Push("Perry");
             
            stack.Print();

            string Head = stack.Pop(); //извлекаем один элемент      

            Console.WriteLine("Извлекаем верхушку стека..." + $"({Head})");
            Console.WriteLine("Показываем верхушку стека: ");
            Head = stack.Peek();

            Console.WriteLine(Head);
            Console.ReadKey(); 

        }
          
    }
    public class Lab7
    {
        public string Name { get; } = "Очереди";

        public void DefaultQueueShow()
        {
            Queue q = new Queue();
               
            q.Enqueue("Tom");
            q.Enqueue("Alice");
            q.Enqueue("Jim");

            q.Print(); 


            string elem = q.Dequeue();
            Console.WriteLine("Извлекаем головной элемент очереди..." + $"({elem})");
            Console.WriteLine("Показываем головной элемент очереди: ");
            Console.WriteLine(q.Peek());
            Console.ReadKey();
        }

        public void CircularQueueShow()
        {
            CircularBuffer<int> queue = new CircularBuffer<int>(5);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            while (!queue.IsEmpty)
            {
                Console.WriteLine("Dequeued {0}", queue.Dequeue());
            }

            Console.ReadKey();
        } 

        public void PriorityQueueShow()
        {
            PriorityQueue<double> queue = new PriorityQueue<double>();

            queue.Add(2,-9.83);
            queue.Add(3,0.0);
            queue.Add(1, 5.45); 
            queue.Add(4,1.0);
            queue.Add(5,99.86);   

            Console.WriteLine("Dequeued {0}", queue.RemoveMin());
            Console.WriteLine("Dequeued {0}", queue.RemoveMin());
            Console.WriteLine("Dequeued {0}", queue.RemoveMin());
            Console.WriteLine("Dequeued {0}", queue.RemoveMin());
            Console.WriteLine("Dequeued {0}", queue.RemoveMin()); 


            Console.ReadKey(); 
        }

        
    }
    public class Lab8
    {


        public  void Deque()
        {
            Deque<string> usersDeck = new Deque<string>();
            usersDeck.AddFirst("Alice");
            usersDeck.AddLast("Kate");
            usersDeck.AddLast("Tom");
            usersDeck.AddLast("Sanya");
            usersDeck.AddFirst("Jonny");

            foreach (string s in usersDeck)
                Console.WriteLine(s);
           
            Console.WriteLine("\n Удален: {0} \n", usersDeck.RemoveLast());
            Console.WriteLine("\n Удален: {0} \n", usersDeck.RemoveFirst());
            
            foreach (string s in usersDeck)
                Console.WriteLine(s);
            string gaga;
            if (usersDeck.Contains("Tom")) gaga = "Tom"; else gaga = "Несодержит";
            Console.WriteLine("\n Дек содержит: {0} \n", gaga);
            Console.ReadKey();
        }
    }
    public class Lab9
    {
        private Linked_List<string> linkedList1 = new Linked_List<string>();
        private Linked_List<string> linkedList2 = new Linked_List<string>();

        public void ListShow()  
        {
             
            Console.WriteLine("--добавление элементов--");
            linkedList1.Add("Tom");
            linkedList1.Add("Alice");
            linkedList1.Add("Bob");
            linkedList1.Add("Sam");

            // выводим элементы
            foreach (var item in linkedList1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Console.WriteLine("--удаляем элемент--");
            linkedList1.Remove("Alice");
            Console.WriteLine("");
            foreach (var item in linkedList1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Console.WriteLine("--проверяем наличие элемента--");
            bool isPresent = linkedList1.Contains("Sam");
            Console.WriteLine("");
            Console.WriteLine(isPresent == true ? "Sam присутствует" : "Sam отсутствует");
            Console.WriteLine("");
            Console.WriteLine("--добавляем элемент в начало--");
            linkedList1.AppendFirst("Bill");
            foreach (var item in linkedList1)
            {
                Console.WriteLine(item);
            }
            

           
            linkedList1.Add("Tom");
            linkedList1.Add("Alice");
            linkedList1.Add("Bob"); 
            linkedList1.Add("Sam");

            //var Gaga = new Confluens();
            //var result = Gaga.Concat(linkedList1, linkedList2);
            Console.ReadKey();
             
        }
       
    }
     

    class Program
    {
        static void Main(string[] args)
        {  
            Lab7 l = new Lab7();
             
            //l.DefaultQueueShow();  

            //l.CircularQueueShow();  

            l.PriorityQueueShow();    
                   
        }
    }       

}
   