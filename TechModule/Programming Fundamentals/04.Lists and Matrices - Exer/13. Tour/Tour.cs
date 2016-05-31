namespace _13.Tour
{
    #region

    using System;
    using System.Linq;

    #endregion

    class Tour
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            var road = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var row = 0;
            var col = 0;

            long sum = 0;
            for (int i = 0; i < road.Length; i++)
            {
                col = road[i];
                sum += matrix[row, col];
                row = road[i];
            }

            Console.WriteLine(sum);
        }
    }
}