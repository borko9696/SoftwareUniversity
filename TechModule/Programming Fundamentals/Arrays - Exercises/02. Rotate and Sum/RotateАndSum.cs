namespace _02.Rotate_and_Sum
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class RotateАndSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotatiotTimes = int.Parse(Console.ReadLine());
            var list = Rotation(array, rotatiotTimes);

            var result = new int[array.Length];
            for (int i = 0; i < list.Count; i++)
            {
                var currentArray = list[i];
                for (int j = 0; j < currentArray.Length; j++)
                {
                    result[j] += currentArray[j];
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }

        static List<int[]> Rotation(int[] array, int rotationTimes)
        {
            var listWithInts = new List<int[]>();
            listWithInts.Add(array);

            for (int i = 0; i < rotationTimes; i++)
            {
                var temp = new int[array.Length];

                var currentArray = listWithInts[listWithInts.Count - 1];

                temp[0] = currentArray[currentArray.Length - 1];
                for (int j = 1; j < array.Length; j++)
                {
                    temp[j] = currentArray[j - 1];
                }

                listWithInts.Add(temp);
            }

            listWithInts.RemoveAt(0);
            return listWithInts;
        }
    }
}