using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Numbers_In_Reversed_Order
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            PrintReversedString(number);
        }

        private static void PrintReversedString(double num)
        {
            char[] number = num.ToString().ToCharArray();
            Array.Reverse(number);
            
            Console.WriteLine("{0}",string.Join(string.Empty,number));
        }
    }
}
