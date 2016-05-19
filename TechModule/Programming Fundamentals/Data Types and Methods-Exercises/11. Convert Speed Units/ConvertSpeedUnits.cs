using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float hoursToSecond = hours * 60 * 60;
            float minutesToSecond = minutes * 60;
            float totalSeconds = hoursToSecond + minutesToSecond + seconds;
            float metersToKm = distanceInMeters / 1000;
            float totalHours = totalSeconds / 60 / 60;
            float oneMileInMeters = 1609;
            float kmToMiles = distanceInMeters / oneMileInMeters;

            Console.WriteLine("{0}", distanceInMeters / totalSeconds);
            Console.WriteLine("{0}", metersToKm / totalHours);
            Console.WriteLine("{0}", kmToMiles / totalHours);
        }
    }
}
