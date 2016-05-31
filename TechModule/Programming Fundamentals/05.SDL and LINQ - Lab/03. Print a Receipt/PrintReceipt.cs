namespace _03.Print_a_Receipt
{
    #region

    using System;
    using System.Linq;

    #endregion

    class PrintReceipt
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double sum = 0;

            Console.WriteLine("/{0}\\", new string('-', 22));
            for (int i = 0; i < numbers.Length; i++)
            {
                var numAsString = string.Format("{0:F2}", numbers[i]);
                sum += double.Parse(numAsString);
                Console.WriteLine("|{0}{1} |", new string(' ', 21 - numAsString.Length), numAsString);
            }

            Console.WriteLine("|{0}|", new string('-', 22));

            var sumAsString = string.Format("{0:F2}", sum);
            Console.WriteLine("| Total:{0}{1} |", new string(' ', 14 - sumAsString.Length), sumAsString);

            Console.WriteLine("\\{0}/", new string('-', 22));
        }
    }
}