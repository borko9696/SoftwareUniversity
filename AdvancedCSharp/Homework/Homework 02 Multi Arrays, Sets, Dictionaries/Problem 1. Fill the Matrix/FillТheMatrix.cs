using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FillТheMatrix
{
    static void Main()
    {
        //matrix Patern A
        int n = int.Parse(Console.ReadLine());
        
        int count=1;
        
        int[,] matrix = new int[n, n];
       

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = count;
                 count+= n;
            }
            count = (row + 2);
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0} ",matrix[row,col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //matrix Patern B
        int[,] matrix1 = new int[n, n];
        int count1=1;

        for (int col = 0; col < n; col++)
        {
            for (int rowSnake=n-1, row = 0; row < n;rowSnake--, row++)
            {
                if (col%2==0)
                {
                    matrix1[row, col] = count1;
                    count1++;
                }

                if (col % 2 != 0)
                {

                    matrix1[rowSnake, col] = count1;
                    count1++;
                }
            }

        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0} ", matrix1[row, col]);
            }
            Console.WriteLine();
        }

    }
}
