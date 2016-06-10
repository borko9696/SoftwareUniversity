namespace _02.Array_Modifier
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    public class ArrayModifier
    {
        private static long[] Decrease(long[] numbers)
        {
            var array = numbers.Select(x => x - 1).ToArray();
            return array;
        }

        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var commands = new List<string>();

            var inputCommand = Console.ReadLine();
            while (inputCommand != "end")
            {
                commands.Add(inputCommand);
                inputCommand = Console.ReadLine();
            }

            for (int i = 0; i < commands.Count; i++)
            {
                var currentCommand = commands[i].Split();
                switch (currentCommand[0])
                {
                    case "swap":
                        Swap(numbers, long.Parse(currentCommand[1]), long.Parse(currentCommand[2]));
                        break;
                    case "multiply":
                        Multiply(numbers, long.Parse(currentCommand[1]), long.Parse(currentCommand[2]));
                        break;
                    case "decrease":
                        numbers = Decrease(numbers);
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void Multiply(long[] numbers, long firstIndex, long secondIndex)
        {
            long temp = numbers[firstIndex];
            numbers[firstIndex] = temp * numbers[secondIndex];
        }

        private static void Swap(long[] numbers, long firstIndex, long secondIndex)
        {
            long temp = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;
        }
    }
}