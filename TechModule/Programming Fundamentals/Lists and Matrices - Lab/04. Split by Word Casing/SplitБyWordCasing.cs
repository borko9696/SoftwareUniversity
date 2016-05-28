namespace _04.Split_by_Word_Casing
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class SplitБyWordCasing
    {
        static void Main(string[] args)
        {
            string[] input =
                Console.ReadLine()
                    .Split(
                        new[] { ',', ':', '.', ';', '!', '(', ')', '!', '\'', '\\', '\"', ']', '[', ' ', '/' }, 
                        StringSplitOptions.RemoveEmptyEntries);

            List<string> lowerCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();

            foreach (string word in input)
            {
                bool areAllLowercase = word.All(char.IsLower);
                bool areAllUppercase = word.All(char.IsUpper);
                if (areAllLowercase)
                {
                    lowerCaseWords.Add(word);
                }
                else if (areAllUppercase)
                {
                    upperCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));
        }
    }
}