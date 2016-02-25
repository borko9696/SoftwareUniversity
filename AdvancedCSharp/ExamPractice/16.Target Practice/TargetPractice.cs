namespace _02.Target_Practice
{
    using System;
    using System.Linq;
    using System.Text;

    internal class TargetPractice
    {
        private static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int row = size[0];
            int col = size[1];

            string word = Console.ReadLine();

            int[] bombParam = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bombRow = bombParam[0];
            int bombCol = bombParam[1];
            int bombRadius = bombParam[2];

            StringBuilder sb = new StringBuilder();
            while (sb.Length < row*col)
            {
                sb.Append(word);
            }

            string result = sb.ToString().Substring(0, col*row);

            char[,] matrix = new char[row,col];


            int count = 0;
            FillTheMatrix(row, col, count, matrix, result);

            Explosion(row, col, bombRow, bombCol, bombRadius, matrix);

            TextGravity(row, col, matrix);

            PrintMatrix(matrix);
        }

        private static void FillTheMatrix(int row, int col, int count, char[,] matrix, string result)
        {
            for (int i = row - 1, red = 0; i >= 0; i--,red++)
            {
                if (red%2 == 0)
                {
                    for (int y = col - 1; y >= 0; y--,count++)
                    {
                        matrix[i, y] = result[count];
                    }
                }
                else
                {
                    for (int j = 0; j < col; j++,count++)
                    {
                        matrix[i, j] = result[count];
                    }
                }
            }
        }

        private static void Explosion(int row, int col, int bombRow, int bombCol, int bombRadius, char[,] matrix)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (Math.Pow(i - bombRow, 2) + Math.Pow(j - bombCol, 2) <= bombRadius*bombRadius)
                    {
                        matrix[i, j] = ' ';
                    }
                }
            }
        }

        private static void TextGravity(int row, int col, char[,] matrix)
        {
            for (int z = 0; z < row; z++)
            {
                for (int i = row - 2; i >= 0; i--)
                {
                    for (int j = 0; j < col; j++)
                    {
                        char temp = ' ';
                        if (matrix[i + 1, j] == ' ')
                        {
                            temp = matrix[i, j];
                            matrix[i, j] = matrix[i + 1, j];
                            matrix[i + 1, j] = temp;
                        }
                    }
                }
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}