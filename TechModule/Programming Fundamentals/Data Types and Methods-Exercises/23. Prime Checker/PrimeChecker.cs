using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Prime_Checker
{
    class PrimeChecker
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(PrimeCheck(n));
        }

        static bool PrimeCheck(long n)
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
