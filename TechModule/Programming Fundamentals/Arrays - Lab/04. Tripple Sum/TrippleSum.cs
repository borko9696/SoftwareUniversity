namespace _04.Tripple_Sum
{
    #region

    using System;
    using System.Linq;
    using System.Text;

    #endregion

    class TrippleSum
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var sb = new StringBuilder();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    long sum = numbers[i] + numbers[j];

                    if (numbers.Contains(sum))
                    {
                        sb.AppendFormat("{0} + {1} == {2}\n", numbers[i], numbers[j], sum);
                    }
                }
            }

            var toString = sb.ToString().Trim();

            if (string.IsNullOrEmpty(toString))
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(toString);
            }
        }
    }
}