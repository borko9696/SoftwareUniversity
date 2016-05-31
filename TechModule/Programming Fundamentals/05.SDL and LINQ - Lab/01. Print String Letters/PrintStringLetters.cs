namespace _01.Print_String_Letters
{
    #region

    using System;

    #endregion

    class PrintStringLetters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine("str[{0}] -> '{1}'", i, word[i]);
            }
        }
    }
}