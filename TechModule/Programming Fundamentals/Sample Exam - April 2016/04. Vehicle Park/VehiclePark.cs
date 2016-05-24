namespace _04.Vehicle_Park
{
    using System;
    using System.Collections.Generic;

    class VehiclePark
    {
        static void Main(string[] args)
        {
            string[] specialNumbers = Console.ReadLine().Split(' ');

            int counter = 0;
            List<string> sold = new List<string>(specialNumbers);
            List<string> requests = new List<string>();

            string request = Console.ReadLine();
            while (request != "End of customers!")
            {
                requests.Add(request);
                
                request = Console.ReadLine();
            }

            for (int i = 0; i < requests.Count; i++)
            {
                var currentrequest = requests[i];
                var splitedRequest = currentrequest.Split(' ');
                string vehicle = splitedRequest[0];
                long seats = long.Parse(splitedRequest[2]);
                
                bool sale = false;
                var currentMashine = string.Empty;

                for (int j = 0; j < specialNumbers.Length; j++)
                {

                    currentMashine = specialNumbers[j];
                    var vehicleType = currentMashine[0].ToString();
                    long vehicleSeats = long.Parse(currentMashine.Substring(1, currentMashine.Length - 1));


                    if (vehicleType == "c" && vehicle == "Car" && !sale)
                    {
                        if (vehicleSeats == seats)
                        {
                            Console.WriteLine("Yes, sold for {0}$", 99 * seats);
                            counter++;
                            sale = true;
                            sold.Remove(currentMashine);
                        }
                    }
                    else if (vehicleType == "v" && vehicle == "Van" && !sale)
                    {
                        if (vehicleSeats == seats)
                        {
                            Console.WriteLine("Yes, sold for {0}$", 118 * seats);
                            counter++;
                            sale = true;
                            sold.Remove(currentMashine);
                        }
                    }
                    else if (vehicleType == "b" && vehicle == "Bus" && !sale)
                    {
                        if (vehicleSeats == seats)
                        {
                            Console.WriteLine("Yes, sold for {0}$", 98 * seats);
                            counter++;
                            sale = true;
                            sold.Remove(currentMashine);
                        }
                    }
                }

                if (!sale)
                {
                    Console.WriteLine("No");
                }
            }

            Console.WriteLine("Vehicles left: {0}", string.Join(", ", sold));
            Console.WriteLine("Vehicles sold: {0}", counter);
        }
    }
}