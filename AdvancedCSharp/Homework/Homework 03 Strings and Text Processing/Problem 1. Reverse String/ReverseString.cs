namespace Problem_1.Reverse_String
{
    using System;

    internal class ReverseString
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(string.Join("", charArray));
        }
    }
}