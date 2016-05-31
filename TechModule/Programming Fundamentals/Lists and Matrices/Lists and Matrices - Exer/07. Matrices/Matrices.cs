namespace _07.Matrices
{
    #region

    using System;

    #endregion

    public class Matrices
    {
        static int[,] AType(int row, int col)
        {
            var matrix = new int[row, col];

            int count = 1;
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    matrix[j, i] = count++;
                }
            }

            return matrix;
        }

        static int[,] BType(int row, int col)
        {
            var matrix = new int[row, col];

            int count = 1;
            for (int i = 0; i < col; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < row; j++)
                    {
                        matrix[j, i] = count++;
                    }
                }
                else
                {
                    for (int j = row - 1; j >= 0; j--)
                    {
                        matrix[j, i] = count++;
                    }
                }
            }

            return matrix;
        }

        static int[,] CType(int row, int col)
        {
            var matrix = new int[row, col];

            int counter = 1;

            for (int startingRow = matrix.GetLength(0) - 1; startingRow >= 0; startingRow--)
            {
                int collon = 0;
                for (int i = startingRow; i < matrix.GetLength(0); i++)
                {
                    matrix[i, collon++] = counter++;
                }
            }

            for (int startingCol = 1; startingCol < matrix.GetLength(1); startingCol++)
            {
                int red = 0;
                for (int j = startingCol; j < matrix.GetLength(1); j++)
                {
                    matrix[red++, j] = counter++;
                }
            }

            return matrix;
        }

        static int[,] DType(int row, int col)
        {
            var matrix = new int[row, col];

            int startRow = 0;
            int startCol = 0;

            int counter = 1;

            while (startRow <= row / 2)
            {
                for (int i = startRow; i < row - startRow; i++)
                {
                    if (matrix[i, startCol] == 0)
                    {
                        matrix[i, startCol] = counter++;
                    }
                }

                int botRow = row - startRow - 1;
                for (int j = startCol + 1; j < col - startCol; j++)
                {
                    if (matrix[botRow, j] == 0)
                    {
                        matrix[botRow, j] = counter++;
                    }
                }

                int rightCol = col - 1 - startCol;
                for (int i = row - 1 - startRow - 1; i >= startRow; i--)
                {
                    if (matrix[i, rightCol] == 0)
                    {
                        matrix[i, rightCol] = counter++;
                    }
                }

                for (int j = col - 1 - startCol - 1; j > startCol; j--)
                {
                    if (matrix[startRow, j] == 0)
                    {
                        matrix[startRow, j] = counter++;
                    }
                }

                startRow++;
                startCol++;
            }

            return matrix;
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var matrix = new int[int.Parse(input[1]), int.Parse(input[2])];

            switch (input[0])
            {
                case "A":
                    matrix = AType(int.Parse(input[1]), int.Parse(input[2]));
                    Print(matrix);
                    break;
                case "B":
                    matrix = BType(int.Parse(input[1]), int.Parse(input[2]));
                    Print(matrix);
                    break;
                case "C":
                    matrix = CType(int.Parse(input[1]), int.Parse(input[2]));
                    Print(matrix);
                    break;
                case "D":
                    matrix = DType(int.Parse(input[1]), int.Parse(input[2]));
                    Print(matrix);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }

        static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}