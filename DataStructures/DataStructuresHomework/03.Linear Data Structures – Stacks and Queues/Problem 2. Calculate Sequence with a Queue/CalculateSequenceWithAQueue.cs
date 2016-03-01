namespace Problem_2.Calculate_Sequence_with_a_Queue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class CalculateSequenceWithAQueue
    {
        private static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();
            queue.Enqueue(num);
            var element = queue.Dequeue();
            Console.Write(element + " ");
            int counter = 0;
            while (counter < 15)
            {

                Console.Write(element + 1 + " ");
                Console.Write((2*element) + 1 + " ");
                Console.Write(element + 2 + " ");

                queue.Enqueue(element + 1);
                queue.Enqueue((2 * element) + 1);
                queue.Enqueue(element + 2);

                element = queue.Dequeue();
                counter++;
            }
        }
    }
}