namespace _02.Randomize_Words
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class RandomizeWords
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            var result = new string[input.Count];
            var indexes = new List<int>();

            Random random = new Random();

            int count = 0;
            while (indexes.Count < input.Count)
            {
                int index = random.Next(0, input.Count);

                if (!indexes.Contains(index))
                {
                    result[index] = input[count];
                    indexes.Add(index);
                    count++;
                }
            }

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}