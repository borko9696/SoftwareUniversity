namespace _03.Circles_Intersection
{
    #region

    using System;
    using System.Linq;

    #endregion

    class CirclesIntersection
    {
        static void Main(string[] args)
        {
            var inputOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var inputTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var circleOne = new Circle(inputOne[0], inputOne[1], inputOne[2]);
            var circleTwo = new Circle(inputTwo[0], inputTwo[1], inputTwo[2]);

            var distance = Math.Sqrt(Math.Pow(circleTwo.X - circleOne.X, 2) + Math.Pow(circleTwo.Y - circleOne.Y, 2));

            Console.WriteLine(distance <= circleOne.Radius + circleTwo.Radius ? "Yes" : "No");
        }
    }

    class Circle
    {
        public Circle(int x, int y, int radius)
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;
        }

        public int Radius { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
    }
}