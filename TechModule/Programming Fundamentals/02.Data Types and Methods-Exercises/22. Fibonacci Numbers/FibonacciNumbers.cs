using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Fibonacci_Numbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(input));
        }

        public static int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

    }
}
