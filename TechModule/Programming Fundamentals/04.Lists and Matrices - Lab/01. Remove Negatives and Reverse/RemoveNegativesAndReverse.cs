namespace _01.Remove_Negatives_and_Reverse
{
    #region

    using System;
    using System.Linq;

    #endregion

    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).Where(x => x >= 0).Reverse().ToList();

            if (numbers.Any())
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}