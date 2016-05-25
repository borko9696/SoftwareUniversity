namespace _03.Sum__Min__Max__First__Last__Average
{
    #region

    using System;
    using System.Linq;

    #endregion

    class SumMinMaxFirstLastAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new long[n];

            for (int i = 0; i < n; i++)
            {
                long num = long.Parse(Console.ReadLine());
                numbers[i] = num;
            }

            long first = numbers[0];
            long last = numbers[n - 1];

            Array.Sort(numbers);

            long max = numbers[n - 1];
            long min = numbers[0];

            long sum = numbers.Sum();
            decimal average = sum / (decimal)n;

            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("First = {0}", first);
            Console.WriteLine("Last = {0}", last);
            Console.WriteLine("Average = {0}", average);
        }
    }
}