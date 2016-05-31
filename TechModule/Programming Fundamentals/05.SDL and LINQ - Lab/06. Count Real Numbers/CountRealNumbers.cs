namespace _06.Count_Real_Numbers
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var dictWithNumbers = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNum = numbers[i];
                if (!dictWithNumbers.ContainsKey(currentNum))
                {
                    dictWithNumbers[currentNum] = 0;
                }

                dictWithNumbers[currentNum]++;
            }

            foreach (var number in dictWithNumbers)
            {
                Console.WriteLine("{0} -> {1}", number.Key, number.Value);
            }
        }
    }
}