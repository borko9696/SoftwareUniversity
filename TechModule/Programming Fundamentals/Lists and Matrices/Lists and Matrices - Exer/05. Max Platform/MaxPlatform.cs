namespace _05.Max_Platform
{
    #region

    using System;
    using System.Linq;

    #endregion

    class MaxPlatform
    {
        static void Main(string[] args)
        {
            var size =
                Console.ReadLine()
                    .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            var row = size[0];
            var col = size[1];

            long[,] matrix = new long[row, col];

            for (int i = 0; i < row; i++)
            {
                var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            long bestSum = int.MinValue;
            var startIndex = new int[2];
            var endIndex = new int[2];

            for (int i = 0; i < row - 2; i++)
            {
                for (int j = 0; j < col - 2; j++)
                {
                    long sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j]
                               + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1]
                               + matrix[i + 2, j + 2];

                    if (sum > bestSum)
                    {
                        bestSum = sum;

                        startIndex[0] = i;
                        startIndex[1] = j;

                        endIndex[0] = i + 2;
                        endIndex[1] = j + 2;
                    }
                }
            }

            Console.WriteLine(bestSum);

            for (int i = startIndex[0]; i <= endIndex[0]; i++)
            {
                for (int j = startIndex[1]; j <= endIndex[1]; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}