using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == difference)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
