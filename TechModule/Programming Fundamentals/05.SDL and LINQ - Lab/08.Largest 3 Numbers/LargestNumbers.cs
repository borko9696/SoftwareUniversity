namespace _08.Largest_3_Numbers
{
    #region

    using System;
    using System.Linq;

    #endregion

    class LargestNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Array.Sort(input);

            var result = input.OrderByDescending(x => x).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}