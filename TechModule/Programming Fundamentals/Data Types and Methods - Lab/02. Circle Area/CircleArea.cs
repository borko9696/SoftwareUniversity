namespace _02.Circle_Area
{
    #region

    using System;

    #endregion

    class CircleArea
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", radius * radius * Math.PI);
        }
    }
}