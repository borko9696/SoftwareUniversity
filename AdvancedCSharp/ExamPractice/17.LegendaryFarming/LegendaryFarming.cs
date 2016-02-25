namespace _17.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LegendaryFarming
    {
        private static void Main()
        {
            var junk = new SortedDictionary<string, int>();
            var keyMats = new Dictionary<string, int>();
            keyMats.Add("shards", 0);
            keyMats.Add("motes", 0);
            keyMats.Add("fragments", 0);

            var keyWinner = string.Empty;

            while (keyWinner == String.Empty)
            {
                var input = Console.ReadLine().Split(' ');

                for (int i = 0; i < input.Length; i+=2)
                {
                    var material = input[i + 1].ToLower();
                    var quantity = int.Parse(input[i]);

                    if (!keyMats.ContainsKey(material))
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk[material] = 0;
                        }
                        junk[material] += quantity;
                    }
                    else
                    {
                        keyMats[material] += quantity;
                        if (keyMats[material] >= 250)
                        {
                            keyMats[material] -= 250;
                            keyWinner += material;
                            break;
                        }
                    }
                }

            }

            if (keyWinner.Equals("motes"))
            {
                Console.WriteLine("Dragonwrath obtained!");
            }
            else if (keyWinner.Equals("fragments"))
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else
            {
                Console.WriteLine("Shadowmourne obtained!");
            }

            var newKeyMats = keyMats.OrderByDescending(x => x.Value);
            foreach (var pair in newKeyMats)
            {
                Console.WriteLine("{0}: {1}", pair.Key , pair.Value);
            }
            foreach (var pair in junk)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }
    }
}