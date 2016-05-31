namespace _07.Odd_Occurrences
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split();

            var elements = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentElement = input[i];
                if (!elements.ContainsKey(currentElement))
                {
                    elements[currentElement] = 0;
                }

                elements[currentElement]++;
            }

            var resultElements = elements.Where(x => x.Value % 2 != 0);
            var result = new List<string>();

            foreach (var element in resultElements)
            {
                result.Add(element.Key);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}