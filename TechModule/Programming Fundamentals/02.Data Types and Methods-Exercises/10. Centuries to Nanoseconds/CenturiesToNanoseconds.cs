using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    using System.Numerics;

    class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            sbyte century = sbyte.Parse(Console.ReadLine());
            byte oneHundred = 100;
            short years = (short)(century * oneHundred);
            int days = (int)(years * 365.2425);
            int hours = days * 24;
            int minutes = hours * 60;
            long seconds = (long)minutes * 60;
            long miliSec = seconds * 1000;
            ulong microSec = (ulong)miliSec * 1000;
            BigInteger nanoSec = microSec * 1000;

            Console.WriteLine(century);
            Console.WriteLine(years);
            Console.WriteLine(days);
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
            Console.WriteLine(seconds);
            Console.WriteLine(miliSec);
            Console.WriteLine(microSec);
            Console.WriteLine(nanoSec);
        }
    }
}
