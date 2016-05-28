using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Blur_Filter
{
    class BlurFilter
    {
        static void Main(string[] args)
        {
            long blur = long.Parse(Console.ReadLine());
            long[] rowAndCol = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long row = rowAndCol[0];
            long col = rowAndCol[1];

            long[,] matrix = new long[row,col];

            for (int i = 0; i < row; i++)
            {
                long[] line = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            int[] blurPosition = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = blurPosition[0] - 1; i <= blurPosition[0] + 1; i++)
            {
                for (int j = blurPosition[1] - 1; j <= blurPosition[1] + 1; j++)
                {
                    try
                    {
                        matrix[i, j] += blur;
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
