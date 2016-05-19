using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}", 2 * a + 2 * b);
            Console.WriteLine("{0}", a * b);
            Console.WriteLine("{0}", Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
        }
    }
}
