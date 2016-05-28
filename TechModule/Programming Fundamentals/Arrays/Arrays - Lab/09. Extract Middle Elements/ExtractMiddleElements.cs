namespace _09.Extract_Middle_Elements
{
    #region

    using System;
    using System.Linq;

    #endregion

    class ExtractMiddleElements
    {
        public static int[] Middle(int[] arr, int size, int middle)
        {
            var array = new int[size];
            for (int i = middle, j = 0; i < size + middle; i++, j++)
            {
                array[j] = arr[i];
            }

            return array;
        }

        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (array.Length == 1)
            {
                Console.WriteLine("{{ {0} }}", string.Join(", ", Middle(array, 1, 0)));
                return;
            }

            if (array.Length % 2 == 0)
            {
                int middle = (array.Length / 2) - 1;
                Console.WriteLine("{{ {0} }}", string.Join(", ", Middle(array, 2, middle)));
            }
            else
            {
                int middle = (array.Length / 2) - 1;
                Console.WriteLine("{{ {0} }}", string.Join(", ", Middle(array, 3, middle)));
            }
        }
    }
}