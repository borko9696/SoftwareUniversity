namespace Problem_5.Count_of_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class CountOfOccurrences
    {
        private static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var dict = new Dictionary<int,int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!dict.ContainsKey(numbers[i]))
                {
                    dict[numbers[i]] = 0;
                }
                dict[numbers[i]] += 1;
            }

            var sortedDict = dict.OrderBy(x => x.Key);
            foreach (var pair in sortedDict)
            {
                Console.WriteLine("{0} -> {1} times",pair.Key,pair.Value);
            }
        }
    }
}