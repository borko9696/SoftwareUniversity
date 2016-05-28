namespace _06.Max_Sequence_of_Equal_Elements
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var result = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var temp = new List<int>();

                int currentNumber = numbers[i];

                for (int j = i; j < numbers.Length; j++)
                {
                    if (currentNumber == numbers[j])
                    {
                        temp.Add(currentNumber);
                    }
                    else
                    {
                        break;
                    }
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