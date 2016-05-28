namespace _08.Matrix_of_Letters
{
    #region

    using System;

    #endregion

    class MatrixOfLetters
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            char[,] matrix = new char[rows, cols];

            int counter = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = (char)(counter + 65);
                    counter++;

                    if (counter % 28 == 0)
                    {
                        counter = 0;
                    }
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