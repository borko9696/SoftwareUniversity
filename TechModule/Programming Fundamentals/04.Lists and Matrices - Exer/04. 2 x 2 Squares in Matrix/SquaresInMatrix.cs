namespace _04._2_x_2_Squares_in_Matrix
{
    #region

    using System;
    using System.Linq;

    #endregion

    public class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var row = size[0];
            var col = size[1];

            char[,] matrix = new char[row, col];

            for (int i = 0; i < row; i++)
            {
                var input = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int count = 0;
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    int current = matrix[i, j];
                    if (current == matrix[i, j + 1] && current == matrix[i + 1, j] && current == matrix[i + 1, j + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}