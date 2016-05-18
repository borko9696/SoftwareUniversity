namespace _02.BePositive
{
    using System;
    using System.Linq;

    public class BePositiveMain
    {
        public static void Main(string[] args)
        {
            int sequencesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < sequencesCount; i++)
            {
                int[] numbers =
                    Console.ReadLine()
                        .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                bool found = false;
                for (int j = 0; j < numbers.Length; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        found = true;
                        Console.Write(currentNum + " ");
                    }
                    else
                    {
                        if (j != numbers.Length - 1)
                        {
                            j++;
                            currentNum += numbers[j];
                        }

                        if (currentNum >= 0)
                        {
                            found = true;
                            Console.Write(currentNum + " ");
                        }
                    }
                }

                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}