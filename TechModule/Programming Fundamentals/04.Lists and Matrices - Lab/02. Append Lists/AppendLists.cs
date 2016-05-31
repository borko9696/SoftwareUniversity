namespace _02.Append_Lists
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    #endregion

    class AppendLists
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split('|').Reverse().ToList();

            var result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var line = Regex.Split(numbers[i], "\\s+");

                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] != string.Empty)
                    {
                        result.Add(int.Parse(line[j]));
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}