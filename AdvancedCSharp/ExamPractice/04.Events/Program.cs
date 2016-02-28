namespace _04.Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        private static void Main()
        {
            var linesNum = int.Parse(Console.ReadLine());
            var listEvents = new List<string>();
            for (int i = 0; i < linesNum; i++)
            {
                var input = Console.ReadLine();
                listEvents.Add(input);
            }

            var cities = Console.ReadLine().Split(',');

            var dict = new SortedDictionary<string,SortedDictionary<string,List<string>>>();

            for (int i = 0; i < listEvents.Count; i++)
            {
                var line = listEvents[i];

                var regex =new Regex(@"#([A-Za-z]+):\s*@([A-Za-z]+)\s*(\d+):(\d+)");
                var match = regex.Match(line);
                if (match.Success)
                {
                    var person = match.Groups[1].Value.Trim();
                    var city = match.Groups[2].Value.Trim();
                    var hour =uint.Parse(match.Groups[3].Value.Trim());
                    var min =uint.Parse(match.Groups[4].Value.Trim());
                    if (hour<=23 && min<=59)
                    {
                        var sb = new StringBuilder();
                        sb.AppendFormat("{0:00}:{1:00}", hour, min);
                        var time = sb.ToString();
                        if (!dict.ContainsKey(city))
                        {
                            dict[city] = new SortedDictionary<string, List<string>>();
                        }

                        if (!dict[city].ContainsKey(person))
                        {
                            dict[city][person] = new List<string>();
                        }
                        dict[city][person].Add(time);
                    }
                }
            }
          
            foreach (var pair in dict)
            {
                int count = 1;
                if (cities.Contains(pair.Key))
                {
                    Console.WriteLine("{0}:",pair.Key);

                    foreach (var innerPair in pair.Value)
                    {
                        
                        var list = innerPair.Value.OrderBy(x => x);
                        Console.WriteLine("{0}. {1} -> {2}",count,innerPair.Key,string.Join(", ",list));
                        count++;
                    }
                    count++;
                }
            }
        }
    }
}