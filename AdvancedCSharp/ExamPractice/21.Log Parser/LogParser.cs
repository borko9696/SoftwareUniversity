using System.Collections.Generic;

namespace _21.Log_Parser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class LogParser
    {
        private static void Main()
        {
            var dict = new Dictionary<string,Project>();
            var input = Console.ReadLine();
            while (input!="END")
            {
                MatchCollection matches = Regex.Matches(input, ".*?\\[\"(.*?)\"\\]");


                var projectName = matches[0].Groups[1].Value;
                var type = matches[1].Groups[1].Value;
                var message = matches[2].Groups[1].Value;

                if (!dict.ContainsKey(projectName))
                {
                    dict[projectName] = new Project();
                }
                if (type == "Critical")
                {
                    dict[projectName].CriticalMSG.Add(message);
                    dict[projectName].TotalErrors++;
                    dict[projectName].Crit++;
                }
                else
                {
                    dict[projectName].WarningMSG.Add(message);
                    dict[projectName].TotalErrors++;
                    dict[projectName].Warning++;
                }

                input = Console.ReadLine();
            }

            var newDict = dict.OrderByDescending(x => x.Value.TotalErrors).ThenBy(y=>y.Key);
            foreach (var pair in newDict)
            {
                Console.WriteLine(pair.Key+":");
                Console.WriteLine("Total Errors: {0}",pair.Value.TotalErrors);
                Console.WriteLine("Critical: {0}",pair.Value.Crit);
                Console.WriteLine("Warnings: {0}",pair.Value.Warning);

                Console.WriteLine("Critical Messages:");
                var crits = pair.Value.CriticalMSG.OrderBy(x=>x.Length).ThenBy(y=>y).ToList();
                if (crits.Count == 0)
                {
                    Console.WriteLine("--->None");
                }
                else
                {
                    foreach (var crit in crits)
                    {
                        Console.WriteLine("--->{0}", crit);
                    }
                }

                Console.WriteLine("Warning Messages:");
                var warnings = pair.Value.WarningMSG.OrderBy(x => x.Length).ThenBy(y => y).ToList();
                if (warnings.Count == 0)
                {
                    Console.WriteLine("--->None");
                }
                else
                {
                    foreach (var warning in warnings)
                    {
                        Console.WriteLine("--->{0}", warning);
                    }
                }
                Console.WriteLine();
            }


        }
    }

    public class Project
    {
        public Project()
        {
            this.CriticalMSG = new List<string>();
            this.WarningMSG = new List<string>();
        }
        public List<string> CriticalMSG { get; set; }
        public List<string> WarningMSG { get; set; }
        public int TotalErrors { get; set; }
        public int Crit { get; set; }
        public int Warning { get; set; }
    }
}