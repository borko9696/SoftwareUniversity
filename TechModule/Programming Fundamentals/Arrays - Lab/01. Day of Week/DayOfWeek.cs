namespace _01.Day_of_Week
{
    #region

    using System;

    #endregion

    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine(days[0]);
                    break;
                case 2:
                    Console.WriteLine(days[1]);
                    break;
                case 3:
                    Console.WriteLine(days[2]);
                    break;
                case 4:
                    Console.WriteLine(days[3]);
                    break;
                case 5:
                    Console.WriteLine(days[4]);
                    break;
                case 6:
                    Console.WriteLine(days[5]);
                    break;
                case 7:
                    Console.WriteLine(days[6]);
                    break;
                default:
                    Console.WriteLine("Invalid Day!");
                    break;
            }
        }
    }
}