namespace _26.Cubic_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text.RegularExpressions;

    internal class CubicAssault
    {
        private static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, BigInteger>>();

            var input = Console.ReadLine();
            while (input != "Count em all")
            {
                var arguments = Regex.Split(input, "->").Select(x => x.Trim()).ToArray();
                var region = arguments[0];
                var type = arguments[1];
                var value = BigInteger.Parse(arguments[2]);

                if (!dict.ContainsKey(region))
                {
                    dict[region] = new Dictionary<string, BigInteger>();
                    dict[region]["Black"] = 0;
                    dict[region]["Red"] = 0;
                    dict[region]["Green"] = 0;
                    dict[region][type] = value;
                }
                else
                {
                    var oldValue = dict[region][type];
                    dict[region][type] = oldValue + value;
                }

                switch (type)
                {
                    case "Black":
                        break;
                    case "Red":
                        if (dict[region][type] >= 1000000)
                        {
                            while (dict[region][type] >= 1000000)
                            {
                                dict[region]["Black"]++;
                                dict[region][type] -= 1000000;
                            }

                            dict[region][type] = 0;
                        }

                        break;
                    case "Green":
                        if (dict[region][type] >= 1000000)
                        {
                            while (dict[region][type] >= 1000000)
                            {
                                dict[region]["Red"]++;
                                dict[region][type] -= 1000000;
                            }

                            dict[region][type] = 0;
                            if (dict[region]["Red"] >= 1000000)
                            {
                                while (dict[region]["Red"] >= 1000000)
                                {
                                    dict[region]["Black"]++;
                                    dict[region]["Red"] -= 1000000;
                                }

                                dict[region]["Red"] = 0;
                            }
                        }

                        break;
                }

                input = Console.ReadLine();
            }

            var result = dict.OrderByDescending(x => x.Value["Black"]).ThenBy(x => x.Key.Length).ThenBy(x => x.Key);
            foreach (var pair in result)
            {
                Console.WriteLine(pair.Key);
                var values = pair.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

                foreach (var value in values)
                {
                    Console.WriteLine("-> {0} : {1}", value.Key, value.Value);
                }
            }
        }
    }
}