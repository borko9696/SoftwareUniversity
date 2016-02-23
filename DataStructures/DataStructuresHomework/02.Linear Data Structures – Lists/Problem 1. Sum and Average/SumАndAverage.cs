namespace Problem_1.Sum_and_Average
{
    using System;
    using System.Linq;

    internal class SumАndAverage
    {
        private static void Main()
        {
            var readLine = Console.ReadLine();
            try
            {
                var list = readLine.Split(' ').Select(int.Parse).ToList();
                double sum = list.Sum(x => x);
                double average = sum / list.Count;
                Console.WriteLine("Sum: {0}; Average: {1}", sum, average);
            }
            catch (Exception)
            {

                Console.WriteLine("Sum: 0; Average: 0");
            }
        }
    }
}