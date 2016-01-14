namespace MatrixMultiplicator
{
    using System;

    public class MatrixMultiply
    {
        public static void Main(string[] args)
        {
            var firstMatrix = new double[,] { { 1, 3 }, { 5, 7 } };
            var secondMatrix = new double[,] { { 4, 2 }, { 1, 5 } };
            var multipliedMatrixes = MatrixMultiplier(firstMatrix, secondMatrix);

            for (int rows = 0; rows < multipliedMatrixes.GetLength(0); rows++)
            {
                for (int colums = 0; colums < multipliedMatrixes.GetLength(1); colums++)
                {
                    Console.Write(multipliedMatrixes[rows, colums] + " ");
                }

                Console.WriteLine();
            }
        }

        private static double[,] MatrixMultiplier(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new ArgumentOutOfRangeException("The length of the first and second matrix must be the same!");
            }

            var numberOfColumsFirstMatrix = firstMatrix.GetLength(1);
            var resultMatrix = new double[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
            for (int rows = 0; rows < resultMatrix.GetLength(0); rows++)
            {
                for (int colums = 0; colums < resultMatrix.GetLength(1); colums++)
                {
                    for (int i = 0; i < numberOfColumsFirstMatrix; i++)
                    {
                        resultMatrix[rows, colums] += firstMatrix[rows, i] * secondMatrix[i, colums];
                    }
                }
            }

            return resultMatrix;
        }
    }
}