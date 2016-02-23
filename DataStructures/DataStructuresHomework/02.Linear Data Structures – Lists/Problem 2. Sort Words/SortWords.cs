namespace Problem_2.Sort_Words
{
    using System;
    using System.Linq;

    internal class SortWords
    {
        private static void Main()
        {
            var list = Console.ReadLine().Trim().Split(' ').ToList();

            var sortedList = list.OrderBy(x => x);

            Console.WriteLine(string.Join(" ",sortedList));
        }
    }
}