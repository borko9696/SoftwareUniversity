namespace _11.Sum_Reversed_Numbers
{
    #region

    using System;
    using System.Linq;

    #endregion

    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            long sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNum = numbers[i].ToString().ToCharArray();
                Array.Reverse(currentNum);
                int number = int.Parse(new string(currentNum));
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}