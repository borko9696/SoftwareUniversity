namespace _7.Square_Numbers
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class SquareNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var squareNums = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                double squareNum = Math.Sqrt(input[i]);
                int currentNum = (int)squareNum;

                if (squareNum == currentNum)
                {
                    squareNums.Add(input[i]);
                }
            }

            var descendingSortedSquareNumbers = squareNums.OrderByDescending(x => x);
            Console.WriteLine(string.Join(" ", descendingSortedSquareNumbers));
        }
    }
}