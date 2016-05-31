namespace _03.Diagonal_Difference
{
    #region

    using System;
    using System.Linq;

    #endregion

    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            int count = size - 1;
            for (int i = 0; i < size; i++)
            {
                primaryDiagonal += matrix[i, i];
                secondaryDiagonal += matrix[i, count];
                count--;
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}