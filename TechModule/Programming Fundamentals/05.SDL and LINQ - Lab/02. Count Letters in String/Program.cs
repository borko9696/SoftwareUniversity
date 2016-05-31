namespace _02.Count_Letters_in_String
{
    #region

    using System;
    using System.Collections.Generic;

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            var letters = new SortedDictionary<char, int>();
            var intput = Console.ReadLine();

            for (int i = 0; i < intput.Length; i++)
            {
                var currentLetter = char.ToLower(intput[i]);

                if (!letters.ContainsKey(currentLetter))
                {
                    letters[currentLetter] = 0;
                }

                letters[currentLetter]++;
            }

            foreach (var letter in letters)
            {
                Console.WriteLine("{0} -> {1}", letter.Key, letter.Value);
            }
        }
    }
}