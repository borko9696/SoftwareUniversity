namespace _08.Most_Frequent_Number
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                if (!dict.ContainsKey(currentNum))
                {
                    dict[currentNum] = 0;
                }

                dict[currentNum]++;
            }

            var sorted = dict.OrderByDescending(x => x.Value);

            var result = sorted.First();
            Console.WriteLine(result.Key);
        }
    }
}