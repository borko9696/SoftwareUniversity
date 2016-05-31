namespace _03.Exact_Sum_of_Real_Numbers
{
    #region

    using System;

    #endregion

    class SumOfRealNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}