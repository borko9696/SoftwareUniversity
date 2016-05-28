namespace _06.Count_Numbers
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class CountNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var countNumbers = new Dictionary<int, int>();

            for (int i = 0; i < input.Count; i++)
            {
                var currentNum = input[i];
                if (!countNumbers.ContainsKey(currentNum))
                {
                    countNumbers[currentNum] = 0;
                }

                countNumbers[currentNum]++;
            }

            foreach (var number in countNumbers.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1}", number.Key, number.Value);
            }
        }
    }
}