namespace _05.Multi_Targeted_Cell
{
    #region

    using System;
    using System.Linq;

    #endregion

    class MultiplyTargetedCell
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var row = size[0];
            var col = size[1];

            var matrix = new long[row, col];
            for (int i = 0; i < row; i++)
            {
                long[] line = Console.ReadLine().Split().Select(long.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            var center = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var centerValue = matrix[center[0], center[1]];
            long sum = -centerValue;

            for (int i = center[0] - 1; i <= center[0] + 1; i++)
            {
                for (int j = center[1] - 1; j <= center[1] + 1; j++)
                {
                    try
                    {
                        sum += matrix[i, j];
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
            }

            for (int i = center[0] - 1; i <= center[0] + 1; i++)
            {
                for (int j = center[1] - 1; j <= center[1] + 1; j++)
                {
                    try
                    {
                        long temp = matrix[i, j];
                        if (i == center[0] && j == center[1])
                        {
                            matrix[i, j] = temp * sum;
                        }
                        else
                        {
                            matrix[i, j] = centerValue * temp;
                        }
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}