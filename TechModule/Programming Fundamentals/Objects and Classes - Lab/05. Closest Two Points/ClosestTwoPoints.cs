namespace _05.Closest_Two_Points
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            var points = new List<Point>();
            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var point = new Point(input[0], input[1]);
                points.Add(point);
            }

            var distances = new List<Distance>();
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var distance = new Distance(points[i], points[j]);
                    distances.Add(distance);
                }
            }

            var sortedDistances = distances.OrderBy(x => x.DistanceBetweenPoints);
            var result = sortedDistances.First();

            Console.WriteLine("{0:F3}", result.DistanceBetweenPoints);
            Console.WriteLine("({0}, {1})", result.PointA.X, result.PointA.Y);
            Console.WriteLine("({0}, {1})", result.PointB.X, result.PointB.Y);
        }
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

    public class Distance
    {
        public Distance(Point pointA, Point pointB)
        {
            this.PointA = pointA;
            this.PointB = pointB;
        }

        public double DistanceBetweenPoints
        {
            get
            {
                return this.DistanceCalculator(this.PointA, this.PointB);
            }

            set
            {
            }
        }

        public Point PointA { get; set; }

        public Point PointB { get; set; }

        public double DistanceCalculator(Point pointA, Point pointB)
        {
            double deltaX = pointB.X - pointA.X;
            double deltaY = pointB.Y - pointA.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        }
    }
}