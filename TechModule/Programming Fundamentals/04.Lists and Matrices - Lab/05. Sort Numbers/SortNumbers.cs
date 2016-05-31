namespace _05.Sort_Numbers
{
    #region

    using System;
    using System.Linq;

    #endregion

    class SortNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(decimal.Parse).OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(" <= ", input));
        }
    }
}