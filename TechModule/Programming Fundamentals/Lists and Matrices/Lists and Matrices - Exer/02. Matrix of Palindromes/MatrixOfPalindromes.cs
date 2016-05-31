namespace _02.Matrix_of_Palindromes
{
    #region

    using System;
    using System.Linq;

    #endregion

    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    char[] word = { (char)(97 + i), (char)(97 + j + i), (char)(97 + i) };
                    matrix[i, j] = new string(word);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}