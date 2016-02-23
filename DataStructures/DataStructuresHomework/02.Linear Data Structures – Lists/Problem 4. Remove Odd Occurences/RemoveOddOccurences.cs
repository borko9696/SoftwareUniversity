namespace Problem_4.Remove_Odd_Occurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class RemoveOddOccurences
    {
        private static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
          
            var numbersToRemove = new List<int>();

            for (var i = 0; i < numbers.Count; i++)
            {
                var count = 0;
                for (var j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }
                if (count%2 == 1 && !numbersToRemove.Contains(numbers[i]))
                {
                    numbersToRemove.Add(numbers[i]);
                }
            }

            foreach (var numToRemove in numbersToRemove)
            {
                numbers.RemoveAll(x => x == numToRemove);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}