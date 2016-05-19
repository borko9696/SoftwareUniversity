using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Factorial
{
    using System.Numerics;

    class Factorial
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            BigInteger sum = 1;
            for (int i = 2; i <= number; i++)
            {
                sum *= i;
            }

            Console.WriteLine(sum);
        }
    }
}
