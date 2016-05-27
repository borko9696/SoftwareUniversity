namespace _09.Index_of_letters
{
    #region

    using System;

    #endregion

    class IndexOfletters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", input[i], input[i] - 97);
            }
        }
    }
}