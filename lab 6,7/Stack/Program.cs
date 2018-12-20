using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryStack;

namespace StackAndQueue
{
    class Program
    {
        private static void StackShow()
        {
            Stack stack = new Stack();

            stack.Push("Kate");  
            stack.Push("Tom"); 
            stack.Push("Perry");

            string Head = stack.Pop(); //извлекаем один элемент      

            Console.WriteLine("Извлекаем верхушку стека..." + $"({Head})");
            Console.WriteLine("Показываем верхушку стека: ");
            Head = stack.Peek();

            Console.WriteLine(Head);
            Console.ReadKey();
        }
         
        private static void QueueShow()
        {
            Queue q = new Queue(); 

            q.Enqueue("Tom");
            q.Enqueue("Alice"); 
            q.Enqueue("Jim");

            string elem = q.Dequeue();
            Console.WriteLine("Извлекаем головной элемент очереди..." + $"({elem})");
            Console.WriteLine("Показываем головной элемент очереди: ");
            Console.WriteLine(q.Peek());
            Console.ReadKey();
        }
         
        static void Main(string[] args)
        {
           Console.WriteLine("1.Cтек");
           Console.WriteLine("2.Очередь");
           string input = Console.ReadLine(); 

           switch (input)
            {
                case "1":
                    StackShow();
                    break;
                case "2":  
                    QueueShow();
                    break;
                default:
                    Console.WriteLine("Неверный ввод");
                    break;
            }

            Console.ReadKey();

        } 
    } 

}  
        