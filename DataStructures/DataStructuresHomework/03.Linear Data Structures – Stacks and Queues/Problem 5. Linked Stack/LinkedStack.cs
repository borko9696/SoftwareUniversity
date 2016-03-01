using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Linked_Stack
{
    public class LinkedStack<T>
    {
        private Node<T> firstNode;

        public int Count { get; private set; }

        public void Push(T element)
        {
            if (this.Count == 0)
            {
                this.firstNode = new Node<T>(element);
            }
            else
            {
                this.firstNode = new Node<T>(element, this.firstNode);
            }

            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The linked stack is empty.");
            }

            T element = this.firstNode.Value;

            this.firstNode = this.firstNode.NextNode;

            this.Count--;

            return element;
        }

        public T[] ToArray()
        {
            var elements = new T[this.Count];

            var tempNode = this.firstNode;

            for (int i = 0; i < this.Count; i++)
            {
                elements[i] = tempNode.Value;
                tempNode = tempNode.NextNode;
            }

            return elements;
        }

        private class Node<N>
        {
            private readonly N value;

            public Node(N value, Node<N> nextNode = null)
            {
                this.value = value;
                this.NextNode = nextNode;
            }

            public Node<N> NextNode { get; set; }

            public N Value
            {
                get
                {
                    return this.value;
                }
            }
        }

    }

    public class Program
    {
        static void Main()
        {
        }
    }
}
