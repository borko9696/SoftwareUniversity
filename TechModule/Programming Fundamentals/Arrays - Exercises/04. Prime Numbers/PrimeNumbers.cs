namespace _04.Prime_Numbers
{
    #region

    using System;
    using System.Collections.Generic;

    #endregion

    class PrimeNumbers
    {
        public static List<int> FindPrimesInRange(int endNum)
        {
            List<int> collection = new List<int>();
            for (int i = 1; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    collection.Add(i);
                }
            }

            return collection;
        }

        public static bool IsPrime(int n)
        {
            if (n == 0)
            {
                return false;
            }

            if (n == 1)
            {
                return false;
            }

            if (n == 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); ++i)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", string.Join(", ", FindPrimesInRange(end)));
        }
    }
}