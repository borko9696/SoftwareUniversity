namespace _01.Numbers
{
    #region

    using System;
    using System.Linq;

    #endregion

    class Numbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var average = numbers.Sum() / numbers.Length;
            var result = numbers.OrderByDescending(y => y).Where(x => x > average).Take(5).ToArray();
            if (result.Any())
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}