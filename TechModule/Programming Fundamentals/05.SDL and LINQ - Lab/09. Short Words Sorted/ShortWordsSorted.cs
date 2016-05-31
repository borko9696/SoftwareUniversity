namespace _09.Short_Words_Sorted
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            string[] separators = { ".", ",", "!", "?", "(", ")", "\"", "'", ":", ";", "[", "]" };

            for (int i = 0; i < separators.Length; i++)
            {
                input = input.Replace(separators[i], string.Empty);
            }

            var sorted = input.Split().Where(x => x.Length < 5).OrderBy(x => x);
            var result = new SortedSet<string>(sorted);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}