namespace _05.Compare_Char_Arrays
{
    #region

    using System;
    using System.Linq;

    #endregion

    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] arrayOne = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arrayTwo = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int comparer = string.CompareOrdinal(new string(arrayOne), new string(arrayTwo));

            if (comparer < 0)
            {
                Console.WriteLine(new string(arrayOne));
                Console.WriteLine(new string(arrayTwo));
            }
            else if (comparer > 0)
            {
                Console.WriteLine(new string(arrayTwo));
                Console.WriteLine(new string(arrayOne));
            }
            else
            {
                Console.WriteLine(new string(arrayOne));
                Console.WriteLine(new string(arrayTwo));
            }
        }
    }
}