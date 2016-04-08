using System;

namespace Recursive_Array_Sum
{
    class RecursiveArraySum
    {
        static void Main()
        {
            int[] num = { 1, 2, 3, 4};
            Console.WriteLine(FindSum(num,0));
        }

        static int FindSum(int[] numbers, int index)
        {
            if (index == numbers.Length)
            {
                return 0;
            }
            return numbers[index] + FindSum(numbers, index + 1);
        }
    }
}
