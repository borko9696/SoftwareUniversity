using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Practice_Floating_Points
{
    class PracticeFloatingPoints
    {
        static void Main(string[] args)
        {
            decimal doubleNum = decimal.Parse(Console.ReadLine());
            double floatNum = double.Parse(Console.ReadLine());
            decimal decimalNum = decimal.Parse(Console.ReadLine());

            Console.WriteLine(doubleNum);
            Console.WriteLine(floatNum);
            Console.WriteLine(decimalNum);
        }
    }
}
