namespace _04.Distance_between_Points
{
    #region

    using System;
    using System.Linq;

    #endregion

    class DistanceBetweenPoints
    {
        static double Distance(Point a, Point b)
        {
            double deltaX = b.X - a.X;
            double deltaY = b.Y - a.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        }

        static void Main(string[] args)
        {
            var param1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var param2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            Point pointA = new Point(param1[0], param1[1]);
            Point pointB = new Point(param2[0], param2[1]);

            Console.WriteLine("{0:F3}", Distance(pointA, pointB));
        }

        public class Point
        {
            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public int X { get; set; }

            public int Y { get; set; }
        }
    }
}