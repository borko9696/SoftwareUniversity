using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Practice_Integers
{
    using System.Numerics;

    class PracticeIntegers
    {
        static void Main(string[] args)
        {
            sbyte byteNum = sbyte.Parse(Console.ReadLine());
            short shortNum = short.Parse(Console.ReadLine());
            int intNum = int.Parse(Console.ReadLine());
            ushort uintNum = ushort.Parse(Console.ReadLine());
            ulong ulongNum = ulong.Parse(Console.ReadLine());
            long longNum = long.Parse(Console.ReadLine());
            BigInteger bigIntefer = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(byteNum);
            Console.WriteLine(shortNum);
            Console.WriteLine(intNum);
            Console.WriteLine(uintNum);
            Console.WriteLine(ulongNum);
            Console.WriteLine(longNum);
            Console.WriteLine(bigIntefer);
        }
    }
}
