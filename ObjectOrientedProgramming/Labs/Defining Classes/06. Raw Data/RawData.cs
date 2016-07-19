namespace _06.Raw_Data
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class RawData
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var model = input[0];
                var engineSpeed = long.Parse(input[1]);
                var enginePower = long.Parse(input[2]);
                var cargoWeight = long.Parse(input[3]);
                var cargoType = input[4];
                var tier1P = double.Parse(input[5]);
                var tier1A = int.Parse(input[6]);
                var tier2P = double.Parse(input[7]);
                var tier2A = int.Parse(input[8]);
                var tier3P = double.Parse(input[9]);
                var tier3A = int.Parse(input[10]);
                var tier4P = double.Parse(input[11]);
                var tier4A = int.Parse(input[12]);

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);

                var tierOne = new Tier(tier1P, tier1A);
                var tierTwo = new Tier(tier2P, tier2A);
                var tierThree = new Tier(tier3P, tier3A);
                var tierFour = new Tier(tier4P, tier4A);
                List<Tier> tiers = new List<Tier> { tierOne, tierTwo, tierThree, tierFour };
                var car = new Car(model, engine, cargo, tiers);
                cars[car.Model] = car;
            }

            var type = Console.ReadLine();
            if (type == "fragile")
            {
                var result = cars.Where(x => x.Value.Tiers.Exists(y => y.TirePressure < 1d));
                foreach (var car in result)
                {
                    Console.WriteLine(car.Key);
                }
            }
            else
            {
                var result = cars.Where(x => x.Value.Engine.EnginePower > 250);
                foreach (var car in result)
                {
                    Console.WriteLine(car.Key);
                }
            }
        }
    }

    public class Engine
    {
        public Engine(long engineSpeed, long enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }

        public long EnginePower { get; set; }

        public long EngineSpeed { get; set; }
    }

    public class Cargo
    {
        public Cargo(long cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }

        public string CargoType { get; set; }

        public long CargoWeight { get; set; }
    }

    public class Tier
    {
        public Tier(double tirePressure, int tierAge)
        {
            this.TirePressure = tirePressure;
            this.TierAge = tierAge;
        }

        public int TierAge { get; set; }

        public double TirePressure { get; set; }
    }

    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo, List<Tier> tiers)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tiers = tiers;
        }

        public Cargo Cargo { get; set; }

        public Engine Engine { get; set; }

        public string Model { get; set; }

        public List<Tier> Tiers { get; set; }
    }
}