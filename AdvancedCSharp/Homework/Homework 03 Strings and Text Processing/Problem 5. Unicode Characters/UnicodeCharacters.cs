namespace Problem_5.Unicode_Characters
{
    using System;

    internal class UnicodeCharacters
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            foreach (char i in input)
            {
                Console.Write("\\u" + ((int)i).ToString("X4"));
            }
            Console.WriteLine();
        }
    }
}