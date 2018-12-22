using System;
using System.Collections.Generic;

namespace LabsClassLibrary
{
    public class Stack  
    {
        const int n = 10;
        public string[] items = new string[n];
        public int count = 0;

        /// <summary>
        /// Пустой ли стек? 
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() 
        {
            if (count == 0) return true; 
            return false;
        }
        /// <summary>
        /// Поместить в стек
        /// </summary>
        /// <param name="N"></param>
        public void Push(string N)
        {
            if (count == items.Length)
                throw new InvalidOperationException("Переполнение стека");
            items[count++] = N;
        }

        /// <summary>
        /// Извлечь верхушку стека
        /// </summary>
        /// <returns></returns>
        public string Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Стек пуст");
            string item = items[--count];
            items[count] = "";
            return item;
        }
        /// <summary>
        /// Показать верхушку стека
        /// </summary>
        /// <returns></returns>
        public string Peek()
        {
            return items[count - 1];
        }

        /// <summary>
        /// Вывести стек в консоль
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
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

        /// <summary>
        /// Вывести очередь в консоль
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }

    public class CircularBuffer<T>
    {
        T[] _buffer; 
        int _head;
        int _tail;
        int _length;
        int _bufferSize;
        object _lock = new object();

        public CircularBuffer(int bufferSize)
        {
            _buffer = new T[bufferSize];
            _bufferSize = bufferSize;
            _head = bufferSize - 1;
        }

        public bool IsEmpty
        {
            get { return _length == 0; }
        }

        public bool IsFull
        {
            get { return _length == _bufferSize; }
        }

        public T Dequeue()
        {
            lock (_lock)
            {
                if (IsEmpty) throw new InvalidOperationException("Queue exhausted");

                T dequeued = _buffer[_tail];
                _tail = NextPosition(_tail);
                _length--;
                return dequeued;
            }
        }

        private int NextPosition(int position)
        {
            return (position + 1) % _bufferSize;
        }

        public void Enqueue(T toAdd)
        {
            lock (_lock)
            {
                _head = NextPosition(_head);
                _buffer[_head] = toAdd;
                if (IsFull)
                    _tail = NextPosition(_tail);
                else
                    _length++;
            }
        }
   
    }

    class MinHeap<T> where T : IComparable<T>
    {
        private List<T> array = new List<T>();

        public void Add(T element)
        {
            array.Add(element);
            int c = array.Count - 1;
            while (c > 0 && array[c].CompareTo(array[c / 2]) == -1)
            {
                T tmp = array[c];
                array[c] = array[c / 2];
                array[c / 2] = tmp;
                c = c / 2;
            }
        }

        public T RemoveMin()
        {
            T ret = array[0];
            array[0] = array[array.Count - 1];
            array.RemoveAt(array.Count - 1);

            int c = 0;
            while (c < array.Count)
            {
                int min = c;
                if (2 * c + 1 < array.Count && array[2 * c + 1].CompareTo(array[min]) == -1)
                    min = 2 * c + 1;
                if (2 * c + 2 < array.Count && array[2 * c + 2].CompareTo(array[min]) == -1)
                    min = 2 * c + 2;

                if (min == c)
                    break;
                else
                {
                    T tmp = array[c];
                    array[c] = array[min];
                    array[min] = tmp;
                    c = min;
                }
            }

            return ret;
        }

        public T Peek()
        {
            return array[0];
        }

        public int Count
        {
            get
            {
                return array.Count;
            }
        }
    } 

    public class PriorityQueue<T>
    {
        internal class Node : IComparable<Node> 
        {
            public int Priority;
            public T O;
            public int CompareTo(Node other)
            {
                return Priority.CompareTo(other.Priority);
            }
        }

        private MinHeap<Node> minHeap = new MinHeap<Node>();

        public void Add(int priority, T element)
        {
            minHeap.Add(new Node() { Priority = priority, O = element });
        }

        public T RemoveMin()
        {
            return minHeap.RemoveMin().O;
        }

        public T Peek()
        {
            return minHeap.Peek().O;
        }

        public int Count
        {
            get
            {
                return minHeap.Count;
            }
        }
    } 
}
 