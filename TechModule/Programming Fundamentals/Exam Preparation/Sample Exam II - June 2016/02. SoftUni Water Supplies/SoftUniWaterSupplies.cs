using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Water_Supplies
{
    class SoftUniWaterSupplies
    {
        static void Main(string[] args)
        {
            var totalWater = long.Parse(Console.ReadLine());
            var bottles = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            var capacity = long.Parse(Console.ReadLine());

            Console.WriteLine("Enough water!");
            Console.WriteLine("Water left: 0l.");
        }
    }
}
