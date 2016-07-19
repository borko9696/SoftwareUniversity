using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Car_Salesman
{
    class CarSalesman
    {
        static void Main(string[] args)
        {
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Trim().Split();
                Engine engine = null;

                if (input.Length == 3)
                {
                    try
                    {
                        int displacement = int.Parse(input[2]);
                        engine = new Engine(input[0], input[1], input[2], "n/a");
                    }
                    catch (Exception)
                    {

                        string efficiency = input[2];
                        engine = new Engine(input[0], input[1], "n/a", efficiency);
                    }
                }
                else if (input.Length == 4)
                {

                    engine = new Engine(input[0], input[1], input[2], input[3]);
                }
                else
                {
                    engine = new Engine(input[0], input[1], "n/a", "n/a");
                }

                engines[engine.Model] = engine;
            }

            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Trim().Split();
                Car car = null;

                if (input.Length == 3)
                {
                    try
                    {
                        int weight = int.Parse(input[2]);
                        car = new Car(input[0], engines[input[1]], input[2],"n/a");
                    }
                    catch (Exception)
                    {
                        string color = input[2];
                        car = new Car(input[0], engines[input[1]], "n/a", color);
                    }
                }
                else if (input.Length == 4)
                {

                    car = new Car(input[0], engines[input[1]], input[2], input[3]);
                }
                else
                {
                    car = new Car(input[0], engines[input[1]], "n/a", "n/a");
                }

                cars[car.Model] = car;
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Value);
            }
        }
    }

    public class Engine
    {
        public Engine(string model, string power, string displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public string Model { get; set; }

        public string Power { get; set; }

        public string Displacement { get; set; }

        public string Efficiency { get; set; } 
    }

    public class Car
    {
        public Car(string model, Engine engine, string weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public string Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Model + ":");
            sb.AppendLine("  " + this.Engine.Model + ":");
            sb.AppendLine("    Power: " + this.Engine.Power);
            sb.AppendLine("    Displacement: " + this.Engine.Displacement);
            sb.AppendLine("    Efficiency: " + this.Engine.Efficiency);
            sb.AppendLine("  Weight: " + this.Weight);
            sb.AppendLine("  Color: " + this.Color);

            return sb.ToString().Trim();
        }
    }
}
