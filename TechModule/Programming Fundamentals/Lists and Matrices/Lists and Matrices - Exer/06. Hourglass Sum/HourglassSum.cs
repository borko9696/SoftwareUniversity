namespace _06.Hourglass_Sum
{
    #region

    using System;
    using System.Linq;

    #endregion

    class HourglassSum
    {
        static void Main(string[] args)
        {
            var matrix = new long[6, 6];

            for (int i = 0; i < 6; i++)
            {
                var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            long maxSum = long.MinValue;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    long sum = matrix[i, j] + matrix[i - 1, j - 1] + matrix[i - 1, j] + matrix[i - 1, j + 1]
                               + matrix[i + 1, j - 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}