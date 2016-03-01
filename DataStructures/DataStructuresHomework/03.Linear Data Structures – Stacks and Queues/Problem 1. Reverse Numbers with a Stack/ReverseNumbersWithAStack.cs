namespace Problem_1.Reverse_Numbers_with_a_Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class ReverseNumbersWithAStack
    {
        private static void Main()
        {
            try
            {
                var arrayElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var stack = new Stack<int>(arrayElements);
                Console.WriteLine(string.Join(" ", stack));
            }
            catch (Exception)
            {

                Console.WriteLine("(empty)");
            }
        }
    }
}