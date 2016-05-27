namespace _03.Fold_and_Sum
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var range = (array.Length / 2) - 2;

            var listResult = new List<int>();

            for (int i = 0, numCounter = 0; i < array.Length / 2; numCounter++, i++)
            {
                if (i == array.Length / 4)
                {
                    numCounter = array.Length / 2;
                    range = array.Length - 2;
                    listResult.Reverse();
                }

                int sum = 0;
                sum += array[numCounter] + array[range + 1];
                listResult.Add(sum);

                range -= 1;
            }

            Console.WriteLine(string.Join(" ", listResult));
        }
    }
}