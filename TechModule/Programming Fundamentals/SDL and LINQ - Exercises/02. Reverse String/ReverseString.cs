namespace _02.Reverse_String
{
    #region

    using System;

    #endregion

    class ReverseString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            Console.WriteLine(new string(input));
        }
    }
}