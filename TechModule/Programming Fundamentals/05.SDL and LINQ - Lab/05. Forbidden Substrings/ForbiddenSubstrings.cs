namespace _05.Forbidden_Substrings
{
    #region

    using System;
    using System.Text.RegularExpressions;

    #endregion

    class ForbiddenSubstrings
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var word = Console.ReadLine().Split();

            for (int i = 0; i < word.Length; i++)
            {
                var currentWord = word[i];
                input = Regex.Replace(input, currentWord, new string('*', currentWord.Length));
            }

            Console.WriteLine(input);
        }
    }
}