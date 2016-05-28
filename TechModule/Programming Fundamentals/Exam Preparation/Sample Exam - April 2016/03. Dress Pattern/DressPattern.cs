using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Dress_Pattern
{
    class DressPattern
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}.{0}.{0}", new string('_', n * 4));
            int lines = n * 4 - 2;
            int stars = 2;

            for (int i = 0; i < n*2-1; i++)
            {
                Console.WriteLine("{0}.{1}.{0}.{1}.{0}",new string('_', lines), new string('*', stars));
                lines -= 2;
                stars += 3;
            }

            Console.WriteLine(".{0}..{0}.", new string('*', 6 * n - 1));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(".{0}.", new string('*', 12 * n));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n * 3), new string('*', n * 6 + 2));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('_', n * 3), new string('o', n * 6 + 2));
            }

            int lines2 = n * 3;
            int stars2 = n * 6;

            for (int i = 0; i < n * 3; i++)
            {
                Console.WriteLine("{0}.{1}.{0}",new string('_', lines2), new string('*', stars2));
                lines2--;
                stars2 += 2;
            }

            Console.WriteLine("{0}", new string('.', 12 * n + 2));
        }
    }
}
