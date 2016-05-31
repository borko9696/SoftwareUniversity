using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int intValue = int.Parse(Console.ReadLine());
            string hexValue = intValue.ToString("X");
            Console.WriteLine(hexValue);
            string binary = Convert.ToString(intValue, 2);
            Console.WriteLine(binary);
        }
    }
}
