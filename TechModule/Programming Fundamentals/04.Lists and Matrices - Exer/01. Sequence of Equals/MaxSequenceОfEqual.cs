namespace _01.Sequence_of_Equals
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class MaxSequenceОfEqual
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var temp = new List<int>();

                int currentNumber = numbers[i];

                for (int j = i; j < numbers.Count; j++)
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