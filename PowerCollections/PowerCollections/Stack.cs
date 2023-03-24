using System;
using System.Collections.Generic;
using System.Text;

namespace Wintellect.PowerCollections
{
    public class Stack<T>:IEnumerable<T>
    {
        public int Count { get; set; }
        public int Capacity { get; }

        T[] array;

        public Stack(int size = 100)
        {
            if (size < 0)
                throw new InvalidOperationException("Размер стека не может быть отрицателен");
            array = new T[size];
            Capacity = size;
        }

        public void Push(T ara)
        {
            if(Count>= Capacity)
                throw new InvalidOperationException("Превышен лимит стека");
            array[Count] = ara;
            Count = Count + 1;
        }

        public T Pop()
        {
            if( Count == 0)
            {
                throw new InvalidOperationException("Стек не имеет значений");
            }
            Count = Count -1;
            return array[Count];
        }

        public T Top()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Стек не имеет значений");
            }
            return array[Count-1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int max = Count - 1; max >= 0; max--)
            {
                yield return array[max];
            
        } 

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
