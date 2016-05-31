namespace _12.Bomb_Numbers
{
    #region

    using System;
    using System.Linq;

    #endregion

    public class BombNumbers
    {
        public static void DetonateLeftSide(int[] numbers, int bombIndex, int size)
        {
            int count = bombIndex - 1;
            while (size > 0 && count >= 0)
            {
                numbers[count] = int.MinValue;
                size--;
                count--;
            }
        }

        private static void DetonateRightSide(int[] numbers, int bombIndex, int size)
        {
            int count = bombIndex + 1;
            while (size > 0 && count < numbers.Length)
            {
                numbers[count] = int.MinValue;
                size--;
                count++;
            }
        }

        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var inputArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bomb = inputArgs[0];
            var size = inputArgs[1];

            for (int i = 0; i < elements.Length; i++)
            {
                var currentNum = elements[i];

                if (currentNum == bomb)
                {
                    DetonateLeftSide(elements, i, size);
                    DetonateRightSide(elements, i, size);
                    elements[i] = int.MinValue;
                }
            }

            var sum = elements.Where(x => x != int.MinValue).Sum();
            Console.WriteLine(sum);
        }
    }
}