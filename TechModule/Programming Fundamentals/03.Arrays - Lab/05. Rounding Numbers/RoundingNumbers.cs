namespace _05.Rounding_Numbers
{
    #region

    using System;
    using System.Linq;

    #endregion

    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                var num = numbers[i];
                var round = Math.Round(num, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", num, round);
            }
        }
    }
}