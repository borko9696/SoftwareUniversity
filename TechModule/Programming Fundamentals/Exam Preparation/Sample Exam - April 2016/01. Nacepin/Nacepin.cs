using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Nacepin
{
    class Nacepin
    {
        static void Main(string[] args)
        {
            decimal priceUS = decimal.Parse(Console.ReadLine());
            long weightUS = long.Parse(Console.ReadLine());

            decimal priceUK = decimal.Parse(Console.ReadLine());
            long weightUK = long.Parse(Console.ReadLine());

            decimal priceCH = decimal.Parse(Console.ReadLine());
            long weightCh = long.Parse(Console.ReadLine());

            decimal usStore = (priceUS / weightUS) / 0.58m;
            decimal ukStore = (priceUK / weightUK) / 0.41m;
            decimal chStore = (priceCH / weightCh) * 0.27m;

            Dictionary<string, decimal> stores = new Dictionary<string, decimal>();
            stores.Add("US store.", usStore);
            stores.Add("UK store.", ukStore);
            stores.Add("Chinese store.", chStore);

            var sortedStores = stores.OrderBy(x => x.Value);
            var bestPrice = sortedStores.First();
            var worstPrice = sortedStores.Last();

            Console.WriteLine("{0} {1:f2} lv/kg", bestPrice.Key, bestPrice.Value);
            Console.WriteLine("Difference {0:f2} lv/kg", Math.Abs(bestPrice.Value - worstPrice.Value));

        }
    }
}
