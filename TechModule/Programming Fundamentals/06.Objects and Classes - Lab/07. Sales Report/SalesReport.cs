namespace _07.Sales_Report
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class SalesReport
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var listWithSales = new List<Sale>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var sale = new Sale(input[0], input[1], double.Parse(input[2]), double.Parse(input[3]));
                listWithSales.Add(sale);
            }

            var dict = new Dictionary<string, double>();
            foreach (var sale in listWithSales)
            {
                if (!dict.ContainsKey(sale.Town))
                {
                    dict[sale.Town] = 0;
                }

                dict[sale.Town] += sale.Price * sale.Quantity;
            }

            foreach (var sale in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:F2}", sale.Key, sale.Value);
            }
        }
    }

    class Sale
    {
        public Sale(string town, string product, double price, double quantity)
        {
            this.Town = town;
            this.Product = product;
            this.Price = price;
            this.Quantity = quantity;
        }

        public double Price { get; set; }

        public string Product { get; set; }

        public double Quantity { get; set; }

        public string Town { get; set; }
    }
}