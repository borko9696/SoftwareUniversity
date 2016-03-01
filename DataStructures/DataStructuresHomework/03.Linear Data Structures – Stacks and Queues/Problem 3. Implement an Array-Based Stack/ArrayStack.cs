namespace Problem_3.Implement_an_Array_Based_Stack
{
    using System;

    public class ArrayStack<T>
    {
        private T[] elements;
        private const int InitialCapacity = 16;


        public ArrayStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
        }

        public int Count { get; private set; }

        public void Push(T element)
        {
            if (this.elements.Length == this.Count)
            {
                this.Grow();
            }
            this.elements[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty ArrayStack");
            }
            this.Count--;
            return this.elements[this.Count];
        }

        public T[] ToArray()
        {
            var result = new T[this.Count];
            int count = 0;
            for (int i = this.Count - 1; i >= 0; i--,count++)
            {
                result[count] = this.elements[i];
            }
            return result;
        }

        private void Grow()
        {
            var newElements = new T[2 * this.elements.Length];
            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }
    }

    class Program
    {
        static void Main()
        {
           
        }
    }
}