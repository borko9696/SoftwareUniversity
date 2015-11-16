namespace Problem_3.Count_Substring_Occurrences
{
    using System;

    internal class CountSubstringOccurrences
    {
        private static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string match = Console.ReadLine().ToLower();
            int count = 0;

            for (int i = 0; i <= input.Length - match.Length; i++)
            {
                if (match == input.Substring(i, match.Length))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}