namespace _08.Palindromes
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class Palindromes
    {
        static void Main(string[] args)
        {
            var input =
                Console.ReadLine()
                    .Split(
                        new[] { ' ', '.', ',', '!', ':', ';', '?', '(', ')', '[', ']', '\\', '/', '\"', '\'' }, 
                        StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            var palindromes = new SortedSet<string>();

            foreach (var element in input)
            {
                var wordToChar = element.ToCharArray();
                Array.Reverse(wordToChar);
                var reversed = new string(wordToChar);

                if (element == reversed)
                {
                    palindromes.Add(element);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}