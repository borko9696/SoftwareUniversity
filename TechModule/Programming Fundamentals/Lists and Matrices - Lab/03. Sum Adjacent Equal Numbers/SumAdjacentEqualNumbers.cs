namespace _03.Sum_Adjacent_Equal_Numbers
{
    #region

    using System;
    using System.Linq;

    #endregion

    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            int index = 0;
            while (index >= 0 && index < input.Count - 1)
            {
                if (input[index] == input[index + 1])
                {
                    input[index] += input[index + 1];
                    input.RemoveAt(index + 1);
                    index--;
                    if (index < 0)
                    {
                        index = 0;
                    }
                }
                else
                {
                    index++;
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}