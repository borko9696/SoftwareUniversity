using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SelectionSort
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int temp = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int sort = 0; sort < arr.Length-1; sort++)
            {
                if (arr[sort]>arr[sort+1])
                {
                    temp = arr[sort];
                    arr[sort] = arr[sort + 1];
                    arr[sort + 1] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(" ", arr));
    }
}
