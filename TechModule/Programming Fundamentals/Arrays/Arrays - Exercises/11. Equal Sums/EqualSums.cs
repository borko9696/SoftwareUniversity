namespace _11.Equal_Sums
{
    #region

    using System;
    using System.Linq;

    #endregion

    class EqualSums
    {
        public static int LeftSum(int[] array, int endIndex)
        {
            int sum = 0;
            if (endIndex != -1)
            {
                for (int i = 0; i <= endIndex; i++)
                {
                    sum += array[i];
                }
            }

            return sum;
        }

        public static int RightSum(int[] array, int startIndex)
        {
            int sum = 0;
            if (startIndex != array.Length)
            {
                for (int i = startIndex; i < array.Length; i++)
                {
                    sum += array[i];
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int index = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                var leftSum = LeftSum(numbers, i - 1);
                var rightSum = RightSum(numbers, i + 1);
                if (leftSum == rightSum)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}