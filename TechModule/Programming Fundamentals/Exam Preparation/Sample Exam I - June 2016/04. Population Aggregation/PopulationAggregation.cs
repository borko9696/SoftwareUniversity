namespace _04.Population_Aggregation
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    #endregion

    class PopulationAggregation
    {
        static void Main(string[] args)
        {
            var countries = new SortedDictionary<string, int>();
            var towns = new Dictionary<string, long>();

            var input = Console.ReadLine();
            while (input != "stop")
            {
                var inputArgs = input.Split('\\');
                var argumentOne = Regex.Replace(inputArgs[0], @"[@#$&\d]+", string.Empty);
                var argumentTwo = Regex.Replace(inputArgs[1], @"[@#$&\d]+", string.Empty);

                var country = string.Empty;
                var town = string.Empty;

                if (char.IsUpper(argumentOne[0]))
                {
                    country = argumentOne;
                    town = argumentTwo;
                }
                else
                {
                    country = argumentTwo;
                    town = argumentOne;
                }

                if (!countries.ContainsKey(country))
                {
                    countries[country] = 0;
                }

                countries[country]++;

                if (!towns.ContainsKey(town))
                {
                    towns[town] = 0;
                }

                towns[town] = long.Parse(inputArgs[2]);

                input = Console.ReadLine();
            }

            var sortedTowns = towns.OrderByDescending(x => x.Value).Take(3);

            foreach (var country in countries)
            {
                Console.WriteLine("{0} -> {1}", country.Key, country.Value);
            }

            foreach (var town in sortedTowns)
            {
                Console.WriteLine("{0} -> {1}", town.Key, town.Value);
            }
        }
    }
}