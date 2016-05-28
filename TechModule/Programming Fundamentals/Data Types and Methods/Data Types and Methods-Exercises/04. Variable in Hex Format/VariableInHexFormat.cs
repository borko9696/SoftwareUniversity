using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hex_Format
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('x');
            int binary = Convert.ToInt32(input[1], 16);
            Console.WriteLine(binary);
        }
    }
}
