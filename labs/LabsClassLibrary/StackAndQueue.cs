using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsClassLibrary
{
    public class Stack 
    {
        const int n = 10;
        public string[] items = new string[n];
        public int count = 0;

        public bool IsEmpty()
        {
            if (count == 0) return true; 
            return false;
        }

        public void Push(string N)
        {
            if (count == items.Length)
                throw new InvalidOperationException("Переполнение стека");
            items[count++] = N;
        }

        public string Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Стек пуст");
            string item = items[--count];
            items[count] = "";
            return item;
        }

        public string Peek()
        {
            return items[count - 1];
        }
         
    }

    public class Queue
    {
        public static int size = 10; //размер массива
        private string[] items = new string[size]; //локальный массив 

        private int front = -1; //позиция головы очереди 
        private int rear = -1; //позиция хвоста очереди
        private int count = 0; //количество элементов


        public bool IsFull()
        {
            return rear == size - 1; //true , если хвост очереди - 9 эл
        }

        public bool IsEmpty()
        {
            return count == 0; //true , если count = 0
        }

        public void Enqueue(string item)
        {
            if (IsFull()) //заполнен ли массив
                throw new Exception("Очередь полностью заполнена.");

            items[++rear] = item; //добавляем элемент в конец и увеличиваем позицию хвоста
            count++; //увеличивается кол-во элементов
        }

        public string Dequeue()
        {
            if (IsEmpty()) //пустая ли очередь
                throw new Exception("Очередь не заполнена.");

            string item = items[++front]; //считываем элемент 
            count--; //удаляем из очереди

            if (front == rear) //если из очереди были вычитаны все эл-ты
            {
                front = -1; //возвращаем начальные значения обратно
                rear = -1;
            }

            return item;
        }

        public string Peek()
        {
            if (IsEmpty()) //пустая ли очередь
                throw new Exception("Очередь не заполнена.");

            string Item = items[front + 1]; //берем головной элемент
            return Item;

        }
    } 
}
