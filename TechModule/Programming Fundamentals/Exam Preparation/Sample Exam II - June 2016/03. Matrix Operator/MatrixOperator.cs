using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Matrix_Operator
{
    class MatrixOperator
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var matrix = new List<List<long>>();
            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split().Select(long.Parse).ToList();
                matrix.Add(input);
            }

            var command = Console.ReadLine();
            while (command != "end")
            {
                var commandArgs = command.Split();

                switch (commandArgs[0])
                {
                    case "remove":
                        Remove(matrix, commandArgs[1],commandArgs[2], int.Parse(commandArgs[3]));
                        break;
                    case "swap":
                        Swap(matrix, int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                        break;
                    case "insert":
                        Insert(matrix, int.Parse(commandArgs[1]), long.Parse(commandArgs[2]));
                        break;
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < matrix.Count; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }

        private static void Insert(List<List<long>> matrix, int row, long number)
        {
            matrix[row].Insert(0, number);
        }

        private static void Swap(List<List<long>> matrix, int indexOne, int indexTwo)
        {
            var temp = matrix[indexOne];
            matrix[indexOne] = matrix[indexTwo];
            matrix[indexTwo] = temp;
        }

        private static void Remove(List<List<long>> matrix, string type, string rowOrCol, int position)
        {
            if (rowOrCol == "row")
            {
                switch (type)
                {
                    case "even":
                        matrix[position] = matrix[position].Where(x => x % 2 != 0).ToList();
                        break;
                    case "odd":
                        matrix[position] = matrix[position].Where(x => x % 2 == 0).ToList();
                        break;
                    case "positive":
                        matrix[position] = matrix[position].Where(x => x < 0).ToList();
                        break;
                    case "negative":
                        matrix[position] = matrix[position].Where(x => x > 0).ToList();
                        break;
                }
            }
            else
            {
                switch (type)
                {
                    case "even":
                        for (int row = 0; row < matrix.Count; row++)
                        {
                            if (matrix[row].Count > position)
                            {
                                if (matrix[row][position] % 2 == 0)
                                {
                                    matrix[row].RemoveAt(position);
                                }
                            }
                        }
                        break;
                    case "odd":
                        for (int row = 0; row < matrix.Count; row++)
                        {
                            if (matrix[row].Count > position)
                            {
                                if (matrix[row][position] % 2 != 0)
                                {
                                    matrix[row].RemoveAt(position);
                                }
                            }
                        }
                        break;
                    case "positive":
                        for (int row = 0; row < matrix.Count; row++)
                        {
                            if (matrix[row].Count > position)
                            {
                                if (matrix[row][position] >= 0)
                                {
                                    matrix[row].RemoveAt(position);
                                }
                            }
                        }
                        break;
                    case "negative":
                        for (int row = 0; row < matrix.Count; row++)
                        {
                            if (matrix[row].Count > position)
                            {
                                if (matrix[row][position] < 0)
                                {
                                    matrix[row].RemoveAt(position);
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
}
