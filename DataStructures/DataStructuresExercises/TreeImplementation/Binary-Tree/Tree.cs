using System;
using System.Collections.Generic;

namespace Trees
{
    public class Tree<T>
    {
        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Childen = new List<Tree<T>>();
            foreach (var child in children)
            {
                this.Childen.Add(child);
            }
        }

        public IList<Tree<T>> Childen { get; set; }
        public T Value { get; set; }

        public void Print(int indent = 0)
        {
            Console.Write(new string(' ',2*indent));
            Console.WriteLine(this.Value);
            foreach (var child in this.Childen)
            {
                child.Print(indent+1);
            }
        }

        public void Each(Action<T> action)
        {
            action(this.Value);
            foreach (var child in this.Childen)
            {
                child.Each(action);
            }
        }
    }
}
