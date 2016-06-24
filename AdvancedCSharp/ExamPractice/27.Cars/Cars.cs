namespace _27.Cars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];

                var engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));

                var cargo = new Cargo(int.Parse(input[3]), (CargoType)Enum.Parse(typeof(CargoType), input[4]));

                var tire =
                    new Tire(
                        new List<double>
                            {
                                double.Parse(input[5]),
                                double.Parse(input[7]),
                                double.Parse(input[9]),
                                double.Parse(input[11])
                            },
                        new List<int>
                            {
                                int.Parse(input[6]),
                                int.Parse(input[8]),
                                int.Parse(input[10]),
                                int.Parse(input[12])
                            });
             


                var car = new Car(model, engine, cargo, tire);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                var newCars =
                    cars.Where(x => x.Cargo.CargoType == CargoType.fragile)
                        .Where(y => y.Tire.TireOnePreassure.Exists(t => t < 1d))
                        .ToList();
            }
        }
    }

    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo, Tire tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tire = tires;
        }

        public Tire Tire { get; set; }

        public Cargo Cargo { get; set; }

        public Engine Engine { get; set; }

        public string Model { get; set; }
    }

    public class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }

        public int EnginePower { get; set; }

        public int EngineSpeed { get; set; }
    }

    public class Cargo
    {
        public Cargo(int cargoWeight, CargoType cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }

        public CargoType CargoType { get; set; }

        public int CargoWeight { get; set; }
    }

    public class Tire
    {
        public Tire(List<double> tireOnePreassure, List<int> tireOneAge)
        {
            this.TireOnePreassure = tireOnePreassure;
            this.TireOneAge = tireOneAge;
        }

        public List<double> TireOnePreassure { get; set; }

        public List<int> TireOneAge { get; set; }
    }

    public enum CargoType
    {
        fragile,
        flamable
    }
}