using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSum
{
    static void Main()
    {
        
        int[] sides = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[,] matrix = new int[sides[0], sides[1]];
        

        for (int row = 0; row < sides[0]; row++)
        {

            string str = Console.ReadLine();
            string[] elements = str.Split(' ');

            for (int col = 0; col < sides[1]; col++)
            {
                matrix[row, col] = int.Parse(elements[col]);
            }
        }
        int bestSum = int.MinValue;
        List<int> bestMatrixNumbers = new List<int>();
        int counterRow = 0;
        int counterCol = 0;

        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            for (int col = 0; col <matrix.GetLength(1)-2; col++)
            {
                int sum = 
                    matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + 
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + 
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                
                if (sum>bestSum)
                {
                    
                    bestSum = sum;
                    bestMatrixNumbers.Clear();

                    for (int i = 0; i < 3; i++)
                    {
                        
                        for (int j = 0; j < 3; j++)
                        {
                            bestMatrixNumbers.Add(matrix[i+counterRow, j+counterCol]);
                            
                        }
                      
                    }
                }

            }
            counterCol++;
            counterRow++;
        }

        Console.WriteLine("Sum= {0}",bestSum);

        int counter=0;

        while (counter < 9)
        {
            Console.Write("{0} ", bestMatrixNumbers[counter]);
            if (counter == 2 || counter == 5 || counter == 8)
            {
                Console.WriteLine();
            }
            counter++;
        }
       
        
    }
}
