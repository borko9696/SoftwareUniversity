namespace _18.OlympicsAreComing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class OlympicsAreComing
    {
        private static void Main()
        {
            var input = Console.ReadLine();
            ;

            var data = new Dictionary<string, Dictionary<string, int>>();

            while (input != "report")
            {
                var inputArray = input.Split('|');

                var player = string.Empty;
                player = FormatPlayer(inputArray, player);
                
                var country = string.Empty;
                country = FormatCountry(inputArray, country);

                FieldTheDictionary(data, country, player);

                input = Console.ReadLine();
            }

            var newDict = data.OrderByDescending(x => x.Value.Sum(y => y.Value));
            foreach (var pair in newDict)
            {
                var dict = pair.Value;
                Console.WriteLine("{0} ({1} participants): {2} wins", pair.Key, dict.Count, pair.Value.Sum(x => x.Value));
            }
        }

        private static void FieldTheDictionary(Dictionary<string, Dictionary<string, int>> data, string country, string player)
        {
            if (!data.ContainsKey(country))
            {
                data[country] = new Dictionary<string, int>();
            }
            if (!data[country].ContainsKey(player))
            {
                data[country][player] = 0;
            }
            data[country][player] += 1;
        }

        private static string FormatCountry(string[] inputArray, string country)
        {
            if (inputArray[1].Trim().Contains(' '))
            {
                var nonFormatedCountry = inputArray[1].Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                country = nonFormatedCountry[0].Trim() + " " + nonFormatedCountry[1].Trim();
            }
            else
            {
                country = inputArray[1].Trim();
            }
            return country;
        }

        private static string FormatPlayer(string[] inputArray, string player)
        {
            if (inputArray[0].Trim().Contains(' '))
            {
                var nonFormatPlayer = inputArray[0].Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                player = nonFormatPlayer[0].Trim() + " " + nonFormatPlayer[1].Trim();
            }
            else
            {
                player = inputArray[0].Trim();
            }
            return player;
        }
    }
}