namespace _05.Fubinacci
{
    #region

    using System;
    using System.Collections.Generic;

    #endregion

    class FibonacciMain
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            Fibonacci fib = new Fibonacci(firstNum, secNum);
            Console.WriteLine(string.Join(", ", fib.NumbersInRange));
        }
    }

    public class Fibonacci
    {
        public Fibonacci(int start, int end)
        {
            this.Start = start;
            this.End = end;
        }

        public int End { get; set; }

        public List<long> NumbersInRange
        {
            get
            {
                return this.GetNumbersInRange(this.Start, this.End);
            }

            set
            {
            }
        }

        public int Start { get; set; }

        private List<long> GetNumbersInRange(int start, int end)
        {
            var numbers = new List<long> { 0, 1, 1 };
            for (int i = 3; i <= end; i++)
            {
                var sum = numbers[i - 1] + numbers[i - 2];
                numbers.Add(sum);
            }

            var resultNumvers = numbers.GetRange(start, end - start);

            return resultNumvers;
        }
    }
}