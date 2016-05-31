namespace _09.Rotate_a_Matrix
{
    #region

    using System;
    using System.Text;

    #endregion

    class RotateMatrix
    {
        static void Main(string[] args)
        {
            int cols = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];

            var sb = new StringBuilder();
            for (int i = 0; i < cols; i++)
            {
                sb.AppendFormat("{0} ", Console.ReadLine());
            }

            var inputArgs = sb.ToString().Trim().Split();

            int counter = 0;
            for (int i = cols - 1; i >= 0; i--)
            {
                for (int j = 0; j < rows; j++)
                {
                    matrix[j, i] = inputArgs[counter];
                    counter++;
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