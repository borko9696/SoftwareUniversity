namespace _07.Sum_Arrays
{
    #region

    using System;
    using System.Linq;

    #endregion

    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (array1.Length > array2.Length)
            {
                var newArray = Resize(array2, array1.Length);
                Console.WriteLine(string.Join(" ", SumOfArrays(array1, newArray)));
            }
            else if (array1.Length < array2.Length)
            {
                var newArray = Resize(array1, array2.Length);
                Console.WriteLine(string.Join(" ", SumOfArrays(array2, newArray)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", SumOfArrays(array1, array2)));
            }
        }

        static int[] Resize(int[] arr, int size)
        {
            var newArray = new int[size];
            int i = 0;
            int breakCounter = 0;
            while (breakCounter < size)
            {
                newArray[breakCounter] = arr[i];
                i++;
                breakCounter++;
                if (i == arr.Length)
                {
                    i = 0;
                }
            }

            return newArray;
        }

        static int[] SumOfArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }

            return result;
        }
    }
}