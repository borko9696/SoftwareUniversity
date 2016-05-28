namespace _7.Max_Sequence_of_Increasing_Elements
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var result = new List<int>();
            var temp = new List<int>();

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] < numbers[i])
                {
                    if (temp.Count == 0)
                    {
                        temp.Add(numbers[i - 1]);
                    }

                    temp.Add(numbers[i]);
                }
                else
                {
                    temp = new List<int>();
                }

                if (temp.Count > result.Count)
                {
                    result = new List<int>(temp);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}