namespace Problem_6.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Palindromes
    {
        private static void Main()
        {
            string[] input =
                Console.ReadLine()
                    .Split(new string[] { ".", " ", ",", ".", "!", "?" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            SortedSet<string> result = new SortedSet<string>();

            for (int i = 0; i < input.Length; i++)
            {
                char[] charArray = input[i].ToCharArray();
                Array.Reverse(charArray);
                string reverseWord = new string(charArray);

                if (reverseWord == input[i])
                {
                    result.Add(reverseWord);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}