using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Sweet_Dessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            long guests = long.Parse(Console.ReadLine());
            decimal banana = decimal.Parse(Console.ReadLine());
            decimal eggs = decimal.Parse(Console.ReadLine());
            decimal barries = decimal.Parse(Console.ReadLine());

            decimal neededSets = Math.Ceiling(guests / 6m);
            decimal moneyNeeded = neededSets * (2 * banana) + neededSets * (4 * eggs) + neededSets * (0.2m * barries);

            if (moneyNeeded <= money)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.",moneyNeeded);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", moneyNeeded - money);
            }
        }
    }
}
