using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftUni_Airline
{
    class SoftUniAirline
    {
        static void Main(string[] args)
        {
            var flights = int.Parse(Console.ReadLine());

            var flightsResult = new List<decimal>();
            for (int i = 0; i < flights; i++)
            {
                var adultCount = long.Parse(Console.ReadLine());
                var adultPrice = decimal.Parse(Console.ReadLine());
                var youthCount = long.Parse(Console.ReadLine());
                var youthPrice = decimal.Parse(Console.ReadLine());
                var fuelPrice = decimal.Parse(Console.ReadLine());
                var fuelCons = decimal.Parse(Console.ReadLine());
                var flightDuration = int.Parse(Console.ReadLine());
                var tickedSell = (adultCount * adultPrice) + (youthCount * youthPrice);
                var expenses = fuelPrice * fuelCons * flightDuration;
                var subtrac = tickedSell - expenses;

                if (subtrac >= 0)
                {
                    Console.WriteLine("You are ahead with {0:f3}$.", subtrac);
                }
                else
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:f3}$.", subtrac);
                }

                flightsResult.Add(subtrac);
            }

            Console.WriteLine("Overall profit -> {0:f3}$.", flightsResult.Sum());
            Console.WriteLine("Average profit -> {0:f3}$.", flightsResult.Sum() / flightsResult.Count);
        }
    }
}
