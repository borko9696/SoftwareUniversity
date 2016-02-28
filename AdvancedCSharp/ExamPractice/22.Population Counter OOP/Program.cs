namespace _04.Population_Counter_OOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main()
        {
            var dict = new Dictionary<string,Country>();
            var input = Console.ReadLine();

            while (input != "report")
            {
                var array = input.Split('|');
                var city = array[0];
                var country = array[1];
                var population =int.Parse(array[2]);

                if (!dict.ContainsKey(country))
                {
                    dict[country] = new Country();
                }
                dict[country].Cities.Add(new City(city,population));
                dict[country].Population += population;

                input = Console.ReadLine();
            }

            var sortedByCountreis = dict.OrderByDescending(x => x.Value.Population);
            foreach (var pair in sortedByCountreis)
            {
                Console.WriteLine("{0} (total population: {1})",pair.Key,pair.Value.Population);

                var listByCities = pair.Value.Cities.OrderByDescending(x => x.Population);
                foreach (var city in listByCities)
                {
                    Console.WriteLine("=>{0}: {1}",city.Name,city.Population);
                }
            }
        }
    }

    public class City
    {
        public City(string name , int population)
        {
            this.Name = name;
            this.Population = population;
        }
        public string Name { get; set; }
        public int Population { get; set; }
    }

    public class Country
    {
        public Country()
        {
            this.Cities = new List<City>();
        }
        public long Population { get; set; }
        public List<City> Cities { get; set; }
    }
}