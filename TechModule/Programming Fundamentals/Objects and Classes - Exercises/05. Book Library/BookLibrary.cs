namespace _05.Book_Library
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class BookLibrary
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dictWithAuthors = new Dictionary<string, List<Book>>();
            for (int i = 0; i < n; i++)
            {
                var inputArgs = Console.ReadLine().Split();
                var book = new Book(double.Parse(inputArgs[5]));
                var author = inputArgs[1];

                if (!dictWithAuthors.ContainsKey(author))
                {
                    dictWithAuthors[author] = new List<Book>();
                }

                dictWithAuthors[author].Add(book);
            }

            var sortedAutors =
                dictWithAuthors.OrderByDescending(author => author.Value.Sum(y => y.Price))
                    .ThenBy(autorName => autorName.Key);

            foreach (var autor in sortedAutors)
            {
                decimal sum = (decimal)autor.Value.Sum(x => x.Price);
                Console.WriteLine("{0} -> {1:f2}", autor.Key, sum);
            }
        }
    }

    class Book
    {
        public Book(double price)
        {
            this.Price = price;
        }

        public double Price { get; set; }
    }
}