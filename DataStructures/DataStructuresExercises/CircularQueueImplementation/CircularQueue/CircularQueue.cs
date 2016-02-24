﻿using System;

public class CircularQueue<T>
{
    private const int InitialCapacity = 16;
    private T[] elements;
    private int headIndex = 0;
    private int tailIndex= 0;


    public CircularQueue(int capacity = InitialCapacity)
    {
        this.elements = new T[capacity];
    }

    public int Count { get; private set; }

    public void Enqueue(T element)
    {
        if (this.Count >= this.elements.Length)
        {
            this.Grow();
        }
        this.elements[this.tailIndex] = element;
        this.tailIndex = (this.tailIndex + 1)%this.elements.Length;
        this.Count++;
    }

    private void Grow()
    {
        var newElements = new T[2*this.elements.Length];
        this.CopyElementsTo(newElements);
        this.elements = newElements;
        this.headIndex = 0;
        this.tailIndex = this.Count;
    }

    private void CopyElementsTo(T[] newElements)
    {
        int startIndex = this.headIndex;
        int destinationIndex = 0;
        for (int i = 0; i < this.Count; i++)
        {
            newElements[destinationIndex] = this.elements[startIndex];
            startIndex = (startIndex + 1)%this.elements.Length;
            destinationIndex++;
        }
    }

    public T Dequeue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("The Queue is emtpy");
        }
        var result = this.elements[this.headIndex];
        this.headIndex = (this.headIndex + 1)%this.elements.Length;
        this.Count--;
        return result;
    }

    public T[] ToArray()
    {
        var result = new T[this.Count];
        this.CopyElementsTo(result);
        return result;
    }
}


internal class Example
{
    private static void Main()
    {
        var queue = new CircularQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);

        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        var first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-7);
        queue.Enqueue(-8);
        queue.Enqueue(-9);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-10);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");
    }
}