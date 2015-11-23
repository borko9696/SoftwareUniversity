namespace LaptopShop
{
    using System;

    internal class LaptopShop
    {
        private static void Main(string[] args)
        {
            var battery = new Battery("Li-Ion", 4, 2550, 4.5);

            var laptop = new Laptop(
                "Lenovo Yoga 2 Pro",
                "Lenovo",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                "8 GB",
                "Intel HD Graphics 4400",
                "128GB SSD",
                "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                battery,
                2259.00m);

            Console.WriteLine(laptop.ToString());
        }
    }
}