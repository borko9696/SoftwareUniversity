namespace _08.Count_Working_Days
{
    #region

    using System;
    using System.Globalization;

    #endregion

    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int count = 0;
            for (DateTime date = firstDate; date <= secondDate; date = date.AddDays(1))
            {
                bool isWorkday = true;

                if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                {
                    isWorkday = false;
                }
                else if ((date.Day == 1 && date.Month == 1) || (date.Day == 3 && date.Month == 3)
                         || (date.Day == 1 && date.Month == 5) || (date.Day == 6 && date.Month == 5)
                         || (date.Day == 24 && date.Month == 5) || (date.Day == 6 && date.Month == 9)
                         || (date.Day == 22 && date.Month == 9) || (date.Day == 1 && date.Month == 11)
                         || (date.Day == 24 && date.Month == 12) || (date.Day == 25 && date.Month == 12)
                         || (date.Day == 26 && date.Month == 12))
                {
                    isWorkday = false;
                }

                if (isWorkday)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}