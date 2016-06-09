namespace _01.Day_of_Week
{
    #region

    using System;

    #endregion

    class DayOfWeek
    {
        static void Main(string[] args)
        {
            var inputDate = Console.ReadLine().Split('-');
            var date = new DateTime(int.Parse(inputDate[2]), int.Parse(inputDate[1]), int.Parse(inputDate[0]));
            Console.WriteLine(date.DayOfWeek);
        }
    }
}