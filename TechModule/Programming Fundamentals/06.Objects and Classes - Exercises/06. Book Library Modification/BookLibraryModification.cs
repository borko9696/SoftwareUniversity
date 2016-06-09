namespace _06.Book_Library_Modification
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    #endregion

    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dictWithAuthors = new Dictionary<string, DateTime>();
            for (int i = 0; i < n; i++)
            {
                var inputArgs = Console.ReadLine().Split();
                var title = inputArgs[0];
                var date = DateTime.ParseExact(inputArgs[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                if (!dictWithAuthors.ContainsKey(title))
                {
                    dictWithAuthors[title] = new DateTime();
                }

                dictWithAuthors[title] = date;
            }

            DateTime datereleased = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var sortedTitles =
                dictWithAuthors.Where(date => date.Value > datereleased).OrderBy(x => x.Value).ThenBy(y => y.Key);

            foreach (var title in sortedTitles)
            {
                string format = "dd.MM.yyyy";
                Console.WriteLine("{0} -> {1}", title.Key, title.Value.ToString(format));
            }
        }
    }
}