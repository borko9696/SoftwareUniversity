namespace _02.Softuni_Coffee_Orders
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    #endregion

    class SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var resultOrders = new List<decimal>();

            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderTime = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var daysInMonth = DateTime.DaysInMonth(orderTime.Year, orderTime.Month);
                var count = long.Parse(Console.ReadLine());

                var result = (daysInMonth * count) * pricePerCapsule;
                Console.WriteLine("The price for the coffee is: ${0:f2}", result);
                resultOrders.Add(result);
            }

            Console.WriteLine("Total: ${0:f2}", resultOrders.Sum());
        }
    }
}