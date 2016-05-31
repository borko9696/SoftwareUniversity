namespace _04.Occurrences_in_String
{
    #region

    using System;

    #endregion

    class OccurrencesInString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var word = Console.ReadLine();

            var offset = 0;
            int count = 0;
            while (offset != -1)
            {
                offset = input.IndexOf(word, offset);
                if (offset != -1)
                {
                    count++;
                    offset++;
                }
            }

            Console.WriteLine(count);
        }
    }
}