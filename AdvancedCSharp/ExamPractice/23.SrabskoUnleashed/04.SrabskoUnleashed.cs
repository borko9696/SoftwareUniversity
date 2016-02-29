namespace _04.SrabskoUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal class SrabskoUnleashed
    {
        private static void Main()
        {
            var regex = new Regex(@"(\D+)\s@(\D+)\s+(\d+)\s(\d+)");

            var dict = new Dictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                var match = regex.Match(input);
                if (match.Success)
                {
                    var singer = match.Groups[1].Value.Trim();
                    var place = match.Groups[2].Value.Trim();
                    var ticketPrice = int.Parse(match.Groups[3].Value);
                    var ticketCount = int.Parse(match.Groups[4].Value);


                    if (!dict.ContainsKey(place))
                    {
                        dict[place] = new Dictionary<string, int>();
                    }
                    if (!dict[place].ContainsKey(singer))
                    {
                        dict[place][singer] = 0;
                    }
                    dict[place][singer] += ticketCount*ticketPrice;
                }

                input = Console.ReadLine();
            }

            foreach (var pair in dict)
            {
                Console.WriteLine(pair.Key);

                var dicts = pair.Value.OrderByDescending(x => x.Value);
                foreach (var valuePair in dicts)
                {
                    Console.WriteLine("#  {0} -> {1}", valuePair.Key, valuePair.Value);
                }
            }
        }
    }
}