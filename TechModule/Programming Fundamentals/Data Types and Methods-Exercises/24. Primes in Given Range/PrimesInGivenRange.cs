using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Primes_in_Given_Range
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", string.Join(", ", FindPrimesInRange(start, end)));
        }

        public static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> collection = new List<int>();
            for (int i = startNum; i <= endNum; i++)
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
    }
}
